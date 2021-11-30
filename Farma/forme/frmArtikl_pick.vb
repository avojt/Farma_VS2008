Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmArtikl_pick

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            Lista()
            lvLista.Select()
            lvLista.FullRowSelect = True
            If lvLista.Items.Count > 0 Then
                lvLista.Items(0).Selected = True
            End If
        End If
    End Sub

    Private Sub Lista()
        Try
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            lvLista.Visible = True
            lvLista.Items.Clear()

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    If _forma = Imena.tabele.pr_lab_dn.ToString Then
                        .CommandText = "select * from pr_sastavnica_head WHERE sas_art_naziv like N'" & RTrim(txtNaziv.Text) & "%'"
                    Else
                        .CommandText = "select * from rm_artikli WHERE artikl_naziv like N'" & RTrim(txtNaziv.Text) & "%'"
                    End If
                    DR = .ExecuteReader
                End With

                While DR.Read
                    If _forma = Imena.tabele.pr_lab_dn.ToString Then
                        Dim podatak As New ListViewItem(DR.Item("sas_art_sifra").ToString)
                        podatak.SubItems.Add(DR.Item("sas_art_naziv"))

                        podatak.ForeColor = Color.RoyalBlue
                        lvLista.Items.AddRange(New ListViewItem() {podatak})
                    Else
                        Dim podatak As New ListViewItem(DR.Item("artikl_sifra").ToString)
                        podatak.SubItems.Add(DR.Item("artikl_naziv"))

                        podatak.ForeColor = Color.RoyalBlue
                        lvLista.Items.AddRange(New ListViewItem() {podatak})
                    End If
                End While
                DR.Close()
                CM.Dispose()
                CN.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub btnUnesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnesi.Click
        popuni()
    End Sub

    'Private Sub lvLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.DoubleClick
    '    popuni()
    'End Sub

    Private Sub lvLista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvLista.KeyPress
        If e.KeyChar = Chr(13) Then
            popuni()
        End If
    End Sub

    Private Sub popuni()

        If _forma = Imena.tabele.pr_lab_dn.ToString Then
            selektuj_sastavnicu(lvLista.SelectedItems.Item(0).Text, Selekcija.po_sifri)
            mProiz_kontrola.tb_sifra.Text = _sas_art_sifra
            mProiz_kontrola.tb_naziv.Text = _sas_art_naziv
            mProiz_kontrola.tb_jm.Text = _sas_jm_recept
            mProiz_kontrola.tb_cena.Text = _sas_art_cena
            mProiz_kontrola.tb_rad_taksa.Text = _sas_radna_taksa
            _radna_taksa = _sas_radna_taksa
        Else
            selektuj_artikl(lvLista.SelectedItems.Item(0).Text, Selekcija.po_sifri)
            mRob_kontrola.tb_sifra.Text = _artikl_sifra
            mRob_kontrola.tb_naziv.Text = _artikl_naziv

            selektuj_jm(_artikl_id_jm, Selekcija.po_id)
            mRob_kontrola.tb_jm.Text = _jm_oznaka

            If _forma <> Imena.tabele.pr_sastavnica.ToString Then
                selektuj_GrupeArt(_artikl_id_grupa, Selekcija.po_id)
                mRob_kontrola.tb_grupa.Text = _gr_art_sifra
                mRob_kontrola.tb_grupa_naziv.Text = _gr_art_skraceno

                If _forma = Imena.tabele.rm_izlazni_dokument_head.ToString Then
                    mRob_kontrola.tb_marza.Text = _gr_art_marza
                End If

                selektuj_pdv(_artikl_id_pdv, Selekcija.po_id)
                mRob_kontrola.tb_pdv.Text = _pdv_stopa

            End If
        End If

        label()

        Select Case _forma
            Case Imena.tabele.pr_lab_dn.ToString
                mProiz_kontrola.tb_kol.Select()
            Case Imena.tabele.pr_sastavnica.ToString
                mRob_kontrola.tb_kol.Select()
            Case Imena.tabele.rm_ulazni_dokument_head.ToString
                mRob_kontrola.tb_kol.Select()
            Case Imena.tabele.rm_izlazni_dokument_head.ToString
                mRob_kontrola.tb_kol.Select()
        End Select



        Me.Dispose()

    End Sub

    Private Sub label()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim lSifra As String = ""
        Dim lNaziv As String = ""
        Dim lKol As String = ""
        Dim lCena As String = ""
        Dim lRab As String = ""

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_artikli_cene where dbo.rm_artikli_cene.id_artikl = " & _id_artikl & " and dbo.rm_artikli_cene.id_magacin = " & _id_magacin
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then lCena = Format(DR.Item("cena_nab_zadnja"), "#,##0.00")
                If Not IsDBNull(DR.Item("rabat")) Then lRab = Format(DR.Item("rabat"), "#,##0.00")
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()

        lKol = Format(stanje_iz_magacina_stavka(_id_magacin, _id_artikl), "#,##0.00")

        If lCena <> "" Then
            mRob_kontrola.tb_nab_cena.Text = lCena
        End If
        If lRab <> "" Then
            mRob_kontrola.tb_rabat.Text = lRab
        End If

        _mLabel.Text = RTrim(_artikl_sifra) & " - " & _artikl_naziv & " - kol: " & lKol & " - cena: " & lCena
        _mLabel.Text = "Kol: " & lKol & " kom; Cena: " & lCena & " din."

    End Sub

End Class