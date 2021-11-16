Module Module1

    Sub Main()
        Dim str1, begstr, endstr As String
        begstr = ""
        str1 = ""
        endstr = ""
        Console.Write("Enter string to evaluate: ")
        str1 = Console.ReadLine
       
        If InStr(str1, "not") < InStr(str1, "bad") Then
            begstr = Left(str1, InStr(str1, "not") - 1)
            endstr = Right(str1, Len(str1) - InStr(str1, "bad") - 2)

            Console.Write("processed string: " & begstr & "good" & endstr)
        Else : Console.Write("processed string: " & str1)

        End If
        Console.ReadKey()

    End Sub

End Module
