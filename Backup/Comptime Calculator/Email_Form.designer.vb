<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Email
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
        Me.btn_Exit = New System.Windows.Forms.Button
        Me.btn_Clear = New System.Windows.Forms.Button
        Me.btn_Email = New System.Windows.Forms.Button
        Me.txt_From = New System.Windows.Forms.TextBox
        Me.txt_To = New System.Windows.Forms.TextBox
        Me.txt_Path = New System.Windows.Forms.TextBox
        Me.brn_Browse = New System.Windows.Forms.Button
        Me.lbl_From = New System.Windows.Forms.Label
        Me.lbl_To = New System.Windows.Forms.Label
        Me.lbl_Path = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txt_Subject = New System.Windows.Forms.TextBox
        Me.txt_Msg = New System.Windows.Forms.TextBox
        Me.lbl_Subject = New System.Windows.Forms.Label
        Me.lbl_Msg = New System.Windows.Forms.Label
        Me.txt_Username = New System.Windows.Forms.TextBox
        Me.txt_PW = New System.Windows.Forms.TextBox
        Me.lbl_PW = New System.Windows.Forms.Label
        Me.lbl_Username = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btn_Exit.Location = New System.Drawing.Point(14, 569)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(83, 27)
        Me.btn_Exit.TabIndex = 6
        Me.btn_Exit.Text = "Rtn to Main"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(182, 569)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(83, 27)
        Me.btn_Clear.TabIndex = 7
        Me.btn_Clear.Text = "Clear Form"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Email
        '
        Me.btn_Email.Location = New System.Drawing.Point(365, 569)
        Me.btn_Email.Name = "btn_Email"
        Me.btn_Email.Size = New System.Drawing.Size(83, 27)
        Me.btn_Email.TabIndex = 8
        Me.btn_Email.Text = "Email Data"
        Me.btn_Email.UseVisualStyleBackColor = True
        '
        'txt_From
        '
        Me.txt_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_From.Location = New System.Drawing.Point(10, 173)
        Me.txt_From.Multiline = True
        Me.txt_From.Name = "txt_From"
        Me.txt_From.Size = New System.Drawing.Size(206, 29)
        Me.txt_From.TabIndex = 2
        '
        'txt_To
        '
        Me.txt_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_To.Location = New System.Drawing.Point(245, 173)
        Me.txt_To.Multiline = True
        Me.txt_To.Name = "txt_To"
        Me.txt_To.Size = New System.Drawing.Size(206, 29)
        Me.txt_To.TabIndex = 3
        '
        'txt_Path
        '
        Me.txt_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Path.Location = New System.Drawing.Point(9, 459)
        Me.txt_Path.Multiline = True
        Me.txt_Path.Name = "txt_Path"
        Me.txt_Path.Size = New System.Drawing.Size(439, 29)
        Me.txt_Path.TabIndex = 10
        '
        'brn_Browse
        '
        Me.brn_Browse.Location = New System.Drawing.Point(14, 494)
        Me.brn_Browse.Name = "brn_Browse"
        Me.brn_Browse.Size = New System.Drawing.Size(83, 27)
        Me.brn_Browse.TabIndex = 5
        Me.brn_Browse.Text = "Browse"
        Me.brn_Browse.UseVisualStyleBackColor = True
        '
        'lbl_From
        '
        Me.lbl_From.AutoSize = True
        Me.lbl_From.Location = New System.Drawing.Point(7, 157)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(102, 13)
        Me.lbl_From.TabIndex = 7
        Me.lbl_From.Text = "From Email Address:"
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Location = New System.Drawing.Point(242, 157)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(92, 13)
        Me.lbl_To.TabIndex = 8
        Me.lbl_To.Text = "To Email Address:"
        '
        'lbl_Path
        '
        Me.lbl_Path.AutoSize = True
        Me.lbl_Path.CausesValidation = False
        Me.lbl_Path.Location = New System.Drawing.Point(7, 443)
        Me.lbl_Path.Name = "lbl_Path"
        Me.lbl_Path.Size = New System.Drawing.Size(182, 13)
        Me.lbl_Path.TabIndex = 9
        Me.lbl_Path.Text = "Path to comptimerun.txt file to attach:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Select Your File"
        Me.OpenFileDialog1.Filter = "Text File(*.txt)|*.txt|All Files|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\Comptime\"
        '
        'txt_Subject
        '
        Me.txt_Subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Subject.Location = New System.Drawing.Point(10, 222)
        Me.txt_Subject.Multiline = True
        Me.txt_Subject.Name = "txt_Subject"
        Me.txt_Subject.Size = New System.Drawing.Size(443, 29)
        Me.txt_Subject.TabIndex = 9
        '
        'txt_Msg
        '
        Me.txt_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Msg.Location = New System.Drawing.Point(10, 272)
        Me.txt_Msg.Multiline = True
        Me.txt_Msg.Name = "txt_Msg"
        Me.txt_Msg.Size = New System.Drawing.Size(443, 149)
        Me.txt_Msg.TabIndex = 4
        '
        'lbl_Subject
        '
        Me.lbl_Subject.AutoSize = True
        Me.lbl_Subject.Location = New System.Drawing.Point(7, 206)
        Me.lbl_Subject.Name = "lbl_Subject"
        Me.lbl_Subject.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Subject.TabIndex = 12
        Me.lbl_Subject.Text = "Subject:"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.Location = New System.Drawing.Point(7, 256)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(77, 13)
        Me.lbl_Msg.TabIndex = 13
        Me.lbl_Msg.Text = "Brief Message:"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(9, 37)
        Me.txt_Username.Multiline = True
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(206, 29)
        Me.txt_Username.TabIndex = 0
        '
        'txt_PW
        '
        Me.txt_PW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PW.Location = New System.Drawing.Point(9, 93)
        Me.txt_PW.Multiline = True
        Me.txt_PW.Name = "txt_PW"
        Me.txt_PW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_PW.Size = New System.Drawing.Size(206, 29)
        Me.txt_PW.TabIndex = 1
        '
        'lbl_PW
        '
        Me.lbl_PW.AutoSize = True
        Me.lbl_PW.Location = New System.Drawing.Point(7, 77)
        Me.lbl_PW.Name = "lbl_PW"
        Me.lbl_PW.Size = New System.Drawing.Size(56, 13)
        Me.lbl_PW.TabIndex = 16
        Me.lbl_PW.Text = "Password:"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(7, 21)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Username.TabIndex = 17
        Me.lbl_Username.Text = "Username:"
        '
        'frm_Email
        '
        Me.AcceptButton = Me.btn_Email
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Exit
        Me.ClientSize = New System.Drawing.Size(464, 622)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_PW)
        Me.Controls.Add(Me.txt_PW)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.lbl_Subject)
        Me.Controls.Add(Me.txt_Msg)
        Me.Controls.Add(Me.txt_Subject)
        Me.Controls.Add(Me.lbl_Path)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.lbl_From)
        Me.Controls.Add(Me.brn_Browse)
        Me.Controls.Add(Me.txt_Path)
        Me.Controls.Add(Me.txt_To)
        Me.Controls.Add(Me.txt_From)
        Me.Controls.Add(Me.btn_Email)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Data by Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Email As System.Windows.Forms.Button
    Friend WithEvents txt_From As System.Windows.Forms.TextBox
    Friend WithEvents txt_To As System.Windows.Forms.TextBox
    Friend WithEvents txt_Path As System.Windows.Forms.TextBox
    Friend WithEvents brn_Browse As System.Windows.Forms.Button
    Friend WithEvents lbl_To As System.Windows.Forms.Label
    Friend WithEvents lbl_Path As System.Windows.Forms.Label
    Friend WithEvents lbl_From As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_Subject As System.Windows.Forms.TextBox
    Friend WithEvents txt_Msg As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Subject As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents txt_PW As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PW As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
End Class
