'Alexis Villagran
'RCET 2265
'Spring 2025
'SayMyNameAGAIN

Option Strict On
Option Explicit On
Module SayMyNameAGAIN

    Sub Main()
        Console.WriteLine("Hello please enter your name?")
        Dim name As String = Console.ReadLine()

        Select Case name.ToLower

            Case "tim"
                Console.WriteLine("5 Bucks!" & vbNewLine & "-Tim")
            Case "joe"
                Console.WriteLine("Joe-mama")
            Case "emily"
                Console.WriteLine("Yo, Emily what is up?")
            Case "alexis"
                Console.WriteLine("Alexis are you donw with your lab?")
            Case Else
                Console.WriteLine($"NO CUSTOM GREETING FOR YOU {name}!")
        End Select



    End Sub

End Module
