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
        Panel1 = New Panel()
        Button2 = New Button()
        Label5 = New Label()
        txt_user = New TextBox()
        txt_password = New TextBox()
        txt_name = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btn_Register = New Button()
        cbo_role = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(371, 57)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatAppearance.BorderSize = 0
        Button2.Location = New Point(291, 0)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 57)
        Button2.TabIndex = 3
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(24, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 23)
        Label5.TabIndex = 2
        Label5.Text = "Manage User's"
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(133, 113)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(163, 27)
        txt_user.TabIndex = 1
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(133, 163)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(163, 27)
        txt_password.TabIndex = 1
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(133, 64)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(163, 27)
        txt_name.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 2
        Label2.Text = "Usuário"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Senha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 2
        Label4.Text = "Role"
        ' 
        ' btn_Register
        ' 
        btn_Register.BackColor = SystemColors.Highlight
        btn_Register.FlatAppearance.BorderSize = 0
        btn_Register.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Register.ForeColor = Color.White
        btn_Register.Location = New Point(133, 256)
        btn_Register.Margin = New Padding(3, 4, 3, 4)
        btn_Register.Name = "btn_Register"
        btn_Register.Size = New Size(163, 31)
        btn_Register.TabIndex = 3
        btn_Register.Text = "Register"
        btn_Register.UseVisualStyleBackColor = False
        ' 
        ' cbo_role
        ' 
        cbo_role.FormattingEnabled = True
        cbo_role.Items.AddRange(New Object() {"ADMIN", "PRODUCTION", "STORE"})
        cbo_role.Location = New Point(134, 214)
        cbo_role.Name = "cbo_role"
        cbo_role.Size = New Size(162, 28)
        cbo_role.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(371, 323)
        Controls.Add(cbo_role)
        Controls.Add(btn_Register)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_password)
        Controls.Add(txt_name)
        Controls.Add(txt_user)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_role As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Register As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbo_role As ComboBox
End Class
