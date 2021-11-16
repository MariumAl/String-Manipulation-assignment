Module Module1

    Sub Main()

        Dim str1, str2 As String
        Dim char1, char2, thischar As Char
        Dim count As Integer
        count = 0
        char1 = ""
        str1 = ""
        char2 = ""
        thischar = ""
        str2 = ""

        Console.WriteLine("Enter string to process: ")
        str1 = Console.ReadLine
        Console.WriteLine("Enter charcter to replace: ")
        char1 = Console.ReadLine
        Console.WriteLine("Enter character to replace with: ")
        char2 = Console.ReadLine

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If thischar = char1 Then
                thischar = char2

            End If
            str2 = str2 & thischar

        Next

        Console.WriteLine("processed string: " & str2)
        Console.ReadKey()
    End Sub

End Module



