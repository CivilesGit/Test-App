Imports System.IO
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.FileIO
Imports System.IO.FileSystemInfo
Imports System
Imports System.Runtime.InteropServices



Public Class Form1

    Dim pathIzquierda As String = "C:\"
    Dim pathDerecha As String = "C:\"

    Dim strTipoIzquierda As String = ""
    Dim strTipoDerecha As String = ""

    Dim listIzquierdaItem As ListViewItem
    Dim listDerechaItem As ListViewItem

    Dim listItemSeleccionado As ListViewItem

    Dim lngCantElementosCopiados As Long


    Dim strArchivoLog As String = ""



    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, ExactSpelling:=False, SetLastError:=True)>
    Public Shared Function DeleteFile(ByVal path As String) As Boolean
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each vUnidad As String In Directory.GetLogicalDrives()
            cboUnidadesDerecha.Items.Add(vUnidad)
        Next vUnidad

        For Each vUnidad As String In Directory.GetLogicalDrives()
            cboUnidadesIzquierda.Items.Add(vUnidad)
        Next vUnidad

        CreateHeadersAndFillListView(lstViewIzquierda)
        CreateHeadersAndFillListView(lstViewDerecha)

        cboUnidadesIzquierda.SelectedIndex = 0
        cboUnidadesDerecha.SelectedIndex = 0

        strArchivoLog = "Log_" & Format(Now, "dd_MM_yyyy_HHmmss") & ".txt"
    End Sub



    Private Sub cboUnidadesIzquierda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadesIzquierda.SelectedIndexChanged
        txtPathIzquierda.Text = cboUnidadesIzquierda.Text
    End Sub



    Private Sub cboUnidadesDerecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadesDerecha.SelectedIndexChanged
        txtPathDerecha.Text = cboUnidadesDerecha.Text
    End Sub



    Private Sub CreateHeadersAndFillListView(lstv As ListView)
        Dim colHead As ColumnHeader

        colHead = New ColumnHeader()
        colHead.Text = "Nombre"
        colHead.Width = 250
        lstv.Columns.Add(colHead)

        colHead = New ColumnHeader()
        colHead.Text = "Tamaño"
        colHead.Width = 100
        colHead.TextAlign = HorizontalAlignment.Right
        lstv.Columns.Add(colHead)

        colHead = New ColumnHeader()
        colHead.Text = "Último Acceso"
        colHead.Width = 100
        colHead.TextAlign = HorizontalAlignment.Center
        lstv.Columns.Add(colHead)
    End Sub



    Private Sub PaintListView(root As String, lstv As ListView)
        Dim lvi As ListViewItem
        Dim lvsi As ListViewItem.ListViewSubItem

        Try

            If System.IO.Directory.Exists(root) = False Then Exit Sub

            Dim dir As New System.IO.DirectoryInfo(root)

            Dim dirs As DirectoryInfo() = dir.GetDirectories()
            Dim files As FileInfo() = dir.GetFiles()


            lstv.Items.Clear()

            lstv.BeginUpdate()

            If dirs.Length > 0 AndAlso dir.Root.FullName <> dir.FullName Then

                lvi = New ListViewItem()
                lvi.Text = "[..]"
                lvi.ImageIndex = 17

                If dirs.Length > 0 Then
                    Dim strPath As String = Mid(dirs(0).FullName, 1, InStrRev(dirs(0).FullName, "\") - 1)
                    lvi.Tag = Mid(strPath, 1, InStrRev(strPath, "\"))
                Else
                    lvi.Tag = root
                End If

                lvsi = New ListViewItem.ListViewSubItem()
                lvsi.Text = "<DIR>"
                lvi.SubItems.Add(lvsi)
                lvsi = New ListViewItem.ListViewSubItem()
                lvsi.Text = ""
                lvi.SubItems.Add(lvsi)

                lstv.Items.Add(lvi)

            Else
                If dir.Root.FullName <> dir.FullName Then
                    lvi = New ListViewItem()
                    lvi.Text = "[..]"
                    lvi.ImageIndex = 17

                    If dirs.Length > 0 Then
                        Dim strPath As String = Mid(dirs(0).FullName, 1, InStrRev(dirs(0).FullName, "\") - 1)
                        lvi.Tag = Mid(strPath, 1, InStrRev(strPath, "\"))
                    Else
                        lvi.Tag = root
                    End If

                    lvsi = New ListViewItem.ListViewSubItem()
                    lvsi.Text = "<DIR>"
                    lvi.SubItems.Add(lvsi)
                    lvsi = New ListViewItem.ListViewSubItem()
                    lvsi.Text = ""
                    lvi.SubItems.Add(lvsi)

                    lstv.Items.Add(lvi)
                End If
            End If



            If dirs.Length > 0 Or files.Length > 0 Then

                For Each di As System.IO.DirectoryInfo In dirs
                    lvi = New ListViewItem()
                    lvi.Text = di.Name
                    lvi.ImageIndex = 0
                    lvi.Tag = di.FullName

                    lvsi = New ListViewItem.ListViewSubItem()
                    lvsi.Text = "<DIR>"
                    lvi.SubItems.Add(lvsi)
                    lvsi = New ListViewItem.ListViewSubItem()
                    lvsi.Text = di.LastAccessTime.ToString()
                    lvi.SubItems.Add(lvsi)

                    lstv.Items.Add(lvi)
                Next


                For Each fi As System.IO.FileInfo In files
                    lvi = New ListViewItem()
                    lvi.Text = fi.Name
                    Select Case UCase(fi.Extension)
                        Case ".EXE", ".COM"
                            lvi.ImageIndex = 6
                        Case ".PDF"
                            lvi.ImageIndex = 3
                        Case ".DOC", ".DOCX"
                            lvi.ImageIndex = 5
                        Case ".SYS", ".CFG"
                            lvi.ImageIndex = 4
                        Case ".NFO"
                            lvi.ImageIndex = 15
                        Case ".DBF"
                            lvi.ImageIndex = 11
                        Case ".MDB", ".ACCDB"
                            lvi.ImageIndex = 18
                        Case ".XLS", "XLSX"
                            lvi.ImageIndex = 22
                        Case ".DLL"
                            lvi.ImageIndex = 20
                        Case ".PNG", ".BMP", ".JPG", ".JPEG", ".GIF"
                            lvi.ImageIndex = 14
                        Case Else
                            lvi.ImageIndex = 2
                    End Select
                    lvi.Tag = fi.FullName

                    lvsi = New ListViewItem.ListViewSubItem()
                    lvsi.Text = fi.Length
                    lvi.SubItems.Add(lvsi)
                    lvsi = New ListViewItem.ListViewSubItem()
                    lvsi.Text = fi.LastAccessTime.ToString()
                    lvi.SubItems.Add(lvsi)

                    lstv.Items.Add(lvi)
                Next

            End If

            lstv.EndUpdate()


        Catch err As System.Exception
            MessageBox.Show("Error: " + err.Message)
        End Try

        lstv.View = View.Details
    End Sub



    Private Sub txtPathIzquierda_TextChanged(sender As Object, e As EventArgs) Handles txtPathIzquierda.TextChanged
        PaintListView("\\?\" & Replace(txtPathIzquierda.Text, "\\?\", ""), lstViewIzquierda)
    End Sub



    Private Sub txtPathDerecha_TextChanged(sender As Object, e As EventArgs) Handles txtPathDerecha.TextChanged
        PaintListView("\\?\" & Replace(txtPathDerecha.Text, "\\?\", ""), lstViewDerecha)
    End Sub



    Private Sub lstViewIzquierda_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstViewIzquierda.MouseDoubleClick
        If listIzquierdaItem.SubItems(1).Text = "<DIR>" Then
            If listIzquierdaItem.SubItems(0).Text = "[..]" Then
                txtPathIzquierda.Text = Mid(listIzquierdaItem.Tag, 1, InStrRev(listIzquierdaItem.Tag, "\"))
            Else
                txtPathIzquierda.Text = listIzquierdaItem.Tag
            End If
        End If
    End Sub



    Private Sub lstViewIzquierda_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstViewIzquierda.ItemSelectionChanged
        listIzquierdaItem = e.Item
        listItemSeleccionado = e.Item
    End Sub



    Private Sub lstViewDerecha_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstViewDerecha.MouseDoubleClick
        If listDerechaItem.SubItems(1).Text = "<DIR>" Then
            If listDerechaItem.SubItems(0).Text = "[..]" Then
                txtPathDerecha.Text = Mid(listDerechaItem.Tag, 1, InStrRev(listDerechaItem.Tag, "\"))
            Else
                txtPathDerecha.Text = listDerechaItem.Tag
            End If
        End If
    End Sub



    Private Sub lstViewDerecha_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstViewDerecha.ItemSelectionChanged
        listDerechaItem = e.Item
        listItemSeleccionado = e.Item
    End Sub



    Private Function Directorio_Elementos_Contar(strPath As String, intContador As Long) As Long
        Directorio_Elementos_Contar = intContador

        Dim dir As New System.IO.DirectoryInfo(strPath)

        Try
            Dim dirs As DirectoryInfo() = dir.GetDirectories()
            Dim files As FileInfo() = dir.GetFiles()

            Directorio_Elementos_Contar += files.Length
            If dirs.Length > 0 Then
                For Each di As System.IO.DirectoryInfo In dirs
                    Directorio_Elementos_Contar = Directorio_Elementos_Contar(di.FullName, Directorio_Elementos_Contar)
                Next
            End If

        Catch ex As Exception

        End Try

    End Function



    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        System.Windows.Forms.Application.DoEvents()

        If listItemSeleccionado Is Nothing Then
            Exit Sub
        End If

        If MessageBox.Show("Está seguro de querer eliminar el elemento " & listItemSeleccionado.Tag & " ?.", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Controles_Estado_Cambiar(False)
        Me.UseWaitCursor = True


        pbarBorrando.Value = 0
        pnlIDialogBorrar.Visible = True

        System.Windows.Forms.Application.DoEvents()

        Dim lngCantidadArchivos As Long = Directorio_Elementos_Contar(listItemSeleccionado.Tag, 0)

        lblBorrandoInfo.Text = "Borrando..."

        pbarBorrando.Maximum = lngCantidadArchivos


        If Directory.Exists(listItemSeleccionado.Tag) Then
            Log_Escribir("Inciando borrado.... De " & listItemSeleccionado.Tag)
            Items_Borrar(listItemSeleccionado.Tag)

            If Directory.Exists(listItemSeleccionado.Tag) Then
                Try
                    Directory.Delete(listItemSeleccionado.Tag, True)
                Catch ex As Exception
                    ' MessageBox.Show("No se pudo eliminar el Directorio " & listItemSeleccionado.Tag & vbCrLf & vbCrLf & ex.Message, "Error")

                End Try
            End If

            Log_Escribir("Borrado Finalizado....")

        ElseIf File.Exists(listItemSeleccionado.Tag) Then
            Try
                File.Delete(listItemSeleccionado.Tag)
            Catch ex As Exception
                MessageBox.Show("No se pudo eliminar el archivo " & listItemSeleccionado.Tag & vbCrLf & vbCrLf & ex.Message, "Error")
            End Try
        End If

        pnlIDialogBorrar.Visible = False

        PaintListView("\\?\" & Replace(txtPathIzquierda.Text, "\\?\", ""), lstViewIzquierda)
        PaintListView("\\?\" & Replace(txtPathDerecha.Text, "\\?\", ""), lstViewDerecha)

        Controles_Estado_Cambiar(True)
        Me.UseWaitCursor = False
    End Sub



    Private Sub Items_Borrar(strPath As String)

        System.Windows.Forms.Application.DoEvents()

        Dim dir As New System.IO.DirectoryInfo(strPath)

        Try
            Dim dirs As DirectoryInfo() = dir.GetDirectories()
            Dim files As FileInfo() = dir.GetFiles()

            If files.Length > 0 Then
                For Each Arch As System.IO.FileInfo In files
                    Dim strNombreArch As String = Arch.FullName

                    If strNombreArch.Length > 150 Then
                        strNombreArch = Mid(strNombreArch, 1, 30) & "..." & Mid(strNombreArch, strNombreArch.Length - 120, strNombreArch.Length)
                    End If
                    lblBorrandoInfo.Text = "Borrando archivo... " & strNombreArch
                    Try
                        If DeleteFile(Arch.FullName) = False Then
                            txtEstado.Text = "No se pudo eliminar el archivo " & Arch.FullName
                            Log_Escribir("No se pudo eliminar el archivo " & Arch.FullName)
                        End If
                        'File.Delete(Arch.FullName)
                    Catch ex As Exception
                        ' MessageBox.Show("No se pudo eliminar el archivo " & Arch.FullName & vbCrLf & vbCrLf & ex.Message, "Error")
                        txtEstado.Text = "No se pudo eliminar el archivo " & Arch.FullName & vbCrLf & ex.Message
                        Log_Escribir("No se pudo eliminar el archivo " & Arch.FullName & vbCrLf & ex.Message)
                    End Try

                    pbarBorrando.Value += 1
                Next
            End If

            If dirs.Length > 0 Then
                For Each di As System.IO.DirectoryInfo In dirs
                    System.Threading.Thread.Sleep(150)

                    Items_Borrar(di.FullName)

                    Dim strNombreDirectorio As String = di.FullName
                    If strNombreDirectorio.Length > 150 Then
                        strNombreDirectorio = Mid(strNombreDirectorio, 1, 30) & "..." & Mid(strNombreDirectorio, strNombreDirectorio.Length - 120, strNombreDirectorio.Length)
                    End If

                    lblBorrandoInfo.Text = "Borrando directorio... " & strNombreDirectorio
                    Try
                        Directory.Delete(di.FullName, True)
                    Catch ex As Exception
                        'MessageBox.Show("No se pudo eliminar el Directorio " & di.FullName & vbCrLf & vbCrLf & ex.Message, "Error")
                        txtEstado.Text = "No se pudo eliminar el Directorio " & di.FullName & vbCrLf & ex.Message
                        Log_Escribir("No se pudo eliminar el Directorio " & di.FullName & vbCrLf & ex.Message)
                    End Try
                Next
            End If


        Catch ex As Exception

        End Try


    End Sub



    Private Sub Controles_Estado_Cambiar(Estado As Boolean)
        cmdBorrar.Enabled = Estado
        cmdCopiarDerAIzq.Enabled = Estado
        cmdCopiarIzqADer.Enabled = Estado
        lstViewDerecha.Enabled = Estado
        lstViewIzquierda.Enabled = Estado
        cboUnidadesDerecha.Enabled = Estado
        cboUnidadesIzquierda.Enabled = Estado
    End Sub




    Private Sub cmdCopiarIzqADer_Click(sender As Object, e As EventArgs) Handles cmdCopiarIzqADer.Click

        If listIzquierdaItem Is Nothing Then
            Exit Sub
        End If

        If MessageBox.Show("Está seguro de querer Copiar el elemento " & listIzquierdaItem.Tag & vbCrLf & " a " & txtPathDerecha.Text & "?.", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Controles_Estado_Cambiar(False)
        Me.UseWaitCursor = True

        System.Windows.Forms.Application.DoEvents()

        Dim lngCantidadArchivos As Long
        lngCantidadArchivos = Directorio_Elementos_Contar(listIzquierdaItem.Tag, 0)

        pbarCopiar.Maximum = lngCantidadArchivos
        pbarCopiar.Value = 0

        pnlCopiar.Visible = True

        If Directory.Exists(listIzquierdaItem.Tag) Then

            Log_Escribir("Inciando Copia.... De " & listIzquierdaItem.Tag & " a " & txtPathDerecha.Text)
            Log_Escribir("Cantidad de elementos a Copiar " & lngCantidadArchivos)

            lngCantElementosCopiados = 0

            Items_Copiar(listIzquierdaItem.Tag, txtPathDerecha.Text)

            Log_Escribir("Cantidad de elementos copiados " & lngCantElementosCopiados)
            Log_Escribir("Copia Finalizada....")

        ElseIf File.Exists(listIzquierdaItem.Tag) Then
            Try
                Dim arch As FileInfo = New FileInfo(listIzquierdaItem.Tag)

                File.Copy(listIzquierdaItem.Tag, txtPathDerecha.Text & "\" & arch.Name)
            Catch ex As Exception
                MessageBox.Show("No se pudo copiar el archivo " & listIzquierdaItem.Tag & vbCrLf & vbCrLf & ex.Message, "Error")
            End Try
        End If

        pnlCopiar.Visible = False

        PaintListView("\\?\" & Replace(txtPathIzquierda.Text, "\\?\", ""), lstViewIzquierda)
        PaintListView("\\?\" & Replace(txtPathDerecha.Text, "\\?\", ""), lstViewDerecha)

        Controles_Estado_Cambiar(True)
        Me.UseWaitCursor = False
    End Sub




    Private Sub Items_Copiar(strPathOrigen As String, strPathDestino As String)

        System.Windows.Forms.Application.DoEvents()


        Dim dir As New System.IO.DirectoryInfo(strPathOrigen)

        Try
            Dim dirs As DirectoryInfo() = dir.GetDirectories()
            Dim files As FileInfo() = dir.GetFiles()

            Dim strNuevoDirectorio As String = strPathDestino & "\" & (New DirectoryInfo(strPathOrigen)).Name

            Directory.CreateDirectory(strNuevoDirectorio)

            If files.Length > 0 Then
                For Each Arch As System.IO.FileInfo In files
                    Dim strNombreArch As String = Arch.FullName

                    If strNombreArch.Length > 150 Then
                        strNombreArch = Mid(strNombreArch, 1, 30) & "..." & Mid(strNombreArch, strNombreArch.Length - 120, strNombreArch.Length)
                    End If
                    lblCopiandoDe.Text = "Copiando archivo... " & strNombreArch

                    lblCopiandoA.Text = "A archivo... " & strNuevoDirectorio & "\" & Arch.Name

                    Try
                        File.Copy(Arch.FullName, strNuevoDirectorio & "\" & Arch.Name, True)

                        lngCantElementosCopiados += 1
                    Catch ex As Exception
                        'MessageBox.Show("No se pudo copiar el archivo " & Arch.FullName & vbCrLf & vbCrLf & ex.Message, "Error")
                        txtEstado.Text = "No se pudo copiar el archivo " & Arch.FullName & vbCrLf & ex.Message
                        Log_Escribir("No se pudo copiar el archivo " & Arch.FullName & "  --  " & ex.Message)
                    End Try

                    pbarCopiar.Value += 1
                Next
            End If

            If dirs.Length > 0 Then
                For Each di As System.IO.DirectoryInfo In dirs
                    Items_Copiar(di.FullName, strNuevoDirectorio)
                Next
            End If

        Catch ex As Exception

        End Try


    End Sub



    Private Sub cmdCopiarDerAIzq_Click(sender As Object, e As EventArgs) Handles cmdCopiarDerAIzq.Click
        System.Windows.Forms.Application.DoEvents()
        If listDerechaItem Is Nothing Then
            Exit Sub
        End If

        If MessageBox.Show("Está seguro de querer Copiar el elemento " & listDerechaItem.Tag & vbCrLf & " a " & txtPathIzquierda.Text & "?.", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Controles_Estado_Cambiar(False)
        Me.UseWaitCursor = True

        System.Windows.Forms.Application.DoEvents()

        pbarCopiar.Value = 0
        pnlCopiar.Visible = True

        Dim lngCantidadArchivos As Long = Directorio_Elementos_Contar(listDerechaItem.Tag, 0)

        pbarCopiar.Maximum = lngCantidadArchivos


        If Directory.Exists(listDerechaItem.Tag) Then

            Log_Escribir("Inciando Copia.... De " & txtPathDerecha.Text & " a " & listIzquierdaItem.Tag)
            Log_Escribir("Cantidad de elementos a Copiar " & lngCantidadArchivos)
            lngCantElementosCopiados = 0

            Items_Copiar(listDerechaItem.Tag, txtPathIzquierda.Text)

            Log_Escribir("Cantidad de elementos copiados " & lngCantElementosCopiados)
            Log_Escribir("Copia Finalizada....")

        ElseIf File.Exists(listDerechaItem.Tag) Then
            Try
                Dim arch As FileInfo = New FileInfo(listDerechaItem.Tag)

                File.Copy(listDerechaItem.Tag, txtPathIzquierda.Text & "\" & arch.Name, True)
            Catch ex As Exception
                MessageBox.Show("No se pudo copiar el archivo " & listDerechaItem.Tag & vbCrLf & vbCrLf & ex.Message, "Error")
            End Try
        End If

        pnlCopiar.Visible = False

        PaintListView("\\?\" & Replace(txtPathIzquierda.Text, "\\?\", ""), lstViewIzquierda)
        PaintListView("\\?\" & Replace(txtPathDerecha.Text, "\\?\", ""), lstViewDerecha)

        Controles_Estado_Cambiar(True)
        Me.UseWaitCursor = False
    End Sub




    Private Sub Log_Escribir(strError As String)

        Dim fs As New StringWriter

        Try
            If File.Exists(strArchivoLog) = False Then
                Dim FsNew As FileStream = File.Create(strArchivoLog)
                FsNew.Close()
                FsNew = Nothing
            End If

        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo de log: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Dim escribir As New StreamWriter(strArchivoLog, True)
        Try
            escribir.WriteLine(Format(Now, "dd/MM/yyyy HH:mm") & " :: " & strError)
            escribir.Close()
            escribir.Dispose()

        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo de log: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub



End Class

