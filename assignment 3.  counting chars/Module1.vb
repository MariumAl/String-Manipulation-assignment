Module Module1

    Sub Main()
        Dim str1 As String
        Dim count, alphaCount, digCount, specCount, x As Integer
        Dim char1, thischar As Char
        str1 = ""
        count = 0
        char1 = ""
        x = 0
        alphaCount = 0
        digCount = 0
        specCount = 0
        thischar = ""


        Console.Write("enter string text: ")
        str1 = Console.ReadLine()

        Console.Write("enter character:")
        char1 = Console.ReadLine()
        For x = 1 To Len(str1)
            thischar = Mid(str1, x, 1)
            If UCase(thischar) = UCase(char1) Then
                count = count + 1
            End If
            If Asc(thischar) >= Asc("A") And Asc(thischar) <= Asc("Z") Or Asc(thischar) >= Asc("a") And Asc(thischar) <= Asc("z") Then
                alphaCount = alphaCount + 1
            ElseIf thischar >= "0" And thischar <= "9" Then
                digCount = digCount + 1
            Else : specCount = specCount + 1
            End If
        Next

        Console.WriteLine("Number of times character appeared: " & count)
        Console.WriteLine("number of alphabets: " & alphaCount)
        Console.WriteLine("Number of digits: " & digCount)
        Console.WriteLine("Number of special characters: " & specCount)
        Console.ReadLine()
    End Sub

End Module
