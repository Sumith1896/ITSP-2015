
'Let us create a ball and few observers
Public Class GameEngine

    Public Shared Sub Main()

        'Create our ball (i.e, the ConcreteSubject)
        Dim ball As New FootBall()

        'Create few players (i.e, ConcreteObservers)
        Dim Owen As New Player(ball, "Owen")
        Dim Ronaldo As New Player(ball, "Ronaldo")
        Dim Rivaldo As New Player(ball, "Rivaldo")

        'Create few referees (i.e, ConcreteObservers)
        Dim Mike As New Referee(ball, "Mike")
        Dim John As New Referee(ball, "John")

        System.Console.WriteLine()

        'Attach them with the ball
        ball.AttachObserver(Owen)
        ball.AttachObserver(Ronaldo)
        ball.AttachObserver(Rivaldo)
        ball.AttachObserver(Mike)
        ball.AttachObserver(John)

        System.Console.WriteLine(" After attaching the observers...")
        'Update the position of the ball. 
        'At this point, all the observers should be notified
        ball.SetBallPosition(New Position())



        System.Console.WriteLine()


        'Remove some observers
        ball.DetachObserver(Owen)
        ball.DetachObserver(John)


        System.Console.WriteLine(" After detaching Owen and John...")

        'Updating the position of ball again
        'At this point, all the observers should be notified
        ball.SetBallPosition(New Position(10, 10, 30))

        'Press any key to continue..
        System.Console.Read()


    End Sub

End Class
