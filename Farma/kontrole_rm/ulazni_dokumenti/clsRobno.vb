Imports System.Xml
Imports System.ComponentModel
Imports System.IO

Public Class clsRobno

    Private _Tekst As String
    Private _Number As Short
    Private m_cntRobnoIcon As System.Drawing.Icon
    Private m_cRobnoIcon As String

    '''
    <CategoryAttribute("Robno"), _
    Browsable(True), _
    [ReadOnly](False), _
    BindableAttribute(False), _
    DefaultValueAttribute("5"), _
    DesignOnly(False), _
    DescriptionAttribute("Унесите податак о броју линија на страни")> _
 Public Property KonamdTekst() As String
        Get
            Return _Tekst
        End Get
        Set(ByVal Value As String)
            _Tekst = Value
        End Set
    End Property
    '''
    <CategoryAttribute("Robno"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute("0"), _
       DesignOnly(False), _
       DescriptionAttribute("")> _
    Public Property Broj_kolona() As Integer
        Get
            Return _Number
        End Get
        Set(ByVal Value As Integer)
            _Number = Value
        End Set
    End Property
    <CategoryAttribute("Robno"), _
        DefaultValueAttribute(""), _
        DescriptionAttribute("Select icon for application")> _
         Public Property Ikona() As System.Drawing.Icon
        Get
            Return m_cntRobnoIcon
        End Get
        Set(ByVal Value As System.Drawing.Icon)
            m_cntRobnoIcon = Value
        End Set
    End Property
    <CategoryAttribute("Robno"), _
         Browsable(False), _
         [ReadOnly](False), _
         BindableAttribute(False), _
         DefaultValueAttribute("0"), _
         DesignOnly(False), _
         DescriptionAttribute("")> _
 Public Property IcoPath() As String
        Get
            Return m_cRobnoIcon
        End Get
        Set(ByVal Value As String)
            m_cRobnoIcon = Value
        End Set
    End Property
    '''server
    <CategoryAttribute("Robno"), _
          Browsable(True), _
          [ReadOnly](False), _
          BindableAttribute(False), _
          DefaultValueAttribute(""), _
          DesignOnly(False), _
          DescriptionAttribute("Унесите параметар конекције - име SQL сервера.")> _
       Public Property dokumenta_sifra() As Integer
        Get
            Return _Number
        End Get
        Set(ByVal Value As Integer)
            _Number = Value
        End Set
    End Property
    <CategoryAttribute("Robno"), _
         Browsable(True), _
         [ReadOnly](False), _
         BindableAttribute(False), _
         DefaultValueAttribute(""), _
         DesignOnly(False), _
         DescriptionAttribute("Унесите параметар конекције - име SQL сервера.")> _
      Public Property dokumenta_id() As Integer
        Get
            Return _Number
        End Get
        Set(ByVal Value As Integer)
            _Number = Value
        End Set
    End Property

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class

Public Class clsRobno_dokument

    Private _naziv As String
    Private _komanda As String
    Private _tabela As String
    Private _br_kolona As Integer
    Private _dok_id As Integer
    Private _dok_sifra As String 'integer
    Private m_cntRobnoIcon As System.Drawing.Icon
    Private m_cRobnoIcon As String

    Public Property naziv() As String
        Get
            Return _naziv
        End Get
        Set(ByVal Value As String)
            _naziv = Value
        End Set
    End Property

    Public Property tabela() As String
        Get
            Return _tabela
        End Get
        Set(ByVal Value As String)
            _tabela = Value
        End Set
    End Property

    Public Property KonamdTekst() As String
        Get
            Return _komanda
        End Get
        Set(ByVal Value As String)
            _komanda = Value
        End Set
    End Property
   
    Public Property Broj_kolona() As Integer
        Get
            Return _br_kolona
        End Get
        Set(ByVal Value As Integer)
            _br_kolona = Value
        End Set
    End Property
   
    Public Property Ikona() As System.Drawing.Icon
        Get
            Return m_cntRobnoIcon
        End Get
        Set(ByVal Value As System.Drawing.Icon)
            m_cntRobnoIcon = Value
        End Set
    End Property
   
    Public Property IcoPath() As String
        Get
            Return m_cRobnoIcon
        End Get
        Set(ByVal Value As String)
            m_cRobnoIcon = Value
        End Set
    End Property
   
    Public Property dokumenta_sifra() As Integer
        Get
            Return _dok_sifra
        End Get
        Set(ByVal Value As Integer)
            _dok_sifra = Value
        End Set
    End Property
    
    Public Property dokumenta_id() As Integer
        Get
            Return _dok_id
        End Get
        Set(ByVal Value As Integer)
            _dok_id = Value
        End Set
    End Property

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class

Public Class clsRobno_kontrole

    Private _tSifra As TextBox
    Private _tNaziv As TextBox
    Private _tGrupa As TextBox
    Private _tGrupa_naziv As TextBox
    Private _tKol As TextBox
    Private _tJm As TextBox
    Private _tMarza As TextBox
    Private _tN_cena As TextBox
    Private _tPdv As TextBox
    Private _tP_cena As TextBox
    Private _tMpc As TextBox

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

    Public Property tb_marza() As TextBox
        Get
            Return _tMarza
        End Get
        Set(ByVal Value As TextBox)
            _tMarza = Value
        End Set
    End Property

    Public Property tb_nab_cena() As TextBox
        Get
            Return _tN_cena
        End Get
        Set(ByVal Value As TextBox)
            _tN_cena = Value
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

    Public Property tb_prod_cena() As TextBox
        Get
            Return _tP_cena
        End Get
        Set(ByVal Value As TextBox)
            _tP_cena = Value
        End Set
    End Property

    Public Property tb_mpc() As TextBox
        Get
            Return _tMpc
        End Get
        Set(ByVal Value As TextBox)
            _tMpc = Value
        End Set
    End Property

End Class
