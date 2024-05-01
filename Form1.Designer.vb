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
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.btn_Var = New System.Windows.Forms.Button()
        Me.btn_data = New System.Windows.Forms.Button()
        Me.stinput = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.nmrUmur = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lstWork = New System.Windows.Forms.ListBox()
        Me.lblWork = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Go
        '
        Me.btn_Go.Location = New System.Drawing.Point(12, 12)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(207, 77)
        Me.btn_Go.TabIndex = 0
        Me.btn_Go.Text = "Tombol Cringe"
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'btn_Var
        '
        Me.btn_Var.Location = New System.Drawing.Point(230, 14)
        Me.btn_Var.Name = "btn_Var"
        Me.btn_Var.Size = New System.Drawing.Size(202, 74)
        Me.btn_Var.TabIndex = 1
        Me.btn_Var.Text = "Variables"
        Me.btn_Var.UseVisualStyleBackColor = True
        '
        'btn_data
        '
        Me.btn_data.Location = New System.Drawing.Point(12, 95)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(207, 71)
        Me.btn_data.TabIndex = 2
        Me.btn_data.Text = "Data Types"
        Me.btn_data.UseVisualStyleBackColor = True
        '
        'stinput
        '
        Me.stinput.Location = New System.Drawing.Point(230, 95)
        Me.stinput.Name = "stinput"
        Me.stinput.Size = New System.Drawing.Size(200, 71)
        Me.stinput.TabIndex = 3
        Me.stinput.Text = "Form Ngasal"
        Me.stinput.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(230, 219)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(202, 23)
        Me.txtNama.TabIndex = 4
        '
        'nmrUmur
        '
        Me.nmrUmur.Location = New System.Drawing.Point(230, 248)
        Me.nmrUmur.Name = "nmrUmur"
        Me.nmrUmur.Size = New System.Drawing.Size(202, 23)
        Me.nmrUmur.TabIndex = 5
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(172, 227)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(39, 15)
        Me.lblNama.TabIndex = 6
        Me.lblNama.Text = "Nama"
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Location = New System.Drawing.Point(174, 256)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(37, 15)
        Me.lblUmur.TabIndex = 7
        Me.lblUmur.Text = "Umur"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(174, 285)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 15)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(230, 277)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(202, 23)
        Me.txtGender.TabIndex = 8
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(357, 306)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lstWork
        '
        Me.lstWork.FormattingEnabled = True
        Me.lstWork.ItemHeight = 15
        Me.lstWork.Items.AddRange(New Object() {"Pengocoks handal", "Bandar Bokep", "Bintang 4no", "Wibu Nolep", "Pelayer Ngep-ngep"})
        Me.lstWork.Location = New System.Drawing.Point(442, 218)
        Me.lstWork.Name = "lstWork"
        Me.lstWork.Size = New System.Drawing.Size(122, 79)
        Me.lstWork.TabIndex = 11
        '
        'lblWork
        '
        Me.lblWork.AutoSize = True
        Me.lblWork.Location = New System.Drawing.Point(442, 200)
        Me.lblWork.Name = "lblWork"
        Me.lblWork.Size = New System.Drawing.Size(58, 15)
        Me.lblWork.TabIndex = 12
        Me.lblWork.Text = "Pekerjaan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWork)
        Me.Controls.Add(Me.lstWork)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.nmrUmur)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.stinput)
        Me.Controls.Add(Me.btn_data)
        Me.Controls.Add(Me.btn_Var)
        Me.Controls.Add(Me.btn_Go)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Go As Button
    Friend WithEvents btn_Var As Button
    Friend WithEvents btn_data As Button
    Friend WithEvents stinput As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents nmrUmur As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lstWork As ListBox
    Friend WithEvents lblWork As Label
End Class
