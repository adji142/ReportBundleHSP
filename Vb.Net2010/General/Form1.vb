Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdclearhighrange As System.Windows.Forms.Button
	Public WithEvents txtmonthrange As System.Windows.Forms.TextBox
	Public WithEvents cmdhighrange As System.Windows.Forms.Button
	Public WithEvents txtyearrange As System.Windows.Forms.TextBox
	Public WithEvents txtselto As System.Windows.Forms.TextBox
	Public WithEvents txtselfrom As System.Windows.Forms.TextBox
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents cmdchangedaycap As System.Windows.Forms.Button
	Public WithEvents txtdaycaption6 As System.Windows.Forms.TextBox
	Public WithEvents txtdaycaption5 As System.Windows.Forms.TextBox
	Public WithEvents txtdaycaption4 As System.Windows.Forms.TextBox
	Public WithEvents txtdaycaption3 As System.Windows.Forms.TextBox
	Public WithEvents txtdaycaption2 As System.Windows.Forms.TextBox
	Public WithEvents txtdaycaption1 As System.Windows.Forms.TextBox
	Public WithEvents txtdaycaption0 As System.Windows.Forms.TextBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents cbotextsize As System.Windows.Forms.ComboBox
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents cbodaytextfont As System.Windows.Forms.ComboBox
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents txtCurrentDay As System.Windows.Forms.TextBox
	Public WithEvents txtdaytext As System.Windows.Forms.TextBox
	Public WithEvents txtdayno As System.Windows.Forms.TextBox
	Public WithEvents Command6 As System.Windows.Forms.Button
	Public WithEvents txtText As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents txtDay As System.Windows.Forms.TextBox
	Public WithEvents txtMonth As System.Windows.Forms.TextBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmdgo As System.Windows.Forms.Button
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents cbodayfont As System.Windows.Forms.ComboBox
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents cbodaycaption As System.Windows.Forms.ComboBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdmonthyearforecolor As System.Windows.Forms.Button
	Public WithEvents cmdmonthyearbackcolor As System.Windows.Forms.Button
	Public WithEvents cbofont As System.Windows.Forms.ComboBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AxCalendar1 As AxCALENDARLib.AxCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtsetday As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdclearhighrange = New System.Windows.Forms.Button()
        Me.txtmonthrange = New System.Windows.Forms.TextBox()
        Me.cmdhighrange = New System.Windows.Forms.Button()
        Me.txtyearrange = New System.Windows.Forms.TextBox()
        Me.txtselto = New System.Windows.Forms.TextBox()
        Me.txtselfrom = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmdchangedaycap = New System.Windows.Forms.Button()
        Me.txtdaycaption6 = New System.Windows.Forms.TextBox()
        Me.txtdaycaption5 = New System.Windows.Forms.TextBox()
        Me.txtdaycaption4 = New System.Windows.Forms.TextBox()
        Me.txtdaycaption3 = New System.Windows.Forms.TextBox()
        Me.txtdaycaption2 = New System.Windows.Forms.TextBox()
        Me.txtdaycaption1 = New System.Windows.Forms.TextBox()
        Me.txtdaycaption0 = New System.Windows.Forms.TextBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cbotextsize = New System.Windows.Forms.ComboBox()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.cbodaytextfont = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.txtCurrentDay = New System.Windows.Forms.TextBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.txtdaytext = New System.Windows.Forms.TextBox()
        Me.txtdayno = New System.Windows.Forms.TextBox()
        Me.Command6 = New System.Windows.Forms.Button()
        Me.txtText = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Command5 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.cmdgo = New System.Windows.Forms.Button()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cbodayfont = New System.Windows.Forms.ComboBox()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cbodaycaption = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdmonthyearforecolor = New System.Windows.Forms.Button()
        Me.cmdmonthyearbackcolor = New System.Windows.Forms.Button()
        Me.cbofont = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AxCalendar1 = New AxCALENDARLib.AxCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsetday = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Frame9.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Controls.Add(Me.cmdclearhighrange)
        Me.Frame9.Controls.Add(Me.txtmonthrange)
        Me.Frame9.Controls.Add(Me.cmdhighrange)
        Me.Frame9.Controls.Add(Me.txtyearrange)
        Me.Frame9.Controls.Add(Me.txtselto)
        Me.Frame9.Controls.Add(Me.txtselfrom)
        Me.Frame9.Controls.Add(Me.Label22)
        Me.Frame9.Controls.Add(Me.Label21)
        Me.Frame9.Controls.Add(Me.Label20)
        Me.Frame9.Controls.Add(Me.Label19)
        Me.Frame9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(376, 632)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(337, 89)
        Me.Frame9.TabIndex = 58
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "Highlight specific range"
        '
        'cmdclearhighrange
        '
        Me.cmdclearhighrange.BackColor = System.Drawing.SystemColors.Control
        Me.cmdclearhighrange.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdclearhighrange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclearhighrange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdclearhighrange.Location = New System.Drawing.Point(128, 64)
        Me.cmdclearhighrange.Name = "cmdclearhighrange"
        Me.cmdclearhighrange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdclearhighrange.Size = New System.Drawing.Size(113, 25)
        Me.cmdclearhighrange.TabIndex = 68
        Me.cmdclearhighrange.Text = "Clear Highlight"
        Me.cmdclearhighrange.UseVisualStyleBackColor = False
        '
        'txtmonthrange
        '
        Me.txtmonthrange.AcceptsReturn = True
        Me.txtmonthrange.BackColor = System.Drawing.SystemColors.Window
        Me.txtmonthrange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmonthrange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonthrange.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtmonthrange.Location = New System.Drawing.Point(216, 16)
        Me.txtmonthrange.MaxLength = 0
        Me.txtmonthrange.Name = "txtmonthrange"
        Me.txtmonthrange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmonthrange.Size = New System.Drawing.Size(65, 20)
        Me.txtmonthrange.TabIndex = 67
        Me.txtmonthrange.Text = "1"
        '
        'cmdhighrange
        '
        Me.cmdhighrange.BackColor = System.Drawing.SystemColors.Control
        Me.cmdhighrange.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdhighrange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhighrange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdhighrange.Location = New System.Drawing.Point(48, 64)
        Me.cmdhighrange.Name = "cmdhighrange"
        Me.cmdhighrange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdhighrange.Size = New System.Drawing.Size(65, 25)
        Me.cmdhighrange.TabIndex = 64
        Me.cmdhighrange.Text = "Highlight"
        Me.cmdhighrange.UseVisualStyleBackColor = False
        '
        'txtyearrange
        '
        Me.txtyearrange.AcceptsReturn = True
        Me.txtyearrange.BackColor = System.Drawing.SystemColors.Window
        Me.txtyearrange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtyearrange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyearrange.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtyearrange.Location = New System.Drawing.Point(96, 16)
        Me.txtyearrange.MaxLength = 0
        Me.txtyearrange.Name = "txtyearrange"
        Me.txtyearrange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtyearrange.Size = New System.Drawing.Size(57, 20)
        Me.txtyearrange.TabIndex = 63
        Me.txtyearrange.Text = "txtyearrange"
        '
        'txtselto
        '
        Me.txtselto.AcceptsReturn = True
        Me.txtselto.BackColor = System.Drawing.SystemColors.Window
        Me.txtselto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtselto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtselto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtselto.Location = New System.Drawing.Point(200, 40)
        Me.txtselto.MaxLength = 0
        Me.txtselto.Name = "txtselto"
        Me.txtselto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtselto.Size = New System.Drawing.Size(57, 20)
        Me.txtselto.TabIndex = 62
        Me.txtselto.Text = "20"
        '
        'txtselfrom
        '
        Me.txtselfrom.AcceptsReturn = True
        Me.txtselfrom.BackColor = System.Drawing.SystemColors.Window
        Me.txtselfrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtselfrom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtselfrom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtselfrom.Location = New System.Drawing.Point(96, 40)
        Me.txtselfrom.MaxLength = 0
        Me.txtselfrom.Name = "txtselfrom"
        Me.txtselfrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtselfrom.Size = New System.Drawing.Size(49, 20)
        Me.txtselfrom.TabIndex = 60
        Me.txtselfrom.Text = "1"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(160, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(41, 17)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Month"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(73, 17)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Year"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(160, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(25, 17)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "To"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(81, 17)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Start from day"
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.cmdchangedaycap)
        Me.Frame8.Controls.Add(Me.txtdaycaption6)
        Me.Frame8.Controls.Add(Me.txtdaycaption5)
        Me.Frame8.Controls.Add(Me.txtdaycaption4)
        Me.Frame8.Controls.Add(Me.txtdaycaption3)
        Me.Frame8.Controls.Add(Me.txtdaycaption2)
        Me.Frame8.Controls.Add(Me.txtdaycaption1)
        Me.Frame8.Controls.Add(Me.txtdaycaption0)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(720, 480)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(185, 225)
        Me.Frame8.TabIndex = 49
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "Change Day Captions"
        '
        'cmdchangedaycap
        '
        Me.cmdchangedaycap.BackColor = System.Drawing.SystemColors.Control
        Me.cmdchangedaycap.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdchangedaycap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdchangedaycap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdchangedaycap.Location = New System.Drawing.Point(8, 192)
        Me.cmdchangedaycap.Name = "cmdchangedaycap"
        Me.cmdchangedaycap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdchangedaycap.Size = New System.Drawing.Size(73, 25)
        Me.cmdchangedaycap.TabIndex = 57
        Me.cmdchangedaycap.Text = "Change"
        Me.cmdchangedaycap.UseVisualStyleBackColor = False
        '
        'txtdaycaption6
        '
        Me.txtdaycaption6.AcceptsReturn = True
        Me.txtdaycaption6.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption6.Location = New System.Drawing.Point(8, 168)
        Me.txtdaycaption6.MaxLength = 0
        Me.txtdaycaption6.Name = "txtdaycaption6"
        Me.txtdaycaption6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption6.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption6.TabIndex = 56
        Me.txtdaycaption6.Text = "Saturday"
        '
        'txtdaycaption5
        '
        Me.txtdaycaption5.AcceptsReturn = True
        Me.txtdaycaption5.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption5.Location = New System.Drawing.Point(8, 144)
        Me.txtdaycaption5.MaxLength = 0
        Me.txtdaycaption5.Name = "txtdaycaption5"
        Me.txtdaycaption5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption5.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption5.TabIndex = 55
        Me.txtdaycaption5.Text = "Friday"
        '
        'txtdaycaption4
        '
        Me.txtdaycaption4.AcceptsReturn = True
        Me.txtdaycaption4.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption4.Location = New System.Drawing.Point(8, 120)
        Me.txtdaycaption4.MaxLength = 0
        Me.txtdaycaption4.Name = "txtdaycaption4"
        Me.txtdaycaption4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption4.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption4.TabIndex = 54
        Me.txtdaycaption4.Text = "Thursday"
        '
        'txtdaycaption3
        '
        Me.txtdaycaption3.AcceptsReturn = True
        Me.txtdaycaption3.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption3.Location = New System.Drawing.Point(8, 96)
        Me.txtdaycaption3.MaxLength = 0
        Me.txtdaycaption3.Name = "txtdaycaption3"
        Me.txtdaycaption3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption3.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption3.TabIndex = 53
        Me.txtdaycaption3.Text = "Wednesday"
        '
        'txtdaycaption2
        '
        Me.txtdaycaption2.AcceptsReturn = True
        Me.txtdaycaption2.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption2.Location = New System.Drawing.Point(8, 72)
        Me.txtdaycaption2.MaxLength = 0
        Me.txtdaycaption2.Name = "txtdaycaption2"
        Me.txtdaycaption2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption2.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption2.TabIndex = 52
        Me.txtdaycaption2.Text = "Tuesday"
        '
        'txtdaycaption1
        '
        Me.txtdaycaption1.AcceptsReturn = True
        Me.txtdaycaption1.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption1.Location = New System.Drawing.Point(8, 48)
        Me.txtdaycaption1.MaxLength = 0
        Me.txtdaycaption1.Name = "txtdaycaption1"
        Me.txtdaycaption1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption1.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption1.TabIndex = 51
        Me.txtdaycaption1.Text = "Monday"
        '
        'txtdaycaption0
        '
        Me.txtdaycaption0.AcceptsReturn = True
        Me.txtdaycaption0.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaycaption0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaycaption0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaycaption0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaycaption0.Location = New System.Drawing.Point(8, 24)
        Me.txtdaycaption0.MaxLength = 0
        Me.txtdaycaption0.Name = "txtdaycaption0"
        Me.txtdaycaption0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaycaption0.Size = New System.Drawing.Size(161, 20)
        Me.txtdaycaption0.TabIndex = 50
        Me.txtdaycaption0.Text = "Sunday"
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.cbotextsize)
        Me.Frame7.Controls.Add(Me.Command4)
        Me.Frame7.Controls.Add(Me.cbodaytextfont)
        Me.Frame7.Controls.Add(Me.Label23)
        Me.Frame7.Controls.Add(Me.Label18)
        Me.Frame7.Controls.Add(Me.Label17)
        Me.Frame7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(560, 544)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(153, 89)
        Me.Frame7.TabIndex = 44
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "Text"
        '
        'cbotextsize
        '
        Me.cbotextsize.BackColor = System.Drawing.SystemColors.Window
        Me.cbotextsize.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbotextsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotextsize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotextsize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbotextsize.Location = New System.Drawing.Point(72, 40)
        Me.cbotextsize.Name = "cbotextsize"
        Me.cbotextsize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbotextsize.Size = New System.Drawing.Size(73, 22)
        Me.cbotextsize.TabIndex = 70
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(72, 64)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(57, 17)
        Me.Command4.TabIndex = 48
        Me.Command4.Text = "Select"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'cbodaytextfont
        '
        Me.cbodaytextfont.BackColor = System.Drawing.SystemColors.Window
        Me.cbodaytextfont.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbodaytextfont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodaytextfont.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodaytextfont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbodaytextfont.Location = New System.Drawing.Point(40, 16)
        Me.cbodaytextfont.Name = "cbodaytextfont"
        Me.cbodaytextfont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbodaytextfont.Size = New System.Drawing.Size(105, 22)
        Me.cbodaytextfont.TabIndex = 46
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(56, 17)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "Font Size"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(56, 17)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "ForeColor"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(33, 17)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Font"
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.Enabled = False
        Me.Text3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(720, 440)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(161, 20)
        Me.Text3.TabIndex = 41
        '
        'txtCurrentDay
        '
        Me.txtCurrentDay.AcceptsReturn = True
        Me.txtCurrentDay.BackColor = System.Drawing.SystemColors.Window
        Me.txtCurrentDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrentDay.Enabled = False
        Me.txtCurrentDay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCurrentDay.Location = New System.Drawing.Point(848, 384)
        Me.txtCurrentDay.MaxLength = 0
        Me.txtCurrentDay.Name = "txtCurrentDay"
        Me.txtCurrentDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCurrentDay.Size = New System.Drawing.Size(41, 20)
        Me.txtCurrentDay.TabIndex = 40
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.txtdaytext)
        Me.Frame6.Controls.Add(Me.txtdayno)
        Me.Frame6.Controls.Add(Me.Command6)
        Me.Frame6.Controls.Add(Me.txtText)
        Me.Frame6.Controls.Add(Me.Label14)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(720, 248)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(185, 129)
        Me.Frame6.TabIndex = 34
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Text"
        '
        'txtdaytext
        '
        Me.txtdaytext.AcceptsReturn = True
        Me.txtdaytext.BackColor = System.Drawing.SystemColors.Window
        Me.txtdaytext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdaytext.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaytext.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdaytext.Location = New System.Drawing.Point(56, 56)
        Me.txtdaytext.MaxLength = 0
        Me.txtdaytext.Name = "txtdaytext"
        Me.txtdaytext.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdaytext.Size = New System.Drawing.Size(121, 20)
        Me.txtdaytext.TabIndex = 39
        Me.txtdaytext.Text = "enter your text"
        '
        'txtdayno
        '
        Me.txtdayno.AcceptsReturn = True
        Me.txtdayno.BackColor = System.Drawing.SystemColors.Window
        Me.txtdayno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdayno.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdayno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdayno.Location = New System.Drawing.Point(56, 24)
        Me.txtdayno.MaxLength = 0
        Me.txtdayno.Name = "txtdayno"
        Me.txtdayno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdayno.Size = New System.Drawing.Size(81, 20)
        Me.txtdayno.TabIndex = 36
        Me.txtdayno.Text = "1"
        '
        'Command6
        '
        Me.Command6.BackColor = System.Drawing.SystemColors.Control
        Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command6.Location = New System.Drawing.Point(56, 80)
        Me.Command6.Name = "Command6"
        Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command6.Size = New System.Drawing.Size(41, 25)
        Me.Command6.TabIndex = 35
        Me.Command6.Text = "Set"
        Me.Command6.UseVisualStyleBackColor = False
        '
        'txtText
        '
        Me.txtText.BackColor = System.Drawing.SystemColors.Control
        Me.txtText.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtText.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtText.Location = New System.Drawing.Point(8, 56)
        Me.txtText.Name = "txtText"
        Me.txtText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtText.Size = New System.Drawing.Size(41, 25)
        Me.txtText.TabIndex = 38
        Me.txtText.Text = "Text"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(33, 33)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Day"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.txtDay)
        Me.Frame5.Controls.Add(Me.txtMonth)
        Me.Frame5.Controls.Add(Me.txtYear)
        Me.Frame5.Controls.Add(Me.Command5)
        Me.Frame5.Controls.Add(Me.Label13)
        Me.Frame5.Controls.Add(Me.Label12)
        Me.Frame5.Controls.Add(Me.Label11)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(718, 136)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(185, 106)
        Me.Frame5.TabIndex = 26
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Highlight"
        '
        'txtDay
        '
        Me.txtDay.AcceptsReturn = True
        Me.txtDay.BackColor = System.Drawing.SystemColors.Window
        Me.txtDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDay.Location = New System.Drawing.Point(56, 72)
        Me.txtDay.MaxLength = 0
        Me.txtDay.Name = "txtDay"
        Me.txtDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDay.Size = New System.Drawing.Size(73, 20)
        Me.txtDay.TabIndex = 33
        Me.txtDay.Text = "1"
        '
        'txtMonth
        '
        Me.txtMonth.AcceptsReturn = True
        Me.txtMonth.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMonth.Location = New System.Drawing.Point(56, 48)
        Me.txtMonth.MaxLength = 0
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMonth.Size = New System.Drawing.Size(73, 20)
        Me.txtMonth.TabIndex = 31
        Me.txtMonth.Text = "1"
        '
        'txtYear
        '
        Me.txtYear.AcceptsReturn = True
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.Location = New System.Drawing.Point(56, 24)
        Me.txtYear.MaxLength = 0
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(73, 20)
        Me.txtYear.TabIndex = 29
        Me.txtYear.Text = "2005"
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(136, 72)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(41, 25)
        Me.Command5.TabIndex = 27
        Me.Command5.Text = "Set"
        Me.Command5.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Day"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Month"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(41, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Year"
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cmdgo)
        Me.Frame4.Controls.Add(Me.Text2)
        Me.Frame4.Controls.Add(Me.Text1)
        Me.Frame4.Controls.Add(Me.Label10)
        Me.Frame4.Controls.Add(Me.Label8)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(720, 0)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(185, 89)
        Me.Frame4.TabIndex = 20
        Me.Frame4.TabStop = False
        '
        'cmdgo
        '
        Me.cmdgo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdgo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdgo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdgo.Location = New System.Drawing.Point(112, 56)
        Me.cmdgo.Name = "cmdgo"
        Me.cmdgo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdgo.Size = New System.Drawing.Size(49, 27)
        Me.cmdgo.TabIndex = 25
        Me.cmdgo.Text = "GO"
        Me.cmdgo.UseVisualStyleBackColor = False
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(48, 56)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(49, 20)
        Me.Text2.TabIndex = 24
        Me.Text2.Text = "2005"
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(48, 24)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(49, 20)
        Me.Text1.TabIndex = 23
        Me.Text1.Text = "1"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(33, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Year"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Month"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.cbodayfont)
        Me.Frame3.Controls.Add(Me.Command3)
        Me.Frame3.Controls.Add(Me.Label9)
        Me.Frame3.Controls.Add(Me.Label7)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(376, 544)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(177, 89)
        Me.Frame3.TabIndex = 15
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Day "
        '
        'cbodayfont
        '
        Me.cbodayfont.BackColor = System.Drawing.SystemColors.Window
        Me.cbodayfont.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbodayfont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodayfont.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodayfont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbodayfont.Location = New System.Drawing.Point(64, 24)
        Me.cbodayfont.Name = "cbodayfont"
        Me.cbodayfont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbodayfont.Size = New System.Drawing.Size(105, 22)
        Me.cbodayfont.TabIndex = 17
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(64, 56)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(57, 17)
        Me.Command3.TabIndex = 16
        Me.Command3.Text = "Select"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Font"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ForeColor"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Command2)
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.Controls.Add(Me.cbodaycaption)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(200, 544)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(169, 113)
        Me.Frame2.TabIndex = 8
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Day Caption"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(64, 88)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(57, 17)
        Me.Command2.TabIndex = 14
        Me.Command2.Text = "Select"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(64, 56)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(57, 17)
        Me.Command1.TabIndex = 13
        Me.Command1.Text = "Select"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'cbodaycaption
        '
        Me.cbodaycaption.BackColor = System.Drawing.SystemColors.Window
        Me.cbodaycaption.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbodaycaption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodaycaption.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodaycaption.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbodaycaption.Location = New System.Drawing.Point(64, 24)
        Me.cbodaycaption.Name = "cbodaycaption"
        Me.cbodaycaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbodaycaption.Size = New System.Drawing.Size(97, 22)
        Me.cbodaycaption.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ForeColor"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "BackColor"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Font"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdmonthyearforecolor)
        Me.Frame1.Controls.Add(Me.cmdmonthyearbackcolor)
        Me.Frame1.Controls.Add(Me.cbofont)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 544)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(185, 113)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Month Year"
        '
        'cmdmonthyearforecolor
        '
        Me.cmdmonthyearforecolor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdmonthyearforecolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdmonthyearforecolor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmonthyearforecolor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdmonthyearforecolor.Location = New System.Drawing.Point(72, 88)
        Me.cmdmonthyearforecolor.Name = "cmdmonthyearforecolor"
        Me.cmdmonthyearforecolor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdmonthyearforecolor.Size = New System.Drawing.Size(57, 17)
        Me.cmdmonthyearforecolor.TabIndex = 7
        Me.cmdmonthyearforecolor.Text = "Select"
        Me.cmdmonthyearforecolor.UseVisualStyleBackColor = False
        '
        'cmdmonthyearbackcolor
        '
        Me.cmdmonthyearbackcolor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdmonthyearbackcolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdmonthyearbackcolor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmonthyearbackcolor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdmonthyearbackcolor.Location = New System.Drawing.Point(72, 56)
        Me.cmdmonthyearbackcolor.Name = "cmdmonthyearbackcolor"
        Me.cmdmonthyearbackcolor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdmonthyearbackcolor.Size = New System.Drawing.Size(57, 17)
        Me.cmdmonthyearbackcolor.TabIndex = 5
        Me.cmdmonthyearbackcolor.Text = "Select"
        Me.cmdmonthyearbackcolor.UseVisualStyleBackColor = False
        '
        'cbofont
        '
        Me.cbofont.BackColor = System.Drawing.SystemColors.Window
        Me.cbofont.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbofont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofont.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbofont.Location = New System.Drawing.Point(72, 24)
        Me.cbofont.Name = "cbofont"
        Me.cbofont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbofont.Size = New System.Drawing.Size(105, 22)
        Me.cbofont.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ForeColor"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BackColor"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Font"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(720, 424)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(113, 17)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Current Selected Text"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(720, 384)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(113, 17)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Current Selected Day"
        '
        'AxCalendar1
        '
        Me.AxCalendar1.Enabled = True
        Me.AxCalendar1.Location = New System.Drawing.Point(13, 17)
        Me.AxCalendar1.Name = "AxCalendar1"
        Me.AxCalendar1.OcxState = CType(resources.GetObject("AxCalendar1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar1.Size = New System.Drawing.Size(691, 511)
        Me.AxCalendar1.TabIndex = 59
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtsetday)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(721, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 41)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsetday
        '
        Me.txtsetday.Location = New System.Drawing.Point(53, 16)
        Me.txtsetday.Name = "txtsetday"
        Me.txtsetday.Size = New System.Drawing.Size(42, 20)
        Me.txtsetday.TabIndex = 1
        Me.txtsetday.Text = "15"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 14)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Day"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(915, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AxCalendar1)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.txtCurrentDay)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Calendar ActiveX Control Demo"
        Me.Frame9.ResumeLayout(False)
        Me.Frame9.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Form1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form1()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As Form1)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region


    Private Sub cbodaycaption_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbodaycaption.SelectedIndexChanged
        Me.AxCalendar1.DayCaptionFont = cbodaycaption.Text
    End Sub

    Private Sub cbodayfont_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbodayfont.SelectedIndexChanged
        Me.AxCalendar1.DayFont = cbodayfont.Text
    End Sub


    Private Sub cbodaytextfont_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbodaytextfont.SelectedIndexChanged
        Me.AxCalendar1.DayTextFont = cbodaytextfont.Text
    End Sub

    Private Sub cbofont_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbofont.SelectedIndexChanged
        Me.AxCalendar1.MonthYearFont = cbofont.Text

    End Sub

    Private Sub cbotextsize_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbotextsize.SelectedIndexChanged
        Me.AxCalendar1.DayTextFontSize = cbotextsize.Text
    End Sub

    Private Sub cmdchangedaycap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdchangedaycap.Click
        Me.AxCalendar1.SetDayCaptions(0, txtdaycaption0.Text)
        Me.AxCalendar1.SetDayCaptions(1, txtdaycaption1.Text)
        Me.AxCalendar1.SetDayCaptions(2, txtdaycaption2.Text)
        Me.AxCalendar1.SetDayCaptions(3, txtdaycaption3.Text)
        Me.AxCalendar1.SetDayCaptions(4, txtdaycaption4.Text)
        Me.AxCalendar1.SetDayCaptions(5, txtdaycaption5.Text)
        Me.AxCalendar1.SetDayCaptions(6, txtdaycaption6.Text)

    End Sub

    Private Sub cmdclearhighrange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdclearhighrange.Click
        Dim clrColor As Color
        Dim i As Object
        Me.AxCalendar1.Month = CShort(txtmonthrange.Text)
        Me.AxCalendar1.Year = CShort(txtyearrange.Text)
        clrColor = Color.FromArgb(255, 255, 255)


        For i = CInt(txtselfrom.Text) To CInt(txtselto.Text)

            Me.AxCalendar1.SetText(i, "")
            Me.AxCalendar1.DayTextColor = System.Drawing.Color.Red
            Me.AxCalendar1.SetHighLightDay(AxCalendar1.Year, AxCalendar1.Month, i, Color2Uint32(clrColor))

        Next

        Me.AxCalendar1.Redraw()
    End Sub

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function
    Private Sub cmdgo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdgo.Click
        Me.AxCalendar1.Month = CShort(Text1.Text)
        Me.AxCalendar1.Year = CShort(Text2.Text)
    End Sub

    Private Sub cmdhighrange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdhighrange.Click
        Dim i As Object
        Dim clrColor As Color

        clrColor = Color.FromArgb(128, 128, 128)
        Me.AxCalendar1.Month = CShort(txtmonthrange.Text)
        Me.AxCalendar1.Year = CShort(txtyearrange.Text)

        For i = CInt(txtselfrom.Text) To CInt(txtselto.Text)

            Me.AxCalendar1.SetText(i, Str(i))
            Me.AxCalendar1.DayTextColor = System.Drawing.Color.Red
            Me.AxCalendar1.SetHighLightDay(AxCalendar1.Year, AxCalendar1.Month, i, Color2Uint32(clrColor))

        Next

        Me.AxCalendar1.Redraw()

    End Sub

    Private Sub cmdmonthyearbackcolor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdmonthyearbackcolor.Click
        ColorDialog1.ShowDialog()

        Me.AxCalendar1.MonthYearBackColor = ColorDialog1.Color
    End Sub

    Private Sub cmdmonthyearforecolor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdmonthyearforecolor.Click

        ColorDialog1.ShowDialog()

        Me.AxCalendar1.MonthYearForeColor = ColorDialog1.Color

    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar1.DayCaptionBackColor = ColorDialog1.Color

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        ColorDialog1.ShowDialog()

        Me.AxCalendar1.DayCaptionForeColor = ColorDialog1.Color


    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        ColorDialog1.ShowDialog()

        Me.AxCalendar1.DayColor = ColorDialog1.Color

    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click

        ColorDialog1.ShowDialog()

        Me.AxCalendar1.DayTextColor = ColorDialog1.Color

    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click

        ColorDialog1.ShowDialog()


        Me.AxCalendar1.SetHighLightDay(CShort(txtYear.Text), CShort(txtMonth.Text), CShort(txtDay.Text), Color2Uint32(ColorDialog1.Color))
    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        Me.AxCalendar1.SetText(CShort(txtdayno.Text), txtdaytext.Text)
    End Sub



    Private Sub Command8_Click()

    End Sub

    Private Sub Command7_Click()


    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Text2.Text = CStr(Me.AxCalendar1.Year)
        Text1.Text = CStr(Me.AxCalendar1.Month)

        txtYear.Text = CStr(Me.AxCalendar1.Year)
        txtMonth.Text = CStr(Me.AxCalendar1.Month)

        txtyearrange.Text = CStr(Me.AxCalendar1.Year)
        txtmonthrange.Text = CStr(Me.AxCalendar1.Month)

        cbofont.Items.Add("Arial")
        cbofont.Items.Add("Arial Black")
        cbofont.Items.Add("Courier New")
        cbofont.Items.Add("MS Sans Serif")
        cbofont.Items.Add("Tahoma")
        cbofont.Items.Add("Times New Roman")
        cbofont.SelectedIndex = 0

        cbodaycaption.Items.Add("Arial")
        cbodaycaption.Items.Add("Arial Black")
        cbodaycaption.Items.Add("Courier New")
        cbodaycaption.Items.Add("MS Sans Serif")
        cbodaycaption.Items.Add("Tahoma")
        cbodaycaption.Items.Add("Times New Roman")
        cbodaycaption.SelectedIndex = 0

        cbodayfont.Items.Add("Arial")
        cbodayfont.Items.Add("Arial Black")
        cbodayfont.Items.Add("Courier New")
        cbodayfont.Items.Add("MS Sans Serif")
        cbodayfont.Items.Add("Tahoma")
        cbodayfont.Items.Add("Times New Roman")
        cbodayfont.SelectedIndex = 0


        cbodaytextfont.Items.Add("Arial")
        cbodaytextfont.Items.Add("Arial Black")
        cbodaytextfont.Items.Add("Courier New")
        cbodaytextfont.Items.Add("MS Sans Serif")
        cbodaytextfont.Items.Add("Tahoma")
        cbodaytextfont.Items.Add("Times New Roman")
        cbodaytextfont.SelectedIndex = 0

        cbotextsize.Items.Add("8")
        cbotextsize.Items.Add("10")
        cbotextsize.Items.Add("12")
        cbotextsize.Items.Add("14")
        cbotextsize.Items.Add("16")
        cbotextsize.Items.Add("18")
        cbotextsize.SelectedIndex = 0

    End Sub



    Private Sub AxCalendar1_OnDayClick(sender As System.Object, e As AxCALENDARLib._DCalendarEvents_OnDayClickEvent) Handles AxCalendar1.OnDayClick
        txtCurrentDay.Text = CStr(e.iDay)
        Text3.Text = e.strText
    End Sub

    Private Sub AxCalendar1_Activate(sender As System.Object, e As System.EventArgs) Handles AxCalendar1.Activate
        '''''''' if you need load the text when the form loaded, do in this event, do not do in form load event

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxCalendar1.Day = txtsetday.Text
    End Sub
End Class