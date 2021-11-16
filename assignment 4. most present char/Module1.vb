Module Module1

    Sub Main()
        Dim mostChar, thisChar, nextChar As Char
        Dim most, Count, x, y As Integer
        Dim str1 As String

        mostChar = ""
        most = 0
        Count = 0
        x = 0
        y = 0
        thisChar = ""
        nextChar = ""
        str1 = ""


        Console.Write("Enter Phrase: ")
        str1 = Console.ReadLine

        For x = 1 To Len(str1)
            nextChar = Mid(str1, x, 1)
            Count = 0
            For y = 1 To Len(str1)
                thisChar = Mid(str1, y, 1)
                If thisChar = nextChar Then
                    Count = Count + 1
                End If
            Next

            If Count > most Then
                most = Count
                mostChar = nextChar
            End If
        Next
        Console.WriteLine(mostChar & " appeared " & most & " number of times.")
        Console.ReadKey()
    End Sub

End Module
