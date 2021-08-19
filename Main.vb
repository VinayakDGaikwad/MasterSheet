Public Class Main

    ' A) Student_List_SelectedIndexChanged

    Private Sub Student_List_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_List.SelectedIndexChanged
        ' A) Student_List_SelectedIndexChanged

        'A.1) Load GUI

        'A.1.0) Creating variables
        Dim SelectedPath As String = Form1.Selected_Path.Text
        Dim selected_Student As String = SelectedPath + "\" + Student_List.SelectedItem + ".wsz"

        'A.1.1) Enableding items
        Subject_CB.Enabled = True
        Save_B.Enabled = True

        'A.1.2) Refresh all the marks i.e set all marks to "0" 
        For Each item As NumericUpDown In TableLayoutPanel1.Controls
            item.Value = 0
        Next

        'A.1.3) Set Roll.no selected 
        RollNo.Text = Student_List.SelectedItem

        'A.2) Load Marks 

        'A.2.0) Read file 
        Dim MyFileLines As String()
        Dim TextFileStream As System.IO.TextReader

        Try
            TextFileStream = System.IO.File.OpenText(selected_Student)
            MyFileLines = Split(TextFileStream.ReadToEnd, vbCrLf)
        Catch ex As Exception

            'Error Code: 0001
            DialogDisplayer.DisplayError("Reading student's file", "Address formed: " + selected_Student + vbNewLine + ex.Message.ToString, _
                                         "Please check the folder, for this students exists.")
            Exit Sub
        End Try


        'A.2.1) Set the full name

        Try
            'Split the line with the ":"
            Dim Full_Name() As String = Split(MyFileLines(0), ":", 3)

            F_Name.Text = Full_Name(0)
            M_Name.Text = Full_Name(1)
            L_Name.Text = Full_Name(2)
        Catch ex As Exception
            F_Name.Text = "Error Code: 5782"
            M_Name.Text = "Error Code: 7893"
            L_Name.Text = "Error Code: 4754"
        End Try

        'A.2.2) Set the Numbers
        Try
            Dim Full_Nubs() As String = Split(MyFileLines(1), ":", 2)
            GR_Number.Text = Full_Nubs(0)
        Catch ex As Exception
            GR_Number.Text = "Error Code: 9823"
        End Try

        StatusLabel.Text = "Select the Subject"

        TextFileStream.Close()
    End Sub

    Private Sub Subject_CB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject_CB.SelectedIndexChanged
        LoadMarks()
    End Sub

    Private Sub GR_Number_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GR_Number.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
          Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Save_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_B.Click
        If Not F_Name.Text = "Error Code: 5782" Or Not M_Name.Text = "Error Code: 7893" Or Not L_Name.Text = "Error Code: 4754" Or Not GR_Number.Text = "Error Code: 9823" Then
            Dim SelectedPath As String = Form1.Selected_Path.Text
            Dim selected_Student As String = SelectedPath + "\" + Student_List.SelectedItem + ".wsz"


            For c As Integer = 1 To 10 Step 1
                Try

                    Dim lines() As String = System.IO.File.ReadAllLines(selected_Student)

                    lines(0) = F_Name.Text + ":" + M_Name.Text + ":" + L_Name.Text
                    lines(1) = GR_Number.Text + ":" + RollNo.Text

                    Select Case Subject_CB.SelectedItem
                        Case "History"
                            lines(2) = GetAllMarks()

                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For

                        Case "Science"

                            lines(8) = O_A.Value.ToString + ":"

                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For

                        Case "Geography"
                            lines(3) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)

                            Exit For

                        Case "Hindi"
                            lines(7) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For

                        Case "Maths"
                            lines(9) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For

                        Case "Computer"
                            lines(7) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For


                        Case "Marathi"
                            lines(6) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)

                            Exit For


                        Case "English lit"
                            lines(4) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For


                        Case "Engilsh language"
                            lines(5) = O_A.Value.ToString + ":"
                            System.IO.File.WriteAllLines(selected_Student, lines)
                            SaveSucces(Subject_CB.SelectedItem)
                            Exit For

                        Case Else
                            MsgBox("Please select the subject and modify the marks.", MsgBoxStyle.Information)
                            StatusLabel.Text = "The marks were not saved as subject selected is not vaild."
                            Exit For
                    End Select
                Catch ex As Exception
                    If MessageBox.Show("Error while saving to file '" + selected_Student _
                                    + "'. Please check the file in your file system" + ex.ToString, "Error Saving File" _
                                    , MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) _
                                    = Windows.Forms.DialogResult.Cancel Then
                        '
                        Exit For
                    End If
                End Try
            Next
        Else
            DialogDisplayer.DisplayError("Invaild Name", "Error Code: 4754, 7893, 5782")
        End If
    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Me.Close()

        Try
            Form1.Load_Form1()

        Catch ex As Exception

        End Try

        Form1.Show()

    End Sub

    Private Sub Shut_Down_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shut_Down_Button.Click
        If MessageBox.Show("Are you sure you want to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Subject_G_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject_G.EnabledChanged
        For Each item As NumericUpDown In TableLayoutPanel1.Controls
            item.Value = 0
        Next
    End Sub

    Private Sub Subject_CB_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject_CB.DropDown
        StatusLabel.Text = "Please select your subject"
    End Sub

    Private Sub Subject_CB_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject_CB.DropDownClosed
        If Subject_CB.SelectedItem = "Select Subject" Then
            StatusLabel.Text = "Please select your subject"
        Else
            StatusLabel.Text = "Start modifiying marks"
        End If
    End Sub

    Public Sub SaveSucces(ByVal Subject As String)
        If AndNextCheckBox.Checked = True Then
            StatusLabel.Text = "Marks for subject " + Subject + " were succecfully saved to the student file. Next Student Selected"
            MSModule.SelectNextItem(Student_List)
        Else
            StatusLabel.Text = "Marks for subject " + Subject + " were succecfully saved to the student file."
        End If

        Subject_CB.SelectedItem = "Select Subject"
    End Sub

    Public Sub LoadMarks()
        Dim SelectedPath As String = Form1.Selected_Path.Text
        Dim selected_Student As String = SelectedPath + "\" + Student_List.SelectedItem + ".wsz"


        Select Case Subject_CB.SelectedItem
            Case "History"
                Subject_G.Enabled = True

                Dim History_All As String() = Split(MSModule.Read_Text(selected_Student, 2), ":")

                If MSModule.Read_Text(selected_Student, 2) = "" Then
                    DialogDisplayer.DisplayError("While reading marks from line", "The file: '" + selected_Student + _
                                                 "' does not have the marks for '" + Subject_CB.SelectedItem, "'. Contact Administrator")
                Else
                    Try

                        SplitAndApply(History_All)

                    Catch ex As Exception
                        DialogDisplayer.DisplayError("While reading marks from line", "File with error: " + selected_Student + " ." _
                                                     + ex.ToString, "Contact Administrator")
                    End Try
                End If


            Case "Science"
                Subject_G.Enabled = True

                Dim SCience_All As String() = Split(MSModule.Read_Text(selected_Student, 2), ":")
                If MSModule.Read_Text(selected_Student, 2) = "" Then

                Else
                    Try
                        O_A.Value = CInt(SCience_All(0))

                    Catch ex As Exception

                        DialogDisplayer.DisplayError("While reading marks from line", ex.ToString, _
                                                     "The Values shown might be immoral.(Contact Administrator)")

                    End Try
                End If

            Case Else
                Subject_G.Enabled = False

        End Select
    End Sub

    Public Sub SplitAndApply(ByVal line As String())
        O_A.Value = CInt(line(0))
        O_B.Value = CInt(line(1))
        O_C.Value = CInt(line(2))
        O_D.Value = CInt(line(3))
        O_E.Value = CInt(line(4))
        O_F.Value = CInt(line(5))

        C_A.Value = CInt(line(6))
        C_B.Value = CInt(line(7))
        C_C.Value = CInt(line(8))
        C_D.Value = CInt(line(9))
        C_E.Value = CInt(line(10))
        C_F.Value = CInt(line(11))

        H_A.Value = CInt(line(12))
        H_B.Value = CInt(line(13))
        H_C.Value = CInt(line(14))
        H_D.Value = CInt(line(15))
        H_E.Value = CInt(line(16))
        H_F.Value = CInt(line(17))

        A_A.Value = CInt(line(18))
        A_B.Value = CInt(line(19))
        A_C.Value = CInt(line(20))
        A_D.Value = CInt(line(21))
        A_E.Value = CInt(line(22))
        A_F.Value = CInt(line(23))

        Uint1_Total.Value = CInt(line(24))
        Unit2_Total.Value = CInt(line(25))
        Uint3_Total.Value = CInt(line(26))
        Unit4_Toatal.Value = CInt(line(27))
        Term1_Toatal.Value = CInt(line(28))
        Term2_toatal.Value = CInt(line(29))
    End Sub

    Function GetAllMarks()
        Return O_A.Value.ToString + ":" + O_B.Value.ToString + ":" + O_C.Value.ToString + ":" + O_D.Value.ToString + ":" + O_E.Value.ToString + ":" + O_F.Value.ToString _
                                          + ":" + C_A.Value.ToString + ":" + C_B.Value.ToString + ":" + C_C.Value.ToString + ":" + C_D.Value.ToString + ":" + C_E.Value.ToString + ":" + C_F.Value.ToString _
                                          + ":" + H_A.Value.ToString + ":" + H_B.Value.ToString + ":" + H_C.Value.ToString + ":" + H_D.Value.ToString + ":" + H_E.Value.ToString + ":" + H_F.Value.ToString _
                                          + ":" + A_A.Value.ToString + ":" + A_B.Value.ToString + ":" + A_C.Value.ToString + ":" + A_D.Value.ToString + ":" + A_E.Value.ToString + ":" + A_F.Value.ToString _
                                          + ":" + Uint1_Total.Value.ToString + ":" + Unit2_Total.Value.ToString + ":" + Uint3_Total.Value.ToString + ":" + Unit4_Toatal.Value.ToString + ":" + Term1_Toatal.Value.ToString + ":" + Term2_toatal.Value.ToString

    End Function

    Public Sub CalculateToatal()
        Uint1_Total.Value = CInt(O_A.Value) + CInt(C_A.Value) + CInt(H_A.Value) + CInt(A_A.Value)
        Unit2_Total.Value = CInt(O_B.Value) + CInt(C_B.Value) + CInt(H_B.Value) + CInt(A_B.Value)
        Uint3_Total.Value = CInt(O_C.Value) + CInt(C_C.Value) + CInt(H_C.Value) + CInt(A_C.Value)
        Unit4_Toatal.Value = CInt(O_D.Value) + CInt(C_D.Value) + CInt(H_D.Value) + CInt(A_D.Value)
        Term1_Toatal.Value = CInt(O_E.Value) + CInt(C_E.Value) + CInt(H_E.Value) + CInt(A_E.Value)
        Term2_toatal.Value = CInt(O_F.Value) + CInt(C_F.Value) + CInt(H_F.Value) + CInt(A_F.Value)
    End Sub

    'Non-User Code Starts 
    '  There is no chance of errors in this code

    Private Sub O_A_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_A.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub C_A_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_A.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub H_A_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_A.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub A_A_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_A.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub O_B_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_B.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub C_B_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_B.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub H_B_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_B.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub A_B_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_B.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub O_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_C.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub C_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_C.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub H_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_C.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub A_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_C.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub O_D_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_D.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub C_D_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_D.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub H_D_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_D.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub A_D_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_D.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub O_E_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_E.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub C_E_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_E.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub H_E_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_E.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub A_E_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_E.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub O_F_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_F.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub C_F_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_F.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub H_F_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_F.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub A_F_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_F.ValueChanged
        CalculateToatal()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO Enter all the code above this line
        StatusLabel.Text = "Ready"
    End Sub
End Class