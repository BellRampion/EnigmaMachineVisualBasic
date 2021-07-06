<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RRotorSelectCbox = New System.Windows.Forms.ComboBox()
        Me.LRotorStartCbox = New System.Windows.Forms.ComboBox()
        Me.MRotorStartCbox = New System.Windows.Forms.ComboBox()
        Me.RRotorStartCbox = New System.Windows.Forms.ComboBox()
        Me.LRotorSelectCbox = New System.Windows.Forms.ComboBox()
        Me.MRotorSelectCbox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RRotorNumlbl = New System.Windows.Forms.Label()
        Me.LRotorNumLbl = New System.Windows.Forms.Label()
        Me.MRotorNumLbl = New System.Windows.Forms.Label()
        Me.InputTxt = New System.Windows.Forms.TextBox()
        Me.RunBtn = New System.Windows.Forms.Button()
        Me.OutputTxt = New System.Windows.Forms.TextBox()
        Me.RotorStartLbl = New System.Windows.Forms.Label()
        Me.RRotorStartLbl = New System.Windows.Forms.Label()
        Me.MRotorStartLbl = New System.Windows.Forms.Label()
        Me.LRotorStartLbl = New System.Windows.Forms.Label()
        Me.InputLbl = New System.Windows.Forms.Label()
        Me.OutputLbl = New System.Windows.Forms.Label()
        Me.DebugTxt = New System.Windows.Forms.TextBox()
        Me.DebugLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RRotorSelectCbox
        '
        Me.RRotorSelectCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RRotorSelectCbox.FormattingEnabled = True
        Me.RRotorSelectCbox.Items.AddRange(New Object() {"I", "II", "III"})
        Me.RRotorSelectCbox.Location = New System.Drawing.Point(13, 67)
        Me.RRotorSelectCbox.Name = "RRotorSelectCbox"
        Me.RRotorSelectCbox.Size = New System.Drawing.Size(121, 23)
        Me.RRotorSelectCbox.TabIndex = 0
        '
        'LRotorStartCbox
        '
        Me.LRotorStartCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LRotorStartCbox.FormattingEnabled = True
        Me.LRotorStartCbox.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.LRotorStartCbox.Location = New System.Drawing.Point(230, 186)
        Me.LRotorStartCbox.Name = "LRotorStartCbox"
        Me.LRotorStartCbox.Size = New System.Drawing.Size(121, 23)
        Me.LRotorStartCbox.TabIndex = 1
        '
        'MRotorStartCbox
        '
        Me.MRotorStartCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MRotorStartCbox.FormattingEnabled = True
        Me.MRotorStartCbox.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.MRotorStartCbox.Location = New System.Drawing.Point(230, 125)
        Me.MRotorStartCbox.Name = "MRotorStartCbox"
        Me.MRotorStartCbox.Size = New System.Drawing.Size(121, 23)
        Me.MRotorStartCbox.TabIndex = 2
        '
        'RRotorStartCbox
        '
        Me.RRotorStartCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RRotorStartCbox.FormattingEnabled = True
        Me.RRotorStartCbox.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.RRotorStartCbox.Location = New System.Drawing.Point(230, 67)
        Me.RRotorStartCbox.Name = "RRotorStartCbox"
        Me.RRotorStartCbox.Size = New System.Drawing.Size(121, 23)
        Me.RRotorStartCbox.TabIndex = 3
        '
        'LRotorSelectCbox
        '
        Me.LRotorSelectCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LRotorSelectCbox.FormattingEnabled = True
        Me.LRotorSelectCbox.Items.AddRange(New Object() {"I", "II", "III"})
        Me.LRotorSelectCbox.Location = New System.Drawing.Point(13, 186)
        Me.LRotorSelectCbox.Name = "LRotorSelectCbox"
        Me.LRotorSelectCbox.Size = New System.Drawing.Size(121, 23)
        Me.LRotorSelectCbox.TabIndex = 4
        '
        'MRotorSelectCbox
        '
        Me.MRotorSelectCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MRotorSelectCbox.FormattingEnabled = True
        Me.MRotorSelectCbox.Items.AddRange(New Object() {"I", "II", "III"})
        Me.MRotorSelectCbox.Location = New System.Drawing.Point(13, 125)
        Me.MRotorSelectCbox.Name = "MRotorSelectCbox"
        Me.MRotorSelectCbox.Size = New System.Drawing.Size(121, 23)
        Me.MRotorSelectCbox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Rotor Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RRotorNumlbl
        '
        Me.RRotorNumlbl.Location = New System.Drawing.Point(13, 41)
        Me.RRotorNumlbl.Name = "RRotorNumlbl"
        Me.RRotorNumlbl.Size = New System.Drawing.Size(121, 23)
        Me.RRotorNumlbl.TabIndex = 7
        Me.RRotorNumlbl.Text = "Right Rotor Number"
        Me.RRotorNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LRotorNumLbl
        '
        Me.LRotorNumLbl.Location = New System.Drawing.Point(13, 160)
        Me.LRotorNumLbl.Name = "LRotorNumLbl"
        Me.LRotorNumLbl.Size = New System.Drawing.Size(121, 23)
        Me.LRotorNumLbl.TabIndex = 8
        Me.LRotorNumLbl.Text = "Left Rotor Number"
        Me.LRotorNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MRotorNumLbl
        '
        Me.MRotorNumLbl.Location = New System.Drawing.Point(8, 99)
        Me.MRotorNumLbl.Name = "MRotorNumLbl"
        Me.MRotorNumLbl.Size = New System.Drawing.Size(131, 23)
        Me.MRotorNumLbl.TabIndex = 9
        Me.MRotorNumLbl.Text = "Middle Rotor Number"
        Me.MRotorNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InputTxt
        '
        Me.InputTxt.Location = New System.Drawing.Point(13, 237)
        Me.InputTxt.Name = "InputTxt"
        Me.InputTxt.Size = New System.Drawing.Size(338, 23)
        Me.InputTxt.TabIndex = 10
        '
        'RunBtn
        '
        Me.RunBtn.Location = New System.Drawing.Point(138, 266)
        Me.RunBtn.Name = "RunBtn"
        Me.RunBtn.Size = New System.Drawing.Size(89, 23)
        Me.RunBtn.TabIndex = 11
        Me.RunBtn.Text = "Run"
        Me.RunBtn.UseVisualStyleBackColor = True
        '
        'OutputTxt
        '
        Me.OutputTxt.Location = New System.Drawing.Point(13, 340)
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.ReadOnly = True
        Me.OutputTxt.Size = New System.Drawing.Size(338, 23)
        Me.OutputTxt.TabIndex = 12
        '
        'RotorStartLbl
        '
        Me.RotorStartLbl.Location = New System.Drawing.Point(230, 9)
        Me.RotorStartLbl.Name = "RotorStartLbl"
        Me.RotorStartLbl.Size = New System.Drawing.Size(121, 23)
        Me.RotorStartLbl.TabIndex = 13
        Me.RotorStartLbl.Text = "Rotor Start Position"
        Me.RotorStartLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RRotorStartLbl
        '
        Me.RRotorStartLbl.Location = New System.Drawing.Point(230, 41)
        Me.RRotorStartLbl.Name = "RRotorStartLbl"
        Me.RRotorStartLbl.Size = New System.Drawing.Size(121, 23)
        Me.RRotorStartLbl.TabIndex = 14
        Me.RRotorStartLbl.Text = "Right Rotor Start"
        Me.RRotorStartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MRotorStartLbl
        '
        Me.MRotorStartLbl.Location = New System.Drawing.Point(230, 99)
        Me.MRotorStartLbl.Name = "MRotorStartLbl"
        Me.MRotorStartLbl.Size = New System.Drawing.Size(121, 23)
        Me.MRotorStartLbl.TabIndex = 15
        Me.MRotorStartLbl.Text = "Middle Rotor Start"
        Me.MRotorStartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LRotorStartLbl
        '
        Me.LRotorStartLbl.Location = New System.Drawing.Point(230, 160)
        Me.LRotorStartLbl.Name = "LRotorStartLbl"
        Me.LRotorStartLbl.Size = New System.Drawing.Size(121, 23)
        Me.LRotorStartLbl.TabIndex = 16
        Me.LRotorStartLbl.Text = "Left Rotor Start"
        Me.LRotorStartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InputLbl
        '
        Me.InputLbl.Location = New System.Drawing.Point(138, 211)
        Me.InputLbl.Name = "InputLbl"
        Me.InputLbl.Size = New System.Drawing.Size(89, 23)
        Me.InputLbl.TabIndex = 17
        Me.InputLbl.Text = "Input"
        Me.InputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OutputLbl
        '
        Me.OutputLbl.Location = New System.Drawing.Point(138, 314)
        Me.OutputLbl.Name = "OutputLbl"
        Me.OutputLbl.Size = New System.Drawing.Size(89, 23)
        Me.OutputLbl.TabIndex = 18
        Me.OutputLbl.Text = "Output"
        Me.OutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DebugTxt
        '
        Me.DebugTxt.Location = New System.Drawing.Point(366, 41)
        Me.DebugTxt.Multiline = True
        Me.DebugTxt.Name = "DebugTxt"
        Me.DebugTxt.ReadOnly = True
        Me.DebugTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DebugTxt.Size = New System.Drawing.Size(384, 322)
        Me.DebugTxt.TabIndex = 19
        '
        'DebugLbl
        '
        Me.DebugLbl.AutoSize = True
        Me.DebugLbl.Location = New System.Drawing.Point(491, 9)
        Me.DebugLbl.Name = "DebugLbl"
        Me.DebugLbl.Size = New System.Drawing.Size(134, 15)
        Me.DebugLbl.TabIndex = 20
        Me.DebugLbl.Text = "Step by Step Breakdown"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 401)
        Me.Controls.Add(Me.DebugLbl)
        Me.Controls.Add(Me.DebugTxt)
        Me.Controls.Add(Me.OutputLbl)
        Me.Controls.Add(Me.InputLbl)
        Me.Controls.Add(Me.LRotorStartLbl)
        Me.Controls.Add(Me.MRotorStartLbl)
        Me.Controls.Add(Me.RRotorStartLbl)
        Me.Controls.Add(Me.RotorStartLbl)
        Me.Controls.Add(Me.OutputTxt)
        Me.Controls.Add(Me.RunBtn)
        Me.Controls.Add(Me.InputTxt)
        Me.Controls.Add(Me.MRotorNumLbl)
        Me.Controls.Add(Me.LRotorNumLbl)
        Me.Controls.Add(Me.RRotorNumlbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MRotorSelectCbox)
        Me.Controls.Add(Me.LRotorSelectCbox)
        Me.Controls.Add(Me.RRotorStartCbox)
        Me.Controls.Add(Me.MRotorStartCbox)
        Me.Controls.Add(Me.LRotorStartCbox)
        Me.Controls.Add(Me.RRotorSelectCbox)
        Me.Name = "Form1"
        Me.Text = "Enigma Machine (Simplified)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RRotorSelectCbox As ComboBox
    Friend WithEvents LRotorStartCbox As ComboBox
    Friend WithEvents MRotorStartCbox As ComboBox
    Friend WithEvents RRotorStartCbox As ComboBox
    Friend WithEvents LRotorSelectCbox As ComboBox
    Friend WithEvents MRotorSelectCbox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RRotorNumlbl As Label
    Friend WithEvents LRotorNumLbl As Label
    Friend WithEvents MRotorNumLbl As Label
    Friend WithEvents InputTxt As TextBox
    Friend WithEvents RunBtn As Button
    Friend WithEvents OutputTxt As TextBox
    Friend WithEvents RotorStartLbl As Label
    Friend WithEvents RRotorStartLbl As Label
    Friend WithEvents MRotorStartLbl As Label
    Friend WithEvents LRotorStartLbl As Label
    Friend WithEvents InputLbl As Label
    Protected WithEvents OutputLbl As Label
    Friend WithEvents DebugTxt As TextBox
    Friend WithEvents DebugLbl As Label
End Class
