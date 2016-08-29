Public Class frmMedalleria

    'Variable para determinar el ordenamiento
    Private Sub frmMedalleria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Tamaño de columnas de ListView
        cPais.Width = 200
        cMedOro.Width = 150
        cMedPlata.Width = 150
        cMedBronce.Width = 150

        'Limpia la info del ListView
        'lvMedalleria.Items.Clear()

        'Limpiar los TextBox
        txtPais.Text = String.Empty
        txtMedOro.Text = String.Empty
        txtMedPlata.Text = String.Empty
        txtMedBronce.Text = String.Empty

        'Foco al TextBox Pais
        txtPais.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim columnalv(3) As String
        Dim itm As ListViewItem
        Dim PaisExiste As Boolean = False

        'Obligar a que los demas controles pierdan el foco
        btnAgregar.Focus()

        'Tamaño de columnas de ListView
        cPais.Width = 200
        cMedOro.Width = 150
        cMedPlata.Width = 150
        cMedBronce.Width = 150

        For i = 0 To lvMedalleria.Items.Count - 1
            If txtPais.Text = lvMedalleria.Items(i).SubItems(0).Text Then
                PaisExiste = True
                Exit For
            Else
                PaisExiste = False
            End If
        Next i

        Select Case PaisExiste

            Case True

                MessageBox.Show("El pais ya fue añadido a la lista.", "Informacion duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPais.Focus()

            Case False

                If txtPais.Text <> String.Empty And txtMedOro.Text <> String.Empty And txtMedPlata.Text <> String.Empty And txtMedBronce.Text <> String.Empty Then

                    columnalv(0) = txtPais.Text
                    columnalv(1) = txtMedOro.Text
                    columnalv(2) = txtMedPlata.Text
                    columnalv(3) = txtMedBronce.Text

                    itm = New ListViewItem(columnalv)
                    lvMedalleria.Items.Add(itm)

                    'Limpiar los TextBox
                    txtPais.Text = String.Empty
                    txtMedOro.Text = String.Empty
                    txtMedPlata.Text = String.Empty
                    txtMedBronce.Text = String.Empty

                    'Foco al TextBox Pais
                    txtPais.Focus()

                Else
                    MessageBox.Show("Debe diligenciar todos los datos", "Informacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPais.Focus()
                End If

        End Select
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click

        Dim CantidadtipoMedallas As Integer

        CantidadtipoMedallas = lvMedalleria.Columns.Count

        For reiteraciones = 1 To CantidadtipoMedallas
            Ordenar()
        Next

        'Foco al TextBox Pais
        txtPais.Focus()
    End Sub

    Private Sub ModificarPaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPaisToolStripMenuItem.Click

        'Tamaño de columnas de ListView
        cPais.Width = 200
        cMedOro.Width = 150
        cMedPlata.Width = 150
        cMedBronce.Width = 150

        With lvMedalleria
            If .SelectedItems.Count > 0 Then
                For Each i As ListViewItem In .SelectedItems

                    txtPais.Text = .Items(i.Index).SubItems(0).Text
                    txtMedOro.Text = .Items(i.Index).SubItems(1).Text
                    txtMedPlata.Text = .Items(i.Index).SubItems(2).Text
                    txtMedBronce.Text = .Items(i.Index).SubItems(3).Text

                    .Items.Remove(i)
                Next
            Else
                MessageBox.Show("Debe seleccionar el pais a modificar", "Seleccion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With

        txtPais.Focus()
    End Sub

    Private Sub EliminarPaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPaisToolStripMenuItem.Click

        'Tamaño de columnas de ListView
        cPais.Width = 200
        cMedOro.Width = 150
        cMedPlata.Width = 150
        cMedBronce.Width = 150

        With lvMedalleria
            If .SelectedItems.Count > 0 Then
                For Each i As ListViewItem In .SelectedItems
                    .Items.Remove(i)
                Next
            Else
                MessageBox.Show("Debe seleccionar el pais a eliminar de la lista", "Seleccion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub Ordenar()

        Dim i, j, k As Integer
        Dim DatosMenorTMP As String() = {"", "", "", ""}
        Dim DatosMayorTMP As String() = {"", "", "", ""}

        'Limpiar los TextBox
        txtPais.Text = String.Empty
        txtMedOro.Text = String.Empty
        txtMedPlata.Text = String.Empty
        txtMedBronce.Text = String.Empty

        With lvMedalleria

            'Ordenar por bronce
            For i = 0 To .Items.Count - 1
                For j = 1 To .Items.Count - 1
                    If i <= j Then
                        If CInt(.Items(i).SubItems(3).Text) < CInt(.Items(j).SubItems(3).Text) And CInt(.Items(i).SubItems(3).Text) <> CInt(.Items(j).SubItems(3).Text) Then

                            For k = 0 To 3
                                DatosMenorTMP(k) = .Items(i).SubItems(k).Text
                                DatosMayorTMP(k) = .Items(j).SubItems(k).Text
                            Next

                            For k = 0 To 3
                                .Items(i).SubItems(k).Text = DatosMayorTMP(k)
                                .Items(j).SubItems(k).Text = DatosMenorTMP(k)
                            Next
                        End If
                    End If
                Next j
            Next i

            'Ordenar por plata
            For i = 0 To .Items.Count - 1
                For j = 1 To .Items.Count - 1
                    If i <= j Then
                        If CInt(.Items(i).SubItems(2).Text) < CInt(.Items(j).SubItems(2).Text) And CInt(.Items(i).SubItems(2).Text) <> CInt(.Items(j).SubItems(2).Text) Then

                            For k = 0 To 3
                                DatosMenorTMP(k) = .Items(i).SubItems(k).Text
                                DatosMayorTMP(k) = .Items(j).SubItems(k).Text
                            Next

                            For k = 0 To 3
                                .Items(i).SubItems(k).Text = DatosMayorTMP(k)
                                .Items(j).SubItems(k).Text = DatosMenorTMP(k)
                            Next
                        End If
                    End If
                Next j
            Next i

            'Ordenar por oro
            For i = 0 To .Items.Count - 1
                For j = 1 To .Items.Count - 1
                    If i <= j Then
                        If CInt(.Items(i).SubItems(1).Text) < CInt(.Items(j).SubItems(1).Text) And CInt(.Items(i).SubItems(1).Text) <> CInt(.Items(j).SubItems(1).Text) Then

                            For k = 0 To 3
                                DatosMenorTMP(k) = .Items(i).SubItems(k).Text
                                DatosMayorTMP(k) = .Items(j).SubItems(k).Text
                            Next

                            For k = 0 To 3
                                .Items(i).SubItems(k).Text = DatosMayorTMP(k)
                                .Items(j).SubItems(k).Text = DatosMenorTMP(k)
                            Next
                        End If
                    End If
                Next j
            Next i
        End With
    End Sub

    Private Sub txtPais_Leave(sender As Object, e As EventArgs) Handles txtPais.Leave

        txtPais.Text = Trim(UCase(txtPais.Text))
    End Sub

    Private Sub TextBox_Trim(sender As Object, e As EventArgs) Handles txtMedOro.Leave, txtMedPlata.Leave, txtMedBronce.Leave

        sender.Text = Trim(UCase(sender.Text))
    End Sub

    Private Sub TextBox_SoloNumeros(sender As Object, e As KeyPressEventArgs) Handles txtMedOro.KeyPress, txtMedPlata.KeyPress, txtMedBronce.KeyPress

        SoloNumeros(e)
    End Sub

    Private Sub SoloNumeros(e As KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Process.Start("https://facebook.com/jeysonzg")
    End Sub
End Class
