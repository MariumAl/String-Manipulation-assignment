Module Module1

    Sub Main()
        Dim count As Integer
        count = 0
        Console.Write("Input number of donuts:")
        count = Console.ReadLine()
        If count <= "9" And count >= "0" Then
            Console.WriteLine("Number of Donuts: " & count)
        ElseIf count >= "10" Then
            Console.WriteLine("Number of donuts: Many.")
        Else : Console.WriteLine("invalid input.")
        End If
        Console.ReadKey()
    End Sub

End Module
