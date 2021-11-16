Module Module1

    Sub Main()
        Dim str1 As String
        Dim count, acount, ecount, icount, ocount, ucount As Integer
        Dim thischar As Char

        count = 0
        thischar = ""
        str1 = ""
        acount = 0
        ecount = 0
        icount = 0
        ocount = 0
        ucount = 0



        Console.Write("please enter string to find vowel:")
        str1 = Console.ReadLine
        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            thischar = UCase(thischar)
            If thischar = "A" Then
                acount = acount + 1
            ElseIf thischar = "E" Then
                ecount = ecount + 1
            ElseIf thischar = "I" Then
                icount = icount + 1
            ElseIf thischar = "O" Then
                ocount = ocount + 1
            ElseIf thischar = "U" Then
                ucount = ucount + 1

            End If

        Next
        Console.WriteLine("Number of times a appeared: " & acount)
        Console.WriteLine("Number of times e appeared: " & ecount)
        Console.WriteLine("Number of times i appeared: " & icount)
        Console.WriteLine("Number of times o appeared: " & ocount)
        Console.WriteLine("Number of times u appeared: " & ucount)
        Console.ReadKey()
    End Sub

End Module
