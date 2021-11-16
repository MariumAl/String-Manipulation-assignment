Module Module1

    Sub Main()
        Dim str1, str2, str3, s1char, s2char, restChar1, restChar2 As String
        str1 = ""
        str2 = ""
        str3 = ""
        s1char = ""
        s2char = ""
        restChar1 = ""
        restChar2 = ""
        Console.Write("Input first string: ")
        str1 = Console.ReadLine
        Console.Write("Input second string: ")
        str2 = Console.ReadLine

        s1char = Mid(str1, 1, 2)
        s2char = Mid(str2, 1, 2)
        restChar1 = Mid(str1, 3, Len(str1) - 2)
        restChar2 = Mid(str2, 3, Len(str2) - 2)
        str3 = s2char & restChar1 & " " & s1char & restChar2
        Console.Write("Processed string: " & str3)
        Console.ReadKey()


    End Sub

End Module
