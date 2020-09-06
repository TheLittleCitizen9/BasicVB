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
        Me.ChangeColorButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadPicture = New System.Windows.Forms.Button()
        Me.LineButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChangeColorButton
        '
        Me.ChangeColorButton.Location = New System.Drawing.Point(165, 389)
        Me.ChangeColorButton.Name = "ChangeColorButton"
        Me.ChangeColorButton.Size = New System.Drawing.Size(130, 49)
        Me.ChangeColorButton.TabIndex = 0
        Me.ChangeColorButton.Text = "Change Color"
        Me.ChangeColorButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(184, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 376)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LoadPicture
        '
        Me.LoadPicture.Location = New System.Drawing.Point(12, 389)
        Me.LoadPicture.Name = "LoadPicture"
        Me.LoadPicture.Size = New System.Drawing.Size(128, 49)
        Me.LoadPicture.TabIndex = 2
        Me.LoadPicture.Text = "Load"
        Me.LoadPicture.UseVisualStyleBackColor = True
        '
        'LineButton
        '
        Me.LineButton.Location = New System.Drawing.Point(314, 389)
        Me.LineButton.Name = "LineButton"
        Me.LineButton.Size = New System.Drawing.Size(130, 49)
        Me.LineButton.TabIndex = 3
        Me.LineButton.Text = "Draw Line"
        Me.LineButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(467, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Draw Circle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LineButton)
        Me.Controls.Add(Me.LoadPicture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChangeColorButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChangeColorButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadPicture As Button
    Friend WithEvents LineButton As Button
    Friend WithEvents Button1 As Button
End Class
