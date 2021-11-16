Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim count As Integer
        Dim thisChar As Char
        Dim isPangram As Boolean

        str1 = ""
        str2 = "QWERTYUIOPLKJHGFDSAZXCVBNM"
        thisChar = ""
        count = 0
        isPangram = True

        Console.Write("Enter String To Validate: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        For count = 1 To Len(str2)
            thisChar = Mid(str2, count, 1)
            If InStr(str1, thisChar) = 0 Then
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("All alphabets are present in the string.")
        Else
            Console.WriteLine("All alphabets are not present in string.")
        End If
        Console.ReadKey()
    End Sub

End Module
