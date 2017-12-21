Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'checkedlistbox
        CheckedListBox1.Items.Add("sunday", CheckState.Checked)
        CheckedListBox1.Items.Add("monday", CheckState.Unchecked)
        CheckedListBox1.Items.Add("tuesday", CheckState.Indeterminate)
        ' CheckBox1.CheckState = 1
        If CheckBox1.CheckState = 1 Then
            MsgBox("checked")
        Else
            MsgBox("unchecked")
        End If

        'scroll bar - make sure to make Multiline property TRUE 
        'for textbox which enables to adjust height of textbox
        TextBox1.Multiline = True
        TextBox1.ScrollBars = ScrollBars.Both

        'radio button
        Dim c As String
        RadioButton2.Checked = True
        If RadioButton1.Checked = True Then
            c = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            c = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            c = RadioButton3.Text
        End If
        MessageBox.Show(c)

        'panel
        Panel1.BackColor = Color.Aqua
        Me.AllowTransparency = True      'this allows transparancy of form to be true or false and also set the
        'transparencykey property of form to same color as that of panel color that is aqua here

        'listview
        ListView1.Columns.Add("Student name", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Course", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("subject", 100, HorizontalAlignment.Left)
        Dim str(3) As String
        Dim itm As ListViewItem   'add method of listvew takes listviewitem type values
        str(0) = "apoorv"
        str(1) = "BCA"
        str(2) = "VB.NET"
        itm = New ListViewItem(str)    'here we are passing a string array to listview add method
        ListView1.Items.Add(itm)

    End Sub

    'picturebox
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.Image = Image.FromFile("C:\Users\HP\Desktop\pics\IMG_5989.jpg")
        Dim i As Integer
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 150
        For i = 0 To 150
            ProgressBar1.Value = i
        Next
    End Sub

    
    'Adding a new form to current form and making it MDI, 
    'first make the IsMdiContainer property true for form
    Private Sub NewProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWToolStripMenuItem.Click
        Dim frm2 As New Form2
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
    Private Sub OpenProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem.Click
        Dim frm3 As New Form3
        frm3.Show()
        frm3.MdiParent = Me
    End Sub


    'the below showa a message when you click button on toolbar
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MessageBox.Show("button clicked on toolbar")
    End Sub

    'this links Open on menu to Open Dialog box
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFD.Title = "Open Dialog Box"     'this changes the caption of dilog box
        OpenFD.ShowDialog()
    End Sub

    'this links Save on menu to Save Dialog Box
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFD.Title = "Save Dialog Box"
        SaveFD.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFD.FileOk

    End Sub

    Private Sub SAVEASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEASToolStripMenuItem.Click

    End Sub
    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()

    End Sub

End Class

