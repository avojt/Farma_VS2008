Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntNalog
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntFinansijsko_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista

        _pocetak = False
    End Sub

    Shared bukmark As String = 0 'vrsta
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = RTrim(lvLista.SelectedItems.Item(0).Text)
        End If
    End Sub
    Private Sub lvLista_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvLista.MouseDoubleClick
        _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
        _nal_vrsta = _lista.SelectedItems.Item(0).Text
        selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNalog_edit
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_edit
        cntMeniFinansijsko.podesi_boje_linkova(_mPanNalog_meni)
        _mLinkNalog_edit.BackColor = Color.GhostWhite
        _mLinkNalog_edit.LinkColor = Color.MidnightBlue
        cntMeniFinansijsko.disable_linkove(_mPanNalog_meni)
        cntMeniFinansijsko.disable_buttons(_mTableButtons)
    End Sub

    Shared Sub myDelete()
        If bukmark = "0" Or bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmbrišete.", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
            _nal_vrsta = RTrim(_lista.SelectedItems.Item(0).Text)
            selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)
            If _nal_proknjizen And Not _nal_storniran Then
                MsgBox("Nalog je proknjižen. Brisanje nije dozvoleno. Možete ga stornirati.")
            Else
                If _nal_proknjizen And _nal_storniran Then
                    MsgBox("Nalog je storniran. Ne možete ga više menjati.")
                Else
                    If Not _nal_proknjizen And _nal_storniran Then
                        MsgBox("Nalog je storniran. Ne možete ga više menjati.")
                    Else
                        If Not _nal_proknjizen And Not _nal_storniran Then
                            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & _
                                                                                _lista.SelectedItems.Item(0).Text & "-" & _
                                                                                _lista.SelectedItems.Item(0).SubItems(1).Text & " ?"
                            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                                '_nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
                                '_nal_vrsta = _lista.SelectedItems.Item(0).Text

                                brisi_nalog_stavke()
                                brisi_nalog()
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If
        bukmark = ""
        cntNalog_search.Lista()

    End Sub

    Shared Sub brisi_nalog()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_head_delete"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CN.Close()
        End Try
    End Sub
    Shared Sub brisi_nalog_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_stavka_del_nalog"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Shared Sub prn()
        _nal_print_all = False
        If _lista.SelectedItems.Count = 0 Then
            Dim i As Integer = 0
            For i = 0 To _lista.Items.Count - 1
                _nal_broj = _lista.Items(i).SubItems(1).Text
                _nal_vrsta = _lista.Items(i).Text
                selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, RTrim(_nal_vrsta))
                nalog_print()
                _nal_print_all = True
            Next
        Else
            _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
            _nal_vrsta = _lista.SelectedItems.Item(0).Text
            selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)
            nalog_print()
        End If

        _raport = Imena.tabele.fn_nalog.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub



End Class
