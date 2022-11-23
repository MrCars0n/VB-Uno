<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PlayerDeck = New System.Windows.Forms.ListBox()
        Me.AIDeck = New System.Windows.Forms.ListBox()
        Me.Pile = New System.Windows.Forms.ListBox()
        Me.deck = New System.Windows.Forms.ListBox()
        Me.tick = New System.Windows.Forms.Timer(Me.components)
        Me.topCard = New System.Windows.Forms.Label()
        Me.PlayerSlot1 = New System.Windows.Forms.Label()
        Me.Draw = New System.Windows.Forms.PictureBox()
        Me.PlayerSlot2 = New System.Windows.Forms.Label()
        Me.PlayerSlot3 = New System.Windows.Forms.Label()
        Me.PlayerSlot6 = New System.Windows.Forms.Label()
        Me.PlayerSlot5 = New System.Windows.Forms.Label()
        Me.PlayerSlot4 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.AISlot1 = New System.Windows.Forms.PictureBox()
        Me.AISlot2 = New System.Windows.Forms.PictureBox()
        Me.AISlot3 = New System.Windows.Forms.PictureBox()
        Me.AISlot4 = New System.Windows.Forms.PictureBox()
        Me.AISlot5 = New System.Windows.Forms.PictureBox()
        Me.AISlot6 = New System.Windows.Forms.PictureBox()
        Me.Turn = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerSlot1_Selected = New System.Windows.Forms.Label()
        Me.PlayerSlot2_Selected = New System.Windows.Forms.Label()
        Me.PlayerSlot3_Selected = New System.Windows.Forms.Label()
        Me.PlayerSlot4_Selected = New System.Windows.Forms.Label()
        Me.PlayerSlot5_Selected = New System.Windows.Forms.Label()
        Me.PlayerSlot6_Selected = New System.Windows.Forms.Label()
        Me.topCard_Selected = New System.Windows.Forms.Label()
        Me.Draw_Selected = New System.Windows.Forms.Label()
        Me.Thinking = New System.Windows.Forms.PictureBox()
        Me.AIcardNumber = New System.Windows.Forms.Label()
        Me.UnoSound = New System.Windows.Forms.PictureBox()
        Me.UnoSound_Selected = New System.Windows.Forms.Label()
        CType(Me.Draw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISlot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISlot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISlot5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISlot6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thinking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnoSound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerDeck
        '
        Me.PlayerDeck.FormattingEnabled = True
        Me.PlayerDeck.Location = New System.Drawing.Point(726, 405)
        Me.PlayerDeck.Name = "PlayerDeck"
        Me.PlayerDeck.Size = New System.Drawing.Size(120, 95)
        Me.PlayerDeck.TabIndex = 0
        Me.PlayerDeck.Visible = False
        '
        'AIDeck
        '
        Me.AIDeck.FormattingEnabled = True
        Me.AIDeck.Location = New System.Drawing.Point(852, 458)
        Me.AIDeck.Name = "AIDeck"
        Me.AIDeck.Size = New System.Drawing.Size(120, 95)
        Me.AIDeck.TabIndex = 1
        Me.AIDeck.Visible = False
        '
        'Pile
        '
        Me.Pile.FormattingEnabled = True
        Me.Pile.Location = New System.Drawing.Point(852, 357)
        Me.Pile.Name = "Pile"
        Me.Pile.Size = New System.Drawing.Size(120, 95)
        Me.Pile.TabIndex = 2
        Me.Pile.Visible = False
        '
        'deck
        '
        Me.deck.FormattingEnabled = True
        Me.deck.Location = New System.Drawing.Point(852, 256)
        Me.deck.Name = "deck"
        Me.deck.Size = New System.Drawing.Size(120, 95)
        Me.deck.TabIndex = 8
        Me.deck.Visible = False
        '
        'tick
        '
        Me.tick.Enabled = True
        Me.tick.Interval = 1
        '
        'topCard
        '
        Me.topCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topCard.Location = New System.Drawing.Point(500, 300)
        Me.topCard.Name = "topCard"
        Me.topCard.Size = New System.Drawing.Size(150, 200)
        Me.topCard.TabIndex = 12
        Me.topCard.Text = "#"
        Me.topCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerSlot1
        '
        Me.PlayerSlot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot1.Location = New System.Drawing.Point(32, 591)
        Me.PlayerSlot1.Name = "PlayerSlot1"
        Me.PlayerSlot1.Size = New System.Drawing.Size(150, 200)
        Me.PlayerSlot1.TabIndex = 14
        Me.PlayerSlot1.Text = "#"
        Me.PlayerSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Draw
        '
        Me.Draw.BackColor = System.Drawing.Color.Transparent
        Me.Draw.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.Draw.Location = New System.Drawing.Point(344, 300)
        Me.Draw.Name = "Draw"
        Me.Draw.Size = New System.Drawing.Size(150, 200)
        Me.Draw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Draw.TabIndex = 16
        Me.Draw.TabStop = False
        '
        'PlayerSlot2
        '
        Me.PlayerSlot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot2.Location = New System.Drawing.Point(188, 591)
        Me.PlayerSlot2.Name = "PlayerSlot2"
        Me.PlayerSlot2.Size = New System.Drawing.Size(150, 200)
        Me.PlayerSlot2.TabIndex = 17
        Me.PlayerSlot2.Text = "#"
        Me.PlayerSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerSlot3
        '
        Me.PlayerSlot3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot3.Location = New System.Drawing.Point(344, 591)
        Me.PlayerSlot3.Name = "PlayerSlot3"
        Me.PlayerSlot3.Size = New System.Drawing.Size(150, 200)
        Me.PlayerSlot3.TabIndex = 18
        Me.PlayerSlot3.Text = "#"
        Me.PlayerSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerSlot6
        '
        Me.PlayerSlot6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot6.Location = New System.Drawing.Point(812, 591)
        Me.PlayerSlot6.Name = "PlayerSlot6"
        Me.PlayerSlot6.Size = New System.Drawing.Size(150, 200)
        Me.PlayerSlot6.TabIndex = 21
        Me.PlayerSlot6.Text = "#"
        Me.PlayerSlot6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerSlot5
        '
        Me.PlayerSlot5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot5.Location = New System.Drawing.Point(656, 591)
        Me.PlayerSlot5.Name = "PlayerSlot5"
        Me.PlayerSlot5.Size = New System.Drawing.Size(150, 200)
        Me.PlayerSlot5.TabIndex = 20
        Me.PlayerSlot5.Text = "#"
        Me.PlayerSlot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerSlot4
        '
        Me.PlayerSlot4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot4.Location = New System.Drawing.Point(500, 591)
        Me.PlayerSlot4.Name = "PlayerSlot4"
        Me.PlayerSlot4.Size = New System.Drawing.Size(150, 200)
        Me.PlayerSlot4.TabIndex = 19
        Me.PlayerSlot4.Text = "#"
        Me.PlayerSlot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 100
        Me.HScrollBar1.Location = New System.Drawing.Point(32, 564)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(930, 20)
        Me.HScrollBar1.TabIndex = 29
        '
        'AISlot1
        '
        Me.AISlot1.BackColor = System.Drawing.Color.Transparent
        Me.AISlot1.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.AISlot1.Location = New System.Drawing.Point(32, 8)
        Me.AISlot1.Name = "AISlot1"
        Me.AISlot1.Size = New System.Drawing.Size(150, 200)
        Me.AISlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AISlot1.TabIndex = 31
        Me.AISlot1.TabStop = False
        '
        'AISlot2
        '
        Me.AISlot2.BackColor = System.Drawing.Color.Transparent
        Me.AISlot2.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.AISlot2.Location = New System.Drawing.Point(188, 8)
        Me.AISlot2.Name = "AISlot2"
        Me.AISlot2.Size = New System.Drawing.Size(150, 200)
        Me.AISlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AISlot2.TabIndex = 32
        Me.AISlot2.TabStop = False
        '
        'AISlot3
        '
        Me.AISlot3.BackColor = System.Drawing.Color.Transparent
        Me.AISlot3.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.AISlot3.Location = New System.Drawing.Point(344, 8)
        Me.AISlot3.Name = "AISlot3"
        Me.AISlot3.Size = New System.Drawing.Size(150, 200)
        Me.AISlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AISlot3.TabIndex = 33
        Me.AISlot3.TabStop = False
        '
        'AISlot4
        '
        Me.AISlot4.BackColor = System.Drawing.Color.Transparent
        Me.AISlot4.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.AISlot4.Location = New System.Drawing.Point(500, 8)
        Me.AISlot4.Name = "AISlot4"
        Me.AISlot4.Size = New System.Drawing.Size(150, 200)
        Me.AISlot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AISlot4.TabIndex = 34
        Me.AISlot4.TabStop = False
        '
        'AISlot5
        '
        Me.AISlot5.BackColor = System.Drawing.Color.Transparent
        Me.AISlot5.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.AISlot5.Location = New System.Drawing.Point(656, 8)
        Me.AISlot5.Name = "AISlot5"
        Me.AISlot5.Size = New System.Drawing.Size(150, 200)
        Me.AISlot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AISlot5.TabIndex = 35
        Me.AISlot5.TabStop = False
        '
        'AISlot6
        '
        Me.AISlot6.BackColor = System.Drawing.Color.Transparent
        Me.AISlot6.Image = Global.Uno.My.Resources.Resources.uno_card_back
        Me.AISlot6.Location = New System.Drawing.Point(812, 8)
        Me.AISlot6.Name = "AISlot6"
        Me.AISlot6.Size = New System.Drawing.Size(150, 200)
        Me.AISlot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AISlot6.TabIndex = 36
        Me.AISlot6.TabStop = False
        '
        'Turn
        '
        Me.Turn.Enabled = True
        Me.Turn.Interval = 1000
        '
        'PlayerSlot1_Selected
        '
        Me.PlayerSlot1_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.PlayerSlot1_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot1_Selected.Location = New System.Drawing.Point(28, 587)
        Me.PlayerSlot1_Selected.Name = "PlayerSlot1_Selected"
        Me.PlayerSlot1_Selected.Size = New System.Drawing.Size(158, 209)
        Me.PlayerSlot1_Selected.TabIndex = 41
        Me.PlayerSlot1_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlayerSlot1_Selected.Visible = False
        '
        'PlayerSlot2_Selected
        '
        Me.PlayerSlot2_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.PlayerSlot2_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot2_Selected.Location = New System.Drawing.Point(184, 587)
        Me.PlayerSlot2_Selected.Name = "PlayerSlot2_Selected"
        Me.PlayerSlot2_Selected.Size = New System.Drawing.Size(158, 209)
        Me.PlayerSlot2_Selected.TabIndex = 42
        Me.PlayerSlot2_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlayerSlot2_Selected.Visible = False
        '
        'PlayerSlot3_Selected
        '
        Me.PlayerSlot3_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.PlayerSlot3_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot3_Selected.Location = New System.Drawing.Point(340, 587)
        Me.PlayerSlot3_Selected.Name = "PlayerSlot3_Selected"
        Me.PlayerSlot3_Selected.Size = New System.Drawing.Size(158, 209)
        Me.PlayerSlot3_Selected.TabIndex = 43
        Me.PlayerSlot3_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlayerSlot3_Selected.Visible = False
        '
        'PlayerSlot4_Selected
        '
        Me.PlayerSlot4_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.PlayerSlot4_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot4_Selected.Location = New System.Drawing.Point(496, 587)
        Me.PlayerSlot4_Selected.Name = "PlayerSlot4_Selected"
        Me.PlayerSlot4_Selected.Size = New System.Drawing.Size(158, 209)
        Me.PlayerSlot4_Selected.TabIndex = 44
        Me.PlayerSlot4_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlayerSlot4_Selected.Visible = False
        '
        'PlayerSlot5_Selected
        '
        Me.PlayerSlot5_Selected.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PlayerSlot5_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot5_Selected.Location = New System.Drawing.Point(652, 587)
        Me.PlayerSlot5_Selected.Name = "PlayerSlot5_Selected"
        Me.PlayerSlot5_Selected.Size = New System.Drawing.Size(158, 209)
        Me.PlayerSlot5_Selected.TabIndex = 45
        Me.PlayerSlot5_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlayerSlot5_Selected.Visible = False
        '
        'PlayerSlot6_Selected
        '
        Me.PlayerSlot6_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.PlayerSlot6_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSlot6_Selected.Location = New System.Drawing.Point(808, 587)
        Me.PlayerSlot6_Selected.Name = "PlayerSlot6_Selected"
        Me.PlayerSlot6_Selected.Size = New System.Drawing.Size(158, 209)
        Me.PlayerSlot6_Selected.TabIndex = 46
        Me.PlayerSlot6_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlayerSlot6_Selected.Visible = False
        '
        'topCard_Selected
        '
        Me.topCard_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.topCard_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topCard_Selected.Location = New System.Drawing.Point(496, 296)
        Me.topCard_Selected.Name = "topCard_Selected"
        Me.topCard_Selected.Size = New System.Drawing.Size(158, 209)
        Me.topCard_Selected.TabIndex = 47
        Me.topCard_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.topCard_Selected.Visible = False
        '
        'Draw_Selected
        '
        Me.Draw_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.Draw_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Draw_Selected.Location = New System.Drawing.Point(340, 296)
        Me.Draw_Selected.Name = "Draw_Selected"
        Me.Draw_Selected.Size = New System.Drawing.Size(158, 209)
        Me.Draw_Selected.TabIndex = 48
        Me.Draw_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Draw_Selected.Visible = False
        '
        'Thinking
        '
        Me.Thinking.BackColor = System.Drawing.Color.Transparent
        Me.Thinking.Image = Global.Uno.My.Resources.Resources.thinking
        Me.Thinking.Location = New System.Drawing.Point(31, 213)
        Me.Thinking.Margin = New System.Windows.Forms.Padding(2)
        Me.Thinking.Name = "Thinking"
        Me.Thinking.Size = New System.Drawing.Size(155, 105)
        Me.Thinking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Thinking.TabIndex = 49
        Me.Thinking.TabStop = False
        Me.Thinking.Visible = False
        '
        'AIcardNumber
        '
        Me.AIcardNumber.BackColor = System.Drawing.Color.Transparent
        Me.AIcardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIcardNumber.ForeColor = System.Drawing.Color.White
        Me.AIcardNumber.Location = New System.Drawing.Point(267, 213)
        Me.AIcardNumber.Name = "AIcardNumber"
        Me.AIcardNumber.Size = New System.Drawing.Size(467, 44)
        Me.AIcardNumber.TabIndex = 50
        Me.AIcardNumber.Text = "The Computer Has # Cards Left"
        Me.AIcardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnoSound
        '
        Me.UnoSound.BackColor = System.Drawing.Color.Transparent
        Me.UnoSound.Image = Global.Uno.My.Resources.Resources.Uno_Sound
        Me.UnoSound.Location = New System.Drawing.Point(30, 401)
        Me.UnoSound.Name = "UnoSound"
        Me.UnoSound.Size = New System.Drawing.Size(150, 150)
        Me.UnoSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UnoSound.TabIndex = 51
        Me.UnoSound.TabStop = False
        '
        'UnoSound_Selected
        '
        Me.UnoSound_Selected.BackColor = System.Drawing.SystemColors.Highlight
        Me.UnoSound_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnoSound_Selected.Location = New System.Drawing.Point(27, 398)
        Me.UnoSound_Selected.Name = "UnoSound_Selected"
        Me.UnoSound_Selected.Size = New System.Drawing.Size(156, 156)
        Me.UnoSound_Selected.TabIndex = 52
        Me.UnoSound_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UnoSound_Selected.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Uno.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 805)
        Me.Controls.Add(Me.UnoSound)
        Me.Controls.Add(Me.AIcardNumber)
        Me.Controls.Add(Me.Thinking)
        Me.Controls.Add(Me.AISlot6)
        Me.Controls.Add(Me.AISlot5)
        Me.Controls.Add(Me.AISlot4)
        Me.Controls.Add(Me.AISlot3)
        Me.Controls.Add(Me.AISlot2)
        Me.Controls.Add(Me.AISlot1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.PlayerSlot6)
        Me.Controls.Add(Me.PlayerSlot5)
        Me.Controls.Add(Me.PlayerSlot4)
        Me.Controls.Add(Me.PlayerSlot3)
        Me.Controls.Add(Me.PlayerSlot2)
        Me.Controls.Add(Me.Draw)
        Me.Controls.Add(Me.PlayerSlot1)
        Me.Controls.Add(Me.topCard)
        Me.Controls.Add(Me.deck)
        Me.Controls.Add(Me.Pile)
        Me.Controls.Add(Me.AIDeck)
        Me.Controls.Add(Me.PlayerDeck)
        Me.Controls.Add(Me.PlayerSlot1_Selected)
        Me.Controls.Add(Me.PlayerSlot2_Selected)
        Me.Controls.Add(Me.PlayerSlot3_Selected)
        Me.Controls.Add(Me.PlayerSlot4_Selected)
        Me.Controls.Add(Me.PlayerSlot5_Selected)
        Me.Controls.Add(Me.PlayerSlot6_Selected)
        Me.Controls.Add(Me.topCard_Selected)
        Me.Controls.Add(Me.Draw_Selected)
        Me.Controls.Add(Me.UnoSound_Selected)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uno"
        CType(Me.Draw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISlot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISlot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISlot5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISlot6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thinking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnoSound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayerDeck As ListBox
    Friend WithEvents AIDeck As ListBox
    Friend WithEvents Pile As ListBox
    Friend WithEvents deck As ListBox
    Friend WithEvents tick As Timer
    Friend WithEvents topCard As Label
    Friend WithEvents PlayerSlot1 As Label
    Friend WithEvents Draw As PictureBox
    Friend WithEvents PlayerSlot2 As Label
    Friend WithEvents PlayerSlot3 As Label
    Friend WithEvents PlayerSlot6 As Label
    Friend WithEvents PlayerSlot5 As Label
    Friend WithEvents PlayerSlot4 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents AISlot1 As PictureBox
    Friend WithEvents AISlot2 As PictureBox
    Friend WithEvents AISlot3 As PictureBox
    Friend WithEvents AISlot4 As PictureBox
    Friend WithEvents AISlot5 As PictureBox
    Friend WithEvents AISlot6 As PictureBox
    Friend WithEvents Turn As Timer
    Friend WithEvents PlayerSlot1_Selected As Label
    Friend WithEvents PlayerSlot2_Selected As Label
    Friend WithEvents PlayerSlot3_Selected As Label
    Friend WithEvents PlayerSlot4_Selected As Label
    Friend WithEvents PlayerSlot5_Selected As Label
    Friend WithEvents PlayerSlot6_Selected As Label
    Friend WithEvents topCard_Selected As Label
    Friend WithEvents Draw_Selected As Label
    Friend WithEvents Thinking As PictureBox
    Friend WithEvents AIcardNumber As Label
    Friend WithEvents UnoSound As PictureBox
    Friend WithEvents UnoSound_Selected As Label
End Class
