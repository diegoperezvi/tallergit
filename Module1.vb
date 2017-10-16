Option Strict On
Module Module1

    Sub Main()
        Dim situacionLaboral, subvencion As String
        Console.WriteLine("Es usted empleado, autonomo o parado")
        situacionLaboral = Console.ReadLine()
        Console.WriteLine("¿Cobra alguna prestación del estado?")
        subvencion = Console.ReadLine()
        If situacionLaboral = "parado" Or situacionLaboral = "empleado" And subvencion = "no" Or subvencion = "No" Then
            Console.WriteLine("Tiene derecho a solicitar una ayuda del estado")
        Else
            Console.WriteLine("No puede solicitar la ayuda")
        End If
        Console.ReadLine()

    End Sub

End Module
