<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedalleria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CUBA", "5", "2", "4"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"GEORGIA", "2", "1", "4"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COLOMBIA", "3", "2", "3"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedalleria))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtMedBronce = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.txtMedPlata = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtMedOro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lvMedalleria = New System.Windows.Forms.ListView()
        Me.cPais = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cMedOro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cMedPlata = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cMedBronce = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarPaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtMedBronce)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.btnOrdenar)
        Me.GroupBox4.Controls.Add(Me.txtMedPlata)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtPais)
        Me.GroupBox4.Controls.Add(Me.txtMedOro)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 135)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingreso de informacion"
        '
        'txtMedBronce
        '
        Me.txtMedBronce.ForeColor = System.Drawing.Color.Black
        Me.txtMedBronce.Location = New System.Drawing.Point(154, 102)
        Me.txtMedBronce.MaxLength = 5
        Me.txtMedBronce.Name = "txtMedBronce"
        Me.txtMedBronce.Size = New System.Drawing.Size(71, 21)
        Me.txtMedBronce.TabIndex = 3
        Me.txtMedBronce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Medallas de bronce:"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackgroundImage = Global.ConcursoCamisetas.My.Resources.Resources.sort_asc
        Me.btnOrdenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrdenar.Location = New System.Drawing.Point(325, 48)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(75, 75)
        Me.btnOrdenar.TabIndex = 5
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'txtMedPlata
        '
        Me.txtMedPlata.ForeColor = System.Drawing.Color.Black
        Me.txtMedPlata.Location = New System.Drawing.Point(154, 75)
        Me.txtMedPlata.MaxLength = 5
        Me.txtMedPlata.Name = "txtMedPlata"
        Me.txtMedPlata.Size = New System.Drawing.Size(71, 21)
        Me.txtMedPlata.TabIndex = 2
        Me.txtMedPlata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.ConcursoCamisetas.My.Resources.Resources.add
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.Location = New System.Drawing.Point(240, 48)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 75)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Medallas de plata:"
        '
        'txtPais
        '
        Me.txtPais.ForeColor = System.Drawing.Color.Black
        Me.txtPais.Location = New System.Drawing.Point(56, 21)
        Me.txtPais.MaxLength = 1000
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(344, 21)
        Me.txtPais.TabIndex = 0
        Me.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMedOro
        '
        Me.txtMedOro.ForeColor = System.Drawing.Color.Black
        Me.txtMedOro.Location = New System.Drawing.Point(154, 48)
        Me.txtMedOro.MaxLength = 5
        Me.txtMedOro.Name = "txtMedOro"
        Me.txtMedOro.Size = New System.Drawing.Size(71, 21)
        Me.txtMedOro.TabIndex = 1
        Me.txtMedOro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Medallas de oro:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Pais:"
        '
        'lvMedalleria
        '
        Me.lvMedalleria.AutoArrange = False
        Me.lvMedalleria.BackColor = System.Drawing.SystemColors.Window
        Me.lvMedalleria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cPais, Me.cMedOro, Me.cMedPlata, Me.cMedBronce})
        Me.lvMedalleria.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvMedalleria.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMedalleria.FullRowSelect = True
        Me.lvMedalleria.GridLines = True
        Me.lvMedalleria.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvMedalleria.HideSelection = False
        Me.lvMedalleria.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lvMedalleria.Location = New System.Drawing.Point(12, 153)
        Me.lvMedalleria.MultiSelect = False
        Me.lvMedalleria.Name = "lvMedalleria"
        Me.lvMedalleria.ShowItemToolTips = True
        Me.lvMedalleria.Size = New System.Drawing.Size(675, 230)
        Me.lvMedalleria.TabIndex = 35
        Me.lvMedalleria.TabStop = False
        Me.lvMedalleria.UseCompatibleStateImageBehavior = False
        Me.lvMedalleria.View = System.Windows.Forms.View.Details
        '
        'cPais
        '
        Me.cPais.Text = "Pais"
        Me.cPais.Width = 200
        '
        'cMedOro
        '
        Me.cMedOro.Text = "Medallas de oro"
        Me.cMedOro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cMedOro.Width = 150
        '
        'cMedPlata
        '
        Me.cMedPlata.Text = "Medallas de plata"
        Me.cMedPlata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cMedPlata.Width = 150
        '
        'cMedBronce
        '
        Me.cMedBronce.Text = "Medallas de bronce"
        Me.cMedBronce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cMedBronce.Width = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarPaisToolStripMenuItem, Me.EliminarPaisToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 48)
        Me.ContextMenuStrip1.Text = "Opciones"
        '
        'ModificarPaisToolStripMenuItem
        '
        Me.ModificarPaisToolStripMenuItem.Image = Global.ConcursoCamisetas.My.Resources.Resources.edit
        Me.ModificarPaisToolStripMenuItem.Name = "ModificarPaisToolStripMenuItem"
        Me.ModificarPaisToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ModificarPaisToolStripMenuItem.Text = "&Modificar pais"
        Me.ModificarPaisToolStripMenuItem.ToolTipText = "Modificar el pais seleccionado"
        '
        'EliminarPaisToolStripMenuItem
        '
        Me.EliminarPaisToolStripMenuItem.Image = Global.ConcursoCamisetas.My.Resources.Resources.delete
        Me.EliminarPaisToolStripMenuItem.Name = "EliminarPaisToolStripMenuItem"
        Me.EliminarPaisToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EliminarPaisToolStripMenuItem.Text = "&Eliminar pais"
        Me.EliminarPaisToolStripMenuItem.ToolTipText = "Eliminar el pais seleccionado"
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.ConcursoCamisetas.My.Resources.Resources.logo_rio2016
        Me.pbLogo.Location = New System.Drawing.Point(434, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(253, 135)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 36
        Me.pbLogo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Creador por: Ing. Jeyson Zuñiga Gomez -->"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(310, 395)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(155, 16)
        Me.LinkLabel1.TabIndex = 45
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://fb.me/jeysonzg"
        '
        'frmMedalleria
        '
        Me.AcceptButton = Me.btnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 423)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lvMedalleria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMedalleria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medalleria J.J.O.O. Rio 2016 - by Jeyson Zuñiga G."
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMedOro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lvMedalleria As System.Windows.Forms.ListView
    Friend WithEvents cPais As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMedOro As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMedPlata As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMedBronce As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents txtMedBronce As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMedPlata As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOrdenar As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarPaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarPaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
