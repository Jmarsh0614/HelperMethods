Module Module1

    Sub Main()

        Call displayTheMessage()
        Console.ReadLine()
        displayTheMessage()
        Console.ReadLine()

        Dim message As String
        message = superSecretFormula()
        Console.WriteLine(message)
        Console.ReadLine()
        Console.WriteLine(superSecretFormula())
        Console.ReadLine()
        Console.WriteLine(superSecretFormula("Bitch"))
        Console.ReadLine()






    End Sub
    Sub displayTheMessage()
        Console.WriteLine("From displayTheMessage")
    End Sub

    Function superSecretFormula() As String

        Return "Hello World"
    End Function

    Function superSecretFormula(ByVal name As String) As String
        Return String.Format("Hello {0}!", name)
    End Function

End Module
