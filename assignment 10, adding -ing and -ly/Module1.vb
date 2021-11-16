Module Module1

    Sub Main()
        Dim str1, lastChars As String

        str1 = ""
        lastChars = ""

        Console.Write("Enter string to process: ")
        str1 = Console.ReadLine
        lastChars = Right(str1, 3)
        If Len(str1) < 3 Then
            Console.Write("Processed string: " & str1)
        ElseIf lastChars = "ing" Then
            Console.Write("Processed string : " & str1 & "ly")
        Else : Console.Write("Processed string: " & str1 & "ing")

        End If
        Console.ReadKey()

    End Sub

End Module
