' Carson Kramer
' Period 9
' 5-24-19
' Uno

Public Class Form1
    Dim cardColor(3), playerDeckString, AIDeckString, AIcard As String
    Dim card As Integer
    Dim PlayerSlot(5), PlayerSlot_Selected(5) As Label
    Dim sameColor, sameNumber, bothP2, bothReverse, bothSkip, playerSaidUno As Boolean
    Dim AISlot(30) As PictureBox
    Public waitTime As Integer
    Public playerTurn As Boolean

    ' Clicking Uno Audio Button
    Private Sub UnoSound_Click(sender As Object, e As EventArgs) Handles UnoSound.Click
        If playerTurn = True Then
            My.Computer.Audio.Play(My.Resources.Uno, AudioPlayMode.WaitToComplete)
            If Not (PlayerDeck.Items.Count = 1) Then
                MsgBox("You didn't have two cards left! 2 Card Penalty")
                For a = 0 To 1
                    card = Int(Rnd() * deck.Items.Count)
                    PlayerDeck.Items.Add(deck.Items(card))
                    deck.Items.RemoveAt(card)
                Next
            End If
        End If
        playerSaidUno = True
    End Sub

    ' Bugs:
    ' 1. Not required for player to say Uno
    ' 2. Items previously selected dont visually unselect until re-enter and exit mouse over box
    ' 3. Rapidly goes through turn if placable cards, but doesn't draw

    ' Wait time during computer turn
    Private Sub Turn_Tick(sender As Object, e As EventArgs) Handles Turn.Tick
        If waitTime < 5 Then
            Thinking.Visible = True
            waitTime += 1
        Else
            Thinking.Visible = False
        End If

        If PlayerDeck.Items.Count = 1 And playerSaidUno = False And playerTurn = False And waitTime = 5 Then
            MsgBox("You didn't say Uno! 2 Card Penalty")
            For a = 0 To 1
                card = Int(Rnd() * deck.Items.Count)
                PlayerDeck.Items.Add(deck.Items(card))
                deck.Items.RemoveAt(card)
            Next
            playerSaidUno = True
        End If
    End Sub

    ' Sub to set labels to card color and text
    Private Sub cardVisual(card As String, visualCard As Label)

        visualCard.BackColor = Color.Black

        ' Checking card color
        If card.Contains("Y") Then
            visualCard.BackColor = Color.Yellow
            visualCard.ForeColor = Color.Black
        ElseIf card.Contains("B") Then
            visualCard.BackColor = Color.Blue
            visualCard.ForeColor = Color.White
        ElseIf card.Contains("R") Then
            visualCard.BackColor = Color.Red
            visualCard.ForeColor = Color.White
        ElseIf card.Contains("G") Then
            visualCard.BackColor = Color.Green
            visualCard.ForeColor = Color.White
        End If

        ' Checking is card is number
        For a = 0 To 9
            If card.Contains(a) Then
                visualCard.Text = a
                visualCard.Image = Nothing
            End If
        Next

        ' Checking if card is skip
        If card.Contains("skip") Then
            visualCard.Text = ""
            visualCard.Image = My.Resources.skip
        End If

        ' Checking if card is wild or plus four wild
        If card.Contains("wild") Then
            visualCard.Text = ""

            ' If it is a while card in your deck, make it black
            If Not (visualCard.Name = "topCard") Then
                visualCard.BackColor = Color.Black
            End If

            ' If it is a plus four wild card
            If card.Contains("four") Then
                visualCard.Image = My.Resources.p4wild
            Else
                visualCard.Image = My.Resources.wild
            End If
        End If

        ' Checking if card is a reverse
        If card.Contains("reverse") Then
            visualCard.Text = ""
            visualCard.Image = My.Resources.reverse
        End If

        ' Checking if card is a plus two
        If card.Contains("two") Then
            visualCard.Text = ""
            visualCard.Image = My.Resources.plus_2
        End If
    End Sub

    Private Sub tick_Tick(sender As Object, e As EventArgs) Handles tick.Tick

        AIcardNumber.Text = "The Computer Has" + Str(AIDeck.Items.Count) + " Cards Left"

        ' Changes Scoll Bar Length based on number of cards
        If PlayerDeck.Items.Count > 0 Then
            HScrollBar1.LargeChange = Int((6 / PlayerDeck.Items.Count) * 100) '
        End If

        ' Top Card Visual
        cardVisual(Pile.Items(Pile.Items.Count - 1).ToString, topCard)

        ' Player Deck & AI Deck Visual
        For n = 0 To 5
            If n < PlayerDeck.Items.Count Then
                cardVisual(PlayerDeck.Items(n + Int(HScrollBar1.Value * 0.1)), PlayerSlot(n))
                PlayerSlot(n).Visible = True
            Else
                PlayerSlot(n).Visible = False
                PlayerSlot_Selected(n).Visible = False
            End If
        Next

        ' Makes Scroll Bar visible if you need to use it for decks over 6 cards
        If PlayerDeck.Items.Count > 6 Then
            HScrollBar1.Visible = True
        Else
            HScrollBar1.Visible = False
        End If

        ' When pull pile is out of cards, take cards from placed pile
        If deck.Items.Count < 5 And Pile.Items.Count > deck.Items.Count Then
            For n = 0 To (Pile.Items.Count - 2)
                deck.Items.Add(Pile.Items(n))
                Pile.Items.RemoveAt(n)
            Next
        End If

        If playerTurn = False And waitTime = 5 Then

            For a = 0 To (AIDeck.Items.Count - 1)
                ' Checking if selected card color = pile card color
                For n = 0 To 3
                    If AIDeck.Items(a).ToString.Contains(cardColor(n)) And Pile.Items(Pile.Items.Count - 1).ToString.Contains(cardColor(n)) Then
                        AIcard = AIDeck.Items(a)
                    End If
                Next

                ' Checking if selected card # = pile card #
                For n = 0 To 9
                    If AIDeck.Items(a).ToString.Contains(n) And Pile.Items(Pile.Items.Count - 1).ToString.Contains(n) Then
                        AIcard = AIDeck.Items(a)
                    End If
                Next
                ' Checking if selected card & pile card are skip card
                If AIDeck.Items(a).ToString.Contains("skip") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("skip") Then
                    AIcard = AIDeck.Items(a)
                End If

                ' Checking if selected card = wild or plus 4 wild
                If AIDeck.Items(a).ToString.Contains("wild") Then
                    AIcard = AIDeck.Items(a)
                End If

                ' Checking if selected card & pile card are reverse card
                If AIDeck.Items(a).ToString.Contains("reverse") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("reverse") Then
                    AIcard = AIDeck.Items(a)
                End If

                ' Checking if selected card & pile card are plus 2 card
                If AIDeck.Items(a).ToString.Contains("two") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("two") Then
                    AIcard = AIDeck.Items(a)
                End If
            Next

            ' If the checks above found a compatible card in AI deck, AIcard string is set to compatible card
            If Not (AIcard = Nothing) Then
                ' If its a wild, randomly selects color for wild card
                If AIcard.Contains("wild") Then
                    Pile.Items.Add(cardColor(Int(Rnd() * 3)) + AIcard)

                    ' If wild is plus four card, add four to player
                    If AIcard.Contains("four") Then
                        For a = 0 To 3
                            card = Int(Rnd() * deck.Items.Count)
                            PlayerDeck.Items.Add(deck.Items(card))
                            deck.Items.RemoveAt(card)
                        Next
                    End If

                    ' If its a plus two, add two cards to deck
                ElseIf AIcard.Contains("two") Then
                    Pile.Items.Add(AIcard)
                    For a = 0 To 1
                        card = Int(Rnd() * deck.Items.Count)
                        PlayerDeck.Items.Add(deck.Items(card))
                        deck.Items.RemoveAt(card)
                    Next
                Else
                    Pile.Items.Add(AIcard)
                End If
                AIDeck.Items.Remove(AIcard)

                If Not (AIcard.Contains("skip") Or AIcard.Contains("reverse")) Then
                    playerTurn = True
                End If

                AIcard = Nothing
            Else
                ' Draws a card
                card = Int(Rnd() * deck.Items.Count)
                AIDeck.Items.Add(deck.Items(card))
                deck.Items.RemoveAt(card)
                playerTurn = True
            End If

            If AIDeck.Items.Count = 1 Then
                My.Computer.Audio.Play(My.Resources.Uno, AudioPlayMode.WaitToComplete)
            End If

            If AIDeck.Items.Count = 0 Then
                MsgBox("You Lost :(")
                End
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        playerTurn = True
        sameColor = False
        sameNumber = False
        bothP2 = False
        bothReverse = False
        bothSkip = False
        playerSaidUno = False
        waitTime = 5

        ' Set colors in list of colors to asign to cards
        cardColor(0) = "R"
        cardColor(1) = "Y"
        cardColor(2) = "G"
        cardColor(3) = "B"

        ' Makes list of all player deck labels
        PlayerSlot(0) = PlayerSlot1
        PlayerSlot(1) = PlayerSlot2
        PlayerSlot(2) = PlayerSlot3
        PlayerSlot(3) = PlayerSlot4
        PlayerSlot(4) = PlayerSlot5
        PlayerSlot(5) = PlayerSlot6

        ' Makes list of all player deck selections labels
        PlayerSlot_Selected(0) = PlayerSlot1_Selected
        PlayerSlot_Selected(1) = PlayerSlot2_Selected
        PlayerSlot_Selected(2) = PlayerSlot3_Selected
        PlayerSlot_Selected(3) = PlayerSlot4_Selected
        PlayerSlot_Selected(4) = PlayerSlot5_Selected
        PlayerSlot_Selected(5) = PlayerSlot6_Selected

        ' Create deck of cards; Repeated 4 time for 4 colors
        For c = 0 To 3
            ' Create cards 0 to 9, skip, +2, and reverse once (10 = Skip, 11 = Reverse, 12 = +2)
            ' Creates seconds set of same color cards, 1 to 9, skip, +2, and reverse once (23 = Skip, 24 = Reverse, 25 = +2)
            For a = 0 To 26
                If a <= 9 Then
                    deck.Items.Add(cardColor(c) + Str(a))
                ElseIf a = 10 Then
                    deck.Items.Add(cardColor(c) + "skip")
                ElseIf a = 11 Then
                    deck.Items.Add(cardColor(c) + "reverse")
                ElseIf a = 12 Then
                    deck.Items.Add(cardColor(c) + "Ptwo")
                ElseIf a = 13 Then
                    deck.Items.Add("wild")
                ElseIf a >= 14 And a <= 22 Then
                    deck.Items.Add(cardColor(c) + Str(a - 13))
                ElseIf a = 23 Then
                    deck.Items.Add(cardColor(c) + "skip")
                ElseIf a = 24 Then
                    deck.Items.Add(cardColor(c) + "reverse")
                ElseIf a = 25 Then
                    deck.Items.Add(cardColor(c) + "Ptwo")
                ElseIf a = 26 Then
                    deck.Items.Add("Pfourwild")
                End If
                'PlayerDeck.Items.Add(deck(a + (c * 26)))
            Next
        Next

        ' Add 7 cards to player's deck
        For n = 0 To 6
            ' Choose random card slot
            card = Int(Rnd() * deck.Items.Count)

            PlayerDeck.Items.Add(deck.Items(card))
            deck.Items.RemoveAt(card)
        Next

        ' Add 7 cards to computer's deck & start card to pile
        For n = 0 To 7
            card = Int(Rnd() * deck.Items.Count)
            If n < 7 Then
                AIDeck.Items.Add(deck.Items(card))
            ElseIf n = 7 Then
                Pile.Items.Add(deck.Items(card))
            End If
            deck.Items.RemoveAt(card)
        Next



    End Sub

    ' Place a card on the pile
    Private Sub topCard_Click(sender As Object, e As EventArgs) Handles topCard.Click

        If playerTurn = True Then ' Player Turn
            If Not (PlayerDeck.SelectedItem = Nothing) Then

                ' Checking if selected card color = pile card color
                For n = 0 To 3
                    If Not (PlayerDeck.SelectedItem = Nothing) Then
                        If PlayerDeck.SelectedItem.ToString.Contains(cardColor(n)) And Pile.Items(Pile.Items.Count - 1).ToString.Contains(cardColor(n)) Then

                            ' Changes turn to computer if the player did not lay down a skip
                            If PlayerDeck.SelectedItem.ToString.Contains("two") Then
                                For a = 0 To 1
                                    card = Int(Rnd() * deck.Items.Count)
                                    AIDeck.Items.Add(deck.Items(card))
                                    deck.Items.RemoveAt(card)
                                Next
                            End If

                            If Not (PlayerDeck.SelectedItem.ToString.Contains("skip") Or PlayerDeck.SelectedItem.ToString.Contains("reverse")) And Not (PlayerDeck.Items.Count = 0) Then
                                playerTurn = False
                                waitTime = 0
                                Thinking.Visible = False
                            End If

                            Pile.Items.Add(PlayerDeck.SelectedItem)
                            PlayerDeck.Items.Remove(PlayerDeck.SelectedItem)
                            If HScrollBar1.Visible = True And HScrollBar1.Value >= 10 Then
                                HScrollBar1.Value -= 10
                            End If
                        End If
                    End If
                Next

                ' Checking if selected card # = pile card #
                For n = 0 To 9
                    If Not (PlayerDeck.SelectedItem = Nothing) Then
                        If PlayerDeck.SelectedItem.ToString.Contains(n) And Pile.Items(Pile.Items.Count - 1).ToString.Contains(n) Then
                            Pile.Items.Add(PlayerDeck.SelectedItem)
                            PlayerDeck.Items.Remove(PlayerDeck.SelectedItem)
                            If HScrollBar1.Visible = True And HScrollBar1.Value >= 10 Then
                                HScrollBar1.Value -= 10
                            End If
                            If Not (PlayerDeck.Items.Count = 0) Then
                                playerTurn = False
                                waitTime = 0
                                Thinking.Visible = False
                            End If
                        End If
                    End If
                Next

                ' Checking if selected card & pile card are Plus 2 card
                If Not (PlayerDeck.SelectedItem = Nothing) Then
                    If PlayerDeck.SelectedItem.ToString.Contains("two") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("two") Then
                        Pile.Items.Add(PlayerDeck.SelectedItem)
                        PlayerDeck.Items.Remove(PlayerDeck.SelectedItem)
                        If HScrollBar1.Visible = True And HScrollBar1.Value >= 10 Then
                            HScrollBar1.Value -= 10
                        End If

                        ' Add two cards to computer deck
                        card = Int(Rnd() * deck.Items.Count)
                        AIDeck.Items.Add(deck.Items(card))
                        deck.Items.RemoveAt(card)

                        If Not (PlayerDeck.Items.Count = 0) Then
                            playerTurn = False
                            waitTime = 0
                            Thinking.Visible = False
                        End If
                    End If
                End If
                If Not (PlayerDeck.SelectedItem = Nothing) Then
                    ' Checking if selected card & pile card are skip card
                    If PlayerDeck.SelectedItem.ToString.Contains("skip") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("skip") Then
                        Pile.Items.Add(PlayerDeck.SelectedItem)
                        PlayerDeck.Items.Remove(PlayerDeck.SelectedItem)
                        If HScrollBar1.Visible = True And HScrollBar1.Value >= 10 Then
                            HScrollBar1.Value -= 10
                        End If
                    End If
                End If

                If Not (PlayerDeck.SelectedItem = Nothing) Then
                    ' Checking if selected card = wild or plus 4 wild
                    If PlayerDeck.SelectedItem.ToString.Contains("wild") Then

                        ' If it is plus four wild, add four to computer deck
                        If PlayerDeck.SelectedItem.ToString.Contains("four") Then
                            For a = 0 To 3
                                card = Int(Rnd() * deck.Items.Count)
                                AIDeck.Items.Add(deck.Items(card))
                                deck.Items.RemoveAt(card)
                            Next
                        End If

                        Form2.Show()
                        Me.Hide()
                    End If
                End If

                If Not (PlayerDeck.SelectedItem = Nothing) Then
                    ' Checking if selected card & pile card are reverse card
                    If PlayerDeck.SelectedItem.ToString.Contains("reverse") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("reverse") Then
                        Pile.Items.Add(PlayerDeck.SelectedItem)
                        PlayerDeck.Items.Remove(PlayerDeck.SelectedItem)
                        If HScrollBar1.Visible = True And HScrollBar1.Value >= 10 Then
                            HScrollBar1.Value -= 10
                        End If
                    End If
                End If
            End If

            If Not (PlayerDeck.SelectedItem = Nothing) Then
                ' If wild card is start card (allows any card to be placed because of no specific color)
                If Pile.Items(Pile.Items.Count - 1).ToString.Contains("wild") And Not (Pile.Items(Pile.Items.Count - 1).ToString.Contains("R") Or Pile.Items(Pile.Items.Count - 1).ToString.Contains("Y") Or Pile.Items(Pile.Items.Count - 1).ToString.Contains("G") Or Pile.Items(Pile.Items.Count - 1).ToString.Contains("B")) Then
                    Pile.Items.Add(PlayerDeck.SelectedItem)
                    PlayerDeck.Items.Remove(PlayerDeck.SelectedItem)
                    If HScrollBar1.Visible = True And HScrollBar1.Value >= 10 Then
                        HScrollBar1.Value -= 10
                    End If
                    If Not (PlayerDeck.Items.Count = 0) Then
                        playerTurn = False
                        waitTime = 0
                        Thinking.Visible = False
                    End If
                End If
            End If

            If PlayerDeck.Items.Count = 0 Then
                MsgBox("You Won! :D")
                End
            End If

            ' Unselects Previous Card
            PlayerDeck.SelectedItem = -1
        End If
    End Sub


    Private Sub Draw_Click(sender As Object, e As EventArgs) Handles Draw.Click

        ' Prints Player Deck into string
        playerDeckString = ""
        For n = 0 To (PlayerDeck.Items.Count - 1)
            If n < (PlayerDeck.Items.Count - 1) Then
                playerDeckString = playerDeckString + "( " + PlayerDeck.Items(n) + " )" + ", "
            ElseIf n = (PlayerDeck.Items.Count - 1) Then
                playerDeckString = playerDeckString + "( " + PlayerDeck.Items(n) + " )"
            End If
        Next

        ' Checks if all cards in deck are unplayable
        For n = 0 To 3
            If playerDeckString.Contains(cardColor(n)) And Pile.Items(Pile.Items.Count - 1).ToString.Contains(cardColor(n)) Then
                sameColor = True
            End If
        Next
        For n = 0 To 9
            If playerDeckString.Contains(n) And Pile.Items(Pile.Items.Count - 1).ToString.Contains(n) Then
                sameNumber = True
            End If
        Next
        If playerDeckString.Contains("two") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("two") Then
            bothP2 = True
        End If
        If playerDeckString.Contains("reverse") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("reverse") Then
            bothReverse = True
        End If
        If playerDeckString.Contains("skip") And Pile.Items(Pile.Items.Count - 1).ToString.Contains("skip") Then
            bothSkip = True
        End If

        ' Check booleans for is no more cards availible then draw card
        If Not (sameColor = True Or sameNumber = True Or bothP2 = True Or bothReverse = True Or bothSkip = True Or playerDeckString.Contains("wild")) Then
            card = Int(Rnd() * deck.Items.Count)
            PlayerDeck.Items.Add(deck.Items(card))
            deck.Items.RemoveAt(card)
            playerTurn = False
            waitTime = 0
            Thinking.Visible = False
        Else
            MsgBox("You already have a card you can play")
        End If

        ' Resets card availibility check
        sameColor = False
        sameNumber = False
        bothP2 = False
        bothReverse = False
        bothSkip = False
    End Sub

    ' Selection enabled on mouse over
    Private Sub PlayerSlot_Enter(sender As Object, e As EventArgs) Handles PlayerSlot1.MouseEnter, PlayerSlot2.MouseEnter, PlayerSlot3.MouseEnter,
            PlayerSlot4.MouseEnter, PlayerSlot5.MouseEnter, PlayerSlot6.MouseEnter, topCard.MouseEnter, Draw.MouseEnter, UnoSound.MouseEnter

        For n = 0 To 5
            If sender.name = PlayerSlot(n).Name Then
                PlayerSlot_Selected(n).Visible = True
                If Not (PlayerDeck.SelectedIndex = (n + Int(HScrollBar1.Value * 0.1))) Then
                    PlayerSlot_Selected(n).BackColor = SystemColors.Highlight
                End If
            End If
        Next

        If sender.Name = "topCard" Then
            topCard_Selected.Visible = True
        ElseIf sender.Name = "Draw" Then
            Draw_Selected.Visible = True
        ElseIf sender.Name = "UnoSound" Then
            UnoSound_Selected.Visible = True
        End If
    End Sub

    ' Selection removed on exit
    Private Sub PlayerSlot_Leave(sender As Object, e As EventArgs) Handles PlayerSlot1.MouseLeave, PlayerSlot2.MouseLeave, PlayerSlot3.MouseLeave,
            PlayerSlot4.MouseLeave, PlayerSlot5.MouseLeave, PlayerSlot6.MouseLeave, topCard.MouseLeave, Draw.MouseLeave, UnoSound.MouseLeave

        For n = 0 To 5
            If sender.name = PlayerSlot(n).Name And Not (PlayerDeck.SelectedIndex = (n + Int(HScrollBar1.Value * 0.1))) Then
                PlayerSlot_Selected(n).Visible = False
            End If
        Next

        If sender.Name = "topCard" Then
            topCard_Selected.Visible = False
        ElseIf sender.Name = "Draw" Then
            Draw_Selected.Visible = False
        ElseIf sender.Name = "UnoSound" Then
            UnoSound_Selected.Visible = False
        End If
    End Sub

    ' When you click a slot in the deck
    Private Sub PlayerSlot_Click(sender As Object, e As EventArgs) Handles PlayerSlot1.Click, PlayerSlot2.Click, PlayerSlot3.Click,
            PlayerSlot4.Click, PlayerSlot5.Click, PlayerSlot6.Click

        For n = 0 To 5
            If sender.Name = PlayerSlot(n).Name Then
                PlayerDeck.SelectedIndex = n + Int(HScrollBar1.Value * 0.1)
                PlayerSlot_Selected(n).BackColor = Color.Lime
            End If
        Next
    End Sub
End Class
