Imports System.Xml
Imports System.ComponentModel
Imports System.IO

Module appinit

    Public CNNString As String
    Public PrintString As String
    Public msp As New appinitcls
    Public cAppObject As appinitcls

    Private mAppPath As String
    Private mExeName As String

    Public Property AppPath() As String
        Get
            Return mAppPath
        End Get
        Set(ByVal value As String)
            mAppPath = value
        End Set
    End Property

    Public Property ExeName() As String
        Get
            Return mExeName
        End Get
        Set(ByVal value As String)
            mExeName = value
        End Set
    End Property


    Public Sub Main()

        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim bForward As Boolean = True


        Application.EnableVisualStyles()

        Application.DoEvents()

        cAppObject = New appinitcls

        Try
            mAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
            mExeName = Dir(mAppPath)
            mAppPath = Path.GetFullPath((Left(mAppPath, (Len(mAppPath) - Len(mExeName)))))
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Podaci o aplikaciji!")
        End Try

        Inicijalizacija()


        If Not bForward Then
            cAppObject = Nothing
            MsgBox("Došlo je do greške")
        Else
            'Dim xMainForm As New mdiMain
            'xMainForm.ShowDialog()
        End If
    End Sub

    Public Sub Inicijalizacija()

        Dim mxDoc As XmlDocument
        Dim xmlPath As String

        xmlPath = Application.StartupPath & "\Config.xml"  ' AppPath & "Config.xml"  'cAppObject.AppPath & "Config.xml"

        mxDoc = New XmlDocument()
        mxDoc.Load(xmlPath)

        Call ReadXMLFile(mxDoc, 0)

        CNNString = msp.KonString
        PrintString = msp.PrnString
        'CNNString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & msp.База & ";Data Source=" & msp.Сервер
        'CNNString = "Data Source=" & msp.Сервер & ";Initial Catalog=" & msp.База & ";Persist Security Info=False;User ID=sa;Password=xxxx"

    End Sub

    Public Sub ReadXMLFile(ByVal xNode As XmlNode, ByVal intLevel As Integer)

        Dim xNodeLoop As XmlNode
        If xNode.HasChildNodes Then
            For Each xNodeLoop In xNode.ChildNodes
                ReadXMLFile(xNodeLoop, intLevel + 1)
            Next xNodeLoop
            Select Case xNode.Name
                Case "Server"
                    msp.Server = xNode.InnerText
                Case "Konencija"
                    msp.Konencija = xNode.InnerText
                Case "User"
                    msp.Juzer = xNode.InnerText
                Case "Baza"
                    msp.Baza = xNode.InnerText
                Case "CNNString"
                    msp.KonString = xNode.InnerText
                Case "PrnString"
                    msp.PrnString = xNode.InnerText
            End Select
        End If
    End Sub

End Module
