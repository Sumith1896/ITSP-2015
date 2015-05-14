'GameEngine class for demonstration

Public Class GameEngine

    Public Shared Sub Main()



        'Let us create a team and set its strategy,
        'and make the teams play the game

        'Create few strategies
        Dim attack As New AttackStrategy()
        Dim defend As New DefendStrategy()

        'Create our teams
        Dim france As New Team("France")
        Dim italy As New Team("Italy")

        System.Console.WriteLine(" Setting the strategies..")

        'Now let us set the strategies
        france.SetStrategy(attack)
        italy.SetStrategy(defend)

        'Make the teams start the play
        france.PlayGame()
        italy.PlayGame()

        System.Console.WriteLine()
        System.Console.WriteLine(" Changing the strategies..")

        'Let us change the strategies
        france.SetStrategy(defend)
        italy.SetStrategy(attack)

        'Make them play again
        france.PlayGame()
        italy.PlayGame()

        'Wait for a key press
        System.Console.Read()


    End Sub

End Class
