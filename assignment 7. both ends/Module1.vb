Module Module1

    Sub Main()
        Dim str1, char2, char1 As String
        Dim seclastP As Integer
        seclastP = 0
        str1 = ""
        char1 = ""
        char2 = ""
        Console.Write("Input string: ")
        str1 = Console.ReadLine()
        char1 = Mid(str1, 1, 2)
        char2 = Right(str1, 2)
        If Len(str1) < "2" Then
            Console.WriteLine(str1)
        Else : Console.WriteLine("processed string: " & char1 & char2)
        End If
        Console.ReadKey()

    End Sub

End Module
