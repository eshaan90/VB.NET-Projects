<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alarms_Page
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Alarm_recorderDataSet = New WindowsApplication1.alarm_recorderDataSet()
        Me.AlarmsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlarmsTableAdapter = New WindowsApplication1.alarm_recorderDataSetTableAdapters.AlarmsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AlarmIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alarm_recorderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlarmsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(134, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Drawworks"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlarmIDDataGridViewTextBoxColumn, Me.AlarmTimeDataGridViewTextBoxColumn, Me.AlarmDescriptionDataGridViewTextBoxColumn, Me.MachineUnitDataGridViewTextBoxColumn, Me.AlarmStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlarmsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(240, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1033, 583)
        Me.DataGridView1.TabIndex = 4
        '
        'Alarm_recorderDataSet
        '
        Me.Alarm_recorderDataSet.DataSetName = "alarm_recorderDataSet"
        Me.Alarm_recorderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlarmsBindingSource
        '
        Me.AlarmsBindingSource.DataMember = "Alarms"
        Me.AlarmsBindingSource.DataSource = Me.Alarm_recorderDataSet
        '
        'AlarmsTableAdapter
        '
        Me.AlarmsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(560, 791)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ack One"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(832, 791)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 29)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Ack All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AlarmIDDataGridViewTextBoxColumn
        '
        Me.AlarmIDDataGridViewTextBoxColumn.DataPropertyName = "Alarm ID"
        Me.AlarmIDDataGridViewTextBoxColumn.HeaderText = "Alarm ID"
        Me.AlarmIDDataGridViewTextBoxColumn.Name = "AlarmIDDataGridViewTextBoxColumn"
        Me.AlarmIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlarmTimeDataGridViewTextBoxColumn
        '
        Me.AlarmTimeDataGridViewTextBoxColumn.DataPropertyName = "Alarm Time"
        Me.AlarmTimeDataGridViewTextBoxColumn.HeaderText = "Alarm Time"
        Me.AlarmTimeDataGridViewTextBoxColumn.Name = "AlarmTimeDataGridViewTextBoxColumn"
        Me.AlarmTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlarmTimeDataGridViewTextBoxColumn.Width = 120
        '
        'AlarmDescriptionDataGridViewTextBoxColumn
        '
        Me.AlarmDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Alarm Description"
        Me.AlarmDescriptionDataGridViewTextBoxColumn.HeaderText = "Alarm Description"
        Me.AlarmDescriptionDataGridViewTextBoxColumn.Name = "AlarmDescriptionDataGridViewTextBoxColumn"
        Me.AlarmDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlarmDescriptionDataGridViewTextBoxColumn.Width = 500
        '
        'MachineUnitDataGridViewTextBoxColumn
        '
        Me.MachineUnitDataGridViewTextBoxColumn.DataPropertyName = "Machine Unit"
        Me.MachineUnitDataGridViewTextBoxColumn.HeaderText = "Machine Unit"
        Me.MachineUnitDataGridViewTextBoxColumn.Name = "MachineUnitDataGridViewTextBoxColumn"
        Me.MachineUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.MachineUnitDataGridViewTextBoxColumn.Width = 120
        '
        'AlarmStatusDataGridViewTextBoxColumn
        '
        Me.AlarmStatusDataGridViewTextBoxColumn.DataPropertyName = "Alarm Status"
        Me.AlarmStatusDataGridViewTextBoxColumn.HeaderText = "Alarm Status"
        Me.AlarmStatusDataGridViewTextBoxColumn.Name = "AlarmStatusDataGridViewTextBoxColumn"
        Me.AlarmStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlarmStatusDataGridViewTextBoxColumn.Width = 150
        '
        'Alarms_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1616, 911)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Alarms_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarms_Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alarm_recorderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlarmsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Alarm_recorderDataSet As alarm_recorderDataSet
    Friend WithEvents AlarmsBindingSource As BindingSource
    Friend WithEvents AlarmsTableAdapter As alarm_recorderDataSetTableAdapters.AlarmsTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents AlarmIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachineUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlarmStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
