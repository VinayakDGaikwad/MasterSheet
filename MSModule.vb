Module MSModule

    Function Read_Text(ByVal file As String, ByVal Line_nubs As Integer, Optional ByVal DisplayError As Boolean = False) As String
        Dim MyFileLine As String
        Try
            Dim Tr As IO.TextReader = System.IO.File.OpenText(file)
            MyFileLine = Split(Tr.ReadToEnd(), vbCrLf)(Line_nubs)
            Tr.Close()
        Catch ex As Exception
            Select Case DisplayError
                Case True
                    MsgBox("Error while reading from file", MsgBoxStyle.Critical)

                Case False
                    'Nothing just retune empty string
            End Select
            MyFileLine = ""
        End Try

        Return MyFileLine
    End Function

    Public Sub SelectNextItem(ByVal InListbox As System.Windows.Forms.ListBox)

        'default type, string
        Dim T = GetType(String)

        'if every listbox item is a number, consider it as an integer (for sorting purposes)
        Dim numericList = (From x In InListbox.Items Select x).All(Function(x) IsNumeric(x))
        'if true, use Integer as type
        If numericList Then
            T = GetType(Integer)
        End If

        'sort the list items based on type
        Dim sortedList = (From x In InListbox.Items
                          Let y = Convert.ChangeType(x, T)
                          Order By y
                          Select x).ToArray

        'find the index of the current item
        Dim currentIndex = Array.IndexOf(sortedList, InListbox.SelectedItem)

        'find the index of the next item (from the sorted list)
        Dim nextSortedIndex = currentIndex + 1

        'check that the next index exists (otherwise we get an exception) 
        If nextSortedIndex >= InListbox.Items.Count Then
            Exit Sub
        End If

        'find the next listbox index to select
        Dim nextItem = sortedList.ElementAt(nextSortedIndex)
        Dim nextListIndex = InListbox.Items.IndexOf(Convert.ToString(nextItem))

        'select the new item
        InListbox.SelectedIndex = nextListIndex
    End Sub

    Public Sub SortListBox(ByVal InListBox As System.Windows.Forms.ListBox)
        'default type, string
        Dim T = GetType(String)

        'if every listbox item is a number, consider it as an integer (for sorting purposes)
        Dim numericList = (From x In InListBox.Items Select x).All(Function(x) IsNumeric(x))
        'if true, use Integer as type
        If numericList Then
            T = GetType(Integer)
        End If

        'sort the list items based on type
        Dim sortedList = (From x In InListBox.Items
                          Let y = Convert.ChangeType(x, T)
                          Order By y
                          Select x).ToArray

        'select the new item
        InListBox.Items.AddRange(sortedList)
    End Sub
End Module
