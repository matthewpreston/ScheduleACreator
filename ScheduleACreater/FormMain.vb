Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml
Imports System.IO

Public Class FormMain
    Dim pdfReader As PdfReader
    Dim pdfTemplate As String
    Dim xml As String
    Dim entries As SortedList(Of String, Entry)

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initialize members
        pdfReader = Nothing
        pdfTemplate = ""
        xml = "./Categories.xml"
        entries = Nothing

        'Fix some visual stuff
        SCAll.Height = Me.Height - 84

        'Initialize entries
        ParseXML()
    End Sub

    Private Sub FormMain_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        Dim tempArray() As String = Split(pdfTemplate, "\")
        Dim tempName As String = ""

        If tempArray.Length > 1 Then
            tempName = tempArray(0)
        End If
        For i = 1 To tempArray.Length - 2
            tempName += "\" + tempArray(i)
        Next
        tempName += "\temp.pdf"
        If My.Computer.FileSystem.FileExists(tempName) Then
            My.Computer.FileSystem.DeleteFile(tempName)
        End If
    End Sub

    Private Sub ParseXML()
        Dim categoryList As SortedList(Of String, Category)
        Dim optionList As SortedList(Of String, Opt)
        Dim entryTitle, entryType, catTitle, catType, temp As String
        Dim entryEditable, catEditable As Boolean
        Dim xmlDoc As XmlDocument = New XmlDocument
        Dim entryNodes, catNodes, optNodes As XmlNodeList

        If entries Is Nothing Then
            entries = New SortedList(Of String, Entry)
        End If

        'Iterate through nodes and load into hash table
        xmlDoc.Load(xml)
        entryNodes = xmlDoc.SelectSingleNode("Entries").SelectNodes("Entry")
        'MessageBox.Show(entryNodes.Count)
        For Each eNode In entryNodes
            entryTitle = New String(eNode.Attributes.GetNamedItem("Title").Value)
            entryType = New String(eNode.Attributes.GetNamedItem("Type").Value)
            temp = eNode.Attributes.GetNamedItem("Editable").Value
            If temp = "True" Then
                entryEditable = True
            Else
                entryEditable = False
            End If
            catNodes = eNode.SelectNodes("Category")
            'MessageBox.Show(catNodes.Count)
            categoryList = New SortedList(Of String, Category)
            For Each cNode In catNodes
                catTitle = New String(cNode.Attributes.GetNamedItem("Title").Value)
                catType = New String(cNode.Attributes.GetNamedItem("Type").Value)
                temp = cNode.Attributes.GetNamedItem("Editable").Value
                If temp = "True" Then
                    catEditable = True
                Else
                    catEditable = False
                End If
                optNodes = cNode.SelectNodes("Option")
                optionList = New SortedList(Of String, Opt)
                For Each oNode In optNodes
                    optionList.Add(oNode.InnerText, New Opt(False, oNode.InnerText))
                Next
                categoryList.Add(catTitle, New Category(catTitle, catType, catEditable, optionList))
            Next
            If entries.ContainsKey(entryTitle) Then
                'Add categories together, remove duplicate options in between
                'entries.Item(entryTitle)
            Else
                entries.Add(entryTitle, New Entry(entryTitle, entryType, entryEditable, categoryList))
            End If
        Next
    End Sub

    Private Sub WriteXML()
        Dim writer As XmlWriter = Nothing
        Try
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            writer = XmlWriter.Create(xml, settings)

            'Write root
            writer.WriteStartElement("Entries")

            'Write Entries
            For Each entry In entries
                writer.WriteStartElement("Entry")
                writer.WriteAttributeString("Title", entry.Value.title)
                writer.WriteAttributeString("Type", entry.Value.type)

                'Write Categories
                For Each cat In entry.Value.categories
                    writer.WriteStartElement("Category")
                    writer.WriteAttributeString("Title", cat.Value.title)
                    writer.WriteAttributeString("Type", cat.Value.type)

                    'Write Options
                    For Each optn In cat.Value.options
                        writer.WriteElementString("Option", optn.Value.item)
                    Next
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next
            writer.WriteEndElement()

            'Write the XML to file and close writer
            writer.Flush()
            writer.Close()
        Finally
            If writer IsNot Nothing Then
                writer.Close()
            End If
        End Try
    End Sub

    Private Sub ListFieldNames(ByVal template As String)
        If TBFile.Text = "" Then
            MessageBox.Show("Please specify a file")
            Return
        End If

        'Create a new PDF reader based on the PDF template document
        Try
            pdfReader = New PdfReader(template)
            pdfReader.unethicalreading = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        'Populate the different PDF field names into a listbox
        LBTitles.Items.Clear()
        For Each de In pdfReader.AcroFields.Fields
            LBTitles.Items.Add(de.Key.ToString())
        Next
        Dim index = LBTitles.Items.IndexOf("CLAUSES")
        If index >= 0 Then
            LBTitles.SelectedIndex = index
        End If
    End Sub

    Private Sub FillForm(ByVal template As String)
        FillForm(template, "temp.pdf", True, True)
    End Sub

    Private Sub FillForm(ByVal template As String, ByVal title As String, ByVal hidden As Boolean, ByVal preview As Boolean)
        'Creates a temporary pdf that's filled in with the clauses checked by user
        Dim newFile As String = ""

        'Get new file name
        Dim tempArray() As String = Split(template, "\")
        Dim baseName As String = ""

        If tempArray.Length > 1 Then
            baseName = tempArray(0)
        End If
        For i = 1 To tempArray.Length - 2
            baseName += "\" + tempArray(i)
        Next
        newFile = baseName + "\" + title

        'Release old copy
        WBPreview.Navigate("about:blank")
        Do Until WBPreview.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
        Loop

        'Make unhidden to access
        If My.Computer.FileSystem.FileExists(newFile) Then
            Dim attributes = File.GetAttributes(newFile)
            If (attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                File.SetAttributes(newFile, attributes And (Not FileAttributes.Hidden))
            End If
        End If

        'Create pdf
        pdfReader = New PdfReader(template)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream( _
            newFile, FileMode.Create), "\6c", True)
        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

        'Fill in new pdf
        Dim entryValues As List(Of String) = New List(Of String)
        Dim key, text As String

        For Each field In pdfFormFields.Fields
            key = field.Key.ToString()
            If entries.ContainsKey(key) Then
                entryValues.Clear()
                text = ""
                For Each cat In entries(key).categories.Values
                    For Each optn In cat.options.Values
                        If optn.check Then
                            entryValues.Add(optn.item)
                        End If
                    Next
                Next
                If entries(key).type = "String" Then
                    If entryValues.Count > 0 Then
                        text = entryValues(0)
                    End If
                ElseIf entries(key).type = "List" Then
                    For i As Integer = 0 To entryValues.Count - 1
                        text += (i + 1).ToString() + ") " + entryValues(i) + Environment.NewLine + Environment.NewLine
                    Next
                End If
                pdfFormFields.SetField(key, text)
            End If
        Next
        pdfStamper.Close()

        'Make file hidden
        If hidden Then
            File.SetAttributes(newFile, FileAttributes.Hidden)
        End If

        'Preview these changes
        If preview Then
            WBPreview.Navigate(newFile)
        End If
    End Sub

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        'Browses for pdf
        Dim fd As New OpenFileDialog()

        fd.Title = "Open File"
        fd.InitialDirectory = "C:"
        fd.Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf"
        fd.FilterIndex = 1
        'fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            TBFile.Text = fd.FileName
            pdfTemplate = fd.FileName
            BOpen_Click(sender, e)
        End If
    End Sub

    Private Sub BOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOpen.Click
        'Opens pdf
        TBValue.Clear()
        LBCategories.Items.Clear()
        CLBItems.Items.Clear()
        ListFieldNames(pdfTemplate)
        WBPreview.Navigate(pdfTemplate)
    End Sub

    Private Sub LBTitles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBTitles.SelectedIndexChanged
        'Updates categories
        TBValue.Text = pdfReader.AcroFields.GetField(LBTitles.SelectedItem.ToString()).ToString()
        LBCategories.Items.Clear()
        If entries.ContainsKey(LBTitles.SelectedItem) Then
            UpdateCats(LBTitles.SelectedItem)
        Else
            CLBItems.Items.Clear()
            BAddCat.Enabled = True
            BRmvCat.Enabled = True
            BAddOpt.Enabled = False
            BEditOpt.Enabled = False
            BRmvOpt.Enabled = False
        End If
        UpdateValue(LBTitles.SelectedItem)
    End Sub

    Private Sub LBCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCategories.SelectedIndexChanged
        'Updates options
        UpdateOpts(LBTitles.SelectedItem, LBCategories.SelectedItem)
    End Sub

    Private Sub CLBItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CLBItems.DoubleClick
        'Deals with double clicking trouble
        entries(LBTitles.SelectedItem).categories(LBCategories.SelectedItem).options(CLBItems.SelectedItem).check = CLBItems.GetItemChecked(CLBItems.SelectedIndex)
        UpdateValue(LBTitles.SelectedItem)
    End Sub

    Private Sub CLBItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLBItems.SelectedIndexChanged
        'Allows for checking of boxes depending on which type
        Dim cat = entries(LBTitles.SelectedItem).categories(LBCategories.SelectedItem)
        If cat.type = "Multiple" Then
            cat.options(CLBItems.SelectedItem).check = CLBItems.GetItemChecked(CLBItems.SelectedIndex)
        ElseIf cat.type = "Single" Then
            For i = 0 To CLBItems.Items.Count - 1
                CLBItems.SetItemCheckState(i, CheckState.Unchecked)
                cat.options(CLBItems.Items(i)).check = False
            Next
            Dim index = CLBItems.SelectedIndex
            If index >= 0 Then
                CLBItems.SetItemCheckState(index, CheckState.Checked)
                cat.options(CLBItems.SelectedItem).check = True
            End If
        End If
        UpdateValue(LBTitles.SelectedItem)
    End Sub

    Private Sub BAddOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddOpt.Click
        'Adds option
        If LBCategories.SelectedItem <> Nothing Then
            FormAddOpt.Visible = True
        Else
            MessageBox.Show("Please select a category to add an option to.")
        End If
    End Sub

    Private Sub BEditOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditOpt.Click
        'Edits selected option
        If CLBItems.SelectedItem <> Nothing Then
            FormEditOpt.OldOpt = CLBItems.SelectedItem
            FormEditOpt.TBEditOpt.Text = CLBItems.SelectedItem
            FormEditOpt.Visible = True
        Else
            MessageBox.Show("Please select an option to edit.")
        End If
    End Sub

    Private Sub BRmvOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRmvOpt.Click
        'Removes selected option
        If CLBItems.SelectedItem <> Nothing Then
            Dim result = MessageBox.Show("Are you sure you would like to remove this option?", "Remove Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                RmvOption(LBTitles.SelectedItem, LBCategories.SelectedItem, CLBItems.SelectedItem)
            End If
        Else
            MessageBox.Show("Please select an option to remove.")
        End If
    End Sub

    Private Sub BAddCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddCat.Click
        'Adds category to title
        If LBTitles.SelectedItem <> Nothing Then
            FormAddCat.Visible = True
        Else
            MessageBox.Show("Please select a title to add a category to.")
        End If
    End Sub

    Private Sub BRmvCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRmvCat.Click
        'Removes selected category
        If LBTitles.SelectedItem <> Nothing Then
            Dim result = MessageBox.Show("Are you sure you would like to remove this category?", "Remove Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                RmvCategory(LBTitles.SelectedItem, LBCategories.SelectedItem)
            End If
        Else
            MessageBox.Show("Please select category to remove.")
        End If
    End Sub

    Private Sub BSaveOpts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSaveOpts.Click
        'Save to XML
        WriteXML()
    End Sub

    Private Sub BPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPreview.Click
        'Create a temp PDF with options filled in
        FillForm(pdfTemplate)
    End Sub

    Private Sub BCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCreate.Click
        'Create a final PDF document containing all changes
        Dim fd As New SaveFileDialog()
        Dim tempArray() As String = Split(pdfTemplate, "\")
        Dim baseName As String = ""

        If tempArray.Length > 1 Then
            baseName = tempArray(0)
        End If
        For i = 1 To tempArray.Length - 2
            baseName += "\" + tempArray(i)
        Next

        fd.Title = "Save File"
        fd.InitialDirectory = baseName
        fd.Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf"
        fd.FilterIndex = 2
        'fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            tempArray = Split(fd.FileName, "\")
            FillForm(pdfTemplate, tempArray.Last(), False, False)
            TBFile.Text = fd.FileName
            pdfTemplate = fd.FileName
            BOpen_Click(sender, e)
        End If
    End Sub

    Public Sub UpdateCats(ByVal EntryTitle As String)
        'Updates category listbox
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        LBCategories.Items.Clear()
        For Each catTitle In entries(EntryTitle).categories.Keys()
            LBCategories.Items.Add(catTitle)
        Next
        If LBCategories.Items.Count > 0 Then
            LBCategories.SelectedIndex = 0 'Because of this, CLBItems will be filled
        End If
        BAddCat.Enabled = entries(EntryTitle).editable
        BRmvCat.Enabled = entries(EntryTitle).editable
    End Sub

    Public Sub AddCategory(ByVal EntryTitle As String, ByVal CatTitle As String, ByVal CatType As String, ByVal CatEditable As Boolean)
        'Typically used by FormAddCat.BAddCat.Click()
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        If Not entries(EntryTitle).categories.ContainsKey(CatTitle) Then
            entries(EntryTitle).categories.Add(CatTitle, New Category(CatTitle, CatType, CatEditable, New SortedList(Of String, Opt)))
            UpdateCats(EntryTitle)
        End If
    End Sub

    Public Sub RmvCategory(ByVal EntryTitle As String, ByVal CatTitle As String)
        'Remove category
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        If entries(EntryTitle).categories.ContainsKey(CatTitle) Then
            entries(EntryTitle).categories.Remove(CatTitle)
            UpdateCats(EntryTitle)
        End If
    End Sub

    Public Sub UpdateOpts(ByVal EntryTitle As String, ByVal CatTitle As String)
        'Update options in combolistbox
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        If entries(EntryTitle).categories.ContainsKey(CatTitle) Then
            CLBItems.Items.Clear()
            For Each opt In entries(EntryTitle).categories(CatTitle).options.Values
                CLBItems.Items.Add(opt.item, opt.check)
            Next
        End If
        BAddOpt.Enabled = entries(EntryTitle).categories(CatTitle).editable
        BEditOpt.Enabled = entries(EntryTitle).categories(CatTitle).editable
        BRmvOpt.Enabled = entries(EntryTitle).categories(CatTitle).editable
    End Sub

    Public Sub AddOption(ByVal EntryTitle As String, ByVal CatTitle As String, ByVal OptTitle As String)
        'Typically used by FormAddOpt.BAddOpt.Click()
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        If entries(EntryTitle).categories.ContainsKey(CatTitle) Then
            entries(EntryTitle).categories(CatTitle).options.Add(OptTitle, New Opt(False, OptTitle))
            UpdateOpts(EntryTitle, CatTitle)
        End If
    End Sub

    Public Sub EditOption(ByVal EntryTitle As String, ByVal CatTitle As String, ByVal OldOpt As String, ByVal NewOpt As String)
        'Typically used by FormEditOpt.BEditOpt.Click()
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        If entries(EntryTitle).categories.ContainsKey(CatTitle) Then
            If entries(EntryTitle).categories(CatTitle).options.ContainsKey(OldOpt) Then
                entries(EntryTitle).categories(CatTitle).options.Remove(OldOpt)
                entries(EntryTitle).categories(CatTitle).options.Add(NewOpt, New Opt(False, NewOpt))
                UpdateOpts(EntryTitle, CatTitle)
            End If
        End If
    End Sub

    Public Sub RmvOption(ByVal EntryTitle As String, ByVal CatTitle As String, ByVal OptTitle As String)
        'Removes option
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        If entries(EntryTitle).categories.ContainsKey(CatTitle) Then
            entries(EntryTitle).categories(CatTitle).options.Remove(OptTitle)
            UpdateOpts(EntryTitle, CatTitle)
        End If
    End Sub

    Public Sub UpdateValue(ByVal EntryTitle As String)
        Dim entryValues As List(Of String) = New List(Of String)
        If Not entries.ContainsKey(EntryTitle) Then
            Return
        End If
        For Each cat In entries(EntryTitle).categories.Values
            For Each optn In cat.options.Values
                If optn.check Then
                    entryValues.Add(optn.item)
                End If
            Next
        Next
        TBValue.Clear()
        If entries(EntryTitle).type = "String" Then
            If entryValues.Count > 0 Then
                TBValue.Text = entryValues(0)
            End If
        ElseIf entries(EntryTitle).type = "List" Then
            For i As Integer = 0 To entryValues.Count - 1
                TBValue.Text += (i + 1).ToString() + ") " + entryValues(i) + Environment.NewLine + Environment.NewLine
            Next
        End If
    End Sub
End Class

Public Class Entry
    Public title As String
    Public type As String
    Public editable As Boolean
    Public categories As SortedList(Of String, Category)

    Sub New(ByVal EntryTitle As String, ByVal EntryType As String, ByVal EntryEditable As Boolean, ByVal EntryCategories As SortedList(Of String, Category))
        title = EntryTitle
        type = EntryType
        editable = EntryEditable
        categories = EntryCategories
    End Sub
End Class

Public Class Category
    Public title As String
    Public type As String
    Public editable As Boolean
    Public options As SortedList(Of String, Opt)

    Sub New(ByVal CatTitle As String, ByVal CatType As String, ByVal CatEditable As Boolean, ByVal CatOptions As SortedList(Of String, Opt))
        title = CatTitle
        type = CatType
        editable = CatEditable
        options = CatOptions
    End Sub
End Class

Public Class Opt
    Public check As Boolean
    Public item As String

    Sub New(ByVal OptCheck As Boolean, ByVal OptItem As String)
        check = OptCheck
        item = OptItem
    End Sub
End Class
