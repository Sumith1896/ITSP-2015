
'Let us put it together
Public Class GameEngine

    Public Shared Sub Main()

        '-- Step 1: 
        'Create few players (concrete components)

        'Create few field Players
        Dim owen As New FieldPlayer("Owen")
        Dim beck As New FieldPlayer("Beckham")


        'Create a goal keeper
        Dim khan As New GoalKeeper("Khan")

        '-- Step 2: 
        'Just make them pass the ball 
        '(during a warm up session ;))

        System.Console.WriteLine()
        System.Console.WriteLine(" > Warm up Session... ")

        owen.PassBall()
        beck.PassBall()
        khan.PassBall()

        '-- Step 3: Create and assign the responsibilities
        '(when the match starts)

        System.Console.WriteLine()
        System.Console.WriteLine(" > Match is starting.. ")


        'Set owen as our first forward
        Dim forward1 As New Forward()
        forward1.AssignPlayer(owen)

        'Set Beckham as our midfielder
        Dim midfielder1 As New MidFielder()
        midfielder1.AssignPlayer(beck)

        'Now, use these players to do actions
        'specific to their roles

        'Owen can pass the ball
        forward1.PassBall()
        'And owen can shoot as well
        forward1.ShootGoal()

        'Beckham can pass ball
        midfielder1.PassBall()
        'Beckham can dribble too
        midfielder1.Dribble()

        ' [ Arrange the above operations to some meaningfull sequence, like
        ' "Beckham dribbled and passed the ball to owen and owen shooted the
        ' goal ;) - just for some fun ]"

        '-- Step 4: Now, changing responsibilities
        '(during a substitution)

        'Assume that owen got injured, and we need a new player
        'to play as our forward1

        System.Console.WriteLine()
        System.Console.WriteLine(" > OOps, Owen got injured. " & _
                                        "Jerrard replaced Owen.. ")

        'Create a new player
        Dim jerrard As New FieldPlayer("Jerrard")

        'Ask Jerrard to play in position of owen
        forward1.AssignPlayer(jerrard)
        forward1.ShootGoal()

        '-- Step 5: Adding multiple responsibilities
        '(When a player need to handle multiple roles)

        'We already have Beckham as our midfielder. 
        'Let us ask him to play as an additional forward

        Dim onemoreForward As New Forward()
        onemoreForward.AssignPlayer(beck)

        System.Console.WriteLine()
        System.Console.WriteLine(" > Beckham has multiple responsibilities.. ")

        'Now Beckham can shoot
        onemoreForward.ShootGoal()
        'And use his earlier responsibility to dribble too
        midfielder1.Dribble()

        'According to our design, you can attach the responsibility of
        'a forward to a goal keeper too, but when you actually 
        'play football, remember that it is dangerous ;)

        'Wait for key press
        System.Console.Read()


    End Sub

End Class
