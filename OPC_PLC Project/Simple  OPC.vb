Public Class SimpleOPCInterface
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  Do not modify it using the code editor.
    Public WithEvents OPCItemSyncReadButton_9 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_8 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_7 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_6 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_5 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_4 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_3 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_2 As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_1 As System.Windows.Forms.Button
    Public WithEvents OPCItemActiveState_9 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_8 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_7 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_6 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_5 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_4 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_3 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_2 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemActiveState_1 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemWriteButton_9 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_8 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_7 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_6 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_5 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_4 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_3 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_2 As System.Windows.Forms.Button
    Public WithEvents OPCItemWriteButton_1 As System.Windows.Forms.Button
    Public WithEvents OPCItemValueToWrite_9 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_8 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_7 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_6 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_5 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_4 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_3 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_2 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValueToWrite_1 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_9 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_8 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_7 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_6 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_5 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_4 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_3 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_2 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_1 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_9 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_8 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_7 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_6 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_5 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_4 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_3 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_2 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_1 As System.Windows.Forms.TextBox
    Public WithEvents OPCAddItems As System.Windows.Forms.Button
    Public WithEvents OPCItemName_9 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_8 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_7 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_6 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_5 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_4 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_3 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_2 As System.Windows.Forms.TextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents OPCItemName_1 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemName_0 As System.Windows.Forms.TextBox
    Public WithEvents OPCServerName As System.Windows.Forms.TextBox
    Public WithEvents AvailableOPCServerList As System.Windows.Forms.ListBox
    Public WithEvents ListOPCServers As System.Windows.Forms.Button
    Public WithEvents OPCServerConnect As System.Windows.Forms.Button
    Public WithEvents OPCGroupFrame As System.Windows.Forms.GroupBox
    Public WithEvents RemoveOPCGroup As System.Windows.Forms.Button
    Public WithEvents AddOPCGroup As System.Windows.Forms.Button
    Public WithEvents GroupActiveState As System.Windows.Forms.CheckBox
    Public WithEvents GroupDeadBand As System.Windows.Forms.TextBox
    Public WithEvents GroupUpdateRate As System.Windows.Forms.TextBox
    Public WithEvents OPCGroupName As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ExitExample As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents OPCNodeName As System.Windows.Forms.TextBox
    Public WithEvents DisconnectFromServer As System.Windows.Forms.Button
    Public WithEvents lblOPCNodeName As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents OPCRemoveItems As System.Windows.Forms.Button
    Public WithEvents OPCItemSyncReadButton_0 As System.Windows.Forms.Button
    Public WithEvents OPCItemActiveState_0 As System.Windows.Forms.CheckBox
    Public WithEvents OPCItemWriteButton_0 As System.Windows.Forms.Button
    Public WithEvents OPCItemValueToWrite_0 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemQuality_0 As System.Windows.Forms.TextBox
    Public WithEvents OPCItemValue_0 As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OPCItemSyncReadButton_9 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_8 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_7 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_6 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_5 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_4 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_3 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_2 = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_1 = New System.Windows.Forms.Button()
        Me.OPCItemActiveState_9 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_8 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_7 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_6 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_5 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_4 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_3 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_2 = New System.Windows.Forms.CheckBox()
        Me.OPCItemActiveState_1 = New System.Windows.Forms.CheckBox()
        Me.OPCItemWriteButton_9 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_8 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_7 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_6 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_5 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_4 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_3 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_2 = New System.Windows.Forms.Button()
        Me.OPCItemWriteButton_1 = New System.Windows.Forms.Button()
        Me.OPCItemValueToWrite_9 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_8 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_7 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_6 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_5 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_4 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_3 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_2 = New System.Windows.Forms.TextBox()
        Me.OPCItemValueToWrite_1 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_9 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_8 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_7 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_6 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_5 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_4 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_3 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_2 = New System.Windows.Forms.TextBox()
        Me.OPCItemQuality_1 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_9 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_8 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_7 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_6 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_5 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_4 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_3 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_2 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_1 = New System.Windows.Forms.TextBox()
        Me.OPCAddItems = New System.Windows.Forms.Button()
        Me.OPCItemName_9 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_8 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_7 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_6 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_5 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_4 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_3 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_2 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OPCItemName_1 = New System.Windows.Forms.TextBox()
        Me.OPCItemName_0 = New System.Windows.Forms.TextBox()
        Me.OPCServerName = New System.Windows.Forms.TextBox()
        Me.AvailableOPCServerList = New System.Windows.Forms.ListBox()
        Me.ListOPCServers = New System.Windows.Forms.Button()
        Me.OPCServerConnect = New System.Windows.Forms.Button()
        Me.RemoveOPCGroup = New System.Windows.Forms.Button()
        Me.AddOPCGroup = New System.Windows.Forms.Button()
        Me.GroupActiveState = New System.Windows.Forms.CheckBox()
        Me.GroupDeadBand = New System.Windows.Forms.TextBox()
        Me.GroupUpdateRate = New System.Windows.Forms.TextBox()
        Me.OPCGroupName = New System.Windows.Forms.TextBox()
        Me.OPCNodeName = New System.Windows.Forms.TextBox()
        Me.DisconnectFromServer = New System.Windows.Forms.Button()
        Me.OPCRemoveItems = New System.Windows.Forms.Button()
        Me.OPCItemSyncReadButton_0 = New System.Windows.Forms.Button()
        Me.OPCItemActiveState_0 = New System.Windows.Forms.CheckBox()
        Me.OPCItemWriteButton_0 = New System.Windows.Forms.Button()
        Me.OPCItemValueToWrite_0 = New System.Windows.Forms.TextBox()
        Me.OPCGroupFrame = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitExample = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.lblOPCNodeName = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.OPCItemQuality_0 = New System.Windows.Forms.TextBox()
        Me.OPCItemValue_0 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OPCGroupFrame.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OPCItemSyncReadButton_9
        '
        Me.OPCItemSyncReadButton_9.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_9.Enabled = False
        Me.OPCItemSyncReadButton_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_9.Location = New System.Drawing.Point(580, 517)
        Me.OPCItemSyncReadButton_9.Name = "OPCItemSyncReadButton_9"
        Me.OPCItemSyncReadButton_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_9.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_9.TabIndex = 165
        Me.OPCItemSyncReadButton_9.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_9, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_9.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_8
        '
        Me.OPCItemSyncReadButton_8.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_8.Enabled = False
        Me.OPCItemSyncReadButton_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_8.Location = New System.Drawing.Point(580, 488)
        Me.OPCItemSyncReadButton_8.Name = "OPCItemSyncReadButton_8"
        Me.OPCItemSyncReadButton_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_8.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_8.TabIndex = 164
        Me.OPCItemSyncReadButton_8.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_8, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_8.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_7
        '
        Me.OPCItemSyncReadButton_7.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_7.Enabled = False
        Me.OPCItemSyncReadButton_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_7.Location = New System.Drawing.Point(580, 459)
        Me.OPCItemSyncReadButton_7.Name = "OPCItemSyncReadButton_7"
        Me.OPCItemSyncReadButton_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_7.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_7.TabIndex = 163
        Me.OPCItemSyncReadButton_7.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_7, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_7.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_6
        '
        Me.OPCItemSyncReadButton_6.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_6.Enabled = False
        Me.OPCItemSyncReadButton_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_6.Location = New System.Drawing.Point(580, 430)
        Me.OPCItemSyncReadButton_6.Name = "OPCItemSyncReadButton_6"
        Me.OPCItemSyncReadButton_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_6.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_6.TabIndex = 162
        Me.OPCItemSyncReadButton_6.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_6, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_6.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_5
        '
        Me.OPCItemSyncReadButton_5.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_5.Enabled = False
        Me.OPCItemSyncReadButton_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_5.Location = New System.Drawing.Point(580, 401)
        Me.OPCItemSyncReadButton_5.Name = "OPCItemSyncReadButton_5"
        Me.OPCItemSyncReadButton_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_5.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_5.TabIndex = 161
        Me.OPCItemSyncReadButton_5.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_5, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_5.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_4
        '
        Me.OPCItemSyncReadButton_4.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_4.Enabled = False
        Me.OPCItemSyncReadButton_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_4.Location = New System.Drawing.Point(580, 372)
        Me.OPCItemSyncReadButton_4.Name = "OPCItemSyncReadButton_4"
        Me.OPCItemSyncReadButton_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_4.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_4.TabIndex = 160
        Me.OPCItemSyncReadButton_4.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_4, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_4.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_3
        '
        Me.OPCItemSyncReadButton_3.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_3.Enabled = False
        Me.OPCItemSyncReadButton_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_3.Location = New System.Drawing.Point(580, 343)
        Me.OPCItemSyncReadButton_3.Name = "OPCItemSyncReadButton_3"
        Me.OPCItemSyncReadButton_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_3.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_3.TabIndex = 159
        Me.OPCItemSyncReadButton_3.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_3, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_3.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_2
        '
        Me.OPCItemSyncReadButton_2.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_2.Enabled = False
        Me.OPCItemSyncReadButton_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_2.Location = New System.Drawing.Point(580, 314)
        Me.OPCItemSyncReadButton_2.Name = "OPCItemSyncReadButton_2"
        Me.OPCItemSyncReadButton_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_2.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_2.TabIndex = 158
        Me.OPCItemSyncReadButton_2.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_2, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_2.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_1
        '
        Me.OPCItemSyncReadButton_1.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_1.Enabled = False
        Me.OPCItemSyncReadButton_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_1.Location = New System.Drawing.Point(580, 287)
        Me.OPCItemSyncReadButton_1.Name = "OPCItemSyncReadButton_1"
        Me.OPCItemSyncReadButton_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_1.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_1.TabIndex = 157
        Me.OPCItemSyncReadButton_1.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_1, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_1.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_9
        '
        Me.OPCItemActiveState_9.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_9.Checked = True
        Me.OPCItemActiveState_9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_9.Enabled = False
        Me.OPCItemActiveState_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_9.Location = New System.Drawing.Point(508, 523)
        Me.OPCItemActiveState_9.Name = "OPCItemActiveState_9"
        Me.OPCItemActiveState_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_9.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_9.TabIndex = 156
        Me.OPCItemActiveState_9.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_9, "Click here to change the active state of this item")
        Me.OPCItemActiveState_9.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_8
        '
        Me.OPCItemActiveState_8.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_8.Checked = True
        Me.OPCItemActiveState_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_8.Enabled = False
        Me.OPCItemActiveState_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_8.Location = New System.Drawing.Point(508, 494)
        Me.OPCItemActiveState_8.Name = "OPCItemActiveState_8"
        Me.OPCItemActiveState_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_8.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_8.TabIndex = 155
        Me.OPCItemActiveState_8.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_8, "Click here to change the active state of this item")
        Me.OPCItemActiveState_8.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_7
        '
        Me.OPCItemActiveState_7.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_7.Checked = True
        Me.OPCItemActiveState_7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_7.Enabled = False
        Me.OPCItemActiveState_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_7.Location = New System.Drawing.Point(508, 465)
        Me.OPCItemActiveState_7.Name = "OPCItemActiveState_7"
        Me.OPCItemActiveState_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_7.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_7.TabIndex = 154
        Me.OPCItemActiveState_7.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_7, "Click here to change the active state of this item")
        Me.OPCItemActiveState_7.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_6
        '
        Me.OPCItemActiveState_6.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_6.Checked = True
        Me.OPCItemActiveState_6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_6.Enabled = False
        Me.OPCItemActiveState_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_6.Location = New System.Drawing.Point(508, 436)
        Me.OPCItemActiveState_6.Name = "OPCItemActiveState_6"
        Me.OPCItemActiveState_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_6.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_6.TabIndex = 153
        Me.OPCItemActiveState_6.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_6, "Click here to change the active state of this item")
        Me.OPCItemActiveState_6.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_5
        '
        Me.OPCItemActiveState_5.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_5.Checked = True
        Me.OPCItemActiveState_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_5.Enabled = False
        Me.OPCItemActiveState_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_5.Location = New System.Drawing.Point(508, 407)
        Me.OPCItemActiveState_5.Name = "OPCItemActiveState_5"
        Me.OPCItemActiveState_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_5.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_5.TabIndex = 152
        Me.OPCItemActiveState_5.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_5, "Click here to change the active state of this item")
        Me.OPCItemActiveState_5.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_4
        '
        Me.OPCItemActiveState_4.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_4.Checked = True
        Me.OPCItemActiveState_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_4.Enabled = False
        Me.OPCItemActiveState_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_4.Location = New System.Drawing.Point(508, 378)
        Me.OPCItemActiveState_4.Name = "OPCItemActiveState_4"
        Me.OPCItemActiveState_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_4.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_4.TabIndex = 151
        Me.OPCItemActiveState_4.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_4, "Click here to change the active state of this item")
        Me.OPCItemActiveState_4.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_3
        '
        Me.OPCItemActiveState_3.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_3.Checked = True
        Me.OPCItemActiveState_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_3.Enabled = False
        Me.OPCItemActiveState_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_3.Location = New System.Drawing.Point(508, 349)
        Me.OPCItemActiveState_3.Name = "OPCItemActiveState_3"
        Me.OPCItemActiveState_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_3.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_3.TabIndex = 150
        Me.OPCItemActiveState_3.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_3, "Click here to change the active state of this item")
        Me.OPCItemActiveState_3.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_2
        '
        Me.OPCItemActiveState_2.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_2.Checked = True
        Me.OPCItemActiveState_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_2.Enabled = False
        Me.OPCItemActiveState_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_2.Location = New System.Drawing.Point(508, 320)
        Me.OPCItemActiveState_2.Name = "OPCItemActiveState_2"
        Me.OPCItemActiveState_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_2.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_2.TabIndex = 149
        Me.OPCItemActiveState_2.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_2, "Click here to change the active state of this item")
        Me.OPCItemActiveState_2.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_1
        '
        Me.OPCItemActiveState_1.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_1.Checked = True
        Me.OPCItemActiveState_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_1.Enabled = False
        Me.OPCItemActiveState_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_1.Location = New System.Drawing.Point(508, 293)
        Me.OPCItemActiveState_1.Name = "OPCItemActiveState_1"
        Me.OPCItemActiveState_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_1.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_1.TabIndex = 148
        Me.OPCItemActiveState_1.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_1, "Click here to change the active state of this item")
        Me.OPCItemActiveState_1.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_9
        '
        Me.OPCItemWriteButton_9.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_9.Enabled = False
        Me.OPCItemWriteButton_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_9.Location = New System.Drawing.Point(428, 517)
        Me.OPCItemWriteButton_9.Name = "OPCItemWriteButton_9"
        Me.OPCItemWriteButton_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_9.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_9.TabIndex = 147
        Me.OPCItemWriteButton_9.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_9, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_9.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_8
        '
        Me.OPCItemWriteButton_8.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_8.Enabled = False
        Me.OPCItemWriteButton_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_8.Location = New System.Drawing.Point(428, 488)
        Me.OPCItemWriteButton_8.Name = "OPCItemWriteButton_8"
        Me.OPCItemWriteButton_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_8.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_8.TabIndex = 146
        Me.OPCItemWriteButton_8.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_8, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_8.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_7
        '
        Me.OPCItemWriteButton_7.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_7.Enabled = False
        Me.OPCItemWriteButton_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_7.Location = New System.Drawing.Point(428, 459)
        Me.OPCItemWriteButton_7.Name = "OPCItemWriteButton_7"
        Me.OPCItemWriteButton_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_7.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_7.TabIndex = 145
        Me.OPCItemWriteButton_7.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_7, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_7.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_6
        '
        Me.OPCItemWriteButton_6.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_6.Enabled = False
        Me.OPCItemWriteButton_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_6.Location = New System.Drawing.Point(428, 430)
        Me.OPCItemWriteButton_6.Name = "OPCItemWriteButton_6"
        Me.OPCItemWriteButton_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_6.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_6.TabIndex = 144
        Me.OPCItemWriteButton_6.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_6, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_6.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_5
        '
        Me.OPCItemWriteButton_5.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_5.Enabled = False
        Me.OPCItemWriteButton_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_5.Location = New System.Drawing.Point(428, 401)
        Me.OPCItemWriteButton_5.Name = "OPCItemWriteButton_5"
        Me.OPCItemWriteButton_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_5.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_5.TabIndex = 143
        Me.OPCItemWriteButton_5.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_5, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_5.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_4
        '
        Me.OPCItemWriteButton_4.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_4.Enabled = False
        Me.OPCItemWriteButton_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_4.Location = New System.Drawing.Point(428, 372)
        Me.OPCItemWriteButton_4.Name = "OPCItemWriteButton_4"
        Me.OPCItemWriteButton_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_4.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_4.TabIndex = 142
        Me.OPCItemWriteButton_4.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_4, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_4.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_3
        '
        Me.OPCItemWriteButton_3.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_3.Enabled = False
        Me.OPCItemWriteButton_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_3.Location = New System.Drawing.Point(428, 343)
        Me.OPCItemWriteButton_3.Name = "OPCItemWriteButton_3"
        Me.OPCItemWriteButton_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_3.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_3.TabIndex = 141
        Me.OPCItemWriteButton_3.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_3, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_3.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_2
        '
        Me.OPCItemWriteButton_2.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_2.Enabled = False
        Me.OPCItemWriteButton_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_2.Location = New System.Drawing.Point(428, 314)
        Me.OPCItemWriteButton_2.Name = "OPCItemWriteButton_2"
        Me.OPCItemWriteButton_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_2.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_2.TabIndex = 140
        Me.OPCItemWriteButton_2.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_2, "Click here to send the value entered in the 'Value to Write' field")
        Me.OPCItemWriteButton_2.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_1
        '
        Me.OPCItemWriteButton_1.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_1.Enabled = False
        Me.OPCItemWriteButton_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_1.Location = New System.Drawing.Point(428, 287)
        Me.OPCItemWriteButton_1.Name = "OPCItemWriteButton_1"
        Me.OPCItemWriteButton_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_1.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_1.TabIndex = 139
        Me.OPCItemWriteButton_1.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_1, "Click here to send the value entered in the 'Value to Write' field using a Synchr" &
        "onous Write")
        Me.OPCItemWriteButton_1.UseVisualStyleBackColor = False
        '
        'OPCItemValueToWrite_9
        '
        Me.OPCItemValueToWrite_9.AcceptsReturn = True
        Me.OPCItemValueToWrite_9.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_9.Enabled = False
        Me.OPCItemValueToWrite_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_9.Location = New System.Drawing.Point(316, 521)
        Me.OPCItemValueToWrite_9.MaxLength = 0
        Me.OPCItemValueToWrite_9.Name = "OPCItemValueToWrite_9"
        Me.OPCItemValueToWrite_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_9.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_9.TabIndex = 138
        Me.OPCItemValueToWrite_9.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_9, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_8
        '
        Me.OPCItemValueToWrite_8.AcceptsReturn = True
        Me.OPCItemValueToWrite_8.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_8.Enabled = False
        Me.OPCItemValueToWrite_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_8.Location = New System.Drawing.Point(316, 492)
        Me.OPCItemValueToWrite_8.MaxLength = 0
        Me.OPCItemValueToWrite_8.Name = "OPCItemValueToWrite_8"
        Me.OPCItemValueToWrite_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_8.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_8.TabIndex = 137
        Me.OPCItemValueToWrite_8.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_8, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_7
        '
        Me.OPCItemValueToWrite_7.AcceptsReturn = True
        Me.OPCItemValueToWrite_7.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_7.Enabled = False
        Me.OPCItemValueToWrite_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_7.Location = New System.Drawing.Point(316, 463)
        Me.OPCItemValueToWrite_7.MaxLength = 0
        Me.OPCItemValueToWrite_7.Name = "OPCItemValueToWrite_7"
        Me.OPCItemValueToWrite_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_7.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_7.TabIndex = 136
        Me.OPCItemValueToWrite_7.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_7, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_6
        '
        Me.OPCItemValueToWrite_6.AcceptsReturn = True
        Me.OPCItemValueToWrite_6.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_6.Enabled = False
        Me.OPCItemValueToWrite_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_6.Location = New System.Drawing.Point(316, 434)
        Me.OPCItemValueToWrite_6.MaxLength = 0
        Me.OPCItemValueToWrite_6.Name = "OPCItemValueToWrite_6"
        Me.OPCItemValueToWrite_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_6.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_6.TabIndex = 135
        Me.OPCItemValueToWrite_6.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_6, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_5
        '
        Me.OPCItemValueToWrite_5.AcceptsReturn = True
        Me.OPCItemValueToWrite_5.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_5.Enabled = False
        Me.OPCItemValueToWrite_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_5.Location = New System.Drawing.Point(316, 405)
        Me.OPCItemValueToWrite_5.MaxLength = 0
        Me.OPCItemValueToWrite_5.Name = "OPCItemValueToWrite_5"
        Me.OPCItemValueToWrite_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_5.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_5.TabIndex = 134
        Me.OPCItemValueToWrite_5.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_5, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_4
        '
        Me.OPCItemValueToWrite_4.AcceptsReturn = True
        Me.OPCItemValueToWrite_4.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_4.Enabled = False
        Me.OPCItemValueToWrite_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_4.Location = New System.Drawing.Point(316, 376)
        Me.OPCItemValueToWrite_4.MaxLength = 0
        Me.OPCItemValueToWrite_4.Name = "OPCItemValueToWrite_4"
        Me.OPCItemValueToWrite_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_4.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_4.TabIndex = 133
        Me.OPCItemValueToWrite_4.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_4, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_3
        '
        Me.OPCItemValueToWrite_3.AcceptsReturn = True
        Me.OPCItemValueToWrite_3.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_3.Enabled = False
        Me.OPCItemValueToWrite_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_3.Location = New System.Drawing.Point(316, 347)
        Me.OPCItemValueToWrite_3.MaxLength = 0
        Me.OPCItemValueToWrite_3.Name = "OPCItemValueToWrite_3"
        Me.OPCItemValueToWrite_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_3.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_3.TabIndex = 132
        Me.OPCItemValueToWrite_3.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_3, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_2
        '
        Me.OPCItemValueToWrite_2.AcceptsReturn = True
        Me.OPCItemValueToWrite_2.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_2.Enabled = False
        Me.OPCItemValueToWrite_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_2.Location = New System.Drawing.Point(316, 318)
        Me.OPCItemValueToWrite_2.MaxLength = 0
        Me.OPCItemValueToWrite_2.Name = "OPCItemValueToWrite_2"
        Me.OPCItemValueToWrite_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_2.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_2.TabIndex = 131
        Me.OPCItemValueToWrite_2.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_2, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemValueToWrite_1
        '
        Me.OPCItemValueToWrite_1.AcceptsReturn = True
        Me.OPCItemValueToWrite_1.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_1.Enabled = False
        Me.OPCItemValueToWrite_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_1.Location = New System.Drawing.Point(316, 291)
        Me.OPCItemValueToWrite_1.MaxLength = 0
        Me.OPCItemValueToWrite_1.Name = "OPCItemValueToWrite_1"
        Me.OPCItemValueToWrite_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_1.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_1.TabIndex = 130
        Me.OPCItemValueToWrite_1.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_1, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCItemQuality_9
        '
        Me.OPCItemQuality_9.AcceptsReturn = True
        Me.OPCItemQuality_9.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_9.Location = New System.Drawing.Point(660, 521)
        Me.OPCItemQuality_9.MaxLength = 0
        Me.OPCItemQuality_9.Name = "OPCItemQuality_9"
        Me.OPCItemQuality_9.ReadOnly = True
        Me.OPCItemQuality_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_9.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_9.TabIndex = 129
        '
        'OPCItemQuality_8
        '
        Me.OPCItemQuality_8.AcceptsReturn = True
        Me.OPCItemQuality_8.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_8.Location = New System.Drawing.Point(660, 492)
        Me.OPCItemQuality_8.MaxLength = 0
        Me.OPCItemQuality_8.Name = "OPCItemQuality_8"
        Me.OPCItemQuality_8.ReadOnly = True
        Me.OPCItemQuality_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_8.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_8.TabIndex = 128
        '
        'OPCItemQuality_7
        '
        Me.OPCItemQuality_7.AcceptsReturn = True
        Me.OPCItemQuality_7.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_7.Location = New System.Drawing.Point(660, 463)
        Me.OPCItemQuality_7.MaxLength = 0
        Me.OPCItemQuality_7.Name = "OPCItemQuality_7"
        Me.OPCItemQuality_7.ReadOnly = True
        Me.OPCItemQuality_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_7.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_7.TabIndex = 127
        '
        'OPCItemQuality_6
        '
        Me.OPCItemQuality_6.AcceptsReturn = True
        Me.OPCItemQuality_6.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_6.Location = New System.Drawing.Point(660, 434)
        Me.OPCItemQuality_6.MaxLength = 0
        Me.OPCItemQuality_6.Name = "OPCItemQuality_6"
        Me.OPCItemQuality_6.ReadOnly = True
        Me.OPCItemQuality_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_6.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_6.TabIndex = 126
        '
        'OPCItemQuality_5
        '
        Me.OPCItemQuality_5.AcceptsReturn = True
        Me.OPCItemQuality_5.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_5.Location = New System.Drawing.Point(660, 405)
        Me.OPCItemQuality_5.MaxLength = 0
        Me.OPCItemQuality_5.Name = "OPCItemQuality_5"
        Me.OPCItemQuality_5.ReadOnly = True
        Me.OPCItemQuality_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_5.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_5.TabIndex = 125
        '
        'OPCItemQuality_4
        '
        Me.OPCItemQuality_4.AcceptsReturn = True
        Me.OPCItemQuality_4.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_4.Location = New System.Drawing.Point(660, 376)
        Me.OPCItemQuality_4.MaxLength = 0
        Me.OPCItemQuality_4.Name = "OPCItemQuality_4"
        Me.OPCItemQuality_4.ReadOnly = True
        Me.OPCItemQuality_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_4.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_4.TabIndex = 124
        '
        'OPCItemQuality_3
        '
        Me.OPCItemQuality_3.AcceptsReturn = True
        Me.OPCItemQuality_3.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_3.Location = New System.Drawing.Point(660, 347)
        Me.OPCItemQuality_3.MaxLength = 0
        Me.OPCItemQuality_3.Name = "OPCItemQuality_3"
        Me.OPCItemQuality_3.ReadOnly = True
        Me.OPCItemQuality_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_3.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_3.TabIndex = 123
        '
        'OPCItemQuality_2
        '
        Me.OPCItemQuality_2.AcceptsReturn = True
        Me.OPCItemQuality_2.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_2.Location = New System.Drawing.Point(660, 318)
        Me.OPCItemQuality_2.MaxLength = 0
        Me.OPCItemQuality_2.Name = "OPCItemQuality_2"
        Me.OPCItemQuality_2.ReadOnly = True
        Me.OPCItemQuality_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_2.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_2.TabIndex = 122
        '
        'OPCItemQuality_1
        '
        Me.OPCItemQuality_1.AcceptsReturn = True
        Me.OPCItemQuality_1.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_1.Location = New System.Drawing.Point(660, 291)
        Me.OPCItemQuality_1.MaxLength = 0
        Me.OPCItemQuality_1.Name = "OPCItemQuality_1"
        Me.OPCItemQuality_1.ReadOnly = True
        Me.OPCItemQuality_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_1.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_1.TabIndex = 121
        '
        'OPCItemValue_9
        '
        Me.OPCItemValue_9.AcceptsReturn = True
        Me.OPCItemValue_9.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_9.Location = New System.Drawing.Point(212, 521)
        Me.OPCItemValue_9.MaxLength = 0
        Me.OPCItemValue_9.Name = "OPCItemValue_9"
        Me.OPCItemValue_9.ReadOnly = True
        Me.OPCItemValue_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_9.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_9.TabIndex = 120
        '
        'OPCItemValue_8
        '
        Me.OPCItemValue_8.AcceptsReturn = True
        Me.OPCItemValue_8.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_8.Location = New System.Drawing.Point(212, 492)
        Me.OPCItemValue_8.MaxLength = 0
        Me.OPCItemValue_8.Name = "OPCItemValue_8"
        Me.OPCItemValue_8.ReadOnly = True
        Me.OPCItemValue_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_8.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_8.TabIndex = 119
        '
        'OPCItemValue_7
        '
        Me.OPCItemValue_7.AcceptsReturn = True
        Me.OPCItemValue_7.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_7.Location = New System.Drawing.Point(212, 463)
        Me.OPCItemValue_7.MaxLength = 0
        Me.OPCItemValue_7.Name = "OPCItemValue_7"
        Me.OPCItemValue_7.ReadOnly = True
        Me.OPCItemValue_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_7.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_7.TabIndex = 118
        '
        'OPCItemValue_6
        '
        Me.OPCItemValue_6.AcceptsReturn = True
        Me.OPCItemValue_6.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_6.Location = New System.Drawing.Point(212, 434)
        Me.OPCItemValue_6.MaxLength = 0
        Me.OPCItemValue_6.Name = "OPCItemValue_6"
        Me.OPCItemValue_6.ReadOnly = True
        Me.OPCItemValue_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_6.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_6.TabIndex = 117
        '
        'OPCItemValue_5
        '
        Me.OPCItemValue_5.AcceptsReturn = True
        Me.OPCItemValue_5.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_5.Location = New System.Drawing.Point(212, 405)
        Me.OPCItemValue_5.MaxLength = 0
        Me.OPCItemValue_5.Name = "OPCItemValue_5"
        Me.OPCItemValue_5.ReadOnly = True
        Me.OPCItemValue_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_5.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_5.TabIndex = 116
        '
        'OPCItemValue_4
        '
        Me.OPCItemValue_4.AcceptsReturn = True
        Me.OPCItemValue_4.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_4.Location = New System.Drawing.Point(212, 376)
        Me.OPCItemValue_4.MaxLength = 0
        Me.OPCItemValue_4.Name = "OPCItemValue_4"
        Me.OPCItemValue_4.ReadOnly = True
        Me.OPCItemValue_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_4.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_4.TabIndex = 115
        '
        'OPCItemValue_3
        '
        Me.OPCItemValue_3.AcceptsReturn = True
        Me.OPCItemValue_3.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_3.Location = New System.Drawing.Point(212, 347)
        Me.OPCItemValue_3.MaxLength = 0
        Me.OPCItemValue_3.Name = "OPCItemValue_3"
        Me.OPCItemValue_3.ReadOnly = True
        Me.OPCItemValue_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_3.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_3.TabIndex = 114
        '
        'OPCItemValue_2
        '
        Me.OPCItemValue_2.AcceptsReturn = True
        Me.OPCItemValue_2.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_2.Location = New System.Drawing.Point(212, 318)
        Me.OPCItemValue_2.MaxLength = 0
        Me.OPCItemValue_2.Name = "OPCItemValue_2"
        Me.OPCItemValue_2.ReadOnly = True
        Me.OPCItemValue_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_2.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_2.TabIndex = 113
        '
        'OPCItemValue_1
        '
        Me.OPCItemValue_1.AcceptsReturn = True
        Me.OPCItemValue_1.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_1.Location = New System.Drawing.Point(212, 291)
        Me.OPCItemValue_1.MaxLength = 0
        Me.OPCItemValue_1.Name = "OPCItemValue_1"
        Me.OPCItemValue_1.ReadOnly = True
        Me.OPCItemValue_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_1.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_1.TabIndex = 112
        '
        'OPCAddItems
        '
        Me.OPCAddItems.BackColor = System.Drawing.SystemColors.Control
        Me.OPCAddItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCAddItems.Enabled = False
        Me.OPCAddItems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCAddItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCAddItems.Location = New System.Drawing.Point(300, 219)
        Me.OPCAddItems.Name = "OPCAddItems"
        Me.OPCAddItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCAddItems.Size = New System.Drawing.Size(121, 24)
        Me.OPCAddItems.TabIndex = 110
        Me.OPCAddItems.Text = "Add OPC Items"
        Me.ToolTip1.SetToolTip(Me.OPCAddItems, "Click here to add the OPC item names you have entered to the group")
        Me.OPCAddItems.UseVisualStyleBackColor = False
        '
        'OPCItemName_9
        '
        Me.OPCItemName_9.AcceptsReturn = True
        Me.OPCItemName_9.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_9.Enabled = False
        Me.OPCItemName_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_9.Location = New System.Drawing.Point(20, 521)
        Me.OPCItemName_9.MaxLength = 0
        Me.OPCItemName_9.Name = "OPCItemName_9"
        Me.OPCItemName_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_9.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_9.TabIndex = 109
        Me.OPCItemName_9.Text = "OPCItemName_9"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_9, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_8
        '
        Me.OPCItemName_8.AcceptsReturn = True
        Me.OPCItemName_8.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_8.Enabled = False
        Me.OPCItemName_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_8.Location = New System.Drawing.Point(20, 492)
        Me.OPCItemName_8.MaxLength = 0
        Me.OPCItemName_8.Name = "OPCItemName_8"
        Me.OPCItemName_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_8.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_8.TabIndex = 108
        Me.OPCItemName_8.Text = "OPCItemName_8"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_8, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_7
        '
        Me.OPCItemName_7.AcceptsReturn = True
        Me.OPCItemName_7.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_7.Enabled = False
        Me.OPCItemName_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_7.Location = New System.Drawing.Point(20, 463)
        Me.OPCItemName_7.MaxLength = 0
        Me.OPCItemName_7.Name = "OPCItemName_7"
        Me.OPCItemName_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_7.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_7.TabIndex = 107
        Me.OPCItemName_7.Text = "OPCItemName_7"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_7, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_6
        '
        Me.OPCItemName_6.AcceptsReturn = True
        Me.OPCItemName_6.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_6.Enabled = False
        Me.OPCItemName_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_6.Location = New System.Drawing.Point(20, 434)
        Me.OPCItemName_6.MaxLength = 0
        Me.OPCItemName_6.Name = "OPCItemName_6"
        Me.OPCItemName_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_6.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_6.TabIndex = 106
        Me.OPCItemName_6.Text = "OPCItemName_6"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_6, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_5
        '
        Me.OPCItemName_5.AcceptsReturn = True
        Me.OPCItemName_5.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_5.Enabled = False
        Me.OPCItemName_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_5.Location = New System.Drawing.Point(20, 405)
        Me.OPCItemName_5.MaxLength = 0
        Me.OPCItemName_5.Name = "OPCItemName_5"
        Me.OPCItemName_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_5.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_5.TabIndex = 105
        Me.OPCItemName_5.Text = "OPCItemName_5"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_5, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_4
        '
        Me.OPCItemName_4.AcceptsReturn = True
        Me.OPCItemName_4.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_4.Enabled = False
        Me.OPCItemName_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_4.Location = New System.Drawing.Point(20, 376)
        Me.OPCItemName_4.MaxLength = 0
        Me.OPCItemName_4.Name = "OPCItemName_4"
        Me.OPCItemName_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_4.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_4.TabIndex = 104
        Me.OPCItemName_4.Text = "OPCItemName_4"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_4, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_3
        '
        Me.OPCItemName_3.AcceptsReturn = True
        Me.OPCItemName_3.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_3.Enabled = False
        Me.OPCItemName_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_3.Location = New System.Drawing.Point(20, 347)
        Me.OPCItemName_3.MaxLength = 0
        Me.OPCItemName_3.Name = "OPCItemName_3"
        Me.OPCItemName_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_3.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_3.TabIndex = 103
        Me.OPCItemName_3.Text = "OPCItemName_3"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_3, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCItemName_2
        '
        Me.OPCItemName_2.AcceptsReturn = True
        Me.OPCItemName_2.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_2.Enabled = False
        Me.OPCItemName_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_2.Location = New System.Drawing.Point(20, 318)
        Me.OPCItemName_2.MaxLength = 0
        Me.OPCItemName_2.Name = "OPCItemName_2"
        Me.OPCItemName_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_2.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_2.TabIndex = 102
        Me.OPCItemName_2.Text = "OPCItemName_2"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_2, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'OPCItemName_1
        '
        Me.OPCItemName_1.AcceptsReturn = True
        Me.OPCItemName_1.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_1.Enabled = False
        Me.OPCItemName_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_1.Location = New System.Drawing.Point(20, 291)
        Me.OPCItemName_1.MaxLength = 0
        Me.OPCItemName_1.Name = "OPCItemName_1"
        Me.OPCItemName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_1.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_1.TabIndex = 101
        Me.OPCItemName_1.Text = "OPCItemName_1"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_1, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'OPCItemName_0
        '
        Me.OPCItemName_0.AcceptsReturn = True
        Me.OPCItemName_0.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemName_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemName_0.Enabled = False
        Me.OPCItemName_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemName_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemName_0.Location = New System.Drawing.Point(20, 265)
        Me.OPCItemName_0.MaxLength = 0
        Me.OPCItemName_0.Name = "OPCItemName_0"
        Me.OPCItemName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemName_0.Size = New System.Drawing.Size(185, 20)
        Me.OPCItemName_0.TabIndex = 100
        Me.OPCItemName_0.Text = "OPCItemName_0"
        Me.ToolTip1.SetToolTip(Me.OPCItemName_0, "Enter an OPC Item name in the form of ServerBranch.ServerItem (i.e. Channel1.Devi" &
        "ce1.R0, [PLCSHORTCUT]Tagname)")
        '
        'OPCServerName
        '
        Me.OPCServerName.AcceptsReturn = True
        Me.OPCServerName.BackColor = System.Drawing.SystemColors.Window
        Me.OPCServerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCServerName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCServerName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCServerName.Location = New System.Drawing.Point(101, 119)
        Me.OPCServerName.MaxLength = 0
        Me.OPCServerName.Name = "OPCServerName"
        Me.OPCServerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCServerName.Size = New System.Drawing.Size(152, 20)
        Me.OPCServerName.TabIndex = 97
        Me.OPCServerName.Text = "Click on list above to select"
        Me.ToolTip1.SetToolTip(Me.OPCServerName, "You can select an OPC Server from the list above or enter one here")
        '
        'AvailableOPCServerList
        '
        Me.AvailableOPCServerList.BackColor = System.Drawing.SystemColors.Window
        Me.AvailableOPCServerList.Cursor = System.Windows.Forms.Cursors.Default
        Me.AvailableOPCServerList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableOPCServerList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AvailableOPCServerList.ItemHeight = 14
        Me.AvailableOPCServerList.Location = New System.Drawing.Point(11, 53)
        Me.AvailableOPCServerList.Name = "AvailableOPCServerList"
        Me.AvailableOPCServerList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvailableOPCServerList.Size = New System.Drawing.Size(232, 60)
        Me.AvailableOPCServerList.Sorted = True
        Me.AvailableOPCServerList.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.AvailableOPCServerList, "Select an OPC Server from the list and press the 'Connect' button below")
        '
        'ListOPCServers
        '
        Me.ListOPCServers.BackColor = System.Drawing.SystemColors.Control
        Me.ListOPCServers.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListOPCServers.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListOPCServers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListOPCServers.Location = New System.Drawing.Point(60, 19)
        Me.ListOPCServers.Name = "ListOPCServers"
        Me.ListOPCServers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListOPCServers.Size = New System.Drawing.Size(177, 31)
        Me.ListOPCServers.TabIndex = 94
        Me.ListOPCServers.Text = "List OPC Servers"
        Me.ToolTip1.SetToolTip(Me.ListOPCServers, "Click here to list available OPC Servers, find KEPServerEX and click on it")
        Me.ListOPCServers.UseVisualStyleBackColor = False
        '
        'OPCServerConnect
        '
        Me.OPCServerConnect.BackColor = System.Drawing.SystemColors.Control
        Me.OPCServerConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCServerConnect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCServerConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCServerConnect.Location = New System.Drawing.Point(34, 120)
        Me.OPCServerConnect.Name = "OPCServerConnect"
        Me.OPCServerConnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCServerConnect.Size = New System.Drawing.Size(57, 21)
        Me.OPCServerConnect.TabIndex = 93
        Me.OPCServerConnect.Text = "Connect"
        Me.ToolTip1.SetToolTip(Me.OPCServerConnect, "Press the 'Connect' button once you have selected an OPC Server")
        Me.OPCServerConnect.UseVisualStyleBackColor = False
        '
        'RemoveOPCGroup
        '
        Me.RemoveOPCGroup.BackColor = System.Drawing.SystemColors.Control
        Me.RemoveOPCGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.RemoveOPCGroup.Enabled = False
        Me.RemoveOPCGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveOPCGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RemoveOPCGroup.Location = New System.Drawing.Point(152, 168)
        Me.RemoveOPCGroup.Name = "RemoveOPCGroup"
        Me.RemoveOPCGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RemoveOPCGroup.Size = New System.Drawing.Size(129, 26)
        Me.RemoveOPCGroup.TabIndex = 16
        Me.RemoveOPCGroup.Text = "Remove Group"
        Me.ToolTip1.SetToolTip(Me.RemoveOPCGroup, "Click here to remove a group from the OPC Server, you must first remove the items" &
        " if any")
        Me.RemoveOPCGroup.UseVisualStyleBackColor = False
        '
        'AddOPCGroup
        '
        Me.AddOPCGroup.BackColor = System.Drawing.SystemColors.Control
        Me.AddOPCGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddOPCGroup.Enabled = False
        Me.AddOPCGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddOPCGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddOPCGroup.Location = New System.Drawing.Point(8, 168)
        Me.AddOPCGroup.Name = "AddOPCGroup"
        Me.AddOPCGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AddOPCGroup.Size = New System.Drawing.Size(129, 26)
        Me.AddOPCGroup.TabIndex = 15
        Me.AddOPCGroup.Text = "Add Group"
        Me.ToolTip1.SetToolTip(Me.AddOPCGroup, "Once you have entered a group name and it's settings click here to add the group")
        Me.AddOPCGroup.UseVisualStyleBackColor = False
        '
        'GroupActiveState
        '
        Me.GroupActiveState.BackColor = System.Drawing.SystemColors.Control
        Me.GroupActiveState.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GroupActiveState.Checked = True
        Me.GroupActiveState.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GroupActiveState.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupActiveState.Enabled = False
        Me.GroupActiveState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupActiveState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupActiveState.Location = New System.Drawing.Point(56, 128)
        Me.GroupActiveState.Name = "GroupActiveState"
        Me.GroupActiveState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupActiveState.Size = New System.Drawing.Size(89, 17)
        Me.GroupActiveState.TabIndex = 14
        Me.GroupActiveState.Text = "Group Active"
        Me.ToolTip1.SetToolTip(Me.GroupActiveState, "The active determines if the group is actively updating or not, this can be chang" &
        "ed at any time")
        Me.GroupActiveState.UseVisualStyleBackColor = False
        '
        'GroupDeadBand
        '
        Me.GroupDeadBand.AcceptsReturn = True
        Me.GroupDeadBand.BackColor = System.Drawing.SystemColors.Window
        Me.GroupDeadBand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GroupDeadBand.Enabled = False
        Me.GroupDeadBand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDeadBand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupDeadBand.Location = New System.Drawing.Point(128, 96)
        Me.GroupDeadBand.MaxLength = 0
        Me.GroupDeadBand.Name = "GroupDeadBand"
        Me.GroupDeadBand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupDeadBand.Size = New System.Drawing.Size(113, 20)
        Me.GroupDeadBand.TabIndex = 13
        Me.GroupDeadBand.Text = "0"
        Me.ToolTip1.SetToolTip(Me.GroupDeadBand, "Enter the percentage of change an item must make before it is returned to the cli" &
        "ent, the default is 0 percent")
        '
        'GroupUpdateRate
        '
        Me.GroupUpdateRate.AcceptsReturn = True
        Me.GroupUpdateRate.BackColor = System.Drawing.SystemColors.Window
        Me.GroupUpdateRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GroupUpdateRate.Enabled = False
        Me.GroupUpdateRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupUpdateRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupUpdateRate.Location = New System.Drawing.Point(128, 64)
        Me.GroupUpdateRate.MaxLength = 0
        Me.GroupUpdateRate.Name = "GroupUpdateRate"
        Me.GroupUpdateRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupUpdateRate.Size = New System.Drawing.Size(113, 20)
        Me.GroupUpdateRate.TabIndex = 11
        Me.GroupUpdateRate.Text = "1000"
        Me.ToolTip1.SetToolTip(Me.GroupUpdateRate, "Enter how often you want the the server to refresh items in this group, this can " &
        "be changed at any time")
        '
        'OPCGroupName
        '
        Me.OPCGroupName.AcceptsReturn = True
        Me.OPCGroupName.BackColor = System.Drawing.SystemColors.Window
        Me.OPCGroupName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCGroupName.Enabled = False
        Me.OPCGroupName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCGroupName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCGroupName.Location = New System.Drawing.Point(128, 32)
        Me.OPCGroupName.MaxLength = 0
        Me.OPCGroupName.Name = "OPCGroupName"
        Me.OPCGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCGroupName.Size = New System.Drawing.Size(121, 20)
        Me.OPCGroupName.TabIndex = 9
        Me.OPCGroupName.Text = "Group1"
        Me.ToolTip1.SetToolTip(Me.OPCGroupName, "The group name can be anything you like but it must always be unique")
        '
        'OPCNodeName
        '
        Me.OPCNodeName.AcceptsReturn = True
        Me.OPCNodeName.BackColor = System.Drawing.SystemColors.Window
        Me.OPCNodeName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCNodeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCNodeName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCNodeName.Location = New System.Drawing.Point(101, 145)
        Me.OPCNodeName.MaxLength = 0
        Me.OPCNodeName.Name = "OPCNodeName"
        Me.OPCNodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCNodeName.Size = New System.Drawing.Size(152, 20)
        Me.OPCNodeName.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.OPCNodeName, "Enter the name of the PC running the server here if not this PC.")
        '
        'DisconnectFromServer
        '
        Me.DisconnectFromServer.BackColor = System.Drawing.SystemColors.Control
        Me.DisconnectFromServer.Cursor = System.Windows.Forms.Cursors.Default
        Me.DisconnectFromServer.Enabled = False
        Me.DisconnectFromServer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisconnectFromServer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisconnectFromServer.Location = New System.Drawing.Point(56, 168)
        Me.DisconnectFromServer.Name = "DisconnectFromServer"
        Me.DisconnectFromServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DisconnectFromServer.Size = New System.Drawing.Size(137, 26)
        Me.DisconnectFromServer.TabIndex = 6
        Me.DisconnectFromServer.Text = "Disconnect From Server"
        Me.ToolTip1.SetToolTip(Me.DisconnectFromServer, "Once you are finished accessing an OPC Server you should disconnect from it allow" &
        "ing the server to release the resources you used")
        Me.DisconnectFromServer.UseVisualStyleBackColor = False
        '
        'OPCRemoveItems
        '
        Me.OPCRemoveItems.BackColor = System.Drawing.SystemColors.Control
        Me.OPCRemoveItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCRemoveItems.Enabled = False
        Me.OPCRemoveItems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCRemoveItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCRemoveItems.Location = New System.Drawing.Point(424, 16)
        Me.OPCRemoveItems.Name = "OPCRemoveItems"
        Me.OPCRemoveItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCRemoveItems.Size = New System.Drawing.Size(121, 24)
        Me.OPCRemoveItems.TabIndex = 93
        Me.OPCRemoveItems.Text = "Remove OPC Items"
        Me.ToolTip1.SetToolTip(Me.OPCRemoveItems, "Click here to remove the current items from the OPC group")
        Me.OPCRemoveItems.UseVisualStyleBackColor = False
        '
        'OPCItemSyncReadButton_0
        '
        Me.OPCItemSyncReadButton_0.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemSyncReadButton_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemSyncReadButton_0.Enabled = False
        Me.OPCItemSyncReadButton_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemSyncReadButton_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemSyncReadButton_0.Location = New System.Drawing.Point(568, 55)
        Me.OPCItemSyncReadButton_0.Name = "OPCItemSyncReadButton_0"
        Me.OPCItemSyncReadButton_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemSyncReadButton_0.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemSyncReadButton_0.TabIndex = 83
        Me.OPCItemSyncReadButton_0.Text = "Sync Read"
        Me.ToolTip1.SetToolTip(Me.OPCItemSyncReadButton_0, "Click here to perform a Synchronous read of this OPC Item")
        Me.OPCItemSyncReadButton_0.UseVisualStyleBackColor = False
        '
        'OPCItemActiveState_0
        '
        Me.OPCItemActiveState_0.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemActiveState_0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OPCItemActiveState_0.Checked = True
        Me.OPCItemActiveState_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OPCItemActiveState_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemActiveState_0.Enabled = False
        Me.OPCItemActiveState_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemActiveState_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemActiveState_0.Location = New System.Drawing.Point(496, 62)
        Me.OPCItemActiveState_0.Name = "OPCItemActiveState_0"
        Me.OPCItemActiveState_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemActiveState_0.Size = New System.Drawing.Size(57, 17)
        Me.OPCItemActiveState_0.TabIndex = 64
        Me.OPCItemActiveState_0.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.OPCItemActiveState_0, "Click here to change the active state of this item")
        Me.OPCItemActiveState_0.UseVisualStyleBackColor = False
        '
        'OPCItemWriteButton_0
        '
        Me.OPCItemWriteButton_0.BackColor = System.Drawing.SystemColors.Control
        Me.OPCItemWriteButton_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPCItemWriteButton_0.Enabled = False
        Me.OPCItemWriteButton_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemWriteButton_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCItemWriteButton_0.Location = New System.Drawing.Point(416, 55)
        Me.OPCItemWriteButton_0.Name = "OPCItemWriteButton_0"
        Me.OPCItemWriteButton_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemWriteButton_0.Size = New System.Drawing.Size(72, 28)
        Me.OPCItemWriteButton_0.TabIndex = 63
        Me.OPCItemWriteButton_0.Text = "Write Value"
        Me.ToolTip1.SetToolTip(Me.OPCItemWriteButton_0, "Click here to send the value entered in the 'Value to Write' field using a Synchr" &
        "onous Write")
        Me.OPCItemWriteButton_0.UseVisualStyleBackColor = False
        '
        'OPCItemValueToWrite_0
        '
        Me.OPCItemValueToWrite_0.AcceptsReturn = True
        Me.OPCItemValueToWrite_0.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValueToWrite_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValueToWrite_0.Enabled = False
        Me.OPCItemValueToWrite_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValueToWrite_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValueToWrite_0.Location = New System.Drawing.Point(304, 62)
        Me.OPCItemValueToWrite_0.MaxLength = 0
        Me.OPCItemValueToWrite_0.Name = "OPCItemValueToWrite_0"
        Me.OPCItemValueToWrite_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValueToWrite_0.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValueToWrite_0.TabIndex = 52
        Me.OPCItemValueToWrite_0.Text = "0"
        Me.ToolTip1.SetToolTip(Me.OPCItemValueToWrite_0, "Enter the value to written here then click the 'Write Value' button")
        '
        'OPCGroupFrame
        '
        Me.OPCGroupFrame.BackColor = System.Drawing.SystemColors.Control
        Me.OPCGroupFrame.Controls.Add(Me.RemoveOPCGroup)
        Me.OPCGroupFrame.Controls.Add(Me.AddOPCGroup)
        Me.OPCGroupFrame.Controls.Add(Me.GroupActiveState)
        Me.OPCGroupFrame.Controls.Add(Me.GroupDeadBand)
        Me.OPCGroupFrame.Controls.Add(Me.GroupUpdateRate)
        Me.OPCGroupFrame.Controls.Add(Me.OPCGroupName)
        Me.OPCGroupFrame.Controls.Add(Me.Label6)
        Me.OPCGroupFrame.Controls.Add(Me.Label5)
        Me.OPCGroupFrame.Controls.Add(Me.Label1)
        Me.OPCGroupFrame.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCGroupFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPCGroupFrame.Location = New System.Drawing.Point(300, 3)
        Me.OPCGroupFrame.Name = "OPCGroupFrame"
        Me.OPCGroupFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCGroupFrame.Size = New System.Drawing.Size(289, 200)
        Me.OPCGroupFrame.TabIndex = 99
        Me.OPCGroupFrame.TabStop = False
        Me.OPCGroupFrame.Text = "Add Group to OPC Server"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(48, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Deadband  (%)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Update Rate (ms.)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Group Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ExitExample
        '
        Me.ExitExample.BackColor = System.Drawing.SystemColors.Control
        Me.ExitExample.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitExample.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitExample.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitExample.Location = New System.Drawing.Point(642, 99)
        Me.ExitExample.Name = "ExitExample"
        Me.ExitExample.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitExample.Size = New System.Drawing.Size(106, 29)
        Me.ExitExample.TabIndex = 98
        Me.ExitExample.Text = "Quit"
        Me.ExitExample.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.OPCNodeName)
        Me.Frame1.Controls.Add(Me.DisconnectFromServer)
        Me.Frame1.Controls.Add(Me.lblOPCNodeName)
        Me.Frame1.Controls.Add(Me.OPCServerConnect)
        Me.Frame1.Controls.Add(Me.OPCServerName)
        Me.Frame1.Controls.Add(Me.AvailableOPCServerList)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 3)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(264, 200)
        Me.Frame1.TabIndex = 96
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "List Available OPC Servers"
        '
        'lblOPCNodeName
        '
        Me.lblOPCNodeName.BackColor = System.Drawing.SystemColors.Control
        Me.lblOPCNodeName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOPCNodeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPCNodeName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOPCNodeName.Location = New System.Drawing.Point(31, 148)
        Me.lblOPCNodeName.Name = "lblOPCNodeName"
        Me.lblOPCNodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOPCNodeName.Size = New System.Drawing.Size(64, 17)
        Me.lblOPCNodeName.TabIndex = 95
        Me.lblOPCNodeName.Text = "Node Name"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.OPCRemoveItems)
        Me.Frame2.Controls.Add(Me.OPCItemSyncReadButton_0)
        Me.Frame2.Controls.Add(Me.OPCItemActiveState_0)
        Me.Frame2.Controls.Add(Me.OPCItemWriteButton_0)
        Me.Frame2.Controls.Add(Me.OPCItemValueToWrite_0)
        Me.Frame2.Controls.Add(Me.OPCItemQuality_0)
        Me.Frame2.Controls.Add(Me.OPCItemValue_0)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(12, 203)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(736, 351)
        Me.Frame2.TabIndex = 111
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "OPC Items"
        '
        'OPCItemQuality_0
        '
        Me.OPCItemQuality_0.AcceptsReturn = True
        Me.OPCItemQuality_0.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemQuality_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemQuality_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemQuality_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemQuality_0.Location = New System.Drawing.Point(648, 62)
        Me.OPCItemQuality_0.MaxLength = 0
        Me.OPCItemQuality_0.Name = "OPCItemQuality_0"
        Me.OPCItemQuality_0.ReadOnly = True
        Me.OPCItemQuality_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemQuality_0.Size = New System.Drawing.Size(57, 20)
        Me.OPCItemQuality_0.TabIndex = 41
        '
        'OPCItemValue_0
        '
        Me.OPCItemValue_0.AcceptsReturn = True
        Me.OPCItemValue_0.BackColor = System.Drawing.SystemColors.Window
        Me.OPCItemValue_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OPCItemValue_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPCItemValue_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OPCItemValue_0.Location = New System.Drawing.Point(200, 62)
        Me.OPCItemValue_0.MaxLength = 0
        Me.OPCItemValue_0.Name = "OPCItemValue_0"
        Me.OPCItemValue_0.ReadOnly = True
        Me.OPCItemValue_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPCItemValue_0.Size = New System.Drawing.Size(97, 20)
        Me.OPCItemValue_0.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(304, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Value to Write"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(648, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Item Quality"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(200, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Current Value"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Enter OPC Item Names"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(642, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 29)
        Me.Button1.TabIndex = 166
        Me.Button1.Text = "Data Overview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SimpleOPCInterface
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(763, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OPCItemSyncReadButton_9)
        Me.Controls.Add(Me.OPCItemSyncReadButton_8)
        Me.Controls.Add(Me.OPCItemSyncReadButton_7)
        Me.Controls.Add(Me.OPCItemSyncReadButton_6)
        Me.Controls.Add(Me.OPCItemSyncReadButton_5)
        Me.Controls.Add(Me.OPCItemSyncReadButton_4)
        Me.Controls.Add(Me.OPCItemSyncReadButton_3)
        Me.Controls.Add(Me.OPCItemSyncReadButton_2)
        Me.Controls.Add(Me.OPCItemSyncReadButton_1)
        Me.Controls.Add(Me.OPCItemActiveState_9)
        Me.Controls.Add(Me.OPCItemActiveState_8)
        Me.Controls.Add(Me.OPCItemActiveState_7)
        Me.Controls.Add(Me.OPCItemActiveState_6)
        Me.Controls.Add(Me.OPCItemActiveState_5)
        Me.Controls.Add(Me.OPCItemActiveState_4)
        Me.Controls.Add(Me.OPCItemActiveState_3)
        Me.Controls.Add(Me.OPCItemActiveState_2)
        Me.Controls.Add(Me.OPCItemActiveState_1)
        Me.Controls.Add(Me.OPCItemWriteButton_9)
        Me.Controls.Add(Me.OPCItemWriteButton_8)
        Me.Controls.Add(Me.OPCItemWriteButton_7)
        Me.Controls.Add(Me.OPCItemWriteButton_6)
        Me.Controls.Add(Me.OPCItemWriteButton_5)
        Me.Controls.Add(Me.OPCItemWriteButton_4)
        Me.Controls.Add(Me.OPCItemWriteButton_3)
        Me.Controls.Add(Me.OPCItemWriteButton_2)
        Me.Controls.Add(Me.OPCItemWriteButton_1)
        Me.Controls.Add(Me.OPCItemValueToWrite_9)
        Me.Controls.Add(Me.OPCItemValueToWrite_8)
        Me.Controls.Add(Me.OPCItemValueToWrite_7)
        Me.Controls.Add(Me.OPCItemValueToWrite_6)
        Me.Controls.Add(Me.OPCItemValueToWrite_5)
        Me.Controls.Add(Me.OPCItemValueToWrite_4)
        Me.Controls.Add(Me.OPCItemValueToWrite_3)
        Me.Controls.Add(Me.OPCItemValueToWrite_2)
        Me.Controls.Add(Me.OPCItemValueToWrite_1)
        Me.Controls.Add(Me.OPCItemQuality_9)
        Me.Controls.Add(Me.OPCItemQuality_8)
        Me.Controls.Add(Me.OPCItemQuality_7)
        Me.Controls.Add(Me.OPCItemQuality_6)
        Me.Controls.Add(Me.OPCItemQuality_5)
        Me.Controls.Add(Me.OPCItemQuality_4)
        Me.Controls.Add(Me.OPCItemQuality_3)
        Me.Controls.Add(Me.OPCItemQuality_2)
        Me.Controls.Add(Me.OPCItemQuality_1)
        Me.Controls.Add(Me.OPCItemValue_9)
        Me.Controls.Add(Me.OPCItemValue_8)
        Me.Controls.Add(Me.OPCItemValue_7)
        Me.Controls.Add(Me.OPCItemValue_6)
        Me.Controls.Add(Me.OPCItemValue_5)
        Me.Controls.Add(Me.OPCItemValue_4)
        Me.Controls.Add(Me.OPCItemValue_3)
        Me.Controls.Add(Me.OPCItemValue_2)
        Me.Controls.Add(Me.OPCItemValue_1)
        Me.Controls.Add(Me.OPCAddItems)
        Me.Controls.Add(Me.OPCItemName_9)
        Me.Controls.Add(Me.OPCItemName_8)
        Me.Controls.Add(Me.OPCItemName_7)
        Me.Controls.Add(Me.OPCItemName_6)
        Me.Controls.Add(Me.OPCItemName_5)
        Me.Controls.Add(Me.OPCItemName_4)
        Me.Controls.Add(Me.OPCItemName_3)
        Me.Controls.Add(Me.OPCItemName_2)
        Me.Controls.Add(Me.OPCItemName_1)
        Me.Controls.Add(Me.OPCItemName_0)
        Me.Controls.Add(Me.ListOPCServers)
        Me.Controls.Add(Me.OPCGroupFrame)
        Me.Controls.Add(Me.ExitExample)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Name = "SimpleOPCInterface"
        Me.Text = "VS2010 SimpleOPCInterface V1.0.0.3"
        Me.OPCGroupFrame.ResumeLayout(False)
        Me.OPCGroupFrame.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Number of items we are dealing with in this example.  If you make this greater than
    ' 10 you will need to create additional controls on the form.  You will notice that arrays
    ' are set to NUMITEMS.  This is so that we can treat all arrays as 1 based, like the
    ' Interop DLL
    Const NUMITEMS As Integer = 10

    ' Also note what the actual array size is.( NUMITEMS SPECIFIES Upper Bound of Array )
    ' To summarize then:
    '	1) Array size = 11
    '	2) We use indexes 1 thru 10
    '	3) Index 0 is not used at all
    Const ACTUAL_ARRAY_SIZE As Integer = NUMITEMS + 1

    ' Server and group related data
    ' The OPCServer objects must be declared here due to the use of WithEvents
    Dim WithEvents AnOPCServer As OPCAutomation.OPCServer
    Dim WithEvents ConnectedOPCServer As OPCAutomation.OPCServer
    Dim WithEvents ConnectedGroup As OPCAutomation.OPCGroup

    ' OPC Item related data
    Dim OPCItemIDs(NUMITEMS) As String
    Dim ClientHandles(NUMITEMS) As Int32
    Dim ItemServerHandles As System.Array

    ' Arrays are used to provide iterative access to sets of controls
    Dim OPCItemName(NUMITEMS) As Object
    Dim OPCItemValue(NUMITEMS) As Object
    Dim OPCItemValueToWrite(NUMITEMS) As Object
    Dim OPCItemWriteButton(NUMITEMS) As Object
    Dim OPCItemActiveState(NUMITEMS) As Object
    Dim OPCItemSyncReadButton(NUMITEMS) As Object
    Dim OPCItemQuality(NUMITEMS) As Object
    Dim OPCItemIsArray(NUMITEMS) As Integer

    Enum CanonicalDataTypes As Short
        CanonDtByte = 17
        CanonDtChar = 16
        CanonDtWord = 18
        CanonDtShort = 2
        CanonDtDWord = 19
        CanonDtLong = 3
        CanonDtFloat = 4
        CanonDtDouble = 5
        CanonDtBool = 11
        CanonDtString = 8
    End Enum

    ' General startup initialization
    Public Sub SimpleOPCInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize controls
        AvailableOPCServerList.Items.Add("Click on 'List OPC Servers' to start")
        Me.Text = "VS2008 SimpleOPCInterface V" & My.Application.Info.Version.ToString


        ' Initialize arrays for iterative access to controls
        OPCItemName(1) = OPCItemName_0
        OPCItemName(2) = OPCItemName_1
        OPCItemName(3) = OPCItemName_2
        OPCItemName(4) = OPCItemName_3
        OPCItemName(5) = OPCItemName_4
        OPCItemName(6) = OPCItemName_5
        OPCItemName(7) = OPCItemName_6
        OPCItemName(8) = OPCItemName_7
        OPCItemName(9) = OPCItemName_8
        OPCItemName(10) = OPCItemName_9

        OPCItemValue(1) = OPCItemValue_0
        OPCItemValue(2) = OPCItemValue_1
        OPCItemValue(3) = OPCItemValue_2
        OPCItemValue(4) = OPCItemValue_3
        OPCItemValue(5) = OPCItemValue_4
        OPCItemValue(6) = OPCItemValue_5
        OPCItemValue(7) = OPCItemValue_6
        OPCItemValue(8) = OPCItemValue_7
        OPCItemValue(9) = OPCItemValue_8
        OPCItemValue(10) = OPCItemValue_9

        OPCItemValueToWrite(1) = OPCItemValueToWrite_0
        OPCItemValueToWrite(2) = OPCItemValueToWrite_1
        OPCItemValueToWrite(3) = OPCItemValueToWrite_2
        OPCItemValueToWrite(4) = OPCItemValueToWrite_3
        OPCItemValueToWrite(5) = OPCItemValueToWrite_4
        OPCItemValueToWrite(6) = OPCItemValueToWrite_5
        OPCItemValueToWrite(7) = OPCItemValueToWrite_6
        OPCItemValueToWrite(8) = OPCItemValueToWrite_7
        OPCItemValueToWrite(9) = OPCItemValueToWrite_8
        OPCItemValueToWrite(10) = OPCItemValueToWrite_9

        OPCItemWriteButton(1) = OPCItemWriteButton_0
        OPCItemWriteButton(2) = OPCItemWriteButton_1
        OPCItemWriteButton(3) = OPCItemWriteButton_2
        OPCItemWriteButton(4) = OPCItemWriteButton_3
        OPCItemWriteButton(5) = OPCItemWriteButton_4
        OPCItemWriteButton(6) = OPCItemWriteButton_5
        OPCItemWriteButton(7) = OPCItemWriteButton_6
        OPCItemWriteButton(8) = OPCItemWriteButton_7
        OPCItemWriteButton(9) = OPCItemWriteButton_8
        OPCItemWriteButton(10) = OPCItemWriteButton_9

        OPCItemActiveState(1) = OPCItemActiveState_0
        OPCItemActiveState(2) = OPCItemActiveState_1
        OPCItemActiveState(3) = OPCItemActiveState_2
        OPCItemActiveState(4) = OPCItemActiveState_3
        OPCItemActiveState(5) = OPCItemActiveState_4
        OPCItemActiveState(6) = OPCItemActiveState_5
        OPCItemActiveState(7) = OPCItemActiveState_6
        OPCItemActiveState(8) = OPCItemActiveState_7
        OPCItemActiveState(9) = OPCItemActiveState_8
        OPCItemActiveState(10) = OPCItemActiveState_9

        OPCItemSyncReadButton(1) = OPCItemSyncReadButton_0
        OPCItemSyncReadButton(2) = OPCItemSyncReadButton_1
        OPCItemSyncReadButton(3) = OPCItemSyncReadButton_2
        OPCItemSyncReadButton(4) = OPCItemSyncReadButton_3
        OPCItemSyncReadButton(5) = OPCItemSyncReadButton_4
        OPCItemSyncReadButton(6) = OPCItemSyncReadButton_5
        OPCItemSyncReadButton(7) = OPCItemSyncReadButton_6
        OPCItemSyncReadButton(8) = OPCItemSyncReadButton_7
        OPCItemSyncReadButton(9) = OPCItemSyncReadButton_8
        OPCItemSyncReadButton(10) = OPCItemSyncReadButton_9

        OPCItemQuality(1) = OPCItemQuality_0
        OPCItemQuality(2) = OPCItemQuality_1
        OPCItemQuality(3) = OPCItemQuality_2
        OPCItemQuality(4) = OPCItemQuality_3
        OPCItemQuality(5) = OPCItemQuality_4
        OPCItemQuality(6) = OPCItemQuality_5
        OPCItemQuality(7) = OPCItemQuality_6
        OPCItemQuality(8) = OPCItemQuality_7
        OPCItemQuality(9) = OPCItemQuality_8
        OPCItemQuality(10) = OPCItemQuality_9
    End Sub

    ' This sub handles gathering a list of available OPC Servers and displays them
    ' The OPCServer Object provides a method called 'GetOPCServers' that will allow
    ' you to get a list of the OPC Servers that are installed on your machine.  The
    ' list is retured as a string array.
    Public Sub ListOPCServers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOPCServers.Click
        Try
            ' Create a temporary OPCServer object and use it to get the list of
            ' available OPC Servers
            AnOPCServer = New OPCAutomation.OPCServer

            ' Clear the list control used to display them
            AvailableOPCServerList.Items.Clear()

            ' Obtain the list of available OPC servers
            Dim AllOPCServers As Object
            AllOPCServers = AnOPCServer.GetOPCServers

            ' Load the list returned into the List box for user selection
            Dim i As Short
            For i = LBound(AllOPCServers) To UBound(AllOPCServers)
                AvailableOPCServerList.Items.Add(AllOPCServers(i))
            Next i

            ' Release the temporary OPCServer object now that we're done with it
            AnOPCServer = Nothing

        Catch ex As Exception
            ' Error handling
            MessageBox.Show("List OPC servers failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
    End Sub

    ' This sub loads the OPC Server name when selected from the list
    ' and places it in the OPCServerName object
    Public Sub AvailableOPCServerList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableOPCServerList.SelectedIndexChanged
        ' When a user selects a server from the list box its name is placed
        ' in the OPCServerName
        OPCServerName.Text = AvailableOPCServerList.Text
    End Sub

    ' This sub handles connecting with the selected OPC Server
    ' The OPCServer Object provides a method called 'Connect' that allows you
    ' to 'connect' with an OPC server.  The 'Connect' method can take two arguments,
    ' a server name and a Node name.  The Node name is optional and does not have to
    ' be used to connect to a local server.  When the 'Connect' method is called you
    ' should see the OPC Server application start if it is not aleady running.
    '
    'Special Note: When connect remotely to another PC running the KepserverEx make
    'sure that you have properly configured DCOM on both PC's. You will find documentation
    'explaining exactly how to do this on your installation CD or at the Kepware web site.
    'The web site is www.kepware.com.
    Public Sub OPCServerConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCServerConnect.Click
        ' Test to see if the User has entered or selected an OPC server name yet if not post a message
        If InStr(OPCServerName.Text, "Click") = 0 Then
            Try
                'Create a new OPC Server object
                ConnectedOPCServer = New OPCAutomation.OPCServer

                'Attempt to connect with the server
                ConnectedOPCServer.Connect(OPCServerName.Text, OPCNodeName.Text)

                ' Throughout this example you will see a lot of code that simply enables and disables the various controls on the form.  The purpose of these
                ' actions is to demonstrate and insure the proper sequence of events when making an OPC connection.
                ' If we successfully connect to a server allow the user to disconnect
                DisconnectFromServer.Enabled = True

                ' Don't allow a reconnect until the user disconnects
                OPCServerConnect.Enabled = False
                AvailableOPCServerList.Enabled = False
                OPCServerName.Enabled = False

                ' Enable the group controls now that we have a server connection
                OPCGroupName.Enabled = True
                GroupUpdateRate.Enabled = True
                GroupDeadBand.Enabled = True
                GroupActiveState.Enabled = True
                AddOPCGroup.Enabled = True              ' Remove group isn't enable until a group has been added

            Catch ex As Exception
                ' Error handling
                DisconnectFromServer.Enabled = False
                ConnectedOPCServer = Nothing
                MessageBox.Show("OPC server connect failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try

        Else
            ' A server name has not been selected yet post an error to the user
            MessageBox.Show("You must first select an OPC Server, Click on the 'List OPC Servers' button and select a server", "OPC Server Connect", MessageBoxButtons.OK)
        End If
    End Sub

    ' This sub handles disconnecting from the OPC Server.  The OPCServer Object provides the method 'Disconnect'.  Calling this on an active OPCSerer
    ' object will release the OPC Server interface with your application.  When this occurs you should see the OPC server application shut down if it started
    ' automatically on the OPC connect. This step should not occur until the group and items have been removed

    Public Sub DisconnectFromServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectFromServer.Click
        ' Test to see if the OPC Server connection is currently available
        If Not ConnectedOPCServer Is Nothing Then
            Try
                'Disconnect from the server, This should only occur after the items and group
                ' have been removed
                ConnectedOPCServer.Disconnect()
            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server disconnect failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            Finally
                ' Release the old instance of the OPC Server object and allow the resources
                ' to be freed
                ConnectedOPCServer = Nothing

                ' Allow a reconnect once the disconnect completes
                OPCServerConnect.Enabled = True
                AvailableOPCServerList.Enabled = True
                OPCServerName.Enabled = True

                ' Don't alllow the Disconnect to be issued now that the connection is closed
                DisconnectFromServer.Enabled = False

                ' Disable the group controls now that we no longer have a server connection
                OPCGroupName.Enabled = False
                GroupUpdateRate.Enabled = False
                GroupDeadBand.Enabled = False
                GroupActiveState.Enabled = False
                AddOPCGroup.Enabled = False
            End Try
        End If
    End Sub

    ' This sub handles adding the group to the OPC server and establishing the group interface.  When adding a group you can preset some of the group
    ' parameters using the properties '.DefaultGroupIsActive' and '.DefaultGroupDeadband'.  Set these before adding the group. Once the
    ' group has been successfully added you can change these same settings along with the group update rate on the fly using the properties on the
    ' resulting OPCGroup object.

    Public Sub AddOPCGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOPCGroup.Click
        Try
            ' Set the desire active state for the group
            ConnectedOPCServer.OPCGroups.DefaultGroupIsActive = GroupActiveState.CheckState

            'Set the desired percent deadband
            ConnectedOPCServer.OPCGroups.DefaultGroupDeadband = Val(GroupDeadBand.Text)

            ' Add the group and set its update rate
            ConnectedGroup = ConnectedOPCServer.OPCGroups.Add(OPCGroupName.Text)

            ' Set the update rate for the group
            ConnectedGroup.UpdateRate = Val(GroupUpdateRate.Text)

            ' ****************************************************************
            ' Mark this group to receive asynchronous updates via the DataChange event. This setting is IMPORTANT. Without setting '.IsSubcribed' to True your
            ' VB application will not receive DataChange notifications.  This will make it appear that you have not properly connected to the server.

            ConnectedGroup.IsSubscribed = True

            '*****************************************************************
            ' Now that a group has been added disable the Add group Button and enable the Remove group Button.  This demo application adds only a single group
            OPCGroupName.Enabled = False
            AddOPCGroup.Enabled = False
            RemoveOPCGroup.Enabled = True

            ' Enable the OPC item controls now that a group has been added
            OPCAddItems.Enabled = True

            For i As Short = 1 To NUMITEMS
                OPCItemName(i).Enabled = True
            Next

            ' Disable the Disconnect Server button since we now have a group that must be removed first
            DisconnectFromServer.Enabled = False

        Catch ex As Exception
            ' Error handling
            MessageBox.Show("OPC server add group failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
    End Sub

    ' This sub handles removing a group from the OPC server, this must be done after items have been removed.  The 'Remove' method allows a group to be removed
    ' by name from the OPC Server.  If your application will maintains more than one group you will need to keep a list of the group names for use in the
    ' 'Remove' method.  In this demo there is only one group.  The name is maintained in the OPCGroupName TextBox but it can not be changed once the group is added.

    Public Sub RemoveOPCGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOPCGroup.Click
        ' Test to see if the OPC Group object is currently available
        If Not ConnectedGroup Is Nothing Then
            Try
                ' Remove the group from the server
                ConnectedOPCServer.OPCGroups.Remove(OPCGroupName.Text)
            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server remove group failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            Finally
                ConnectedGroup = Nothing

                ' Enable the Add group Button and disable the Remove group Button
                OPCGroupName.Enabled = True
                AddOPCGroup.Enabled = True
                RemoveOPCGroup.Enabled = False

                ' Disable the item controls now that a group has been removed.
                ' Items can't be added without a group so prevent the user from editing them.
                OPCAddItems.Enabled = False
                OPCRemoveItems.Enabled = False

                For i As Short = 1 To NUMITEMS
                    OPCItemName(i).Enabled = False
                Next

                ' Enable the Disconnect Server button since we have removed the group and can disconnect from the server properly
                DisconnectFromServer.Enabled = True
            End Try
        End If
    End Sub

    ' This sub allows the group's update rate to be changed on the fly.  The '.UpdateRate' property allows you to control how often data from this
    ' group will be returned to your application in the 'DataChange' event. The '.UpdateRate' property can be used to control and improve the overall
    ' performance of you application.  In this example you can see that the update rate is set for maximum update speed.  In a demo that's OK.  In your real
    ' world application, forcing the OPC Server to gather all of the OPC items in a group at their fastest rate may not be ideal.  In applications where you
    ' have data that needs to be acquired at different rates you can create multiple groups each with its own update rate.  Using multiple groups would
    ' allow you to gather time critical data in GroupA with an update rate of 200 millliseconds, and gather low priority data from GroupB with an
    ' update rate of 7000 milliseconds.  The lowest value for the '.UpdateRate'is 0 which tells the OPC Server go as fast as possible.  The maximium is
    ' 2147483647 milliseconds which is about 596 hours.

    Public Sub GroupUpdateRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupUpdateRate.TextChanged
        ' If the group has been added and exist then change its update rate
        If Not ConnectedGroup Is Nothing Then
            Try
                ConnectedGroup.UpdateRate = Val(GroupUpdateRate.Text)

            Catch ex As Exception
                MessageBox.Show("OPC server group update rate change failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This sub allows the group's deadband to be changed on the fly.  Like the '.IsActive' property, the '.DeadBand' property can be changed at any time.
    ' The Deadband property allows you to control how much change must occur in an OPC item in this group before the value will be reported in the 'DataChange'
    ' event.  The value entered for '.DeadBand' is 0 to 100 as a percentage of full scale for each OPC item data type within this group.  If your OPC item is a
    ' Short(VT_I2) then your full scale is -32768 to 32767 or 65535.  If you enter a Deadband value of 1% then all OPC Items in this goup would need
    ' to change by a value of 655 before the change would be returned in the 'DataChange' event.  The '.DeadBand' property is a floating point number
    ' allowing very small ranges of change to be filtered.

    Public Sub GroupDeadBand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupDeadBand.TextChanged
        ' If the group has been added and exist then change its dead band
        If Not ConnectedGroup Is Nothing Then
            Try
                ConnectedGroup.DeadBand = Val(GroupDeadBand.Text)

            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server group deadband change failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This sub allows the group's active state to be changed on the fly.  The OPCGroup object provides a number of properties that can be used to control
    ' a group's operation.  The '.IsActive' property allows you to turn all of the OPC items in the group On(active) and Off(inactive).  To see the effect that
    ' the group's '.InActive' property has on an OPC Server run this demo and connect with KEPServerEx, add the default group, add the default items.  Once you see
    ' changing data click on the CheckBox in the Group frame.  If you watch the KEPServerEx OPC Server you will see it's active tag count go from 10 when
    ' updating to 'No Active Items' when the group is made inactive. Changing the actvie state of a group can be useful in controlling how your
    ' application makes use of an OPC Servers communication bandwidth.  If you don't need any of the data in a given group simply set it inactive, this will allow an
    ' OPC Server to gather only the data current required by your application.

    Public Sub GroupActiveState_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupActiveState.CheckedChanged
        ' If the group has been added and exist then change its active state
        If Not ConnectedGroup Is Nothing Then
            Try
                ConnectedGroup.IsActive = GroupActiveState.CheckState

            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server group active state change failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This sub handles adding an OPC item to a group.  The group must be established first before any items can be added.  Once you  have a group added to the OPC Server you
    ' need to add item to the group.  The OPCItems object provides the methods and properties need to add item to an estabished OPC group.

    Public Sub OPCAddItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCAddItems.Click
        ' Test to see if the OPC Group object is currently available
        If Not ConnectedGroup Is Nothing Then
            Try
                Dim ItemCount As Integer = NUMITEMS

                ' Array for potential error returns.  This example doesn't
                ' check them but yours should ultimately.
                Dim AddItemServerErrors As System.Array

                ' Load the request OPC Item names and build the ClientHandles list
                For i As Short = 1 To NUMITEMS
                    ' Load the name of then item to be added to this group.  You can add as many items as you want to the group in a single call by building these arrays as needed.
                    OPCItemIDs(i) = OPCItemName(i).Text

                    ' ASSume all aren't an array. If it is, this holds size and is set in
                    ' Data change event.
                    OPCItemIsArray(i) = 0

                    ' The client handles are given to the OPC Server for each item you intend to add to the group.  The OPC Server will uses these client handles
                    ' by returning them to you in the 'DataChange' event.  You can use the client handles as a key to linking each valued returned from the Server
                    ' back to some element in your application.  In this example we are simply placing the Index number of each control that will be used to display
                    ' data for the item.  In your application the ClientHandle value you use can by whatever you need to best fit your program.  You will see how
                    ' these client handles are used in the 'DataChange' event handler.

                    ClientHandles(i) = i

                    ' Make the Items active start control Active, for the demo I want all items to start active Your application may need to start the items as inactive.
                    OPCItemActiveState(i).CheckState = System.Windows.Forms.CheckState.Checked
                Next i

                ' Establish a connection to the OPC item interface of the connected group
                '                OPCItemCollection = ConnectedGroup.OPCItems
                ' Setting the '.DefaultIsActive' property forces all items we are about to add to the group to be added in an active state.  If you want to add them
                ' all as inactive simply set this property false, you can always make the items active later as needed using each item's own active state property.
                ' One key distinction to note, the active state of an item is independent from the group active state.  If a group is active but the item is
                ' inactive no data will be received for the item.  Also changing the state of the group will not change the state of an item.

                ConnectedGroup.OPCItems.DefaultIsActive = True

                ' Atempt to add the items,  some may fail so the ItemServerErrors will need to be check on completion of the call.  We are adding all item using the
                ' default data type of VT_EMPTY and letting the server pick the appropriate data type.  The ItemServerHandles is an array that the OPC Server will
                ' return to your application.  This array like your own ClientHandles array is used by the server to allow you to reference individual items in an OPC
                ' group.  When you need to perform an action on a single OPC item you will need to use the ItemServerHandles for that item.  With this said you need to
                ' maintain the ItemServerHandles array for use throughout your application. Use of the ItemServerHandles will be demonstrated in other subroutines in
                ' this example program.

                ConnectedGroup.OPCItems.AddItems(ItemCount, OPCItemIDs, ClientHandles, ItemServerHandles, AddItemServerErrors)

                ' This next step checks the error return on each item we attempted to register.  If an item is in error it's associated controls will be
                ' disabled.  If all items are in error then the Add Item button will remain active.
                Dim AnItemIsGood As Boolean
                AnItemIsGood = False
                For i As Short = 1 To NUMITEMS
                    If AddItemServerErrors(i) = 0 Then                    'If the item was added successfully then allow it to be used.
                        OPCItemValueToWrite(i).Enabled = True
                        OPCItemWriteButton(i).Enabled = True
                        OPCItemActiveState(i).Enabled = True
                        OPCItemSyncReadButton(i).Enabled = True

                        AnItemIsGood = True
                        OPCItemValue(i).Enabled = True
                    Else
                        ItemServerHandles(i) = 0                         ' If the handle was bad mark it as empty
                        OPCItemValueToWrite(i).Enabled = False
                        OPCItemWriteButton(i).Enabled = False
                        OPCItemActiveState(i).Enabled = False
                        OPCItemSyncReadButton(i).Enabled = False

                        OPCItemValue(i).Enabled = False
                        OPCItemValue(i).Text = "OPC Add Item Fail"
                    End If
                Next i

                ' Disable the Add OPC item button if any item in the list was good
                'Dim Response As Object
                If AnItemIsGood Then
                    OPCAddItems.Enabled = False

                    For i As Short = 1 To NUMITEMS
                        OPCItemName(i).Enabled = False                        ' Disable the Item Name cotnrols while now that they have been added to the group.
                    Next i

                    RemoveOPCGroup.Enabled = False                   ' If an item has been added don't allow the group to be removed until the item is removed
                    OPCRemoveItems.Enabled = True
                Else
                    ' The OPC Server did not accept any of the items we attempted to enter, let the user know to try again.
                    MessageBox.Show("The OPC Server has not accepted any of the item you have entered, check your item names and try again. Hint: Check to make sure you entered the correct tag name with shortcut (ie.[PLCName]Tagname)", "OPC Add Item", MessageBoxButtons.OK)
                End If

            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server add items failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This sub handles removing OPC items from a group.  Like the 'AddItems' method of the OPCItems object, the 'Remove' method allow us to remove item from
    ' an OPC group.  In this example we are removing all item from the group. In your application you may find it necessary to remove some items from
    ' a group while ading others.  Normally the best practice however it to add all the item you wish to use to the group and then control their active
    ' states indivudually.  You can control the active state of individual items in a group as shown in the 'OPCItemActiveState_Click' subroutine of this
    ' module.  With that said if you intend to remove the group you should first remove all its items.  The 'Remove' method uses the
    ' ItemServerHandles we received from the 'AddItems' method to properly remove only the items you wish.  This is an example of how ItemServerHandles are
    ' used by your application and the OPC Server.  As stated above, you can design your application to add and remove items as needed but that's not
    ' necessarily the most effiecent operation for the OPC Server.

    Public Sub OPCRemoveItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCRemoveItems.Click
        If Not ConnectedGroup Is Nothing Then
            If ConnectedGroup.OPCItems.Count <> 0 Then
                Try
                    ' Provide an array to contain the ItemServerHandles of the item
                    ' we intend to remove
                    Dim RemoveItemServerHandles(NUMITEMS) As Int32

                    ' Array for potential error returns.  This example doesn't check them but yours should ultimately.
                    Dim RemoveItemServerErrors As System.Array

                    ' Get the Servers handle for the desired items.  The server handles were returned in add item subroutine.  In this case we need to get
                    ' only the handles for item that are valid.
                    Dim ItemCount As Short = 0
                    For i As Short = 1 To NUMITEMS
                        ' In this example if the ItemServerHandle is non zero it is valid
                        If ItemServerHandles(i) <> 0 Then
                            ItemCount = ItemCount + 1
                            RemoveItemServerHandles(ItemCount) = ItemServerHandles(i)
                        End If
                    Next i

                    ' Invoke the Remove Item operation.  Remember this call will
                    ' wait until completion
                    ConnectedGroup.OPCItems.Remove(ItemCount, RemoveItemServerHandles, RemoveItemServerErrors)

                    For i As Short = 1 To ItemCount
                        If RemoveItemServerErrors(i) <> 0 Then
                            MessageBox.Show("OPC server remove item failed with error: " + RemoveItemServerErrors(i), "OPC remove item", MessageBoxButtons.OK)
                        End If
                    Next i

                Catch ex As Exception
                    ' Error handling
                    MessageBox.Show("OPC server remove items failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
                Finally

                    ' Clear the ItemServerHandles and turn off the controls for interacting
                    ' with the OPC items on the form.
                    For i As Short = 1 To NUMITEMS
                        ItemServerHandles(i) = 0                         'Mark the handle as empty
                        OPCItemValueToWrite(i).Enabled = False
                        OPCItemWriteButton(i).Enabled = False
                        OPCItemActiveState(i).Enabled = False
                        OPCItemSyncReadButton(i).Enabled = False
                    Next i

                    ' Enable the Add OPC item button and Remove Group button now that the
                    ' items are released
                    OPCAddItems.Enabled = True
                    RemoveOPCGroup.Enabled = True
                    OPCRemoveItems.Enabled = False

                    ' Enable the OPC Item name controls to allow a new set of items
                    ' to be entered
                    For i As Short = 1 To NUMITEMS
                        OPCItemName(i).Enabled = True

                        OPCItemIsArray(i) = 0
                    Next i
                End Try
            End If
        End If
    End Sub

    Public Function LoadArray(ByRef AnArray As System.Array, ByVal CanonDT As Short, ByRef wrTxt As String) As Boolean
        Dim ii As Integer
        Dim loc As Integer
        Dim Wlen As Integer
        Dim start As Integer

        Try
            start = 1
            Wlen = Len(wrTxt)
            For ii = AnArray.GetLowerBound(0) To AnArray.GetUpperBound(0)
                loc = InStr(start, wrTxt, ",")
                If ii < AnArray.GetUpperBound(0) Then
                    If loc = 0 Then
                        MsgBox("Write Value: Incorrect Number of Items for Array Size?", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                Else
                    loc = Wlen + 1
                End If

                Select Case CanonDT
                    Case CanonicalDataTypes.CanonDtByte
                        AnArray(ii) = Convert.ToByte(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtChar
                        AnArray(ii) = Convert.ToSByte(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtWord
                        AnArray(ii) = Convert.ToUInt16(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtShort
                        AnArray(ii) = Convert.ToInt16(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtDWord
                        AnArray(ii) = Convert.ToUInt32(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtLong
                        AnArray(ii) = Convert.ToInt32(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtFloat
                        AnArray(ii) = Convert.ToSingle(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtDouble
                        AnArray(ii) = Convert.ToDouble(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtBool
                        AnArray(ii) = Convert.ToBoolean(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case CanonicalDataTypes.CanonDtString
                        AnArray(ii) = Convert.ToString(Mid(wrTxt, start, loc - start))
                        ' End case

                    Case Else
                        MsgBox("Write Value Unknown data type", MsgBoxStyle.Exclamation)
                        Return False
                End Select

                start = loc + 1
            Next ii

            Return True
        Catch ex As Exception
            MsgBox("Write Value generated Exception: " & ex.Message, MsgBoxStyle.Exclamation, "SimpleOPCInterface Exception")
            Return False
        End Try
    End Function

    ' This sub handles writing a single value to the server using the  'SyncWrite' write method.  The 'SyncWrite' method provides a
    ' quick(programming wise) means to send a value to an OPC Server.  The item you intend to write must already be part of an OPC group you have added
    ' and you must have the ItemServerHandle for the item.  This is another example of how the ItemServerHandle is used and why it is important to properly
    ' store and track these handles.  The 'SyncWrite' method while quick and easy will wait for the OPC Server to complete the operation.  Once you invoke
    ' the 'SyncWrite' method it could take a moment for the OPC Server to return control to your application.  For this example that's OK.  If your application
    ' can't tolerate a pause you can use the 'AsyncWrite' and its associated 'AsyncWriteComplete' call back event instead.  In this sub we are only
    ' writing one value at a time.  The 'SyncWrite' mehtod can take a list of writes to be performed allow you to write entire recipes to the server
    ' in one shot.  If you are going to write more than one item, the ItemServerHandles for each item must be from the same OPC Group.

    Public Sub OPCItemWriteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCItemWriteButton_0.Click, OPCItemWriteButton_1.Click, OPCItemWriteButton_2.Click, OPCItemWriteButton_3.Click, OPCItemWriteButton_4.Click, OPCItemWriteButton_5.Click, OPCItemWriteButton_6.Click, OPCItemWriteButton_7.Click, OPCItemWriteButton_8.Click, OPCItemWriteButton_9.Click
        If Not ConnectedGroup Is Nothing Then
            ' Get control index from name
            Dim index As Short = -1

            If sender.Name = "OPCItemWriteButton_0" Then
                index = 1
            ElseIf sender.Name = "OPCItemWriteButton_1" Then
                index = 2
            ElseIf sender.Name = "OPCItemWriteButton_2" Then
                index = 3
            ElseIf sender.Name = "OPCItemWriteButton_3" Then
                index = 4
            ElseIf sender.Name = "OPCItemWriteButton_4" Then
                index = 5
            ElseIf sender.Name = "OPCItemWriteButton_5" Then
                index = 6
            ElseIf sender.Name = "OPCItemWriteButton_6" Then
                index = 7
            ElseIf sender.Name = "OPCItemWriteButton_7" Then
                index = 8
            ElseIf sender.Name = "OPCItemWriteButton_8" Then
                index = 9
            Else
                index = 10
            End If

            Try
                ' Write only 1 item
                Dim ItemCount As Short = 1

                ' Create some local scope variables to hold the value to be sent.
                ' These arrays could just as easily contain all of the item we have added.
                Dim SyncItemServerHandles(1) As Integer
                Dim SyncItemValues(1) As Object
                Dim SyncItemServerErrors As System.Array
                Dim AnOpcItem As OPCAutomation.OPCItem

                ' Get the Servers handle for the desired item.  The server handles
                ' were returned in add item subroutine.
                SyncItemServerHandles(1) = ItemServerHandles(index)
                AnOpcItem = ConnectedGroup.OPCItems.GetOPCItem(ItemServerHandles(index))

                ' Load the value to be written using Item's Canonical Data Type to
                ' convert to correct type. 
                ' See Kepware Application note on Canonical Data Types
                Dim ItsAnArray As Array
                Dim CanonDT As Short
                CanonDT = AnOpcItem.CanonicalDataType()

                ' If it is an array, figure out the base type
                If CanonDT > vbArray Then
                    CanonDT -= vbArray
                End If

                Select Case CanonDT
                    Case CanonicalDataTypes.CanonDtByte
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(Byte), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToByte(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtChar
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType([SByte]), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToSByte(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtWord
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(UInt16), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToUInt16(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtShort
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(Int16), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToInt16(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtDWord
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(UInt32), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToUInt32(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtLong
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(Int32), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToInt32(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtFloat
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(Single), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToSingle(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtDouble
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(Double), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToDouble(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtBool
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(Boolean), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToBoolean(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case CanonicalDataTypes.CanonDtString
                        If OPCItemIsArray(index) > 0 Then
                            ItsAnArray = Array.CreateInstance(GetType(String), OPCItemIsArray(index))
                            If Not LoadArray(ItsAnArray, CanonDT, OPCItemValueToWrite(index).Text) Then
                                Return
                            End If
                            SyncItemValues(1) = CObj(ItsAnArray)
                        Else
                            SyncItemValues(1) = Convert.ToString(OPCItemValueToWrite(index).Text)
                        End If
                        ' End case

                    Case Else
                        MsgBox("OPCItemWriteButton Unknown data type", MsgBoxStyle.Exclamation)
                        Return
                        ' End case
                End Select

                ' Invoke the SyncWrite operation.  Remember this call will wait until completion
                ConnectedGroup.SyncWrite(ItemCount, SyncItemServerHandles, SyncItemValues, SyncItemServerErrors)

                If SyncItemServerErrors(1) <> 0 Then
                    MsgBox("SyncItemServerError: " & SyncItemServerErrors(1))
                End If
            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server write item failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This sub handles performing a single synchronous read from a single item using the 'SyncRead' method.  The 'SyncRead' method like the 'SyncWrite',
    ' will wait for comletion from the server before returning to your application. There are two sources for data an OPC Server can return to your application.
    ' The first source is from 'Cache' the other is from 'Device'.  The 'SyncRead' method allows you to choose where you want to get the data.  If you choose
    ' 'Cache' the data has the potential to be old data which you can determine by looking at the time stamp on the data.  If you know that the data you are
    ' requesting is actively being scanned by the OPC Server you should be able to invoke the 'SyncRead' method using the mode selection of 'OPCCache'.  If your
    ' not sure if the data you desire is being scanned by the server or its out of date, you can use the mode selection of 'OPCDevice'.  The 'OPCDevice' mode
    ' commands the OPC Server to go and get this item directly from the device and 'DO IT NOW'.  This pretty much insures that you will receive the most recent
    ' value for the time your are requesting.  The downside, when reading from the device directly the 'SyncRead' method will wait for the device to complete
    ' that read operation which could include mire time, modem time, or any other factor that is required to gather data from the actual device.  There are some
    ' benefits to using a 'SyncRead'  in the 'OPCDevice' mode.  If you want to completely control the data acquisition cycle from your application you can
    ' add your groups, add your items, make the items inactive, then use the 'SyncRead' mehtod to forcibly make the server perform read operations when you want.
    ' Using this scheme the server would only talk to the the device when you invoke either a 'SyncRead' or 'SyncWrite' method.  In this example using the KEPServerEx
    ' simulator you can see this effect by connecting with KEPServerEx, adding the default group, adding the default items, and then clicking on the group active
    ' control.  With the data updates stopped you can now click on the SyncRead button for each item and see a single read occur.  If you look at the active tag count
    ' KEPServerEx you will see it momentarily increase each time you press the SyncRead button.

    Public Sub OPCItemSyncReadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCItemSyncReadButton_0.Click, OPCItemSyncReadButton_1.Click, OPCItemSyncReadButton_2.Click, OPCItemSyncReadButton_3.Click, OPCItemSyncReadButton_4.Click, OPCItemSyncReadButton_5.Click, OPCItemSyncReadButton_6.Click, OPCItemSyncReadButton_7.Click, OPCItemSyncReadButton_8.Click, OPCItemSyncReadButton_9.Click
        If Not ConnectedGroup Is Nothing Then
            ' Get control index from name
            Dim index As Short = -1

            If sender.Name = "OPCItemSyncReadButton_0" Then
                index = 1
            ElseIf sender.Name = "OPCItemSyncReadButton_1" Then
                index = 2
            ElseIf sender.Name = "OPCItemSyncReadButton_2" Then
                index = 3
            ElseIf sender.Name = "OPCItemSyncReadButton_3" Then
                index = 4
            ElseIf sender.Name = "OPCItemSyncReadButton_4" Then
                index = 5
            ElseIf sender.Name = "OPCItemSyncReadButton_5" Then
                index = 6
            ElseIf sender.Name = "OPCItemSyncReadButton_6" Then
                index = 7
            ElseIf sender.Name = "OPCItemSyncReadButton_7" Then
                index = 8
            ElseIf sender.Name = "OPCItemSyncReadButton_8" Then
                index = 9
            Else
                index = 10
            End If

            Try
                ' Read only 1 item
                Dim ItemCount As Short = 1

                ' Provide storage the arrays returned by the 'SyncRead' method
                Dim SyncItemServerHandles(1) As Integer
                Dim SyncItemValues As System.Array
                Dim SyncItemServerErrors As System.Array

                ' Get the Servers handle for the desired item.  The server handles were returned in add item subroutine.
                SyncItemServerHandles(1) = ItemServerHandles(index)

                ' Invoke the SyncRead operation.  Remember this call will wait until completion. The source flag in this case, 'OPCDevice' , is set to
                ' read from device which may take some time.
                ConnectedGroup.SyncRead(OPCAutomation.OPCDataSource.OPCDevice, ItemCount, SyncItemServerHandles, SyncItemValues, SyncItemServerErrors)

                ' Save off the value returned after checking for error
                If SyncItemServerErrors(1) = 0 Then
                    If IsArray(SyncItemValues(1)) Then
                        Dim ItsAnArray As Array
                        Dim x As Integer
                        Dim Suffix As String

                        ItsAnArray = SyncItemValues(1)

                        OPCItemValue(index).Text = ""
                        For x = ItsAnArray.GetLowerBound(0) To ItsAnArray.GetUpperBound(0)
                            If x = ItsAnArray.GetUpperBound(0) Then
                                Suffix = ""
                            Else
                                Suffix = ", "
                            End If
                            OPCItemValue(index).Text =
                             OPCItemValue(index).Text & ItsAnArray(x) & Suffix
                        Next x
                    Else
                        OPCItemValue(index).Text = SyncItemValues(1)
                    End If
                Else
                    MsgBox("SyncItemServerError: " & SyncItemServerErrors(1))
                End If

            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server read item failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This Sub sets the active state of an individual item.  Like the other methods that perform operation on either a single item of list of items, the
    ' 'SetActive' method requires the ItemServerHandle of the item to be modified. Using the active state of an item allows you to control the amount of work
    ' the OPC Server is doing when communicating with a device.  You could add all the item you desire to read in an Active state but if some of those items are
    ' not currently in use you can improve the performance of the OPC Server by making those items inactive.  We suggest that you make the items not currently be used
    ' inactive instead of removing them from the group.  Watch the KEPServerEx active item count at the bottom of its windows as you change the state of items.

    Public Sub OPCItemActiveState_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCItemActiveState_0.CheckedChanged, OPCItemActiveState_1.CheckedChanged, OPCItemActiveState_2.CheckedChanged, OPCItemActiveState_3.CheckedChanged, OPCItemActiveState_4.CheckedChanged, OPCItemActiveState_5.CheckedChanged, OPCItemActiveState_6.CheckedChanged, OPCItemActiveState_7.CheckedChanged, OPCItemActiveState_8.CheckedChanged, OPCItemActiveState_9.CheckedChanged
        If Not ConnectedGroup Is Nothing Then
            ' Get control index from name
            Dim index As Short = -1

            If sender.Name = "OPCItemActiveState_0" Then
                index = 1
            ElseIf sender.Name = "OPCItemActiveState_1" Then
                index = 2
            ElseIf sender.Name = "OPCItemActiveState_2" Then
                index = 3
            ElseIf sender.Name = "OPCItemActiveState_3" Then
                index = 4
            ElseIf sender.Name = "OPCItemActiveState_4" Then
                index = 5
            ElseIf sender.Name = "OPCItemActiveState_5" Then
                index = 6
            ElseIf sender.Name = "OPCItemActiveState_6" Then
                index = 7
            ElseIf sender.Name = "OPCItemActiveState_7" Then
                index = 8
            ElseIf sender.Name = "OPCItemActiveState_8" Then
                index = 9
            Else
                index = 10
            End If

            Try
                ' Change only 1 item
                Dim ItemCount As Short = 1

                ' Dim local arrays to pass desired item for state change
                Dim ActiveItemServerHandles(1) As Integer
                Dim ActiveState As Boolean
                Dim ActiveItemErrors As System.Array

                ' Get the desired state from the control.
                ActiveState = OPCItemActiveState(index).CheckState

                ' Get the Servers handle for the desired item.  The server handles were returned in add item subroutine.
                ActiveItemServerHandles(1) = ItemServerHandles(index)

                ' Invoke the SetActive operation on the OPC item collection interface
                ConnectedGroup.OPCItems.SetActive(ItemCount, ActiveItemServerHandles, ActiveState, ActiveItemErrors)

            Catch ex As Exception
                ' Error handling
                MessageBox.Show("OPC server set active state failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    ' This sub handles the 'DataChange' call back event which returns data that has been detected as changed within the OPC Server.  This call back should be
    ' used primarily to receive the data.  Do not make any other calls back into the OPC server from this call back.  The other item related functions covered
    ' in this example have shown how the ItemServerHandle is used to control and manipulate individual items in the OPC server.  The 'DataChange' event allows
    ' us to see how the 'ClientHandles we gave the OPC Server when adding items are used.  As you can see here the server returns the 'ClientHandles' as an array.
    ' The number of item returned in this event can change from trigger to trigger so don't count on always getting a 1 to 1 match with the number of items
    ' you have registered.  That where the 'ClientHandles' come into play.  Using the 'ClientHandles' returned here you can determine what data has changed and
    ' where in your application the data should go.  In this example the 'ClientHandles' were the Index number of each item we added to the group.
    ' Using this returned index number the 'DataChange' handler shown here knows what controls need to be updated with new data.  In your application you can
    ' make the client handles anything you like as long as they allow you to uniquely identify each item as it returned in this event.

    Public Sub ConnectedGroup_DataChange(ByVal TransactionID As Integer, ByVal NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array) Handles ConnectedGroup.DataChange
        ' We don't have error handling here since this is an event called from the OPC interface

        Try
            Dim i As Short
            For i = 1 To NumItems
                ' Use the 'Clienthandles' array returned by the server to pull out the index number of the control to update and load the value.
                If IsArray(ItemValues(i)) Then
                    Dim ItsAnArray As Array
                    Dim x As Integer
                    Dim Suffix As String

                    ItsAnArray = ItemValues(i)

                    ' Store the size of array for use by sync write
                    OPCItemIsArray(ClientHandles(i)) = ItsAnArray.GetUpperBound(0) + 1

                    OPCItemValue(ClientHandles(i)).Text = ""
                    For x = ItsAnArray.GetLowerBound(0) To ItsAnArray.GetUpperBound(0)
                        If x = ItsAnArray.GetUpperBound(0) Then
                            Suffix = ""
                        Else
                            Suffix = ", "
                        End If
                        OPCItemValue(ClientHandles(i)).Text =
                         OPCItemValue(ClientHandles(i)).Text & ItsAnArray(x) & Suffix
                    Next x
                Else
                    OPCItemValue(ClientHandles(i)).Text = ItemValues(i)
                End If

                ' Check the Qualties for each item retured here.  The actual contents of the quality field can contain bit field data which can provide specific
                ' error conditions.  Normally if everything is OK then the quality will contain the 0xC0

                If (Qualities(i) And OPCAutomation.OPCQuality.OPCQualityGood) = OPCAutomation.OPCQuality.OPCQualityGood Then
                    OPCItemQuality(ClientHandles(i)).Text = "Good"
                ElseIf (Qualities(i) And OPCAutomation.OPCQuality.OPCQualityUncertain) = OPCAutomation.OPCQuality.OPCQualityUncertain Then
                    OPCItemQuality(ClientHandles(i)).Text = "Uncertain"
                Else
                    OPCItemQuality(ClientHandles(i)).Text = "Bad"
                End If
            Next i
        Catch ex As Exception
            ' Error handling
            MessageBox.Show("OPC DataChange failed with exception: " + ex.Message, "SimpleOPCInterface Exception", MessageBoxButtons.OK)
        End Try
    End Sub

    ' This sub handles exiting the example and properly disconnecting
    ' from the OPC server in an orderly fashion.  Like the force order
    ' of the controls on this form, the exit attempts to remove the Items
    ' from the group, then the group from the server and finally disconnect
    ' from the server.  This is also why each of the subroutines had the test
    ' to see if the Object to be removed was already set to 'Nothing'.
    Public Sub ExitExample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitExample.Click

        ExitApp()

    End Sub
    Public Sub ExitApp()
        ' These calls will remove the OPC items, Group, and Disconnect in the proper order
        Call OPCRemoveItems_Click(OPCRemoveItems, New System.EventArgs)
        Call RemoveOPCGroup_Click(RemoveOPCGroup, New System.EventArgs)
        Call DisconnectFromServer_Click(DisconnectFromServer, New System.EventArgs)
        End
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        DataOverview.Show()

    End Sub

    Private Sub OPCItemName_0_TextChanged(sender As Object, e As EventArgs) Handles OPCItemName_0.TextChanged

    End Sub
End Class

