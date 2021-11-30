Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntMagIntPrenos
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMagIntPrenos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista

        _pocetak = False
    End Sub

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = lvLista.SelectedItems.Item(0).Text
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmenite", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            _mip_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text

            If _mip_broj Mod 2 = 0 Then
                MsgBox("Automatski generisani dokument ne možete menjati. Molimo Vas izaberite predhodni dokument sa neparnim brojem.")
                Exit Sub
            End If
            Dim poruka As String = My.Resources.text_brisanje & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                selektuj_mip(bukmark, Selekcija.po_sifri)
                brisi_DPromet(_id_magacina_iz, ID_vrsta_dokumenta, _id_mip, _mip_broj)
                brisi_Dokument_stavke()
                brisi_Dokument_pdv()
                brisi_Dokument()
            Else
                Exit Sub
            End If
        End If

        'cntIntDostavUlaz_search.Lista()

    End Sub

    Shared Sub brisi_Dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_mag_interni_prenos_head_delete"
                    .Parameters.AddWithValue("@id_mip", _id_mip)
                    .ExecuteScalar()
                End With
                CM.Dispose()

                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_mag_interni_prenos_head_delete"
                    .Parameters.AddWithValue("@id_mip", _id_mip_parni)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Doљlo je do greљke prilikom izvrљenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_Dokument_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_mag_interni_prenos_stavka_del_dokument"
                    .Parameters.AddWithValue("@id_mip", _id_mip)
                    .ExecuteScalar()
                End With
                CM.Dispose()

                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_mag_interni_prenos_stavka_del_dokument"
                    .Parameters.AddWithValue("@id_mip", _id_mip_parni)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Doљlo je do greљke prilikom izvrљenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_Dokument_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_mag_interni_prenos_pdv_delete"
                    .Parameters.AddWithValue("@id_mip", _id_mip)
                    .ExecuteScalar()
                End With
                CM.Dispose()

                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_mag_interni_prenos_pdv_delete"
                    .Parameters.AddWithValue("@id_mip", _id_mip_parni)
                    .ExecuteScalar()
                End With
                CM.Dispose()

            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Doљlo je do greљke prilikom izvrљenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Shared Sub prn()
        If bukmark Mod 2 = 0 Then
            MsgBox("Automatski generisani dokument ne možete selektovati. Molimo Vas izaberite predhodni dokument sa neparnim brojem.")
            Exit Sub
        End If
        selektuj_mip(bukmark, Selekcija.po_sifri)
        mip_print()
        _raport = Imena.tabele.rm_mag_interni_prenos.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

End Class
