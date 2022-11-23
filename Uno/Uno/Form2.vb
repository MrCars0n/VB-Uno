Public Class Form2

    ' Select Red
    Private Sub labelRed_Click(sender As Object, e As EventArgs) Handles labelRed.Click
        ' Adds selected wild card to deck plus selected color
        Form1.Pile.Items.Add("R" + Form1.PlayerDeck.SelectedItem)
        Form1.PlayerDeck.Items.Remove(Form1.PlayerDeck.SelectedItem)
        Form1.playerTurn = False
        Form1.waitTime = 0
        Form1.Show()
        Me.Close()
    End Sub

    ' Select Blue
    Private Sub labelBlue_Click(sender As Object, e As EventArgs) Handles labelBlue.Click
        ' Adds selected wild card to deck plus selected color
        Form1.Pile.Items.Add("B" + Form1.PlayerDeck.SelectedItem)
        Form1.PlayerDeck.Items.Remove(Form1.PlayerDeck.SelectedItem)
        Form1.playerTurn = False
        Form1.waitTime = 0
        Form1.Show()
        Me.Close()
    End Sub

    ' Select Yellow
    Private Sub labelYellow_Click(sender As Object, e As EventArgs) Handles labelYellow.Click
        ' Adds selected wild card to deck plus selected color
        Form1.Pile.Items.Add("Y" + Form1.PlayerDeck.SelectedItem)
        Form1.PlayerDeck.Items.Remove(Form1.PlayerDeck.SelectedItem)
        Form1.playerTurn = False
        Form1.waitTime = 0
        Form1.Show()
        Me.Close()
    End Sub

    ' Select Green
    Private Sub labelGreen_Click(sender As Object, e As EventArgs) Handles labelGreen.Click
        ' Adds selected wild card to deck plus selected color
        Form1.Pile.Items.Add("G" + Form1.PlayerDeck.SelectedItem)
        Form1.PlayerDeck.Items.Remove(Form1.PlayerDeck.SelectedItem)
        Form1.playerTurn = False
        Form1.waitTime = 0
        Form1.Show()
        Me.Close()
    End Sub
End Class