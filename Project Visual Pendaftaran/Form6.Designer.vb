<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colNama = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colUpload = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 80)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(213, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PPDB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 490)
        Me.Panel1.TabIndex = 11
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.ForeColor = System.Drawing.SystemColors.Control
        Me.Button9.Location = New System.Drawing.Point(21, 420)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 41)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Log Out"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button5.Location = New System.Drawing.Point(-5, 9)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(204, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Dashboard"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNama, Me.colStatus, Me.colFile, Me.colUpload, Me.colHapus})
        Me.DataGridView1.Location = New System.Drawing.Point(192, 222)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(834, 328)
        Me.DataGridView1.TabIndex = 14
        '
        'colNama
        '
        Me.colNama.DataPropertyName = "(none"
        Me.colNama.HeaderText = "Nama Dokumen"
        Me.colNama.MinimumWidth = 8
        Me.colNama.Name = "colNama"
        Me.colNama.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colNama.Width = 150
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 8
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colStatus.Width = 150
        '
        'colFile
        '
        Me.colFile.HeaderText = "File PDF"
        Me.colFile.MinimumWidth = 8
        Me.colFile.Name = "colFile"
        Me.colFile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colFile.Width = 150
        '
        'colUpload
        '
        Me.colUpload.HeaderText = "Upload"
        Me.colUpload.MinimumWidth = 8
        Me.colUpload.Name = "colUpload"
        Me.colUpload.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUpload.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colUpload.Width = 150
        '
        'colHapus
        '
        Me.colHapus.HeaderText = "Hapus"
        Me.colHapus.MinimumWidth = 8
        Me.colHapus.Name = "colHapus"
        Me.colHapus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colHapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colHapus.Width = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Pilih Jalur Pendaftaran"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSalmon
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Button4.Location = New System.Drawing.Point(637, 163)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 41)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Non Tes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Button3.Location = New System.Drawing.Point(424, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 41)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Tes"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button2.Location = New System.Drawing.Point(196, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 41)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Prestasi"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 562)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colNama As DataGridViewButtonColumn
    Friend WithEvents colStatus As DataGridViewButtonColumn
    Friend WithEvents colFile As DataGridViewButtonColumn
    Friend WithEvents colUpload As DataGridViewButtonColumn
    Friend WithEvents colHapus As DataGridViewButtonColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
