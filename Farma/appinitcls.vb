Imports System.Xml
Imports System.ComponentModel
Imports System.IO

Public Class appinitcls

    Private _Title As String
    Private _Show As String
    Private _Number As Short
    Private m_Server As String
    Private m_Autentication As String
    Private m_Konekcija As String
    Private m_User As String
    Private m_DBName As String
    Private m_Domain As String
    Private m_KonStr As String
    Private m_PrnStr As String

    <CategoryAttribute("Konekcija"), _
          Browsable(True), _
          [ReadOnly](False), _
          BindableAttribute(False), _
          DefaultValueAttribute(""), _
          DesignOnly(False), _
          DescriptionAttribute("Unesite parametar konencije - ime SQL servera.")> _
       Public Property Server() As String
        Get
            Return m_Server
        End Get
        Set(ByVal Value As String)
            m_Server = Value
        End Set
    End Property

    <CategoryAttribute("Konekcija"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute(""), _
       DesignOnly(False), _
       DescriptionAttribute("Unesite parametar konencije - domen.")> _
    Public Property Domen() As String
        Get
            Return m_Domain
        End Get
        Set(ByVal Value As String)
            m_Domain = Value
        End Set
    End Property

    <CategoryAttribute("Konekcija"), _
       Browsable(True), _
       [ReadOnly](False), _
       BindableAttribute(False), _
       DefaultValueAttribute("Oglasi"), _
       DesignOnly(False), _
       DescriptionAttribute("Unesite parametar konencije - ime SQL baze podataka.")> _
    Public Property Baza() As String
        Get
            Return m_DBName
        End Get
        Set(ByVal Value As String)
            m_DBName = Value
        End Set
    End Property

    <CategoryAttribute("Konekcija"), _
     Browsable(True), _
     [ReadOnly](False), _
     BindableAttribute(False), _
     DefaultValueAttribute("Oglasi"), _
     DesignOnly(False), _
     DescriptionAttribute("Unesite parametar konencije - ime SQL baze podataka.")> _
  Public Property Konencija() As String
        Get
            Return m_Konekcija
        End Get
        Set(ByVal Value As String)
            m_Konekcija = Value
        End Set
    End Property

    <CategoryAttribute("Konekcija"), _
     Browsable(True), _
     [ReadOnly](False), _
     BindableAttribute(False), _
     DefaultValueAttribute("Oglasi"), _
     DesignOnly(False), _
     DescriptionAttribute("Unesite parametar konencije - ime SQL baze podataka.")> _
  Public Property Juzer() As String
        Get
            Return m_User
        End Get
        Set(ByVal Value As String)
            m_User = Value
        End Set
    End Property

    Public Property KonString() As String
        Get
            Return m_KonStr
        End Get
        Set(ByVal Value As String)
            m_KonStr = Value
        End Set
    End Property

    Public Property PrnString() As String
        Get
            Return m_PrnStr
        End Get
        Set(ByVal Value As String)
            m_PrnStr = Value
        End Set
    End Property

End Class
