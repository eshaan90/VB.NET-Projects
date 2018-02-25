<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
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
        Me.components = New System.ComponentModel.Container()
        Dim Alarm_NumberLabel As System.Windows.Forms.Label
        Dim Alarm_DateLabel As System.Windows.Forms.Label
        Dim Alarm__DetailsLabel As System.Windows.Forms.Label
        Dim Unit_NameLabel As System.Windows.Forms.Label
        Dim Alarm_StatusLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Alarm_ManagementDataSet = New WindowsApplication1.Alarm_ManagementDataSet()
        Me.Alarms_DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alarms_DatabaseTableAdapter = New WindowsApplication1.Alarm_ManagementDataSetTableAdapters.Alarms_DatabaseTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Alarm_ManagementDataSetTableAdapters.TableAdapterManager()
        Me.Alarm_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Alarm_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Alarm__DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Alarm_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Alarm_NumberLabel = New System.Windows.Forms.Label()
        Alarm_DateLabel = New System.Windows.Forms.Label()
        Alarm__DetailsLabel = New System.Windows.Forms.Label()
        Unit_NameLabel = New System.Windows.Forms.Label()
        Alarm_StatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alarm_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alarms_DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 127)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(74, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Show B"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hide B"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(140, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 288)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "B"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(388, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Show A"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(187, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Hide A"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(528, 192)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "c"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(528, 192)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "d"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(315, 279)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "30.0"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(720, 301)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "text"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Alarm_NumberLabel)
        Me.GroupBox3.Controls.Add(Me.Alarm_NumberTextBox)
        Me.GroupBox3.Controls.Add(Alarm_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Alarm_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Alarm__DetailsLabel)
        Me.GroupBox3.Controls.Add(Me.Alarm__DetailsTextBox)
        Me.GroupBox3.Controls.Add(Unit_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Unit_NameTextBox)
        Me.GroupBox3.Controls.Add(Alarm_StatusLabel)
        Me.GroupBox3.Controls.Add(Me.Alarm_StatusTextBox)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(908, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(679, 636)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.Alarms_DatabaseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(653, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'Alarm_ManagementDataSet
        '
        Me.Alarm_ManagementDataSet.DataSetName = "Alarm_ManagementDataSet"
        Me.Alarm_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Alarms_DatabaseBindingSource
        '
        Me.Alarms_DatabaseBindingSource.DataSource = Me.Alarm_ManagementDataSet
        Me.Alarms_DatabaseBindingSource.Position = 0
        '
        'Alarms_DatabaseTableAdapter
        '
        Me.Alarms_DatabaseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Alarms_DatabaseTableAdapter = Me.Alarms_DatabaseTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Alarm_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Alarm_NumberLabel
        '
        Alarm_NumberLabel.AutoSize = True
        Alarm_NumberLabel.Location = New System.Drawing.Point(36, 433)
        Alarm_NumberLabel.Name = "Alarm_NumberLabel"
        Alarm_NumberLabel.Size = New System.Drawing.Size(76, 13)
        Alarm_NumberLabel.TabIndex = 1
        Alarm_NumberLabel.Text = "Alarm Number:"
        '
        'Alarm_NumberTextBox
        '
        Me.Alarm_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alarms_DatabaseBindingSource, "Alarm Number", True))
        Me.Alarm_NumberTextBox.Location = New System.Drawing.Point(118, 430)
        Me.Alarm_NumberTextBox.Name = "Alarm_NumberTextBox"
        Me.Alarm_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Alarm_NumberTextBox.TabIndex = 2
        '
        'Alarm_DateLabel
        '
        Alarm_DateLabel.AutoSize = True
        Alarm_DateLabel.Location = New System.Drawing.Point(36, 460)
        Alarm_DateLabel.Name = "Alarm_DateLabel"
        Alarm_DateLabel.Size = New System.Drawing.Size(62, 13)
        Alarm_DateLabel.TabIndex = 3
        Alarm_DateLabel.Text = "Alarm Date:"
        '
        'Alarm_DateDateTimePicker
        '
        Me.Alarm_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Alarms_DatabaseBindingSource, "Alarm_Date", True))
        Me.Alarm_DateDateTimePicker.Location = New System.Drawing.Point(118, 456)
        Me.Alarm_DateDateTimePicker.Name = "Alarm_DateDateTimePicker"
        Me.Alarm_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Alarm_DateDateTimePicker.TabIndex = 4
        '
        'Alarm__DetailsLabel
        '
        Alarm__DetailsLabel.AutoSize = True
        Alarm__DetailsLabel.Location = New System.Drawing.Point(36, 485)
        Alarm__DetailsLabel.Name = "Alarm__DetailsLabel"
        Alarm__DetailsLabel.Size = New System.Drawing.Size(74, 13)
        Alarm__DetailsLabel.TabIndex = 5
        Alarm__DetailsLabel.Text = "Alarm  Details:"
        '
        'Alarm__DetailsTextBox
        '
        Me.Alarm__DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alarms_DatabaseBindingSource, "Alarm _Details", True))
        Me.Alarm__DetailsTextBox.Location = New System.Drawing.Point(118, 482)
        Me.Alarm__DetailsTextBox.Name = "Alarm__DetailsTextBox"
        Me.Alarm__DetailsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Alarm__DetailsTextBox.TabIndex = 6
        '
        'Unit_NameLabel
        '
        Unit_NameLabel.AutoSize = True
        Unit_NameLabel.Location = New System.Drawing.Point(36, 511)
        Unit_NameLabel.Name = "Unit_NameLabel"
        Unit_NameLabel.Size = New System.Drawing.Size(60, 13)
        Unit_NameLabel.TabIndex = 7
        Unit_NameLabel.Text = "Unit Name:"
        '
        'Unit_NameTextBox
        '
        Me.Unit_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alarms_DatabaseBindingSource, "Unit_Name", True))
        Me.Unit_NameTextBox.Location = New System.Drawing.Point(118, 508)
        Me.Unit_NameTextBox.Name = "Unit_NameTextBox"
        Me.Unit_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Unit_NameTextBox.TabIndex = 8
        '
        'Alarm_StatusLabel
        '
        Alarm_StatusLabel.AutoSize = True
        Alarm_StatusLabel.Location = New System.Drawing.Point(36, 537)
        Alarm_StatusLabel.Name = "Alarm_StatusLabel"
        Alarm_StatusLabel.Size = New System.Drawing.Size(69, 13)
        Alarm_StatusLabel.TabIndex = 9
        Alarm_StatusLabel.Text = "Alarm Status:"
        '
        'Alarm_StatusTextBox
        '
        Me.Alarm_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alarms_DatabaseBindingSource, "Alarm_Status", True))
        Me.Alarm_StatusTextBox.Location = New System.Drawing.Point(118, 534)
        Me.Alarm_StatusTextBox.Name = "Alarm_StatusTextBox"
        Me.Alarm_StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Alarm_StatusTextBox.TabIndex = 10
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(450, 474)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 38)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Acknowledge One"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(450, 525)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(128, 38)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Acknowledge All"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(450, 420)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(128, 38)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Update"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1610, 882)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Setup"
        Me.Text = "Setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alarm_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alarms_DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Alarm_ManagementDataSet As Alarm_ManagementDataSet
    Friend WithEvents Alarms_DatabaseBindingSource As BindingSource
    Friend WithEvents Alarms_DatabaseTableAdapter As Alarm_ManagementDataSetTableAdapters.Alarms_DatabaseTableAdapter
    Friend WithEvents TableAdapterManager As Alarm_ManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Alarm_NumberTextBox As TextBox
    Friend WithEvents Alarm_DateDateTimePicker As DateTimePicker
    Friend WithEvents Alarm__DetailsTextBox As TextBox
    Friend WithEvents Unit_NameTextBox As TextBox
    Friend WithEvents Alarm_StatusTextBox As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button11 As Button
End Class
