<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RatingFIFA
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPAC = New System.Windows.Forms.TextBox()
        Me.txtSHO = New System.Windows.Forms.TextBox()
        Me.txtPAS = New System.Windows.Forms.TextBox()
        Me.txtDRI = New System.Windows.Forms.TextBox()
        Me.txtDEF = New System.Windows.Forms.TextBox()
        Me.txtPHY = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtCodJogador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picJogador = New System.Windows.Forms.PictureBox()
        CType(Me.picJogador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DRI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SHO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DEF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(162, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PHY"
        '
        'txtPAC
        '
        Me.txtPAC.Location = New System.Drawing.Point(66, 81)
        Me.txtPAC.Name = "txtPAC"
        Me.txtPAC.Size = New System.Drawing.Size(65, 20)
        Me.txtPAC.TabIndex = 0
        '
        'txtSHO
        '
        Me.txtSHO.Location = New System.Drawing.Point(66, 120)
        Me.txtSHO.Name = "txtSHO"
        Me.txtSHO.Size = New System.Drawing.Size(65, 20)
        Me.txtSHO.TabIndex = 2
        '
        'txtPAS
        '
        Me.txtPAS.Location = New System.Drawing.Point(66, 160)
        Me.txtPAS.Name = "txtPAS"
        Me.txtPAS.Size = New System.Drawing.Size(65, 20)
        Me.txtPAS.TabIndex = 4
        '
        'txtDRI
        '
        Me.txtDRI.Location = New System.Drawing.Point(197, 81)
        Me.txtDRI.Name = "txtDRI"
        Me.txtDRI.Size = New System.Drawing.Size(71, 20)
        Me.txtDRI.TabIndex = 1
        '
        'txtDEF
        '
        Me.txtDEF.Location = New System.Drawing.Point(197, 120)
        Me.txtDEF.Name = "txtDEF"
        Me.txtDEF.Size = New System.Drawing.Size(71, 20)
        Me.txtDEF.TabIndex = 3
        '
        'txtPHY
        '
        Me.txtPHY.Location = New System.Drawing.Point(197, 160)
        Me.txtPHY.Name = "txtPHY"
        Me.txtPHY.Size = New System.Drawing.Size(71, 20)
        Me.txtPHY.TabIndex = 5
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(109, 216)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(99, 50)
        Me.btnConfirmar.TabIndex = 6
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtCodJogador
        '
        Me.txtCodJogador.Location = New System.Drawing.Point(132, 28)
        Me.txtCodJogador.Name = "txtCodJogador"
        Me.txtCodJogador.Size = New System.Drawing.Size(65, 20)
        Me.txtCodJogador.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "codJogador"
        '
        'picJogador
        '
        Me.picJogador.Location = New System.Drawing.Point(372, 28)
        Me.picJogador.Name = "picJogador"
        Me.picJogador.Size = New System.Drawing.Size(250, 238)
        Me.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJogador.TabIndex = 15
        Me.picJogador.TabStop = False
        '
        'RatingFIFA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 298)
        Me.Controls.Add(Me.picJogador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodJogador)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtPHY)
        Me.Controls.Add(Me.txtDEF)
        Me.Controls.Add(Me.txtDRI)
        Me.Controls.Add(Me.txtPAS)
        Me.Controls.Add(Me.txtSHO)
        Me.Controls.Add(Me.txtPAC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RatingFIFA"
        Me.Text = "RatingFIFA"
        CType(Me.picJogador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPAC As System.Windows.Forms.TextBox
    Friend WithEvents txtSHO As System.Windows.Forms.TextBox
    Friend WithEvents txtPAS As System.Windows.Forms.TextBox
    Friend WithEvents txtDRI As System.Windows.Forms.TextBox
    Friend WithEvents txtDEF As System.Windows.Forms.TextBox
    Friend WithEvents txtPHY As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtCodJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents picJogador As System.Windows.Forms.PictureBox
End Class
