<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonTes = New System.Windows.Forms.Button()
        Me.ButtonPrestasi = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Location = New System.Drawing.Point(-1, 75)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 594)
        Me.Panel1.TabIndex = 21
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.ForeColor = System.Drawing.SystemColors.Control
        Me.Button9.Location = New System.Drawing.Point(28, 527)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 41)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Log Out"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(937, 80)
        Me.GroupBox1.TabIndex = 20
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
        Me.PictureBox1.Location = New System.Drawing.Point(65, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Jalur Pendaftaran"
        '
        'ButtonTes
        '
        Me.ButtonTes.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonTes.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTes.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ButtonTes.Location = New System.Drawing.Point(591, 179)
        Me.ButtonTes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTes.Name = "ButtonTes"
        Me.ButtonTes.Size = New System.Drawing.Size(282, 41)
        Me.ButtonTes.TabIndex = 24
        Me.ButtonTes.Text = "Teknik Mesin dan Otomotif"
        Me.ButtonTes.UseVisualStyleBackColor = False
        '
        'ButtonPrestasi
        '
        Me.ButtonPrestasi.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonPrestasi.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrestasi.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonPrestasi.Location = New System.Drawing.Point(221, 179)
        Me.ButtonPrestasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonPrestasi.Name = "ButtonPrestasi"
        Me.ButtonPrestasi.Size = New System.Drawing.Size(282, 41)
        Me.ButtonPrestasi.TabIndex = 23
        Me.ButtonPrestasi.Text = "Teknik dan Teknologi"
        Me.ButtonPrestasi.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button2.Location = New System.Drawing.Point(-2, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 49)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Data Peminatan"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(-2, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Verifikasi Dokumen"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button5.Location = New System.Drawing.Point(-2, 34)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(192, 47)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Data Pendaftar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama, Me.jurusan})
        Me.DataGridView1.Location = New System.Drawing.Point(221, 261)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(652, 342)
        Me.DataGridView1.TabIndex = 27
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.MinimumWidth = 8
        Me.nama.Name = "nama"
        Me.nama.Width = 150
        '
        'jurusan
        '
        Me.jurusan.HeaderText = "Jurusan"
        Me.jurusan.MinimumWidth = 8
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Width = 150
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 665)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonTes)
        Me.Controls.Add(Me.ButtonPrestasi)
        Me.Name = "Form12"
        Me.Text = "Form12"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonTes As Button
    Friend WithEvents ButtonPrestasi As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jurusan As DataGridViewTextBoxColumn
End Class
