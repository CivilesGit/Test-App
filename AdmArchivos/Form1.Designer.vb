<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtPathIzquierda = New System.Windows.Forms.TextBox()
        Me.txtPathDerecha = New System.Windows.Forms.TextBox()
        Me.cboUnidadesIzquierda = New System.Windows.Forms.ComboBox()
        Me.cboUnidadesDerecha = New System.Windows.Forms.ComboBox()
        Me.lstViewDerecha = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lstViewIzquierda = New System.Windows.Forms.ListView()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.pnlIDialogBorrar = New System.Windows.Forms.Panel()
        Me.pbarBorrando = New System.Windows.Forms.ProgressBar()
        Me.lblBorrandoInfo = New System.Windows.Forms.Label()
        Me.cmdCopiarIzqADer = New System.Windows.Forms.Button()
        Me.pnlCopiar = New System.Windows.Forms.Panel()
        Me.lblCopiandoA = New System.Windows.Forms.Label()
        Me.lblCopiandoDe = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbarCopiar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCopiarDerAIzq = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.pnlIDialogBorrar.SuspendLayout()
        Me.pnlCopiar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPathIzquierda
        '
        Me.txtPathIzquierda.Enabled = False
        Me.txtPathIzquierda.Location = New System.Drawing.Point(62, 14)
        Me.txtPathIzquierda.Name = "txtPathIzquierda"
        Me.txtPathIzquierda.Size = New System.Drawing.Size(334, 20)
        Me.txtPathIzquierda.TabIndex = 4
        '
        'txtPathDerecha
        '
        Me.txtPathDerecha.Enabled = False
        Me.txtPathDerecha.Location = New System.Drawing.Point(472, 14)
        Me.txtPathDerecha.Name = "txtPathDerecha"
        Me.txtPathDerecha.Size = New System.Drawing.Size(334, 20)
        Me.txtPathDerecha.TabIndex = 5
        '
        'cboUnidadesIzquierda
        '
        Me.cboUnidadesIzquierda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadesIzquierda.FormattingEnabled = True
        Me.cboUnidadesIzquierda.Location = New System.Drawing.Point(9, 14)
        Me.cboUnidadesIzquierda.Name = "cboUnidadesIzquierda"
        Me.cboUnidadesIzquierda.Size = New System.Drawing.Size(49, 21)
        Me.cboUnidadesIzquierda.TabIndex = 8
        '
        'cboUnidadesDerecha
        '
        Me.cboUnidadesDerecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadesDerecha.FormattingEnabled = True
        Me.cboUnidadesDerecha.Location = New System.Drawing.Point(420, 14)
        Me.cboUnidadesDerecha.Name = "cboUnidadesDerecha"
        Me.cboUnidadesDerecha.Size = New System.Drawing.Size(49, 21)
        Me.cboUnidadesDerecha.TabIndex = 9
        '
        'lstViewDerecha
        '
        Me.lstViewDerecha.HideSelection = False
        Me.lstViewDerecha.Location = New System.Drawing.Point(420, 39)
        Me.lstViewDerecha.MultiSelect = False
        Me.lstViewDerecha.Name = "lstViewDerecha"
        Me.lstViewDerecha.Size = New System.Drawing.Size(386, 345)
        Me.lstViewDerecha.SmallImageList = Me.ImageList1
        Me.lstViewDerecha.TabIndex = 10
        Me.lstViewDerecha.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_48.png")
        Me.ImageList1.Images.SetKeyName(1, "paper_48.png")
        Me.ImageList1.Images.SetKeyName(2, "page.ico")
        Me.ImageList1.Images.SetKeyName(3, "pdf.ico")
        Me.ImageList1.Images.SetKeyName(4, "process.ico")
        Me.ImageList1.Images.SetKeyName(5, "word.ico")
        Me.ImageList1.Images.SetKeyName(6, "application.ico")
        Me.ImageList1.Images.SetKeyName(7, "archive.ico")
        Me.ImageList1.Images.SetKeyName(8, "attachment.ico")
        Me.ImageList1.Images.SetKeyName(9, "calendar_date.ico")
        Me.ImageList1.Images.SetKeyName(10, "computer.ico")
        Me.ImageList1.Images.SetKeyName(11, "database.ico")
        Me.ImageList1.Images.SetKeyName(12, "email.ico")
        Me.ImageList1.Images.SetKeyName(13, "folder.ico")
        Me.ImageList1.Images.SetKeyName(14, "image.ico")
        Me.ImageList1.Images.SetKeyName(15, "info.ico")
        Me.ImageList1.Images.SetKeyName(16, "mail.ico")
        Me.ImageList1.Images.SetKeyName(17, "back.ico")
        Me.ImageList1.Images.SetKeyName(18, "access-icon.png")
        Me.ImageList1.Images.SetKeyName(19, "cross_48.png")
        Me.ImageList1.Images.SetKeyName(20, "dll_file.png")
        Me.ImageList1.Images.SetKeyName(21, "floppy_disk_48.png")
        Me.ImageList1.Images.SetKeyName(22, "ms-excel.png")
        Me.ImageList1.Images.SetKeyName(23, "warning_48.png")
        '
        'lstViewIzquierda
        '
        Me.lstViewIzquierda.HideSelection = False
        Me.lstViewIzquierda.Location = New System.Drawing.Point(9, 39)
        Me.lstViewIzquierda.MultiSelect = False
        Me.lstViewIzquierda.Name = "lstViewIzquierda"
        Me.lstViewIzquierda.Size = New System.Drawing.Size(387, 345)
        Me.lstViewIzquierda.SmallImageList = Me.ImageList1
        Me.lstViewIzquierda.TabIndex = 11
        Me.lstViewIzquierda.UseCompatibleStateImageBehavior = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmdBorrar.Location = New System.Drawing.Point(360, 387)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(91, 25)
        Me.cmdBorrar.TabIndex = 12
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'pnlIDialogBorrar
        '
        Me.pnlIDialogBorrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIDialogBorrar.Controls.Add(Me.pbarBorrando)
        Me.pnlIDialogBorrar.Controls.Add(Me.lblBorrandoInfo)
        Me.pnlIDialogBorrar.Location = New System.Drawing.Point(185, 152)
        Me.pnlIDialogBorrar.Name = "pnlIDialogBorrar"
        Me.pnlIDialogBorrar.Size = New System.Drawing.Size(497, 135)
        Me.pnlIDialogBorrar.TabIndex = 13
        Me.pnlIDialogBorrar.Visible = False
        '
        'pbarBorrando
        '
        Me.pbarBorrando.Location = New System.Drawing.Point(11, 101)
        Me.pbarBorrando.Name = "pbarBorrando"
        Me.pbarBorrando.Size = New System.Drawing.Size(471, 20)
        Me.pbarBorrando.TabIndex = 1
        '
        'lblBorrandoInfo
        '
        Me.lblBorrandoInfo.Location = New System.Drawing.Point(11, 17)
        Me.lblBorrandoInfo.Name = "lblBorrandoInfo"
        Me.lblBorrandoInfo.Size = New System.Drawing.Size(471, 71)
        Me.lblBorrandoInfo.TabIndex = 0
        Me.lblBorrandoInfo.Text = "Borrando:"
        Me.lblBorrandoInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmdCopiarIzqADer
        '
        Me.cmdCopiarIzqADer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmdCopiarIzqADer.Location = New System.Drawing.Point(116, 387)
        Me.cmdCopiarIzqADer.Name = "cmdCopiarIzqADer"
        Me.cmdCopiarIzqADer.Size = New System.Drawing.Size(105, 25)
        Me.cmdCopiarIzqADer.TabIndex = 14
        Me.cmdCopiarIzqADer.Text = "Copiar de ^ a >"
        Me.cmdCopiarIzqADer.UseVisualStyleBackColor = True
        '
        'pnlCopiar
        '
        Me.pnlCopiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCopiar.Controls.Add(Me.lblCopiandoA)
        Me.pnlCopiar.Controls.Add(Me.lblCopiandoDe)
        Me.pnlCopiar.Controls.Add(Me.Label2)
        Me.pnlCopiar.Controls.Add(Me.pbarCopiar)
        Me.pnlCopiar.Controls.Add(Me.Label1)
        Me.pnlCopiar.Location = New System.Drawing.Point(185, 82)
        Me.pnlCopiar.Name = "pnlCopiar"
        Me.pnlCopiar.Size = New System.Drawing.Size(497, 257)
        Me.pnlCopiar.TabIndex = 16
        Me.pnlCopiar.Visible = False
        '
        'lblCopiandoA
        '
        Me.lblCopiandoA.Location = New System.Drawing.Point(12, 131)
        Me.lblCopiandoA.Name = "lblCopiandoA"
        Me.lblCopiandoA.Size = New System.Drawing.Size(471, 85)
        Me.lblCopiandoA.TabIndex = 4
        Me.lblCopiandoA.Text = "Copiando a:"
        '
        'lblCopiandoDe
        '
        Me.lblCopiandoDe.Location = New System.Drawing.Point(12, 30)
        Me.lblCopiandoDe.Name = "lblCopiandoDe"
        Me.lblCopiandoDe.Size = New System.Drawing.Size(471, 75)
        Me.lblCopiandoDe.TabIndex = 3
        Me.lblCopiandoDe.Text = "Copiando de:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Copiando a:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pbarCopiar
        '
        Me.pbarCopiar.Location = New System.Drawing.Point(11, 218)
        Me.pbarCopiar.Name = "pbarCopiar"
        Me.pbarCopiar.Size = New System.Drawing.Size(471, 20)
        Me.pbarCopiar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copiando de:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmdCopiarDerAIzq
        '
        Me.cmdCopiarDerAIzq.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmdCopiarDerAIzq.Location = New System.Drawing.Point(589, 387)
        Me.cmdCopiarDerAIzq.Name = "cmdCopiarDerAIzq"
        Me.cmdCopiarDerAIzq.Size = New System.Drawing.Size(105, 25)
        Me.cmdCopiarDerAIzq.TabIndex = 17
        Me.cmdCopiarDerAIzq.Text = "Copiar de ^ a <"
        Me.cmdCopiarDerAIzq.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstado.Location = New System.Drawing.Point(9, 423)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(797, 47)
        Me.txtEstado.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 477)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.cmdCopiarDerAIzq)
        Me.Controls.Add(Me.pnlCopiar)
        Me.Controls.Add(Me.cmdCopiarIzqADer)
        Me.Controls.Add(Me.pnlIDialogBorrar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.lstViewIzquierda)
        Me.Controls.Add(Me.lstViewDerecha)
        Me.Controls.Add(Me.cboUnidadesDerecha)
        Me.Controls.Add(Me.cboUnidadesIzquierda)
        Me.Controls.Add(Me.txtPathDerecha)
        Me.Controls.Add(Me.txtPathIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlIDialogBorrar.ResumeLayout(False)
        Me.pnlCopiar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPathIzquierda As TextBox
    Friend WithEvents txtPathDerecha As TextBox
    Friend WithEvents cboUnidadesIzquierda As ComboBox
    Friend WithEvents cboUnidadesDerecha As ComboBox
    Friend WithEvents lstViewDerecha As ListView
    Friend WithEvents lstViewIzquierda As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents pnlIDialogBorrar As Panel
    Friend WithEvents pbarBorrando As ProgressBar
    Friend WithEvents lblBorrandoInfo As Label
    Friend WithEvents cmdCopiarIzqADer As Button
    Friend WithEvents pnlCopiar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pbarCopiar As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCopiandoA As Label
    Friend WithEvents lblCopiandoDe As Label
    Friend WithEvents cmdCopiarDerAIzq As Button
    Friend WithEvents txtEstado As TextBox
End Class
