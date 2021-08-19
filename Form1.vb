Public Class Form1

    Public Sub Load_Form1()
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()

        StandardCB.Items.Clear()
        StandardCB.Items.Add("Select Standard")

        Dim SCRInfo As New System.IO.DirectoryInfo(scrdirctory)
        For Each dir As System.IO.DirectoryInfo In SCRInfo.GetDirectories()
            StandardCB.Items.Add(dir.ToString())
        Next

        StandardCB.SelectedItem = "Select Standard"
        ClassCB.Items.Clear()
        ClassCB.Enabled = False

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Form1()
    End Sub

    Private Sub StandardCB_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardCB.SelectedValueChanged
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Select Case StandardCB.SelectedItem.ToString
            Case "I"
                Dim Address As String = scrdirctory + "I\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "II"
                Dim Address As String = scrdirctory + "II\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "III"
                Dim Address As String = scrdirctory + "III\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "IV"
                Dim Address As String = scrdirctory + "IV\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "V"
                Dim Address As String = scrdirctory + "V\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "VI"
                Dim Address As String = scrdirctory + "VI\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "VII"
                Dim Address As String = scrdirctory + "VII\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "VIII"
                Dim Address As String = scrdirctory + "VIII\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case "IX"
                Dim Address As String = scrdirctory + "IX\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next

            Case "X"
                Dim Address As String = scrdirctory + "X\"
                ClassCB.Enabled = True

                Dim dInfo As New System.IO.DirectoryInfo(Address)
                ClassCB.Items.Clear()
                For Each dir As System.IO.DirectoryInfo In dInfo.GetDirectories()
                    ClassCB.Items.Add(dir.Name)
                Next
            Case Else

        End Select
    End Sub

    Private Sub GoToClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToClass.Click
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()

        If Not ClassCB.SelectedItem = "" And Not StandardCB.SelectedItem = "Selected Standard" Then

            Selected_Path.Text = scrdirctory + StandardCB.SelectedItem + "\" + ClassCB.SelectedItem

            Try
                Dim SelectedPath As String = Selected_Path.Text

                For Each foundstudent As String In My.Computer.FileSystem.GetFiles(SelectedPath, FileIO.SearchOption.SearchTopLevelOnly, "*.wsz*")
                    Main.Student_List.Items.Add(System.IO.Path.GetFileNameWithoutExtension(foundstudent))
                Next

                Main.Show()
                Main.Subject_CB.SelectedItem = "Select Subject"
                Me.Hide()

            Catch ex As Exception
                DialogDisplayer.DisplayError("The selected 'Subject' or 'Class' does not exists.", ex.ToString, "Please check the class folder selected exists.")
            End Try

        Else
            MsgBox("Please Select the Class or Standard", MsgBoxStyle.Exclamation, "Incomplete data")
        End If
    End Sub
End Class
