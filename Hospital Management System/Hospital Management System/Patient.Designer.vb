<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpatient))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGVPatient = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldisease = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cmdgender = New System.Windows.Forms.ComboBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblpname = New System.Windows.Forms.Label()
        Me.lblpid = New System.Windows.Forms.Label()
        Me.txtdisease = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.lblage = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.lblregisterdate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbednumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdepartment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(449, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 44)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(169, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'DGVPatient
        '
        Me.DGVPatient.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPatient.Location = New System.Drawing.Point(434, 37)
        Me.DGVPatient.Name = "DGVPatient"
        Me.DGVPatient.Size = New System.Drawing.Size(347, 216)
        Me.DGVPatient.TabIndex = 29
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.PowderBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(577, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 44)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(699, 305)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 44)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(577, 305)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(82, 44)
        Me.btnupdate.TabIndex = 26
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(449, 305)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 44)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone Number"
        '
        'lbldisease
        '
        Me.lbldisease.AutoSize = True
        Me.lbldisease.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisease.Location = New System.Drawing.Point(6, 93)
        Me.lbldisease.Name = "lbldisease"
        Me.lbldisease.Size = New System.Drawing.Size(67, 20)
        Me.lbldisease.TabIndex = 7
        Me.lbldisease.Text = "Disease"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(197, 67)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(155, 20)
        Me.txtname.TabIndex = 13
        '
        'cmdgender
        '
        Me.cmdgender.FormattingEnabled = True
        Me.cmdgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmdgender.Location = New System.Drawing.Point(197, 156)
        Me.cmdgender.Name = "cmdgender"
        Me.cmdgender.Size = New System.Drawing.Size(155, 21)
        Me.cmdgender.TabIndex = 10
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(197, 41)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(155, 20)
        Me.txtid.TabIndex = 12
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(197, 232)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(155, 20)
        Me.txtphone.TabIndex = 11
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(6, 157)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(63, 20)
        Me.lblgender.TabIndex = 6
        Me.lblgender.Text = "Gender"
        '
        'lblpname
        '
        Me.lblpname.AutoSize = True
        Me.lblpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpname.Location = New System.Drawing.Point(3, 67)
        Me.lblpname.Name = "lblpname"
        Me.lblpname.Size = New System.Drawing.Size(109, 20)
        Me.lblpname.TabIndex = 5
        Me.lblpname.Text = " Patient Name"
        '
        'lblpid
        '
        Me.lblpid.AutoSize = True
        Me.lblpid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpid.Location = New System.Drawing.Point(6, 39)
        Me.lblpid.Name = "lblpid"
        Me.lblpid.Size = New System.Drawing.Size(80, 20)
        Me.lblpid.TabIndex = 4
        Me.lblpid.Text = "Patient ID"
        '
        'txtdisease
        '
        Me.txtdisease.Location = New System.Drawing.Point(197, 93)
        Me.txtdisease.Name = "txtdisease"
        Me.txtdisease.Size = New System.Drawing.Size(155, 20)
        Me.txtdisease.TabIndex = 17
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(197, 119)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(155, 20)
        Me.txtage.TabIndex = 18
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.Location = New System.Drawing.Point(6, 119)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(38, 20)
        Me.lblage.TabIndex = 19
        Me.lblage.Text = "Age"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(6, 195)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(68, 20)
        Me.lbladdress.TabIndex = 20
        Me.lbladdress.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(197, 197)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(155, 20)
        Me.txtaddress.TabIndex = 21
        '
        'lblregisterdate
        '
        Me.lblregisterdate.AutoSize = True
        Me.lblregisterdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregisterdate.Location = New System.Drawing.Point(4, 277)
        Me.lblregisterdate.Name = "lblregisterdate"
        Me.lblregisterdate.Size = New System.Drawing.Size(108, 20)
        Me.lblregisterdate.TabIndex = 22
        Me.lblregisterdate.Text = "Register Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbednumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbdepartment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.lblregisterdate)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.lbladdress)
        Me.GroupBox1.Controls.Add(Me.lblage)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtdisease)
        Me.GroupBox1.Controls.Add(Me.lblpid)
        Me.GroupBox1.Controls.Add(Me.lblpname)
        Me.GroupBox1.Controls.Add(Me.lblgender)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.cmdgender)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.lbldisease)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 386)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'txtbednumber
        '
        Me.txtbednumber.Location = New System.Drawing.Point(197, 356)
        Me.txtbednumber.Name = "txtbednumber"
        Me.txtbednumber.Size = New System.Drawing.Size(155, 20)
        Me.txtbednumber.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Bed Number"
        '
        'cmbdepartment
        '
        Me.cmbdepartment.FormattingEnabled = True
        Me.cmbdepartment.Items.AddRange(New Object() {" Casualty department", " Operating theatre (OT)", " Intensive care unit (ICU)", " Anesthesiology department", "Cardiology department", " ENT department", " Geriatric department", " Gastroenterology department", " General surgery", " Gynaecology department", " Haematology department", " Pediatrics department", "Neurology department", " Oncology department", " Opthalmology department", "Orthopaedic department", "Urology department", " Psychiatry department", " Inpatient Department (IPD)", "Outpatient Department (OPD)"})
        Me.cmbdepartment.Location = New System.Drawing.Point(197, 315)
        Me.cmbdepartment.Name = "cmbdepartment"
        Me.cmbdepartment.Size = New System.Drawing.Size(155, 21)
        Me.cmbdepartment.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Department"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(197, 277)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker2.TabIndex = 24
        '
        'frmpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVPatient)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmpatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Nurse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGVPatient As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbldisease As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents cmdgender As ComboBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents lblgender As Label
    Friend WithEvents lblpname As Label
    Friend WithEvents lblpid As Label
    Friend WithEvents txtdisease As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents lblage As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents lblregisterdate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtbednumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbdepartment As ComboBox
End Class
