Public Class clsProizvodnja

End Class

Public Class clsProizvodnja_kontrole

    Private _tSifra As TextBox
    Private _tNaziv As TextBox
    Private _tGrupa As TextBox
    Private _tGrupa_naziv As TextBox
    Private _tKol As TextBox
    Private _tJm As TextBox
    Private _tCena As TextBox
    Private _tPdv As TextBox
    Private _tMaterijal As TextBox
    Private _tRadTaksa As TextBox

    Public Property tb_sifra() As TextBox
        Get
            Return _tSifra
        End Get
        Set(ByVal Value As TextBox)
            _tSifra = Value
        End Set
    End Property

    Public Property tb_naziv() As TextBox
        Get
            Return _tNaziv
        End Get
        Set(ByVal Value As TextBox)
            _tNaziv = Value
        End Set
    End Property

    Public Property tb_grupa() As TextBox
        Get
            Return _tGrupa
        End Get
        Set(ByVal Value As TextBox)
            _tGrupa = Value
        End Set
    End Property

    Public Property tb_grupa_naziv() As TextBox
        Get
            Return _tGrupa_naziv
        End Get
        Set(ByVal Value As TextBox)
            _tGrupa_naziv = Value
        End Set
    End Property

    Public Property tb_kol() As TextBox
        Get
            Return _tKol
        End Get
        Set(ByVal Value As TextBox)
            _tKol = Value
        End Set
    End Property

    Public Property tb_jm() As TextBox
        Get
            Return _tJm
        End Get
        Set(ByVal Value As TextBox)
            _tJm = Value
        End Set
    End Property

    Public Property tb_cena() As TextBox
        Get
            Return _tCena
        End Get
        Set(ByVal Value As TextBox)
            _tCena = Value
        End Set
    End Property

    Public Property tb_pdv() As TextBox
        Get
            Return _tPdv
        End Get
        Set(ByVal Value As TextBox)
            _tPdv = Value
        End Set
    End Property

    Public Property tb_rad_taksa() As TextBox
        Get
            Return _tRadTaksa
        End Get
        Set(ByVal Value As TextBox)
            _tRadTaksa = Value
        End Set
    End Property

    Public Property tb_materijal() As TextBox
        Get
            Return _tMaterijal
        End Get
        Set(ByVal Value As TextBox)
            _tMaterijal = Value
        End Set
    End Property

End Class