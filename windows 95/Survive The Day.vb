Public Class Survive_The_Day
    Dim moveable As Boolean = True
    Dim mexlocation, meylocation As Integer
    Dim mewidth, meheight As Integer
    Dim maximize As Boolean

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles programtopbar.MouseDown
        If moveable = True Then
            If e.Button = MouseButtons.Left Then
                programtopbar.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        Else
        End If
    End Sub

    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click

        Me.Close()
    End Sub

    Private Sub pullside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullside.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
    End Sub

    Private Sub pullbottom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullbottom.Tick
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pullbs_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pullbs.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseDown
        pullside.Start()
    End Sub

    Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseUp
        pullside.Stop()
    End Sub

    Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseDown
        pullbottom.Start()
    End Sub

    Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseUp
        pullbottom.Stop()
    End Sub

    Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseDown
        pullbs.Start()
    End Sub

    Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseUp
        pullbs.Stop()
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click
        If maximize = False Then
            meylocation = Windows2000.desktopicons.Height - Me.Height
            mexlocation = Windows2000.desktopicons.Width - Me.Width
            mewidth = Me.Width
            meheight = Me.Height
            toprightcorner.Hide()
            topleftcorner.Hide()
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            left.Hide()
            top.Hide()
            bottom.Hide()
            right.Hide()
            Dim w, h As Integer
            w = Windows2000.desktopicons.Width
            h = Windows2000.desktopicons.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Size(w, h)
            moveable = False
            maximizebutton.Image = My.Resources.unmaximizebutton
            maximize = True
        Else
            toprightcorner.Show()
            topleftcorner.Show()
            bottomrightcorner.Show()
            bottomleftcorner.Show()
            left.Show()
            top.Show()
            bottom.Show()
            right.Show()
            Me.Location = New Point(mexlocation, meylocation)
            Me.Size = New Size(mewidth, meheight)
            moveable = True
            maximizebutton.Image = My.Resources.Maximize
            maximize = False
        End If
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows2000.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows2000.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows2000.exampleprogramtext.BackColor
    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Restart" Then
            Status.Text = "Early Wake Up"
            story.Text = "You are laying in bed surrounded by darkness. You look to your right and see in big red numbers 4:00 AM displayed on your alarm clock."
            Button1.Text = "Get out of Bed"
            Button2.Text = "Go back to sleep"
            Button3.Text = "Set alarm clock to 8:00 AM"
            Button4.Text = "Turn your alarm clocks radio on"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:00 AM"
        ElseIf Status.Text = "Early Wake Up" Then
            Status.Text = "Blind in the darkness"
            story.Text = "You slowly get out of bed unable to see anything. Carefully you walk around in the dark and feel for the light switch. Just as you find it a memory came to your mind about how the electrician said not to use the lights yet as they may be faulty."
            Button1.Text = "Press It"
            Button2.Text = "Explore the house without the lights"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:01 AM"
        ElseIf Status.Text = "Title Screen" Then
            Status.Text = "Early Wake Up"
            story.Text = "You are laying in bed surrounded by darkness. You look to your right and see in big red numbers 4:00 AM displayed on your alarm clock."
            Button1.Text = "Get out of Bed"
            Button2.Text = "Go back to sleep"
            Button3.Text = "Set alarm clock to 8:00 AM"
            Button4.Text = "Turn your alarm clocks radio on"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:00 AM"
        ElseIf Status.Text = "Blind in the darkness" Then
            Status.Text = "House On Fire"
            story.Text = "The Light turns on and everything seems ok. All of a sudden it starts to flicker on and off. Your just about to turn it off when it bursts open. Sparks fly everywhere setting your room on fire."
            Button1.Text = "Run out of the house"
            Button2.Text = "Try and put the fire out"
            Button3.Text = "Call 000"
            Button4.Text = "Yell out loud for help"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:02 AM"
        ElseIf Status.Text = "House On Fire" Then
            Status.Text = "Run Over"
            story.Text = "You run out of the house as it collapses benhind you. Suddenly you hear BEEEEEEEP and see big lights coming toward you. You catch your last look around you and see that your in the middle of the road. Everything goes black as you fall to the ground flaterned by a truck" & Environment.NewLine & Environment.NewLine & "Game Over: Killed by being run over by a car"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:03 AM"
        ElseIf Status.Text = "Run Over" Then
            Status.Text = "Early Wake Up"
            story.Text = "You are laying in bed surrounded by darkness. You look to your right and see in big red numbers 4:00 AM displayed on your alarm clock."
            Button1.Text = "Get out of Bed"
            Button2.Text = "Go back to sleep"
            Button3.Text = "Set alarm clock to 8:00 AM"
            Button4.Text = "Turn your alarm clocks radio on"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:00 AM"
        ElseIf Status.Text = "A Second Smash" Then
            Status.Text = "A Struggle To The Car"
            story.Text = "You take a step towards your front door and the glass in your foot digs deeper in. You fall over unable to take another step. You try sliding your way to the front door to get to the garage but your stomach gets bigs of glass inside it. You are now completly covered in glass bleeding and unable to get to the garage. Your head drops and you lay down slowely falling unconcious and bleeding to death." & Environment.NewLine & Environment.NewLine & "Game Over: Bleed to Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "No Fire Extinguisher" Then
            Status.Text = "A Hopeless Attempt"
            story.Text = "You Quickly fill up a glass of water from the kitchen and rush it to your room. You pour the water onto the fire but it does nothing, again you run to the kitchen but by the time you start running back to your room the fire has blocked you off in the kitchen. You start the frozen with fear as the house comes crashing down on top of you." & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death, Burried Alive"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "Smash" Then
            Status.Text = "Glass"
            story.Text = "You bend down and feel around. Scattered everywhere is small pieces of glass. You take on step away to a dustpan and broom but your foot gets cut. You fall backwards and glass goes through your skull strait through your head." & Environment.NewLine & Environment.NewLine & "Game Over: Glass Through Head"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:03 AM"
        ElseIf Status.Text = "Beginning Of A Relaxing Day" Then
            Status.Text = "Toast"
            story.Text = "You grab some toast and put it into the toaster. It pops up and you butter it. You sit at your table and just look outside at the piece and relaxation. Once you finish your toast you start to wonder what you should do"
            Button1.Text = "Go for a Walk"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:08 AM"
        ElseIf Status.Text = "Sushi" Then
            Status.Text = "Dead In Bed"
            story.Text = "You Quickly go to bed hoping that you don’t throw up. You lay there in bed slowly closing your eyes, little do you know that this is the last time you will do so." & Environment.NewLine & Environment.NewLine & "Game Over: Died In Sleep"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:15 AM"
        ElseIf Status.Text = "Toast" Then
            Status.Text = "Morning Walk"
            story.Text = "You go outside and feel a light breeze blow onto you. The sun is out and its a great day. The world is worry free and everything is perfect. After about 15 minutes you start to get a little tired."
            Button1.Text = "Continue walking"
            Button2.Text = "Go to church"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:17 AM"
        ElseIf Status.Text = "Cereal" Then
            Status.Text = "Morning Walk"
            story.Text = "You go outside and feel a light breeze blow onto you. The sun is out and its a great day. The world is worry free and everything is perfect. After about 15 minutes you start to get a little tired."
            Button1.Text = "Continue walking"
            Button2.Text = "Go Home And Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:17 AM"
        ElseIf Status.Text = "Morning Walk" Then
            Status.Text = "Extended walk"
            story.Text = "As you continue to walk you start to get a little colder. Some white fluffy clouds are slowly appearing in the sky. You are quite a long way from home and you are right next to a movie theatre. You have heard that a movie called ‘End Of The World’ was going to be playing in the cinemas today. Behind you hear the sound of crying and see a young woman on the side of the road with a radio."
            Button1.Text = "Go to the sad woman"
            Button2.Text = "Go in the cinema and watch the movie"
            Button3.Text = "Go Home and watch tv"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:30 AM"
        ElseIf Status.Text = "Morning TV" Then
            Status.Text = "Dead Miners"
            story.Text = "On t.v the morning news comes up. A news reporter says ‘This morning 666 miners have died in 13 different places around the world.’ It seems that a series of small underground earthquakes has been collapsing tunnels all over the world."
            Button1.Text = "Continue watching tv"
            Button2.Text = "-"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:30 AM"
        ElseIf Status.Text = "Extended walk" Then
            Status.Text = "Sad Woman"
            story.Text = "You walk up to the sad woman who is crying on the side of the road. She looks up at you with tears in her eyes. ‘Whats wrong’ you ask her. ‘My husband died, he was killed because a tunnel collapsed on him while he was mining, there was an earthquake’ The woman then looks up at you with an angry face. ‘Why did he have to die’ she yelled. Then she grabs you and pulls you down to the ground repeatedly punching you. You slowly pass out as she beats you to death. " & Environment.NewLine & Environment.NewLine & "Game Over: Punched To Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:30 AM"
        ElseIf Status.Text = "Toast" Then
            Status.Text = "Morning TV"
            story.Text = "You lay back on your couch and start watching tv. You see a little cartoon character jumping around the tv screen. A big weird naked guy comes with a sign on him saying ‘The End Is Near’. The little creature pays no attention then dies when the earth breaks up."
            Button1.Text = "Continue watching TV"
            Button2.Text = "Go to church"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:12 AM"
        ElseIf Status.Text = "Dead Miners" Then
            Status.Text = "Morning Weather Report"
            story.Text = "On tv a man on the morning weather report looks very confused. He looks like he is following instructions from somebody behind the camera quickly changing what he was going to say. He begins talking ‘Today started off mostly sunny but it looks like the weather is changing rapidly and some rain is to be expected by the end of the day.’ He then points to a weather chart shocked at the speedy changes. ‘Today marks the fasted change of weather ever recorded’. This is then followed by a few experts trying to examine the weather changes."
            Button1.Text = "Look Outside"
            Button2.Text = "Call a friend"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:45 AM"
        ElseIf Status.Text = "Church Disscussion" Then
            Status.Text = "Morning Weather Report"
            story.Text = "On tv a man on the morning weather report looks very confused. He looks like he is following instructions from somebody behind the camera quickly changing what he was going to say. He begins talking ‘Today started off mostly sunny but it looks like the weather is changing rapidly and some rain is to be expected by the end of the day.’ He then points to a weather chart shocked at the speedy changes. ‘Today marks the fasted change of weather ever recorded’. This is then followed by a few experts trying to examine the weather changes."
            Button1.Text = "Look Outside"
            Button2.Text = "Call a friend"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:45 AM"
        ElseIf Status.Text = "Morning Weather Report" Then
            Status.Text = "Look Outside"
            story.Text = "After what you saw on TV you just had to check it out for yourself. You remember when you woke up almost an hour ago the sky was clear blue and now it’s almost completely covered by black clouds."
            Button1.Text = "Watch The Sky"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:50 AM"
        ElseIf Status.Text = "Look Outside" Then
            Status.Text = "Sky Watching"
            story.Text = "You lie down on the grass outside your house and stare at the sky. Everything seems quite scary now. The sky does not have a single patch of blue at all. The sky is covered in a think black layer of clouds but there is no rain. You look around and see the darkness everywhere. The sun is almost completely blocked out and there’s no light or happiness on the streets."
            Button1.Text = "Have a Nap"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:00 AM"
        ElseIf Status.Text = "Morning Weather Report" Then
            Status.Text = "News Story: The Sky"
            story.Text = "The morning news begins on TV and its top story comes up titled ‘The Sky’. A news reporter comes up and starts interviewing weather experts. They say they have never seen anything like it before. There was no sign at 8:00am of any clouds appearing. Experts say the clouds came out of nowhere and appeared so fast it was like they teleported there."
            Button1.Text = "Have a Nap"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:00 AM"
        ElseIf Status.Text = "Call A Friend" Then
            Status.Text = "News Story: The Sky"
            story.Text = "The morning news begins on TV and its top story comes up titled ‘The Sky’. A news reporter comes up and starts interviewing weather experts. They say they have never seen anything like it before. There was no sign at 8:00am of any clouds appearing. Experts say the clouds came out of nowhere and appeared so fast it was like they teleported there."
            Button1.Text = "Have a Nap"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:00 AM"
        ElseIf Status.Text = "Go To Friends House" Then
            Status.Text = "Watching a movie with your friend"
            story.Text = "You and your friend try to keep your mind off what’s happening outside. Your friend puts a movie up on his TV he recorded a while ago. After about half an hour of watching it you notice something dark move mysteriously in the sky outside the window."
            Button1.Text = "Go Home"
            Button2.Text = "Tell friend what you saw"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        ElseIf Status.Text = "News Story: The Sky" Then
            Status.Text = "Morning Nap"
            story.Text = "Since there’s nothing much to do you decide to take a nap. After one hour you wake up and see something weird in the sky. You run up to the window to get a good look. It seems to be a weird dark comet but its moving up and down in all different directions. It suddenly disappears and you are unable to locate it again."
            Button1.Text = "Look Outside"
            Button2.Text = "-"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        ElseIf Status.Text = "Sky Watching" Then
            Status.Text = "Morning Nap"
            story.Text = "Since there’s nothing much to do you decide to take a nap. After one hour you wake up and see something weird in the sky. You run up to the window to get a good look. It seems to be a weird dark comet but its moving up and down in all different directions. It suddenly disappears and you are unable to locate it again."
            Button1.Text = "Look Outside"
            Button2.Text = "-"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        ElseIf Status.Text = "Watching a movie with your friend" Then
            Status.Text = "Going Back Home From Your Friend’s House"
            story.Text = "You have had enough of your friends house. The whole dark comet thing in the sky or whatever it was scared you and that’s all it took for you to leave. You finally get home parking your car in the garage. Your about to walk back inside your house when you hear a weird voice coming from the back of your garage saying ‘Help Me’."
            Button1.Text = "Quickly go inside"
            Button2.Text = "Check out where the voice is coming from"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:30 AM"
        ElseIf Status.Text = "Stayed In Your Friends House" Then
            Status.Text = "Going Back Home From Your Friend’s House"
            story.Text = "You have had enough of your friends house. The whole dark comet thing in the sky or whatever it was scared you and that’s all it took for you to leave. You finally get home parking your car in the garage. Your about to walk back inside your house when you hear a weird voice coming from the back of your garage saying ‘Help Me’."
            Button1.Text = "Quickly go inside"
            Button2.Text = "Check out where the voice is coming from"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:30 AM"
        ElseIf Status.Text = "Telling Your Friend What You Saw" Then
            Status.Text = "Going Back Home From Your Friend’s House"
            story.Text = "You have had enough of your friends house. The whole dark comet thing in the sky or whatever it was scared you and that’s all it took for you to leave. You finally get home parking your car in the garage. Your about to walk back inside your house when you hear a weird voice coming from the back of your garage saying ‘Help Me’."
            Button1.Text = "Quickly go inside"
            Button2.Text = "Check out where the voice is coming from"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:30 AM"
        ElseIf Status.Text = "Chatting With Your Friend About The Weird Weather" Then
            Status.Text = "Stayed In Your Friends House"
            story.Text = "You sit in the chair looking outside waiting for your friend to come back. You look at the trees blowing and the wind getting stronger. Waiting now for 10 minutes there is no sign of your friend anywhere. "
            Button1.Text = "Go Home"
            Button2.Text = "Continue Waiting"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:10 AM"
       ElseIf Status.Text = "News Weather Report" Then
            Status.Text = "Morning Nap"
            story.Text = "Since there’s nothing much to do you decide to take a nap. After one hour you wake up and see something weird in the sky. You run up to the window to get a good look. It seems to be a weird dark comet but its moving up and down in all different directions. It suddenly disappears and you are unable to locate it again."
            Button1.Text = "Look Outside"
            Button2.Text = "-"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        ElseIf Status.Text = "Going Back Home From Your Friend’s House" Then
            Status.Text = "Freaky Outside"
            story.Text = " You stand inside your house looking outside your window. You see things mysterious things flying in the sky, weird voices’ coming from outside and everything is almost dark because of the thick layer of dark clouds in the sky. You look at the time and see 10:35. It just had to be like this on a Sunday you thought..."
            Button1.Text = "Hide In Cupboard for rest of day"
            Button2.Text = "Watch TV"
            Button3.Text = "Go Outside"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:35 AM"
        
        ElseIf Status.Text = "Morning Nap" Then
            Status.Text = "Freaky Outside"
            story.Text = " You stand inside your house looking outside your window. You see things mysterious things flying in the sky, weird voices’ coming from outside and everything is almost dark because of the thick layer of dark clouds in the sky. You look at the time and see 10:35. It just had to be like this on a Sunday you thought..."
            Button1.Text = "Hide In Cupboard for rest of day"
            Button2.Text = "Watch TV"
            Button3.Text = "Go Outside"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:35 AM"
        ElseIf Status.Text = "News Weather Report" Then
            Status.Text = "Morning Nap"
            story.Text = "Since there’s nothing much to do you decide to take a nap. After one hour you wake up and see something weird in the sky. You run up to the window to get a good look. It seems to be a weird dark comet but its moving up and down in all different directions. It suddenly disappears and you are unable to locate it again."
            Button1.Text = "Look Outside"
            Button2.Text = "-"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Quit" Then
            Me.Close()
        End If

        If Status.Text = "House On Fire" Then
            Status.Text = "No Fire Extinguisher"
            story.Text = "You run to the kitchen to get the fire extinguisher but you remeber that your neighbour had to borrow it yesterday and has not yet returned it. The fire has now burnt down your whole room and is starting to burn down the hallway. You look around you with not many options. You need to find an alternative way to put the fire out."
            Button1.Text = "fill up a glass of water from the kitchen to pour over the fire"
            Button2.Text = "Get a hose from the garden to put the fire out"
            Button3.Text = "Get a blanket from the loungeroom and try to cover the fire with it"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:03 AM"
        ElseIf Status.Text = "Church Disscusion" Then
            Status.Text = "Morning Weather Report"
            story.Text = "On tv a man on the morning weather report looks very confused. He looks like he is following instructions from somebody behind the camera quickly changing what he was going to say. He begins talking ‘Today started off mostly sunny but it looks like the weather is changing rapidly and some rain is to be expected by the end of the day.’ He then points to a weather chart shocked at the speedy changes. ‘Today marks the fasted change of weather ever recorded’. This is then followed by a few experts trying to examine the weather changes."
            Button1.Text = "Look Outside"
            Button2.Text = "Call a friend"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:45 AM"
        ElseIf Status.Text = "Blind in the darkness" Then
            Status.Text = "Smash"
            story.Text = "You feel around the house not knowing where you are or where your going. Suddenly your hand bumps something off the table and you hear it crash to the ground."
            Button1.Text = "Find out what you dropped"
            Button2.Text = "Keep exploring the house"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:02 AM"
        ElseIf Status.Text = "Smash" Then
            Status.Text = "A Second Smash"
            story.Text = "You take another step to continue exploring your house when you feel a sharp pain in your foot. You jump up in pain and land again in 10x more the pain as bits of glass cut through your foot. You fall backwards feeling the glass cut into your back and your head smash onto the floor."
            Button1.Text = "Drive to hospital"
            Button2.Text = "Go to the bathroom and get bandages"
            Button3.Text = "Take out the bits of glass stuck inside you"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:03 AM"
        ElseIf Status.Text = "A Second Smash" Then
            Status.Text = "A Struggle To The Bathroom"
            story.Text = "Your about 5 metres away from the bathroom. You try sliding yourself along the ground to get there but more glass cuts through your chest. Moving becomes impossible and slowely you bleed to death." & Environment.NewLine & Environment.NewLine & "Game Over: Bleed to Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "A Second Smash" Then
            Status.Text = "A Struggle To The Bathroom"
            story.Text = "Your about 5 metres away from the bathroom. You try sliding yourself along the ground to get there but more glass cuts through your chest. Moving becomes impossible and slowely you bleed to death." & Environment.NewLine & Environment.NewLine & "Game Over: Bleed to Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "No Fire Extinguisher" Then
            Status.Text = "The End Of The House, Hose, And You"
            story.Text = "You run outside as fast as you can ready to get the hose. You pick it up and start unwrapping it. You stand back about 5 metres from your burning house and point the hose to it and try to turn it on. No water comes out and you remeber that you need to turn it on at the tap. Just as your about to get to the tap the house collapses on it and sets the grass on fire. The last thing you feel is yourself burning all over" & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "Beginning Of A Relaxing Day" Then
            Status.Text = "Cereal"
            story.Text = "You open your cupboard and take out the cereal. You slide the fridge open and get the milk. You get a spoon and a bowl and then pour the cereal and milk in. You eat the breakfast but it does seem a little bit cold and does not taste very good."
            Button1.Text = "Go for a Walk"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:09 AM"
        ElseIf Status.Text = "Sushi" Then
            Status.Text = "Car Crash"
            story.Text = "You get into the car feeling very dizzy. You need to get to the doctor right away. As you’re driving you feel yourself drifting off. Things start to go blurry and dark. Then you are awoken with a loud BEEEEEEP" & Environment.NewLine & Environment.NewLine & "Game Over: Killed In Car Crash"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:14 AM"
        ElseIf Status.Text = "Cereal" Then
            Status.Text = "Morning TV"
            story.Text = "You lay back on your couch and start watching tv. You see a little cartoon character jumping around the tv screen. A big weird naked guy comes with a sign on him saying ‘The End Is Near’. The little creature pays no attention then dies when the earth breaks up."
            Button1.Text = "Continue watching TV"
            Button2.Text = "Go to church"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:12 AM"
        ElseIf Status.Text = "Toast" Then
            Status.Text = "Morning TV"
            story.Text = "You lay back on your couch and start watching tv. You see a little cartoon character jumping around the tv screen. A big weird naked guy comes with a sign on him saying ‘The End Is Near’. The little creature pays no attention then dies when the earth breaks up."
            Button1.Text = "Continue watching TV"
            Button2.Text = "Go to church"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:12 AM"
        ElseIf Status.Text = "Morning TV" Then
            Status.Text = "Church Discussion"
            story.Text = "You arrive at church and sit down with the crowd of people to listen to the speaker. The speaker then gets up at the front and starts to speak. ‘The End Is Near’ He begins. Your mind beams back to that cartoon you watched this morning. Did he watch it too you though? He then starts saying that you must respect the world and your place to die in it. ‘We all need to die together’ He says. "
            Button1.Text = "Go home and watch tv"
            Button2.Text = "Stay at church"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:30 AM"
        ElseIf Status.Text = "Extended walk" Then
            Status.Text = "End Of The World Movie"
            story.Text = "You go into the theatre and buy your ticket. The movie shows what the last day on earth might look like. Once the movie finishes you basically sum it up as a bunch of disasters all happening at once. Its the first time in your life you have ever seen 100’s of tornados, tsunamis and earthquakes all at once. When you leave the theatre you are absolutely freezing. There is lots of cold wind rushing past you. The sky is completely covered by black clouds. You start seeing weird things in the sky. You don’t know what they are but they look dangerous. You start running to get home but all of a sudden you are swept of the ground and lifted into the air. You fly up souring high but you start to feel yourself becoming heavy and you fall to your death" & Environment.NewLine & "Game Over: Fell From High Altitude"
            Button1.Text = "Restart"
            Button2.Text = "Exit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        ElseIf Status.Text = "Church Discussion" Then
            Status.Text = "Stayed At Church"
            story.Text = "About 20 people left but you stay at church and continue to listen to this guy continue to talk. He starts saying that when its time to die you need to die. Don’t avoid death when it comes to you. The guy starts walking down towards you. He looks into your eyes and say’s its your time to die. Out of complete fear you run out of church only to find yourself hit by a car. " & Environment.NewLine & Environment.NewLine & "Game Over: Hit By Car"
            Button1.Text = "Restart"
            Button2.Text = "Exit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:30 AM"
        ElseIf Status.Text = "Morning Walk" Then
            Status.Text = "Dead Miners"
            story.Text = "On t.v the morning news comes up. A news reporter says ‘This morning 666 miners have died in 13 different places around the world.’ It seems that a series of small underground earthquakes has been collapsing tunnels all over the world."
            Button1.Text = "Continue Watching TV"
            Button2.Text = "-"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:30 AM"
        ElseIf Status.Text = "Morning Weather Report" Then
            Status.Text = "Call A Friend"
            story.Text = "After this weird sudden weather change you just had to call your best friend to tell them about it. When you call your friend however they already know about the whole thing as they watched it on tv too. Your friend then invites you to their house so that you can have a bit of fun instead of being by yourself at home on a bad day."
            Button1.Text = "Stay home and watch tv"
            Button2.Text = "Go to friends house"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:55 AM"
        ElseIf Status.Text = "Look Outside" Then
            Status.Text = "News Story: The Sky"
            story.Text = "The morning news begins on TV and its top story comes up titled ‘The Sky’. A news reporter comes up and starts interviewing weather experts. They say they have never seen anything like it before. There was no sign at 8:00am of any clouds appearing. Experts say the clouds came out of nowhere and appeared so fast it was like they teleported there."
            Button1.Text = "Have a Nap"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:00 AM"
        ElseIf Status.Text = "Morning Weather Report" Then
            Status.Text = "News Story: The Sky"
            story.Text = "The morning news begins on TV and its top story comes up titled ‘The Sky’. A news reporter comes up and starts interviewing weather experts. They say they have never seen anything like it before. There was no sign at 8:00am of any clouds appearing. Experts say the clouds came out of nowhere and appeared so fast it was like they teleported there."
            Button1.Text = "Have a Nap"
            Button2.Text = "Watch TV"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:00 AM"
        ElseIf Status.Text = "Call A Friend" Then
            Status.Text = "Go To Friends House"
            story.Text = "After a long car trip of about half an hour you finally arrive at your friend’s house at 9:30am. When you get out of your car you notice that there is a strong wind blowing outside so hard the trees are rocking. You quickly knock on your friend’s door and they let you in very quickly."
            Button1.Text = "Watch a movie with your friend"
            Button2.Text = "chat with your friend about the weird weather"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:30 AM"
        ElseIf Status.Text = "Go To Friends House" Then
            Status.Text = "Chatting With Your Friend About The Weird Weather"
            story.Text = "You and your friend both sit down on chairs looking outside near the window. You ask your friend about the sky being covered by black clouds so fast and he says that it’s the first time he has ever seen anything like this in his whole life. Then both of you see something move outside. It was like a dark comet but it moved in all different directions then just disappeared."
            Button1.Text = "Stay In House"
            Button2.Text = "Follow Friend"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:00 AM"
        ElseIf Status.Text = "News Story: The Sky" Then
            Status.Text = "News Weather Report"
            story.Text = "Normal T.V shows seem to have been interrupted. The news is seemly doing reports all day about the weather. A weather reporter starts talking about how the whole earth is completely covered in a think black cloud which does not seem to be made of liquid. It’s not raining anywhere in the world but it’s starting to get windy. The Reporter goes on about how this whole event is not scientifically possible and there’s something defiantly gone wrong."
            Button1.Text = "Have a Nap"
            Button2.Text = "Look Outside"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:30 AM"
        ElseIf Status.Text = "Sky Watching" Then
            Status.Text = "News Weather Report"
            story.Text = "Normal T.V shows seem to have been interrupted. The news is seemly doing reports all day about the weather. A weather reporter starts talking about how the whole earth is completely covered in a think black cloud which does not seem to be made of liquid. It’s not raining anywhere in the world but it’s starting to get windy. The Reporter goes on about how this whole event is not scientifically possible and there’s something defiantly gone wrong."
            Button1.Text = "Have a Nap"
            Button2.Text = "Look Outside"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 9:30 AM"
        ElseIf Status.Text = "Watching a movie with your friend" Then
            Status.Text = "Telling Your Friend What You Saw"
            story.Text = "You quickly stop the movie and try to explain to your friend what you saw. ‘Really’ he says. You conform you are telling the truth. Your friend then runs out of the house looking for whatever it was."
            Button1.Text = "Go Home"
            Button2.Text = "Wait for your friend to come back"
            Button3.Text = "follow friend"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:05 AM"
        ElseIf Status.Text = "Telling Your Friend What You Saw" Then
            Status.Text = "A Wait Which You Wish You Never Did"
            story.Text = "after 20 minutes you start hearing sounds behind you. It must be your friend you think. You turn around and see nobody but you know you heard something. Suddenly you see your friend with red eyes jump out behind the door. ‘Come here’ he says. You stand still terrified to move. ‘We will have to do this the hard way then’ he yells. He runs toward you and his hands go all over your body burning you to death" & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death By Friend"
            Button1.Text = "Restart"
            Button2.Text = "Exit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:20 AM"
        ElseIf Status.Text = "Stayed In Your Friends House" Then
            Status.Text = "A Wait Which You Wish You Never Did"
            story.Text = "after 20 minutes you start hearing sounds behind you. It must be your friend you think. You turn around and see nobody but you know you heard something. Suddenly you see your friend with red eyes jump out behind the door. ‘Come here’ he says. You stand still terrified to move. ‘We will have to do this the hard way then’ he yells. He runs toward you and his hands go all over your body burning you to death" & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death By Friend"
            Button1.Text = "Restart"
            Button2.Text = "Exit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:20 AM"
        ElseIf Status.Text = "Chatting With Your Friend About The Weird Weather" Then
            Status.Text = "Following Your Friend"
            story.Text = "You go outside to see where your friend went but their nowhere in site. Suddenly you look up and see the dark figure you had seen earlier in the clouds. It comes down slowly to you and you start run. It speeds like a rocket toward you and smashes you into the ground. You look up to it barely alive and notice it looks like a spaceship. The door opens and then you see your friend standing at it with red eyes staring at you with a menacing smile on his face. He then walks up to you and says ‘You should have left when you had the chance’ then he touches you burning you to death. " & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death By Friend"
            Button1.Text = "Restart"
            Button2.Text = "Exit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:10 AM"
        ElseIf Status.Text = "Going Back Home From Your Friend’s House" Then
            Status.Text = "The Voice At The Back Of The Garage"
            story.Text = "You walk closer to where you heard the voice. All of a sudden the garage closes leaving you alone in the dark. Then you hear the voice again much loud this time. It starts repeating over and over and it sounds like lots of people are saying it at once. You feel yourself being pulled down and start burning up. Then all around you there are screaming people yelling and crying slowly being tortured to death. That’s the last thing you see before you feel yourself being ripped apart." & Environment.NewLine & Environment.NewLine & "Game Over: Ripped Apart"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:35 AM"
        ElseIf Status.Text = "News Weather Report" Then
            Status.Text = "Freaky Outside"
            story.Text = " You stand inside your house looking outside your window. You see things mysterious things flying in the sky, weird voices’ coming from outside and everything is almost dark because of the thick layer of dark clouds in the sky. You look at the time and see 10:35. It just had to be like this on a Sunday you thought..."
            Button1.Text = "Hide In Cupboard for rest of day"
            Button2.Text = "Watch TV"
            Button3.Text = "Go Outside"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:35 AM"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Status.Text = "A Second Smash" Then
            Status.Text = "Pulling Out The Glass"
            story.Text = "You Quickly but carfully try and take out every bit of glass out of you. Every pull is like a knife digging into your skin and you can barely take it. Every time you pull a piece of glass out the blood starts to come out faster. You start feeling dizzy and light headed. You fall to the ground and slowely bleed to death." & Environment.NewLine & Environment.NewLine & "Game Over: Bleed to Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "No Fire Extinguisher" Then
            Status.Text = "Fire Blanket On Fire"
            story.Text = "You grab a blanket from the lounge and run to your burning room. You try and put the blanket on the fire but the blanket catches on fire. In extreme shock you chuck the blanket away and your house collapses onto you burning away into nothing" & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:04 AM"
        ElseIf Status.Text = "House On Fire" Then
            Status.Text = "No Help In An Emergency"
            story.Text = "You run to the phone and dial triple 000 for the firefighters. You hear a voice say 'Hello, Whats your emergency', then the phone cuts out. You feel your ear burning and realise that the phone is on fire. Your hair catches on fire and just as you run to the bathroom to the sink the house collapses on you." & Environment.NewLine & Environment.NewLine & "Game Over: Buried Alive"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:03 AM"
        ElseIf Status.Text = "Early Wake Up" Then
            Status.Text = "Beginning Of A Relaxing Day"
            story.Text = "Your alarm clock starts beeping and you slowly rise out of bed. You get out of bed sort of annoyed since you still feel like you want to sleep more but happy that it’s a Sunday. The first thing that comes to mind is breakfast. You go to the cupboard and see quite a few things available."
            Button1.Text = "Eat toast"
            Button2.Text = "Pour a bowl of cereal"
            Button3.Text = "Have last weeks sushi"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:00 AM"
        ElseIf Status.Text = "Beginning Of A Relaxing Day" Then
            Status.Text = "Sushi"
            story.Text = "You take out some sushi from the fridge and go to the table and start eating it. It tastes a bit weird but you’re too hungry to think about it. After you finish eating you feel slightly dizzy like you’re going to throw up."
            Button1.Text = "Go to bed"
            Button2.Text = "Drive to Doctor"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:06 AM"
        ElseIf Status.Text = "Extended walk" Then
            Status.Text = "Morning Weather Report"
            story.Text = "On tv a man on the morning weather report looks very confused. He looks like he is following instructions from somebody behind the camera quickly changing what he was going to say. He begins talking ‘Today started off mostly sunny but it looks like the weather is changing rapidly and some rain is to be expected by the end of the day.’ He then points to a weather chart shocked at the speedy changes. ‘Today marks the fasted change of weather ever recorded’. This is then followed by a few experts trying to examine the weather changes."
            Button1.Text = "Look Outside"
            Button2.Text = "Call a friend"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 8:45 AM"
        ElseIf Status.Text = "Telling Your Friend What You Saw" Then
            Status.Text = "Following Your Friend"
            story.Text = "You go outside to see where your friend went but their nowhere in site. Suddenly you look up and see the dark figure you had seen earlier in the clouds. It comes down slowly to you and you start run. It speeds like a rocket toward you and smashes you into the ground. You look up to it barely alive and notice it looks like a spaceship. The door opens and then you see your friend standing at it with red eyes staring at you with a menacing smile on his face. He then walks up to you and says ‘You should have left when you had the chance’ then he touches you burning you to death. " & Environment.NewLine & Environment.NewLine & "Game Over: Burnt To Death By Friend"
            Button1.Text = "Restart"
            Button2.Text = "Exit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 10:10 AM"

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Status.Text = "House On Fire" Then
            Status.Text = "The Bad Man Next Door"
            story.Text = "You Scream out for help only to remember that the man next door to you is a mean guy who has wanted you dead for the 12 years you have lived in your house. You look out your window and see him with a smile on his face, its the last thing you see before your house collapses onto you" & Environment.NewLine & Environment.NewLine & "Game Over: Buried Alive"
            Button1.Text = "Restart"
            Button2.Text = "Quit"
            Button3.Text = "-"
            Button4.Text = "-"
            Button5.Text = "-"
            Button6.Text = "-"
            Time.Text = "Time: 4:03 AM"
        End If
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.Image = My.Resources.survive_the_day_choice_mouseover
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources.survive_the_day_option
    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Image = My.Resources.survive_the_day_choice_mouseover
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources.survive_the_day_option
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.Image = My.Resources.survive_the_day_choice_mouseover
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Image = My.Resources.survive_the_day_option
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.Image = My.Resources.survive_the_day_choice_mouseover
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Image = My.Resources.survive_the_day_option
    End Sub
    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button5.Image = My.Resources.survive_the_day_choice_mouseover
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.Image = My.Resources.survive_the_day_option
    End Sub
    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.Image = My.Resources.survive_the_day_choice_mouseover
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.Image = My.Resources.survive_the_day_option
    End Sub
End Class