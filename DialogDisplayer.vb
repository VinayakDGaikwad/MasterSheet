Module DialogDisplayer
    '
    '                               How to use this module?
    '                               ```````````````````````
    '> To display the error dialog use.
    '
    '   DialogDisplayer.DisplayError("File not found","The file 'text.txt' was not found.", "Please select anouther file")
    '    
    '                                          Or
    '                                          --
    '   DialogDisplayer.DisplayError("File not found","The file 'text.txt' was not found.")
    '
    'If you want to diaplay a Int then use the Tostring() method.
    'The  defalt soultion will be "Contact Addminstrator"
    'Give an empty string for no soultion 


    '> To display the error dialog use.
    '
    '   DialogDisplayer.DisplayInformation("File not found","The file 'text.txt' was not found.", "Please select anouther file")
    '    
    '                                          Or
    '                                          --
    '   DialogDisplayer.DisplayInformation("File not found","The file 'text.txt' was not found.")
    '
    'If you want to diaplay a Int then use the Tostring() method.
    'The  defalt soultion will be empty


    Public Sub DisplayError(ByVal DisplayError As String, ByVal Errordetails As String, Optional ByVal solution As String = "Contact Addminstrator")

        MessageDialog.Error_Message.Text = DisplayError
        MessageDialog.ERRORdETAILS_TO_sHOW = Errordetails
        MessageDialog.solution.Text = "Solution: " + solution

        MessageDialog.ShowDialog()

        MessageDialog.DialogImage.Image = My.Resources._error

    End Sub

    Public Sub DisplayInformation(ByVal DisplayInfo As String, ByVal Infodetails As String, Optional ByVal solution As String = " ")
        'Set the texts in the dialog
        MessageDialog.Error_Message.Text = DisplayInfo
        MessageDialog.ERRORdETAILS_TO_sHOW = infodetails
        MessageDialog.solution.Text = solution

        'Set the Image
        MessageDialog.DialogImage.Image = My.Resources.information

        'Show the dialog
        MessageDialog.ShowDialog()

    End Sub
End Module
