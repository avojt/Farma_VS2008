Option Strict Off
Option Explicit On
Module mCodovi
	' ConnectionString = "Provider=MSDataShape.1;Extended Properties="Jet OLEDB:Database Password=bengal;Jet OLEDB:Encrypt Database=True";Persist Security Info=False;Mode=ReadWrite|Share Deny None;Data Source=C:\Program Files\Finpak\01\mp.mdb;Data Provider=MICROSOFT.JET.OLEDB.4.0"
	'.Text = "Sindjelicev trg 22/47" & vbCrLf & "TEL/FAX 018/510-471;

    'tlbMain.SetRow(dgStavke, 9)
    'tlbMain.SetColumn(dgStavke, 1)

	'Dim tform As Form
	'
	'For Each tform In Forms
	'    Unload tform
	'Next tform
	'Unload Me
	
	'------------
	'Za ListView
	'------------
	'Public Sub Popuni_ListView()
	'Dim MyLI As ListItem
	'Dim i As Integer
	'
	'For i = 0 To RS.Fields.Count - 1
	'    lvTabela.ColumnHeaders.Add , , RS.Fields(i).Name
	'Next i
	'
	'lvTabela.ListItems.Clear
	'With RS
	'    .MoveFirst
	'    While Not .EOF
	'        Set MyLI = lvTabela.ListItems.Add
	'        MyLI.Text = .Fields(0)
	'        For i = 1 To RS.Fields.Count - 1
	'            MyLI.SubItems(i) = .Fields(i)
	'        Next i
	'        .MoveNext
	'    Wend
	'End With
	'
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'
	'End Sub
	'
	
	'----------------------------------------------
	'Za SSOleDBGrid
	'----------------------------------------------
	'Private Sub SSOleDBGrid1_InitColumnProps()
	'
	'On Error GoTo ErrorHandler
	'
	'    With SSOleDBGrid1
	'        .Columns.RemoveAll
	'
	'        NeIzvrsavajKodIzgrdMain_UnboundReadData = True
	'
	'        .Columns.Add 0
	'        .Columns(0).Visible = False
	'        .Columns(0).Width = 700
	'        .Columns(0).Caption = c_FN_LagerObjId
	'        .Columns(0).Alignment = Center
	'
	'        .Columns.Add 4
	'        .Columns(4).Visible = True
	'        .Columns(4).Caption = c_FN_LagerKolicina
	'        .Columns(4).Width = 1100
	'        .Columns(4).Alignment = vbRightJustify
	'        .Columns(4).Mask = "99,99#.##"
	'        .Columns(4).DataType = 5
	'        .Columns(4).NumberFormat = "Standard"
	'        .Columns(4).CaptionAlignment = Center
	'
	'        NeIzvrsavajKodIzgrdMain_UnboundReadData = False
	'        .ReBind
	'    End With
	'Exit Sub
	'
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'End Sub
	'
	'----------------
	'Private Sub SSOleDBGrid1_UnboundReadData(ByVal RowBuf As SSDataWidgets_B_OLEDB.ssRowBuffer, StartLocation As Variant, ByVal ReadPriorRows As Boolean)
	'
	'Dim i As Integer
	'Dim j As Integer
	'Dim BrojacRedova As Integer
	'Dim bk As Variant
	'
	'On Error GoTo ErrorHandler
	'
	'If NeIzvrsavajKodIzgrdMain_UnboundReadData = False Then
	'    BrojacRedova = 0
	'    If Not MyEmpty(dteSharing.rsLager) Then
	'        With dteSharing.rsLager
	'            If IsNull(StartLocation) Then
	'                If ReadPriorRows Then
	'                    .MoveLast
	'                Else
	'                    .MoveFirst
	'                End If
	'            Else
	'                .Bookmark = StartLocation
	'                If ReadPriorRows Then
	'                    .MovePrevious
	'                Else
	'                    .MoveNext
	'                End If
	'            End If
	'            For i = 0 To RowBuf.RowCount - 1
	'                If .BOF = True Or .EOF = True Then Exit For
	'
	'                For j = 0 To (.Fields.Count - 1)
	'                    RowBuf.Value(i, j) = .Fields(j).Value
	'                Next j
	'                RowBuf.Bookmark(i) = .Bookmark
	'
	'                If ReadPriorRows Then
	'                    .MovePrevious
	'                Else
	'                    .MoveNext
	'                End If
	'                BrojacRedova = BrojacRedova + 1
	'            Next i
	'        End With
	'        RowBuf.RowCount = BrojacRedova
	'    End If
	'Else
	'    RowBuf.RowCount = RowBuf.RowCount - 1
	'End If
	'Exit Sub
	'
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'
	'End Sub
	
	'****************
	
	'Private Sub SSoledbGrid1_UnboundAddData(ByVal RowBuf As ssRowBuffer, NewRowBookmark As Variant)
	'Dim i As Integer, n As Integer
	'On Error GoTo ErrorHandler
	'
	'With dteSharing.rsTabela_Kuce
	'    n = NadjiMAX(dteSharing.rsTabela_Kuce) + 1
	'    .AddNew
	'    .Fields(0) = n
	'    For i = 1 To .Fields.Count - 1
	'
	'        If Not IsNull(RowBuf.Value(0, i)) Then
	'            If i = 7 Or i = 8 Then
	'                .Fields(i) = CDbl(RowBuf.Value(0, i))
	'            Else
	'                .Fields(i) = RowBuf.Value(0, i)
	'            End If
	'        Else
	'            MsgBox "Nepotpuni podaci"
	'            Exit Sub
	'        End If
	'    Next i
	'    .Update
	'    .MoveLast
	'    NewRowBookmark = .Bookmark
	'End With
	'Exit Sub
	'oId = n
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'
	'End Sub
	'
	
	'*******************
	'Private Sub SSOleDBGrid1_UnboundWriteData(ByVal RowBuf As SSDataWidgets_B_OLEDB.ssRowBuffer, WriteLocation As Variant)
	'Dim i As Integer
	'
	'On Error GoTo ErrorHandler
	'With dteSharing.rsTabela_Kuce
	'    .Bookmark = WriteLocation
	'    For i = 0 To .Fields.Count - 1
	'        If Not IsNull(RowBuf.Value(0, i)) Then
	'            dteSharing.rsTabela_Kuce(i) = RowBuf.Value(0, i)
	'        End If
	'    Next i
	'    .Update
	'End With
	'Exit Sub
	'
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'End Sub
	
	'***************
	'Private Sub SSOleDBGrid1_UnboundDeleteRow(Bookmark As Variant)
	'   RS.Bookmark = SSOleDBGrid1.Bookmark
	'   RS.Delete adAffectCurrent
	'End Sub
	
	'*****************
	'Private Sub SSOleDBGrid1_KeyPress(KeyAscii As Integer)
	'Dim i As Integer
	'On Error GoTo ErrorHandler
	'If KeyAscii = 13 Then
	'    If SSOleDBGrid1.Col = 7 Or SSOleDBGrid1.Col = 8 Or SSOleDBGrid1.Col = 10 Then
	'        dteSharing.rsTabela_KnjigaNabavke.Bookmark = SSOleDBGrid1.Bookmark
	'        dteSharing.rsTabela_KnjigaNabavke.MovePrevious
	'        If Not dteSharing.rsTabela_KnjigaNabavke.BOF Then
	'            stanje = dteSharing.rsTabela_KnjigaNabavke.Fields("Stanje")
	'            vrednost = dteSharing.rsTabela_KnjigaNabavke.Fields("Vrednost")
	'            prCena = dteSharing.rsTabela_KnjigaNabavke.Fields("Prosecna_Cena")
	'        Else
	'            stanje = 0
	'            vrednost = 0
	'            prCena = 0
	'        End If
	'        dteSharing.rsTabela_KnjigaNabavke.MoveNext
	'
	'        With SSOleDBGrid1
	'            .Columns(10).Value = .Columns(7).Value * .Columns(9).Value / 100
	'            .Columns(12).Value = stanje + .Columns(7).Value - .Columns(10).Value - .Columns(11).Value
	'            .Columns(13).Value = TriDecimale(.Columns(8).Value * .Columns(7).Value - .Columns(11).Value * prCena)
	'            .Columns(14).Value = TriDecimale(vrednost + .Columns(13).Value)
	'            .Columns(15).Value = TriDecimale(.Columns(14).Value / .Columns(12).Value)
	'
	'            dteSharing.rsTabela_KnjigaNabavke.Bookmark = .Bookmark
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Kol_Nab") = .Columns(7).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Cena") = .Columns(8).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Kalo") = .Columns(9).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("KaloIznos") = .Columns(10).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Kol_Upot") = .Columns(11).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Stanje") = .Columns(12).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Iznos") = .Columns(13).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Vrednost") = .Columns(14).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Fields("Prosecna_Cena") = .Columns(15).Value
	'            dteSharing.rsTabela_KnjigaNabavke.Update
	'        End With
	'        dteSharing.rsTabela_KnjigaNabavke.Requery
	'
	'        With dteSharing.rsTabela_KnjigaNabavke
	'            stanje = 0
	'            vrednost = 0
	'            prCena = 0
	'            For i = 0 To .RecordCount - 1
	'                .Fields("KaloIznos") = .Fields("Kol_Nab") * .Fields("Kalo") / 100
	'                .Fields("Stanje") = stanje + .Fields("Kol_Nab") - .Fields("KaloIznos") - .Fields("Kol_Upot")
	'                .Fields("Iznos") = .Fields("Cena") * .Fields("Kol_Nab") - .Fields("Kol_Upot") * prCena
	'                .Fields("Vrednost") = vrednost + .Fields("Iznos")
	'                .Fields("Prosecna_Cena") = .Fields("Vrednost") / .Fields("Stanje")
	'                .Update
	'
	'                stanje = .Fields("Stanje")
	'                vrednost = .Fields("Vrednost")
	'                prCena = .Fields("Prosecna_Cena")
	'                .MoveNext
	'            Next i
	'            .Requery
	'            .Filter = "NazivArtikla Like '" & Text1.Text & "*'"
	'            SSOleDBGrid1.ReBind
	'            SnimiNovoSanjeZaliha
	'        End With
	'    Else
	'        If SSOleDBGrid1.Col = 10 Or SSOleDBGrid1.Col = 11 Or SSOleDBGrid1.Col = 12 Or SSOleDBGrid1.Col = 13 Or SSOleDBGrid1.Col = 14 Or SSOleDBGrid1.Col = 14 Or SSOleDBGrid1.Col = 15 Then
	'            MsgBox "Ove podatke ne mozete menjati"
	'            Exit Sub
	'        End If
	'    End If
	'Else
	'    Exit Sub
	'End If
	'Exit Sub
	'
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'End Sub
	
	'***************
	'Private Sub MoveFirstRecord()
	'
	'    SSOleDBGrid1.MoveFirst
	'
	'End Sub
	'
	'***************
	'Private Sub MoveLastRecord()
	'
	'    SSOleDBGrid1.MoveLast
	'
	'End Sub
	'
	'***************
	'Private Sub MovePreviousRecord()
	'
	'    SSOleDBGrid1.MovePrevious
	'
	'End Sub
	'
	'Private Sub MoveNextRecord()
	'
	'    SSOleDBGrid1.MoveNext
	'
	'End Sub
	'
	'***************
	'Private Sub RefreshGrid()
	'
	'    RS_StanjeB.Requery
	'    SSOleDBGrid1_InitColumnProps
	'
	'End Sub
	'
	'***************
	'Private Sub MovePageDown()
	'
	'    SSOleDBGrid1.MoveRecords (SSOleDBGrid1.VisibleRows)
	'
	'End Sub
	'
	'***************
	'Private Sub MovePageUp()
	'
	'    SSOleDBGrid1.MoveRecords -(SSOleDBGrid1.VisibleRows)
	'
	'End Sub
	
	
	
	'---------------
	' Za ToolBar
	'---------------
	'Private Sub PodesavanjeOsobinaToolbara()
	'With Toolbar1
	'    Set .ImageList = frmImages.ImageList1
	'    .Buttons(c_BN_RefreshButton).Image = c_IN_RefreshIkona
	'    .Buttons(c_BN_SaNulomButton).Image = c_IN_SaIkona
	'    .Buttons(c_BN_BezNuleButton).Image = c_IN_BezIkona
	'    .Buttons(c_BN_MoveFirstButton).Image = c_IN_MoveFirstIkona
	'    .Buttons(c_BN_MoveLastButton).Image = c_IN_MoveLastIkona
	'    .Buttons(c_BN_PgUpButton).Image = c_IN_PgUpIkona
	'    .Buttons(c_BN_PgDwButton).Image = c_IN_PgDwIkona
	'    .Buttons(c_BN_MovePreviousButton).Image = c_IN_MovePreviousIkona
	'    .Buttons(c_BN_MoveNextButton).Image = c_IN_MoveNextIkona
	'    .Buttons(c_BN_SearchButton).Image = c_IN_SearchIkona
	'    .Buttons(c_BN_PrintButton).Image = c_IN_PrintIkona
	'    .Buttons(c_BN_KrajButton).Image = c_IN_KrajIkona
	'End With
	'
	'End Sub
	
	
	'Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
	'    Select Case Button.Key
	'    Case c_BN_DeleteButton
	'        If MsgBox("Da li ste sigurni?", vbOKCancel) = vbOK Then
	'            SSOleDBGrid1_UnboundDeleteRow SSOleDBGrid1.Bookmark
	'            SSOleDBGrid1.ReBind
	'        Else
	'            Exit Sub
	'        End If
	'    Case c_BN_RefreshButton
	'        dteSharing.rsTabela_Kuce.Filter = ""
	'        SSOleDBGrid1.ReBind
	'    Case c_BN_SaNulomButton
	'        PripremiBazuSaNulom
	'    Case c_BN_BezNuleButton
	'        PripremiBazuBezNule
	'    Case c_BN_MoveFirstButton
	'        MoveFirstRecord
	'    Case c_BN_MoveLastButton
	'        MoveLastRecord
	'    Case c_BN_PgUpButton
	'        MovePageUp
	'    Case c_BN_PgDwButton
	'        MovePageDown
	'    Case c_BN_MovePreviousButton
	'        MovePreviousRecord
	'    Case c_BN_MoveNextButton
	'        MoveNextRecord
	'    Case c_BN_SearchButton
	'        frmTraziRobu.Show
	'    Case c_BN_PrintButton
	'        SSOleDBGrid1.PrintData ssPrintAllRows, True, True
	'    Case c_BN_KrajButton
	'        dteSharing.rsLager.Close
	'        dteSharing.rsRoba.Close
	'        dteSharing.rsRobno.Close
	'        Unload Me
	'End Select
	'End Sub
	
	' II
	
	'************************
	'UBACIVANJE SLIKE U PICTURE BOX
	'*************************
	'Private Sub Form_Load()
	'    slika = ""
	'    Drive1.Drive = "d:\.."
	'End Sub
	'
	'Private Sub Drive1_Change()
	'   Dir1.Path = Drive1.Drive     ' Set directory path.
	'End Sub
	'
	'Private Sub Dir1_Change()
	'   File1.Path = Dir1.Path   ' Set file path.
	'End Sub
	'
	'Private Sub File1_Click()
	'    Text1.Text = File1.FileName
	'End Sub
	'
	'Private Sub File1_DblClick()
	''Dim pic As Picture
	'    slika = Dir1.Path & "\" & Text1.Text
	'    Set pic = LoadPicture(slika, 1)
	'    Set frmNalog.Picture1.Picture = pic
	'    Unload Me
	'End Sub
	
	'*******************
	'UBACIVANJE SLIKE U RAPORT
	'*******************
	'Private Sub DataReport_Initialize()
	'
	'    Set pic = LoadPicture(slika, 1)
	'    Set Sections.Item(3).Controls.Item(1).Picture = pic
	'End Sub
	
	'*************************
	' ISPITIVANJE BROJEVA
	'*************************
	'Private Sub Text5_KeyPress(KeyAscii As Integer)
	'Dim i As Integer
	'Dim ispravno As Boolean
	'    If KeyAscii = 13 Then
	'        If Text5.Text = "" Then
	'            MsgBox "Unesi ponovo"
	'            Text5.SetFocus
	'        Else
	'            For i = 1 To Len(Text5.Text)
	'                If Mid(Text5.Text, i, 1) = "-" Or Asc(Mid(Text5.Text, i, 1)) = 46 Or (Asc(Mid(Text5.Text, i, 1)) > 47 And Asc(Mid(Text5.Text, i, 1)) < 58) Then
	'                    ispravno = True
	'                Else
	'                    ispravno = False
	'                    MsgBox "Pogresan tip podataka"
	'                    Text5.SetFocus
	'                    Exit For
	'                End If
	'            Next i
	'        End If
	'    End If
	'End Sub
	'
	
	'************************************************
	'   KOD ZA OTVARANJE DROP DOWN-A SA FILTEROM
	'************************************************
	'
	'Private Sub SSOleDBDropDown1_UnboundReadData(ByVal RowBuf As SSDataWidgets_B_OLEDB.ssRowBuffer, StartLocation As Variant, ByVal ReadPriorRows As Boolean)
	'
	'Dim i As Integer
	'Dim j As Integer
	'Dim BrojacRedova As Integer
	'Dim bk As Variant
	'
	'On Error GoTo ErrorHandler
	'dteSharing.rsTabela_Prodavci.Filter = ""
	'If dteSharing.rsTabela_Kuce.RecordCount > 0 And dteSharing.rsTabela_Prodavci.RecordCount > 0 Then
	'dteSharing.rsTabela_Prodavci.Filter = "IdNekretnina = " & SSOleDBGrid1.Columns(1).Value
	
	''ILI
	''Otvori_RS
	
	'If NeIzvrsavajKodIzgrdMain_UnboundReadData = False Then
	'    BrojacRedova = 0
	'    If Not MyEmpty(RS) Then
	'        With RS
	'            If IsNull(StartLocation) Then
	'                If ReadPriorRows Then
	'                    .MoveLast
	'                Else
	'                    .MoveFirst
	'                End If
	'            Else
	'                .Bookmark = StartLocation
	'                If ReadPriorRows Then
	'                    .MovePrevious
	'                Else
	'                    .MoveNext
	'                End If
	'            End If
	'            For i = 0 To RowBuf.RowCount - 1
	'                If .BOF = True Or .EOF = True Then Exit For
	'
	'                For j = 0 To (.Fields.Count - 1)
	'                    RowBuf.Value(i, j) = .Fields(j).Value
	'                Next j
	'                RowBuf.Bookmark(i) = .Bookmark
	'
	'                If ReadPriorRows Then
	'                    .MovePrevious
	'                Else
	'                    .MoveNext
	'                End If
	'                BrojacRedova = BrojacRedova + 1
	'            Next i
	'        End With
	'        RowBuf.RowCount = BrojacRedova
	'    End If
	'Else
	'    RowBuf.RowCount = RowBuf.RowCount - 1
	'End If
	'Exit Sub
	'
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'End Sub
	'
	'Private Sub Otvori_RS()
	'On Error GoTo ErrorHandler
	'Set RS = New ADODB.Recordset
	'With RS
	'    Set .ActiveConnection = MyConn
	'    .Source = "Select * From Cekovi Where IdVlasnika = " & SSOleDBGrid1.Columns(0).Value ' Bookmark
	'    .LockType = adLockOptimistic
	'    .CursorLocation = adUseClient
	'    .CursorType = adOpenStatic
	'    .Open
	'End With
	'Exit Sub
	'ErrorHandler:
	'    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'End Sub
	
	
	
	'*************************
	
	
	'Private Sub Combo1_DropDown()
	'Dim i As Integer
	'On Error GoTo ErrorHandler
	'Combo1.Clear
	'With dteSharing
	'    RS_Sifre.Filter = ""
	'    If RS_Grejaci.RecordCount > 0 And _
	''        RS_Sifre.RecordCount > 0 Then _
	''        RS_Sifre.Filter = "Kljuc = " & SSOleDBGrid1.Columns(1).Value
	'    If RS_Sifre.RecordCount > 0 Then
	'        RS_Sifre.MoveFirst
	'        For i = 2 To RS_Sifre.Fields.Count - 1
	'            If Not IsNull(RS_Sifre.Fields(i)) Then
	'                Combo1.AddItem RS_Sifre.Fields(i)
	'            Else
	'                Exit For
	'            End If
	'        Next i
	'    Else
	'        Combo1.AddItem "Nema ostalih sifri"
	'    End If
	'End With
	'Exit Sub
	'ErrorHandler:
	'    ObradaGreske Err
	'Exit Sub
	'    Resume Next
	'End Sub
	
	
	'Private Sub Combo1_Click()
	'Dim i As Integer
	'On Error GoTo ErrorHandler
	'Combo1.Clear
	'With dteSharing
	'    RS_Sifre.Filter = ""
	'    If RS_Grejaci.RecordCount > 0 And _
	''        RS_Sifre.RecordCount > 0 And _
	''        SSOleDBGrid1.Bookmark < SSOleDBGrid1.Rows - 1 Then _
	''        RS_Sifre.Filter = "Kljuc = " & SSOleDBGrid1.Columns(1).Value
	'    If RS_Sifre.RecordCount > 0 Then
	'        RS_Sifre.MoveFirst
	'        For i = 2 To RS_Sifre.Fields.Count - 1
	'            If Not IsNull(RS_Sifre.Fields(i)) Then
	'                Combo1.AddItem RS_Sifre.Fields(i)
	'            Else
	'                Exit For
	'            End If
	'        Next i
	'    Else
	'        Combo1.AddItem "Nema ostalih sifri"
	'    End If
	'End With
	'Exit Sub
	'ErrorHandler:
	''    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'
	'End Sub
	
	'Private Sub Memorisi()
	'Dim n As Long
	'
	'On Error GoTo ErrorHandler
	'
	'    With dteSharing.rsTabela_Agencije
	'        If Text1.Text <> "" And ImaBlanko(Text1.Text) = False Then
	'            .Fields("ime").Value = Text1.Text
	'        Else
	'            .Fields("ime") = "/"
	'        End If
	'        If Text2.Text <> "" And ImaBlanko(Text2.Text) = False Then
	'            .Fields("Telefon").Value = Text2.Text
	'        Else
	'            .Fields("Telefon") = "/"
	'        End If
	'        .Update
	'        .Requery
	'    End With
	'Exit Sub
	'
	'ErrorHandler:
	''    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'
	'End Sub
	
	'Private Sub Ponovo()
	'On Error GoTo ErrorHandler
	'    With dteSharing.rsTabela_Agencije
	'    If Not IsNull(.Fields("ime").Value) Then
	'        Text1.Text = .Fields("ime")
	'    Else
	'        Text1.Text = ""
	'    End If
	'    If Not IsNull(.Fields("Telefon").Value) Then
	'        Text2.Text = .Fields("Telefon")
	'    Else
	'        Text2.Text = ""
	'    End If
	'
	'End With
	'    Text1.TabIndex = 0
	'Exit Sub
	'ErrorHandler:
	''    ObradaGreske Err
	'    Resume Next
	'Exit Sub
	'
	'End Sub
	
	
	'Private Sub mnuHelpAbout_Click()
	'    MsgBox "Version " & App.Major & "." & App.Minor & "." & App.Revision
	'End Sub
	'
	'Private Sub mnuHelpSearchForHelpOn_Click()
	'    Dim nRet As Integer
	'
	'
	'    'if there is no helpfile for this project display a message to the user
	'    'you can set the HelpFile for your application in the
	'    'Project Properties dialog
	'    If Len(App.HelpFile) = 0 Then
	'        MsgBox "Unable to display Help Contents. There is no Help associated with this project.", vbInformation, Me.Caption
	'    Else
	'        On Error Resume Next
	'        nRet = OSWinHelp(Me.hwnd, App.HelpFile, 261, 0)
	'        If Err Then
	'            MsgBox Err.Description
	'        End If
	'    End If
	'
	'End Sub
	'
	'Private Sub mnuHelpContents_Click()
	'    Dim nRet As Integer
	'    'if there is no helpfile for this project display a message to the user
	'    'you can set the HelpFile for your application in the
	'    'Project Properties dialog
	'    If Len(App.HelpFile) = 0 Then
	'        MsgBox "Unable to display Help Contents. There is no Help associated with this project.", vbInformation, Me.Caption
	'    Else
	'        On Error Resume Next
	'        nRet = OSWinHelp(Me.hwnd, App.HelpFile, 3, 0)
	'        If Err Then
	'            MsgBox Err.Description
	'        End If
	'    End If
	'
	'End Sub
	'
	'Private Sub mnuWindowArrangeIcons_Click()
	'    Me.Arrange vbArrangeIcons
	'End Sub
	'
	'Private Sub mnuWindowTileVertical_Click()
	'    Me.Arrange vbTileVertical
	'End Sub
	'
	'Private Sub mnuWindowTileHorizontal_Click()
	'    Me.Arrange vbTileHorizontal
	'End Sub
	'
	'Private Sub mnuWindowCascade_Click()
	'    Me.Arrange vbCascade
	'End Sub
	'
	'Private Sub mnuWindowNewWindow_Click()
	'    LoadNewDoc
	'End Sub
	'
	'Private Sub mnuViewWebBrowser_Click()
	'    Dim frmB As New frmBrowser
	'    frmB.StartingAddress = "http://www.microsoft.com"
	'    frmB.Show
	'End Sub
	'
	'Private Sub mnuViewOptions_Click()
	'    'ToDo: Add 'mnuViewOptions_Click' code.
	'    MsgBox "Add 'mnuViewOptions_Click' code."
	'End Sub
	'
	'Private Sub mnuViewRefresh_Click()
	'    'ToDo: Add 'mnuViewRefresh_Click' code.
	'    MsgBox "Add 'mnuViewRefresh_Click' code."
	'End Sub
	'
	'Private Sub mnuViewStatusBar_Click()
	'    mnuViewStatusBar.Checked = Not mnuViewStatusBar.Checked
	'    sbStatusBar.Visible = mnuViewStatusBar.Checked
	'End Sub
	'
	'Private Sub mnuViewToolbar_Click()
	'    mnuViewToolbar.Checked = Not mnuViewToolbar.Checked
	'    tbToolbar.Visible = mnuViewToolbar.Checked
	'End Sub
	'
	'
	'
	'Private Sub mnuEditPasteSpecial_Click()
	'    'ToDo: Add 'mnuEditPasteSpecial_Click' code.
	'    MsgBox "Add 'mnuEditPasteSpecial_Click' code."
	'End Sub
	'
	'Private Sub mnuEditPaste_Click()
	'    On Error Resume Next
	'    ActiveForm.rtfText.SelRTF = Clipboard.GetText
	'
	'End Sub
	'
	'Private Sub mnuEditCopy_Click()
	'    On Error Resume Next
	'    Clipboard.SetText ActiveForm.rtfText.SelRTF
	'
	'End Sub
	'
	'Private Sub mnuEditCut_Click()
	'    On Error Resume Next
	'    Clipboard.SetText ActiveForm.rtfText.SelRTF
	'    ActiveForm.rtfText.SelText = vbNullString
	'
	'End Sub
	'
	'Private Sub mnuEditUndo_Click()
	'    'ToDo: Add 'mnuEditUndo_Click' code.
	'    MsgBox "Add 'mnuEditUndo_Click' code."
	'End Sub
	'
	'
	'Private Sub mnuFileExit_Click()
	'    'unload the form
	'    Unload Me
	'
	'End Sub
	'
	'Private Sub mnuFileSend_Click()
	'    'ToDo: Add 'mnuFileSend_Click' code.
	'    MsgBox "Add 'mnuFileSend_Click' code."
	'End Sub
	'
	'Private Sub mnuFilePrint_Click()
	'    On Error Resume Next
	'    If ActiveForm Is Nothing Then Exit Sub
	'
	'
	'    With dlgCommonDialog
	'        .DialogTitle = "Print"
	'        .CancelError = True
	'        .Flags = cdlPDReturnDC + cdlPDNoPageNums
	'        If ActiveForm.rtfText.SelLength = 0 Then
	'            .Flags = .Flags + cdlPDAllPages
	'        Else
	'            .Flags = .Flags + cdlPDSelection
	'        End If
	'        .ShowPrinter
	'        If Err <> MSComDlg.cdlCancel Then
	'            ActiveForm.rtfText.SelPrint .hDC
	'        End If
	'    End With
	'
	'End Sub
	'
	'Private Sub mnuFilePrintPreview_Click()
	'    'ToDo: Add 'mnuFilePrintPreview_Click' code.
	'    MsgBox "Add 'mnuFilePrintPreview_Click' code."
	'End Sub
	'
	'Private Sub mnuFilePageSetup_Click()
	'    On Error Resume Next
	'    With dlgCommonDialog
	'        .DialogTitle = "Page Setup"
	'        .CancelError = True
	'        .ShowPrinter
	'    End With
	'
	'End Sub
    '


	'Private Sub mnuFileProperties_Click()
	'    'ToDo: Add 'mnuFileProperties_Click' code.
	'    MsgBox "Add 'mnuFileProperties_Click' code."
	'End Sub
	'
	'Private Sub mnuFileSaveAll_Click()
	'    'ToDo: Add 'mnuFileSaveAll_Click' code.
	'    MsgBox "Add 'mnuFileSaveAll_Click' code."
	'End Sub
    '


	'Private Sub mnuFileSaveAs_Click()
	'    Dim sFile As String
	'
    '    If ActiveForm Is Nothing Then Exit Sub
	'
    '    With dlgCommonDialog
	'        .DialogTitle = "Save As"
	'        .CancelError = False
	'        'ToDo: set the flags and attributes of the common dialog control
	'        .Filter = "All Files (*.*)|*.*"
	'        .ShowSave
	'        If Len(.FileName) = 0 Then
	'            Exit Sub
	'        End If
	'        sFile = .FileName
	'    End With
	'    ActiveForm.Caption = sFile
	'    ActiveForm.rtfText.SaveFile sFile
	'
	'End Sub
	'
	'Private Sub mnuFileSave_Click()
	'    Dim sFile As String
	'    If Left$(ActiveForm.Caption, 8) = "Document" Then
	'        With dlgCommonDialog
	'            .DialogTitle = "Save"
	'            .CancelError = False
	'            'ToDo: set the flags and attributes of the common dialog control
	'            .Filter = "All Files (*.*)|*.*"
	'            .ShowSave
	'            If Len(.FileName) = 0 Then
	'                Exit Sub
	'            End If
	'            sFile = .FileName
	'        End With
	'        ActiveForm.rtfText.SaveFile sFile
	'    Else
	'        sFile = ActiveForm.Caption
	'        ActiveForm.rtfText.SaveFile sFile
	'    End If
	'
	'End Sub
	
	'*********************
	'   COMBO
	'*********************
	'Private Sub Popuni_Combo_01()
	'Dim i As Integer
	'Dim j As Integer
	'Dim ima As Boolean
	'Dim s As String
	'
	'On Error GoTo ErrorHandler
	'Combo1.Clear
	'Combo1.AddItem novo
	''Otvori_RS
	'
	'With dteKlijent.rsTabela_Normativi
	'    .Filter = ""
	'    If .RecordCount > 0 Then
	'        .MoveFirst
	'        If Not .EOF Then
	'            For i = 0 To .RecordCount - 1
	'                For j = 0 To Combo1.ListCount - 1
	'                    Combo1.ListIndex = j
	'                    If .Fields("NazivJela") = Combo1.Text Then
	'                        ima = True
	'                    End If
	'                Next j
	'
	'                If Not ima Then
	'                    s = CStr(.Fields("NazivJela")) '& " : " & CStr(.Fields("NazivJela")) & " : " & CStr(.Fields("Datum"))
	'                    Combo1.AddItem s
	'                End If
	'                .MoveNext
	'                ima = False
	'            Next i
	'        Else
	'            MsgBox "Nema podataka"
	'        End If
	'    Else
	'        Combo1.Text = novo
	'    End If
	'    Combo1.ListIndex = 0
	'End With
	'
	'Exit Sub
	'
	'ErrorHandler:
	'Exit Sub
	'End Sub
	
	'IZRACUNAVANJE UKUPNOG POREZA PRVA VARIJANTA
	
	'Public Sub UkupanPP(ByVal tRs As ADODB.Recordset, ByVal tRb)
	'Dim i As Integer
	'
	''Dim dak01 As Integer, dak02 As Integer, dak03 As Integer, dak04 As Integer, dak05 As Integer
	'    stopa01 = 9999
	'    stopa02 = 9999
	'    stopa03 = 9999
	'    stopa04 = 9999
	'    stopa05 = 9999
	'    pp01 = 0
	'    pp02 = 0
	'    pp03 = 0
	'    pp04 = 0
	'    pp05 = 0
	'    dak01 = 9
	'    dak02 = 9
	'    dak03 = 9
	'    dak04 = 9
	'    dak05 = 9
	'    With tRs
	'        .Requery
	'        .Filter = "BrojKalk like '" & tRb & "'"
	'            If .RecordCount > 0 Then
	'            .MoveFirst
	'            For j = 0 To .RecordCount - 1
	'                If IsNull(.Fields("StopaPoreza")) Then tRs.Fields("StopaPoreza") = 0
	'                If IsNull(.Fields("PorezUplata")) Then tRs.Fields("PorezUplata") = 0
	'                If stopa01 = tRs.Fields("StopaPoreza") And dak01 = tRs.Fields("DAK") Then
	'                    pp01 = pp01 + tRs.Fields("PorezUplata")
	'                Else
	'                    If stopa02 = tRs.Fields("StopaPoreza") And dak02 = tRs.Fields("DAK") Then
	'                        pp02 = pp02 + tRs.Fields("PorezUplata")
	'                    Else
	'                        If stopa03 = tRs.Fields("StopaPoreza") And dak03 = tRs.Fields("DAK") Then
	'                            pp03 = pp03 + .Fields("PorezUplata")
	'                        Else
	'                            If stopa04 = tRs.Fields("StopaPoreza") And dak04 = tRs.Fields("DAK") Then
	'                                pp04 = pp04 + tRs.Fields("PorezUplata")
	'                            Else
	'                                If stopa05 = tRs.Fields("StopaPoreza") And dak05 = tRs.Fields("DAK") Then
	'                                    pp05 = pp05 + tRs.Fields("PorezUplata")
	'                                Else
	'                                    If stopa01 = 9999 And dak01 = 9 Then
	'                                        stopa01 = tRs.Fields("StopaPoreza")
	'                                        pp01 = pp01 + tRs.Fields("PorezUplata")
	'                                        dak01 = tRs.Fields("DAK")
	'                                    Else
	'                                        If stopa02 = 9999 And dak02 = 9 Then
	'                                            stopa02 = tRs.Fields("StopaPoreza")
	'                                            pp02 = pp02 + tRs.Fields("PorezUplata")
	'                                            dak02 = tRs.Fields("DAK")
	'                                        Else
	'                                            If stopa03 = 9999 And dak03 = 9 Then
	'                                                stopa03 = tRs.Fields("StopaPoreza")
	'                                                pp03 = pp03 + tRs.Fields("PorezUplata")
	'                                                dak03 = tRs.Fields("DAK")
	'                                            Else
	'                                                If stopa04 = 9999 And dak04 = 9 Then
	'                                                    stopa04 = tRs.Fields("StopaPoreza")
	'                                                    pp04 = pp04 + tRs.Fields("PorezUplata")
	'                                                    dak04 = tRs.Fields("DAK")
	'                                                Else
	'                                                    If stopa05 = 9999 And dak05 = 9 Then
	'                                                        stopa05 = tRs.Fields("StopaPoreza")
	'                                                        pp05 = pp05 + tRs.Fields("PorezUplata")
	'                                                        dak05 = tRs.Fields("DAK")
	'                                                    End If
	'                                                End If
	'                                            End If
	'                                        End If
	'                                    End If
	'                                End If
	'                            End If
	'                        End If
	'                    End If
	'                End If
	'                tRs.MoveNext
	'            Next i
	'        Else
	'            stopa01 = 0
	'            stopa02 = 0
	'            stopa03 = 0
	'            stopa04 = 0
	'            stopa05 = 0
	'            pp01 = 0
	'            pp02 = 0
	'            pp03 = 0
	'            pp04 = 0
	'            pp05 = 0
	'        End If
	'    End With
	'
	'    If stopa01 = 9999 Then stopa01 = 0
	'    If stopa02 = 9999 Then stopa02 = 0
	'    If stopa03 = 9999 Then stopa03 = 0
	'    If stopa04 = 9999 Then stopa04 = 0
	'    If stopa05 = 9999 Then stopa05 = 0
	'    pp01 = DveDecimale(CStr(pp01))
	'    pp02 = DveDecimale(CStr(pp02))
	'    pp03 = DveDecimale(CStr(pp03))
	'    pp04 = DveDecimale(CStr(pp04))
	'    pp05 = DveDecimale(CStr(pp05))
	'End Sub
	'
	'
	
	
	'Public Sub prnRekapitulacija(ByVal DatumOd As Date, ByVal DatumDo As Date)
	'Dim i As Integer, j As Integer
	'Dim rs_KalkHead As New ADODB.Recordset, rs_KalkStavke As New ADODB.Recordset
	'Dim vredPP As Single, ukalkPP As Single, ppDob As Single
	'Dim U_vredPP As Single, U_ukalkPP As Single, U_ppDob As Single
	'On Error Resume Next
	'
	'With dteKlijent
	'    .rsprnRekap.Requery
	'    .rsprnRekap.Filter = ""
	'    If .rsprnRekap.RecordCount > 0 Then
	'        .rsprnRekap.MoveFirst
	'        For i = 0 To .rsprnRekap.RecordCount - 1
	'            .rsprnRekap.Delete adAffectCurrent
	'            .rsprnRekap.Update
	'            .rsprnRekap.MoveNext
	'        Next i
	'    End If
	'
	'    .rsporez.Requery
	'    .rsporez.Filter = ""
	'    If .rsporez.RecordCount > 0 Then
	'        U_ppDob = 0
	'        U_ukalkPP = 0
	'        U_vredPP = 0
	'        .rsTabela_PK1.MoveFirst
	'        For i = 0 To .rsporez.RecordCount - 1
	'            If Not IsNull(.rsporez.Fields("Stopa_Poreza")) _
	''                    And Not IsEmpty(.rsporez.Fields("Stopa_Poreza")) _
	''                    And Not .rsporez.EOF Then
	'
	''                Set rs_KalkHead = Otvori_RS("Select * From KalkulacijaHeader Where DatumKlak >= #" & DatumOd & "# and Datum <= #" & DatumDo & "#")
	''
	''                Set rs_KalkHead = Otvori_RS("Select * From KalkulacijaHeader Where DatumKlak >= #" & DatumOd & "# and Datum <= #" & DatumDo & "#")
	'                .rsTabela_PK1.Requery
	'                .rsTabela_PK1.Filter = ""
	'            'STOPA 01
	'                .rsTabela_PK1.Filter = "Opis Like 'Kalkulacija br.%' and Datum >= #" _
	''                                    & DatumOd & "# and Datum <= #" & DatumDo _
	''                                    & "# and StopaPoreza01 = " & .rsporez.Fields("Stopa_Poreza")
	'                If .rsTabela_PK1.RecordCount > 0 Then
	'                    vredPP = 0
	'                    ukalkPP = 0
	'                    ppDob = 0
	'                    .rsTabela_PK1.MoveFirst
	'                    For j = 0 To .rsTabela_PK1.RecordCount - 1
	'                        vredPP = vredPP + .rsTabela_PK1.Fields("ProdajnaVrednostPP")
	'                        ukalkPP = ukalkPP + .rsTabela_PK1.Fields("NabVrednost")
	'                        ppDob = ppDob + .rsTabela_PK1.Fields("PorezDobavljaca")
	'                        .rsTabela_PK1.MoveNext
	'                    Next j
	'                End If
	'                U_ppDob = U_ppDob + ppDob
	'                U_ukalkPP = U_ukalkPP + ukalkPP
	'                U_vredPP = U_vredPP + vredPP
	'            'STOPA 02
	'                .rsTabela_PK1.Filter = "Opis Like 'Kalkulacija br.%' and Datum >= #" _
	''                                    & DatumOd & "# and Datum <= #" & DatumDo _
	''                                    & "# and StopaPoreza02 = " & .rsporez.Fields("Stopa_Poreza")
	'                If .rsTabela_PK1.RecordCount > 0 Then
	'                    vredPP = 0
	'                    ukalkPP = 0
	'                    ppDob = 0
	'                    .rsTabela_PK1.MoveFirst
	'                    For j = 0 To .rsTabela_PK1.RecordCount - 1
	'                        vredPP = vredPP + .rsTabela_PK1.Fields("ProdajnaVrednostPP")
	'                        ukalkPP = ukalkPP + .rsTabela_PK1.Fields("NabVrednost")
	'                        ppDob = ppDob + .rsTabela_PK1.Fields("PorezDobavljaca")
	'                        .rsTabela_PK1.MoveNext
	'                    Next j
	'                End If
	'                U_ppDob = U_ppDob + ppDob
	'                U_ukalkPP = U_ukalkPP + ukalkPP
	'                U_vredPP = U_vredPP + vredPP
	'            'STOPA 03
	'                .rsTabela_PK1.Filter = "Opis Like 'Kalkulacija br.%' and Datum >= #" _
	''                                    & DatumOd & "# and Datum <= #" & DatumDo _
	''                                    & "# and StopaPoreza03 = " & .rsporez.Fields("Stopa_Poreza")
	'                If .rsTabela_PK1.RecordCount > 0 Then
	'                    vredPP = 0
	'                    ukalkPP = 0
	'                    ppDob = 0
	'                    .rsTabela_PK1.MoveFirst
	'                    For j = 0 To .rsTabela_PK1.RecordCount - 1
	'                        vredPP = vredPP + .rsTabela_PK1.Fields("ProdajnaVrednostPP")
	'                        ukalkPP = ukalkPP + .rsTabela_PK1.Fields("NabVrednost")
	'                        ppDob = ppDob + .rsTabela_PK1.Fields("PorezDobavljaca")
	'                        .rsTabela_PK1.MoveNext
	'                    Next j
	'                End If
	'                U_ppDob = U_ppDob + ppDob
	'                U_ukalkPP = U_ukalkPP + ukalkPP
	'                U_vredPP = U_vredPP + vredPP
	'            'STOPA 04
	'                .rsTabela_PK1.Filter = "Opis Like 'Kalkulacija br.%' and Datum >= #" _
	''                                    & DatumOd & "# and Datum <= #" & DatumDo _
	''                                    & "# and StopaPoreza04 = " & .rsporez.Fields("Stopa_Poreza")
	'                If .rsTabela_PK1.RecordCount > 0 Then
	'                    vredPP = 0
	'                    ukalkPP = 0
	'                    ppDob = 0
	'                    .rsTabela_PK1.MoveFirst
	'                    For j = 0 To .rsTabela_PK1.RecordCount - 1
	'                        vredPP = vredPP + .rsTabela_PK1.Fields("ProdajnaVrednostPP")
	'                        ukalkPP = ukalkPP + .rsTabela_PK1.Fields("NabVrednost")
	'                        ppDob = ppDob + .rsTabela_PK1.Fields("PorezDobavljaca")
	'                        .rsTabela_PK1.MoveNext
	'                    Next j
	'                End If
	'                U_ppDob = U_ppDob + ppDob
	'                U_ukalkPP = U_ukalkPP + ukalkPP
	'                U_vredPP = U_vredPP + vredPP
	'            'STOPA 05
	'                .rsTabela_PK1.Filter = "Opis Like 'Kalkulacija br.%' and Datum >= #" _
	''                                    & DatumOd & "# and Datum <= #" & DatumDo _
	''                                    & "# and StopaPoreza05 = " & .rsporez.Fields("Stopa_Poreza")
	'                If .rsTabela_PK1.RecordCount > 0 Then
	'                    vredPP = 0
	'                    ukalkPP = 0
	'                    ppDob = 0
	'                    .rsTabela_PK1.MoveFirst
	'                    For j = 0 To .rsTabela_PK1.RecordCount - 1
	'                        vredPP = vredPP + .rsTabela_PK1.Fields("ProdajnaVrednostPP")
	'                        ukalkPP = ukalkPP + .rsTabela_PK1.Fields("NabVrednost")
	'                        ppDob = ppDob + .rsTabela_PK1.Fields("PorezDobavljaca")
	'                        .rsTabela_PK1.MoveNext
	'                    Next j
	'                End If
	'                U_ppDob = U_ppDob + ppDob
	'                U_ukalkPP = U_ukalkPP + ukalkPP
	'                U_vredPP = U_vredPP + vredPP
	'
	'                .rsprnRekap.AddNew
	'                .rsprnRekap.Fields("DatumOd") = DatumOd
	'                .rsprnRekap.Fields("DatumDo") = DatumDo
	'                .rsprnRekap.Fields("Opis") = .rsporez.Fields("Opis")
	'                .rsprnRekap.Fields("ZR") = .rsporez.Fields("ZiroRacun")
	'                .rsprnRekap.Fields("StopaPoreza") = .rsporez.Fields("Stopa_Poreza")
	'                .rsprnRekap.Fields("UkalkPorez") = U_ukalkPP
	'                .rsprnRekap.Fields("PorezOsnovica") = U_vredPP
	'                .rsprnRekap.Fields("ZaUplatu") = U_ukalkPP - U_ppDob
	'                .rsprnRekap.Fields("PorezOsnovicaDob") = (.rsTabela_PK1.Fields("PorezDobavljaca") / .rsporez.Fields("Stopa_Poreza")) * 100
	'                .rsprnRekap.Fields("ZaUplatuDob") = U_ppDob
	'                .rsprnRekap.Fields("PorezOsnovicaUsluge") = 0
	'                .rsprnRekap.Fields("ZaUplatuUsluge") = 0
	'                .rsprnRekap.Update
	'            End If
	'        .rsporez.MoveNext
	'        Next i
	'    End If
	'End With
	'End Sub
	
	
	'Private Sub mnuCompresBase_Click()
	'    CompactAndEncrypt
	'End Sub
	'
	'Private Sub mnuDobavljaci_Click()
	'    Dim frmD As frmDobav
	'    Set frmD = New frmDobav
	'    frmD.Caption = "Dobavljaci"
	'    frmD.Show
	'    If mnuToolbar.Checked = True Then
	'        mnuToolbar.Checked = False
	'        mnuToolbar_Click
	'        mnuToolbar.Checked = True
	'    End If
	'End Sub
	
	'Set Rs_qryProdavac_Kuce = RS.Otvori_RS("SELECT Kuce.*, Prodavci.* " & _
	''                                           "FROM Kuce " & _
	''                                           "LEFT JOIN Prodavci ON Kuce.id = Prodavci.IdNekretnina " & _
	''                                           "Where (((Prodavci.TipNekretnina) = 'kuce')) " & _
	''                                           "ORDER BY Kuce.rb")
	
	
	
	
	'Private Sub Combo1_KeyPress(KeyAscii As Integer)
	'On Error GoTo ErrorHandler
	'If KeyAscii = 13 Then
	'        Text9.SetFocus
	'Else
	'    If KeyAscii = vbKeyDown Then
	'        If Combo1.ListIndex < Combo1.ListCount - 1 Then
	'            Combo1.ListIndex = Combo1.ListIndex + 1
	'        End If
	'    End If
	'End If
	'Exit Sub
	'
	'ErrorHandler:
	'    Resume Next
	'Exit Sub
    'End Sub

    '********************************************
    '********************************************
    '**               VB 2005                  **
    '********************************************
    '********************************************

    'Private kol As Single = 1
    'Private cena As Single
    'Private pdv As Single = 1
    'Private skol As Single = 1
    'Private scena As Single
    'Private spdv As Single = 1

    'Private _pocetak As Boolean = True

    'Private Overloads Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
    '    Select Case e.Button.Text
    '        Case "Snimi"
    '            snimi()
    '            pocetak()
    '        Case "Kraj"
    '            Me.Close()
    '    End Select
    'End Sub

    'Private Sub snimi()
    '    'On Error Resume Next
    '    'Dim mConn As New ADODB.Connection
    '    'mConn.ConnectionString = My.Settings.RZZOConnectionString
    '    'If mConn.State = 0 Then mConn.Open(My.Settings.RZZOConnectionString)
    '    Dim i As Integer
    '    If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
    '        Dim rs As New ADODB.Recordset
    '        With rs
    '            Try
    '                .Open("Select * from Faktura", MyConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
    '                .AddNew()
    '                .Fields("IDFaktura").Value = Text1.Text
    '                .Fields("IdFilijala").Value = ""
    '                .Fields("TipFakture").Value = ""
    '                .Fields("PM").Value = ""
    '                .Fields("BrojNaloga").Value = 0
    '                .Fields("NabavnaVrednost").Value = Text7.Text
    '                .Fields("IznosMarze").Value = 0
    '                .Fields("IznosPoreza").Value = Text9.Text
    '                .Fields("IznosParticipacije").Value = 0
    '                .Fields("IznosUcesca").Value = 0
    '                .Fields("Ukupno").Value = 0
    '                .Fields("IznosZaNaplatu").Value = Text13.Text
    '                .Fields("DatumFakturisanja").Value = DateTimePicker1.Value
    '                .Fields("DatumOd").Value = DateTimePicker1.Value
    '                .Fields("DatumDo").Value = DateTimePicker1.Value
    '                .Fields("sifra_katalog").Value = ""
    '                .Fields("fisklani").Value = Text19.Text
    '                .Fields("napomena").Value = Text20.Text
    '                .Fields("licno").Value = 1
    '                .Update()
    '                .Close()
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '                Exit Sub
    '            End Try
    '        End With
    '        rs = Nothing

    '        Dim rs1 As New ADODB.Recordset
    '        With rs1
    '            Try
    '                .Open("Select * from faktura_licno_kupac", MyConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
    '                .AddNew()
    '                .Fields("IDFaktura").Value = Text1.Text
    '                .Fields("ime").Value = TextBox1.Text
    '                .Fields("prezime").Value = TextBox2.Text
    '                .Fields("jmbg").Value = TextBox3.Text
    '                .Update()
    '                .Close()
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '                Exit Sub
    '            End Try

    '        End With
    '        rs1 = Nothing

    '        Dim rs2 As New ADODB.Recordset
    '        With rs2
    '            Try
    '                DataGridView1.Rows.GetFirstRow(0, 0)
    '                For i = 0 To DataGridView1.Rows.Count - 2
    '                    DataGridView1.Rows.GetNextRow(i, Windows.Forms.DataGridViewElementStates.Selected)
    '                    .Open("Select * from faktura_licno_pomagalo", MyConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
    '                    .AddNew()
    '                    .Fields("IDFaktura").Value = Text1.Text
    '                    .Fields("rb").Value = DataGridView1.Rows(i).Cells(0).Value
    '                    .Fields("pomagalo").Value = DataGridView1.Rows(i).Cells(1).Value
    '                    .Fields("cena").Value = DataGridView1.Rows(i).Cells(3).Value
    '                    .Fields("kol").Value = DataGridView1.Rows(i).Cells(2).Value
    '                    .Fields("pdv").Value = DataGridView1.Rows(i).Cells(4).Value
    '                    .Fields("iznos").Value = DataGridView1.Rows(i).Cells(5).Value
    '                    .Update()
    '                    .Close()
    '                Next
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '                Exit Sub
    '            End Try

    '        End With
    '        rs2 = Nothing
    '    Else
    '        MsgBox("Polja: Ime, Prezime i JMBG morate obavezno uneti!")
    '        Exit Sub
    '    End If


    'End Sub

    'Private Sub pocetak()
    '    On Error Resume Next

    '    Text1.Text = redni_broj(RS_Fakture).ToString
    '    Text1.Enabled = False
    '    Text7.Text = CStr(0)
    '    Text9.Text = CStr(0)
    '    Text13.Text = CStr(0)
    '    Text19.Text = ""
    '    Text20.Text = ""
    '    DateTimePicker1.Value = Today

    '    kol = 1
    '    cena = 0
    '    pdv = 1
    '    scena = 0
    '    skol = 1
    '    spdv = 0

    'End Sub


    'Private Sub frmFakturaUnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    pocetak()
    '    'TODO: This line of code loads data into the 'Dataset1.Pomagala' table. You can move, or remove it, as needed.
    '    Me.PomagalaTableAdapter.Fill(Me.Dataset1.Pomagala)
    '    'TODO: This line of code loads data into the 'Dataset1.Pomagala' table. You can move, or remove it, as needed.
    '    Me.PdvTableAdapter.Fill(Me.DataSet1.app_pdv)

    '    _pocetak = False


    'End Sub


    'Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
    '    Dim i As Integer
    '    If Not _pocetak Then
    '        With DataGridView1
    '            Try
    '                .Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
    '                'Select Case e.ColumnIndex
    '                '    Case 1
    '                'DataGridView1.Rows(e.RowIndex).Cells(0).Value
    '                'Case 2
    '                kol = CSng(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
    '                'Case 3
    '                cena = CSng(DataGridView1.Rows(e.RowIndex).Cells(3).Value)
    '                'Case 4
    '                pdv = 1 + (CSng(DataGridView1.Rows(e.RowIndex).Cells(4).Value) / 100)
    '                'End Select
    '                .Rows(e.RowIndex).Cells(5).Value = kol * cena * pdv
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        End With
    '    End If

    '    scena = 0
    '    spdv = 0
    '    Try
    '        DataGridView1.Rows.GetFirstRow(0, 0)
    '        For i = 0 To DataGridView1.Rows.Count - 2
    '            scena = scena + CSng(DataGridView1.Rows(i).Cells(2).Value) * CSng(DataGridView1.Rows(i).Cells(3).Value)
    '            spdv = spdv + (CSng(DataGridView1.Rows(i).Cells(2).Value) * CSng(DataGridView1.Rows(i).Cells(3).Value) * (CSng(DataGridView1.Rows(i).Cells(4).Value) / 100))
    '            DataGridView1.Rows.GetNextRow(i, Windows.Forms.DataGridViewElementStates.Selected)
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Text7.Text = CStr(scena)
    '    Text9.Text = CStr(spdv)
    '    Text13.Text = CStr(scena + spdv)
    'End Sub

    '#Region "Grid 1"


    '    Dim store As System.Collections.Generic.Dictionary(Of Integer, Integer) = _
    '        New Dictionary(Of Integer, Integer)

    '    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
    '        Dim a As Single
    '        Dim b As Single
    '        Dim i As Integer

    '        If Not _pocetak Then

    '            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(1).Value) Then
    '                a = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    '            Else
    '                a = 0
    '            End If

    '            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
    '                b = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    '            Else
    '                b = 0
    '            End If

    '            DataGridView1.Rows(e.RowIndex).Cells(5).Value = CSng(a * b)
    '            'DataGridView1.UpdateCellValue(5, e.RowIndex)
    '        End If
    '        TextBox11.Text = 0
    '        TextBox13.Text = 0
    '        If Not _brisanje Then
    '            DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected, DataGridViewElementStates.Selected)
    '            For i = 0 To DataGridView1.Rows.Count - 2
    '                TextBox11.Text = CSng(TextBox11.Text) + DataGridView1.Rows(i).Cells(5).Value
    '                TextBox13.Text = CSng(TextBox11.Text) + CSng(TextBox12.Text)
    '                DataGridView1.Rows.GetNextRow(i, DataGridViewElementStates.Selected)
    '            Next
    '        End If
    '    End Sub

    '    Const initialValue As Integer = -1
    '    'Private Sub dataGridView1_CellValueNeeded(ByVal sender As Object, _
    '    '    ByVal e As DataGridViewCellValueEventArgs) _
    '    '    Handles DataGridView1.CellValueNeeded

    '    '    If store.ContainsKey(e.RowIndex) Then
    '    '        e.Value = store(e.RowIndex)
    '    '    ElseIf newRowNeeded AndAlso e.RowIndex = numberOfRows Then
    '    '        If DataGridView1.IsCurrentCellInEditMode Then
    '    '            e.Value = initialValue
    '    '        Else
    '    '            e.Value = String.Empty
    '    '        End If
    '    '    Else
    '    '        e.Value = e.RowIndex
    '    '    End If
    '    'End Sub

    '    Private Sub dataGridView1_CellValueNeeded(ByVal sender As Object, _
    '    ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) _
    '    Handles DataGridView1.CellValueNeeded

    '        ' If this is the row for new records, no values are needed.
    '        If e.RowIndex = Me.DataGridView1.RowCount - 1 Then
    '            Return
    '        End If

    '        Dim a As Single
    '        Dim b As Single

    '        If e.ColumnIndex = 1 Then a = e.Value ' rowInEdit Then
    '        If e.ColumnIndex = 4 Then b = e.Value

    '        Select Case Me.DataGridView1.Columns(e.ColumnIndex).Name
    '            Case "iznos"
    '                e.Value = a * b ' customerTmp.CompanyName
    '        End Select

    '    End Sub

    '    Private Sub dataGridView1_CellValuePushed(ByVal sender As Object, _
    '        ByVal e As DataGridViewCellValueEventArgs) _
    '        Handles DataGridView1.CellValuePushed

    '        store.Add(e.RowIndex, CInt(e.Value))

    '    End Sub

    '    Dim newRowNeeded As Boolean

    '    Private Sub dataGridView1_NewRowNeeded(ByVal sender As Object, _
    '            ByVal e As DataGridViewRowEventArgs) _
    '            Handles DataGridView1.NewRowNeeded
    '        newRowNeeded = True
    '    End Sub
    '#End Region


    'Private Sub _dokument()
    '    Dim path As String = cAppObject.AppPath & "Resenje.doc"
    '    'Dim di As DirectoryInfo = New DirectoryInfo(path)
    '    'Dim dir As Directory
    '    Dim fi As FileInfo = New FileInfo(path)
    '    'Dim sw As StreamWriter = fi.Create()
    '    If Not fi.Exists Then
    '        If MsgBox("Тражени документ не постоји!" & vbLf & "Да ли желите да креирате документ?", MsgBoxStyle.OkCancel, My.Application.Info.Title) = MsgBoxResult.Ok Then
    '            fi.Create()
    '        Else
    '            cmdResenja.Enabled = True
    '            Exit Sub
    '        End If
    '        'Else
    '        'MsgBox("Документ са тим називом већ постоји!" _
    '        '    & vbLf & "Биће пребачен у фолдер: " _
    '        '    & cAppObject.AppPath & "RESENJE_" & Date.Today, MsgBoxStyle.Information, My.Application.Info.Title)

    '        'Dim di As DirectoryInfo = New DirectoryInfo(cAppObject.AppPath & "RESENJE_" & Date.Today)
    '        'If Not di.Exists Then
    '        '    Directory.CreateDirectory(cAppObject.AppPath & "RESENJE_" & Date.Today)
    '        'End If
    '        'Try
    '        '    fi.MoveTo(cAppObject.AppPath & "RESENJE_" & Date.Today & "\Resenje_" _
    '        '        & TimeOfDay.Hour & "h" _
    '        '        & TimeOfDay.Minute & "m" & ".doc")
    '        '    fi = New FileInfo(path)
    '        '    fi.Create()
    '        'Catch ex As Exception
    '        '    MsgBox(ex.Message) 'Console.WriteLine(ex.Message)
    '        '    cmdResenja.Enabled = True
    '        '    Exit Sub
    '        'End Try
    '        'di = Nothing
    '    End If
    '    'Try
    '    '    AddFileSecurity(path, My.Computer.Name.ToString, FileSystemRights.FullControl, AccessControlType.Allow)
    '    '    'RemoveFileSecurity(path, "MYDOMAIN\MyAccount", FileSystemRights.FullControl, AccessControlType.Allow)
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try

    '    'fi = New FileInfo(cAppObject.AppPath & "Pera.txt")
    '    'fi.Attributes = FileAttributes.Normal
    '    'fi.IsReadOnly = False
    '    fi = Nothing
    'End Sub
    'Sub AddFileSecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType)
    '    Dim fInfo As New FileInfo(FileName)
    '    Dim fSecurity As FileSecurity = fInfo.GetAccessControl()

    '    fSecurity.AddAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))
    '    fInfo.SetAccessControl(fSecurity)
    'End Sub
    'Sub RemoveFileSecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType)
    '    Dim fInfo As New FileInfo(FileName)
    '    Dim fSecurity As FileSecurity = fInfo.GetAccessControl()

    '    fSecurity.RemoveAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))
    '    fInfo.SetAccessControl(fSecurity)
    'End Sub

    '    'Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    '    Dim CM As New SqlCommand

    '    '    selektuj_potvrdu(Radni_nalog_headDataGridView.CurrentRow.Cells(0).Value)

    '    '    CN.Open()
    '    '    If CN.State = ConnectionState.Open Then
    '    '        CM = New SqlCommand()
    '    '        With CM
    '    '            .Connection = CN
    '    '            .CommandType = CommandType.StoredProcedure
    '    '            .CommandText = "radni_nalog_potvrda_stavka_delete_nalog"
    '    '            .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
    '    '            .ExecuteScalar()
    '    '        End With
    '    '        CM.Dispose()
    '    '    End If

    '    '    If CN.State = ConnectionState.Open Then
    '    '        CM = New SqlCommand()
    '    '        With CM
    '    '            .Connection = CN
    '    '            .CommandType = CommandType.StoredProcedure
    '    '            .CommandText = "radni_nalog_izvrsioci_delete"
    '    '            .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
    '    '            .ExecuteScalar()
    '    '        End With
    '    '        CM.Dispose()
    '    '    End If

    '    '    If CN.State = ConnectionState.Open Then
    '    '        CM = New SqlCommand()
    '    '        With CM
    '    '            .Connection = CN
    '    '            .CommandType = CommandType.StoredProcedure
    '    '            .CommandText = "radni_nalog_delete"
    '    '            .Parameters.AddWithValue("@id_radninalog", Radni_nalog_headDataGridView.CurrentRow.Cells(0).Value)
    '    '            .ExecuteScalar()
    '    '        End With
    '    '        CM.Dispose()
    '    '    End If

    '    '    Try
    '    '        Me.Validate()
    '    '        Me.Radni_nalog_headBindingSource.EndEdit()
    '    '        Me.Radni_nalog_headTableAdapter.Delete(Radni_nalog_headDataGridView.CurrentRow.Cells(0).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(1).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(2).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(3).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(4).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(5).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(6).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(7).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(8).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(9).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(10).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(11).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(12).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(13).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(14).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(15).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(16).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(17).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(18).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(19).Value, _
    '    '                                               Radni_nalog_headDataGridView.CurrentRow.Cells(20).Value)
    '    '        Me.Radni_nalog_headTableAdapter.Update(Me.DataSet1.radni_nalog_head)
    '    '    Catch ex As Exception
    '    '        MsgBox(ex.Message)
    '    '    End Try
    '    'End Sub


    '----------------------
    ' LIST VIEW
    '----------------------
    'Public Sub proveri_stanje_glavni()
    '    Dim listView1 As New ListView()
    '    listView1.View = View.Details
    '    listView1.LabelEdit = True
    '    listView1.AllowColumnReorder = True
    '    listView1.FullRowSelect = True
    '    listView1.GridLines = True
    '    listView1.Dock = DockStyle.Fill
    '    listView1.BringToFront()
    '    listView1.ForeColor = Color.MidnightBlue

    '    listView1.Columns.Add("Šifra", 60, HorizontalAlignment.Left)
    '    listView1.Columns.Add("Šifra - opis", 60, HorizontalAlignment.Left)
    '    listView1.Columns.Add("Naziv", 195, HorizontalAlignment.Left)
    '    listView1.Columns.Add("kolicina", 70, HorizontalAlignment.Right)
    '    listView1.Columns.Add("min.kolicina", 70, HorizontalAlignment.Right)
    '    listView1.Columns.Add("kategorija", 100, HorizontalAlignment.Left)

    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim DR As SqlDataReader
    '    Try
    '        CN.Open()
    '        CM = New SqlCommand()
    '        If CN.State = ConnectionState.Open Then
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.Text
    '                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli"
    '                DR = .ExecuteReader
    '            End With
    '            Do While DR.Read
    '                Dim roba As New ListViewItem(DR.Item("sifra").ToString, 0)
    '                roba.SubItems.Add(DR.Item("sifra_opis").ToString)
    '                roba.SubItems.Add(DR.Item("naziv").ToString)
    '                If CSng(DR.Item("kolicina")) <= CSng(DR.Item("min_kolicina")) Then
    '                    roba.ForeColor = Color.Red
    '                Else
    '                    roba.ForeColor = Color.MidnightBlue
    '                End If
    '                roba.SubItems.Add(DR.Item("kolicina"))
    '                roba.SubItems.Add(DR.Item("min_kolicina"))
    '                roba.SubItems.Add(DR.Item("kategorija"))

    '                listView1.Items.AddRange(New ListViewItem() {roba})
    '            Loop
    '        End If
    '        _lista = listView1
    '        Dim mForm As New frmLista
    '        mForm.Panel1.Controls.Add(listView1)
    '        mForm.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        DR = Nothing
    '        CM.Dispose()
    '        CN.Close()
    '    End Try
    'End Sub

#Region "xml i mail"

    ' Dim mxDoc As XmlDocument
    ' Dim xmlPath As String

    '   xmlPath = cAppObject.AppPath & "Configure.xml"

    '   mxDoc = New XmlDocument()
    '   mxDoc.Load(xmlPath)

    ' Dim msw As New StringWriter
    '   Call ReadXMLFile(mxDoc, 0)

    '   CNNString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & msp.База & ";Data Source=" & msp.Сервер
    ' 'CNNString = "Data Source=" & msp.Сервер & ";Initial Catalog=" & msp.База & ";Persist Security Info=False;User ID=sa;Password=xxxx"

    'End Sub

    ' Public Sub ReadXMLFile(ByVal xNode As XmlNode, ByVal intLevel As Integer)

    '     Dim xNodeLoop As XmlNode
    '     If xNode.HasChildNodes Then
    '         For Each xNodeLoop In xNode.ChildNodes
    '             ReadXMLFile(xNodeLoop, intLevel + 1)
    '         Next xNodeLoop
    '         Select Case xNode.Name

    'Private Sub napravi_xml()
    '    Dim i As Integer, j As Integer
    '    Dim xmlw As XmlTextWriter = Nothing
    '    'Dim wr As XmlTextReader
    '    On Error Resume Next

    '    Dim rs_Fa As New ADODB.Recordset
    '    Dim fa_xml As ADODB.Recordset

    '    fa_xml = New ADODB.Recordset
    '    fa_xml.Open("Select * from FaXML", MyConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
    '    With fa_xml
    '        If .RecordCount > 0 Then
    '            If Not .BOF Or .EOF Then
    '                .MoveFirst()
    '                For i = 0 To .RecordCount - 1
    '                    .Delete(ADODB.AffectEnum.adAffectCurrent)
    '                    .Update()
    '                    .MoveNext()
    '                Next
    '            End If
    '        End If
    '        .Requery(512)
    '    End With

    '    putanja = ""
    '    RS_Filijale.Filter = ""
    '    'RS_Fakture.Bookmark = AxSSOleDBGrid1.Bookmark
    '    rs_Fa = New ADODB.Recordset
    '    rs_Fa.Open("Select * From Faktura where IDFaktura = " & AxSSOleDBGrid1.Columns(1).Value, MyConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
    '    putanja = Mid(My.Computer.FileSystem.CurrentDirectory.ToString, 1, Len(My.Computer.FileSystem.CurrentDirectory.ToString) - 4) & "\fakture\" & rs_Fa.Fields("IDFaktura").Value & ".xml" '"C:\Orto-M\Fakture\" & RS_Fakture.Fields("IDFaktura").Value & ".xml"
    '    xmlw = New XmlTextWriter(putanja, Nothing)

    '    With rs_Fa
    '        '.MoveFirst()
    '        fa_xml.AddNew()
    '        For i = 1 To .Fields.Count - 4
    '            If i = 6 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Then
    '                fa_xml.Fields(i).Value = CDec(.Fields(i).Value)
    '            Else
    '                fa_xml.Fields(i).Value = .Fields(i).Value
    '            End If
    '        Next
    '        fa_xml.Update()
    '    End With

    '    With xmlw
    '        .Formatting = Formatting.Indented
    '        .WriteStartDocument()
    '        'Dim PItext As String = "type='text/xsl', 'http://www.w3.org/TR/1998/REC-xml-19980210#NT'" ' href='book.xsl'"
    '        '.WriteProcessingInstruction("xml-stylesheet", PItext)

    '        .WriteComment("edited with XML Spy v4.4 U (http://www.xmlspy.com)")
    '        .WriteStartElement("FakturaZaNaloge") ', "xsi", "http://www.w3.org/2001/XMLSchema-instance")
    '        .WriteStartElement("Info")
    '        For i = 0 To RS_Info.Fields.Count - 1
    '            If Not IsDBNull(RS_Info.Fields(i).Value) Then
    '                .WriteElementString(RS_Info.Fields(i).Name, RS_Info.Fields(i).Value)
    '            Else
    '                .WriteElementString(RS_Info.Fields(i).Name, "")
    '            End If
    '        Next i
    '        .WriteEndElement() 'end info
    '        .WriteStartElement("Faktura")

    '        For i = 1 To fa_xml.Fields.Count - 1 ' RS_Fakture.Fields.Count - 4
    '            If i <> 2 Then
    '                If i = 1 Then
    '                    .WriteElementString("ID_Faktura", fa_xml.Fields(i).Value) ' RS_Fakture.Fields(i).Value)
    '                Else
    '                    If i = 4 Then
    '                        .WriteElementString("SifraProdajnogMesta", fa_xml.Fields(i).Value) ' RS_Fakture.Fields(i).Value)
    '                    Else
    '                        'If i = 8 Or i = 9 Or i = 10 Or i = 11 Or i = 12 Then
    '                        '    .WriteElementString(RS_Fakture.Fields(i).Name, DveDecimale(RS_Fakture.Fields(i).Value))
    '                        'Else
    '                        .WriteElementString(RS_Fakture.Fields(i).Name, fa_xml.Fields(i).Value) ' RS_Fakture.Fields(i).Value)
    '                        'End If
    '                    End If
    '                End If
    '            End If
    '        Next i

    '        RS_FaktureNalozi.Filter = ""
    '        RS_FaktureNalozi.Filter = "idfaktura = " & rs_Fa.Fields("IDFaktura").Value 'RS_Fakture.Fields("IDFaktura").Value
    '        If RS_FaktureNalozi.RecordCount > 0 Then
    '            RS_FaktureNalozi.MoveFirst()
    '            For i = 0 To RS_FaktureNalozi.RecordCount - 1

    '                'NALOG
    '                .WriteStartElement("Nalog")
    '                RS_Nalog.Filter = ""
    '                RS_Nalog.Filter = "SifraNaloga Like '" & RS_FaktureNalozi.Fields("sifranaloga").Value & "'"
    '                If RS_Nalog.RecordCount > 0 Then
    '                    RS_Nalog.MoveFirst()

    '                    Select Case RS_Nalog.Fields("TipObrasca").Value
    '                        Case "Broj 1"
    '                            .WriteElementString("TipObrasca", CInt("1"))
    '                        Case "Broj 2"
    '                            .WriteElementString("TipObrasca", CInt("2"))
    '                        Case "Broj 3"
    '                            .WriteElementString("TipObrasca", CInt("3"))
    '                    End Select

    ''.WriteElementString("TipObrasca", RS_Nalog.Fields("TipObrasca").Value)
    '                    If RS_Nalog.Fields("TipObrasca").Value = "Broj 3" Then
    '                        If Not RS_Nalog.Fields("VrstaOdrzavanja").Value = 0 Then
    '                            If Not IsDBNull(RS_Nalog.Fields("VrstaOdrzavanja").Value) Then
    '                                .WriteElementString("VrstaOdrzavanja", RS_Nalog.Fields("VrstaOdrzavanja").Value)
    '                            End If
    '                        End If
    '                    End If
    '                    .WriteElementString("SifraNaloga", RS_Nalog.Fields("SifraNaloga").Value)
    '                    .WriteElementString("RedniBroj", i + 1)

    ''OSIGURANIK
    '                    RS_Osiguranici.Filter = "JMBG Like '" & RS_Nalog.Fields("OsiguranikJMBG").Value & "'"
    '                    If RS_Osiguranici.RecordCount > 0 Then
    '                        .WriteStartElement("Osiguranik")
    ''If Not IsDBNull(RS_Osiguranici.Fields(j).Value) Then
    '                        .WriteElementString("PrezimeOsLica", RS_Osiguranici.Fields("Prezime").Value)
    '                        .WriteElementString("ImeOsLica", RS_Osiguranici.Fields("Ime").Value)
    '                        .WriteElementString("AdresaOsLica", RS_Osiguranici.Fields("Adresa").Value)
    '                        .WriteElementString("DatumRodjenjaOsLica", RS_Osiguranici.Fields("DatumRodjenja").Value)
    '                        .WriteElementString("JMBG", RS_Osiguranici.Fields("JMBG").Value)
    '                        .WriteElementString("BrojZdravstveneKnjizice", RS_Osiguranici.Fields("BrZk").Value)
    '                        .WriteElementString("RegistarskiBroj", RS_Osiguranici.Fields("RegBr").Value)
    '                        .WriteElementString("ID_Filijala", RS_Osiguranici.Fields("IdFilijala").Value)
    '                        .WriteElementString("ID_NO", RS_Osiguranici.Fields("IDNO").Value)
    '                        .WriteElementString("JMBGNoOs", RS_Osiguranici.Fields("JMBGNo").Value)
    '                        .WriteElementString("ID_OO", RS_Osiguranici.Fields("IDOO").Value)
    '                        .WriteElementString("ID_OOP", RS_Osiguranici.Fields("IDOOP").Value)
    ''End If
    '                        .WriteEndElement() ' end Osiguranik

    '                        .WriteElementString("BrojKartona", RS_Nalog.Fields("BrojKartona").Value)
    '                        .WriteElementString("SifraZU", RS_Nalog.Fields("SifraZU").Value)

    '' start Propisano pomagalo
    '                        .WriteStartElement("PropisanoPomagalo")
    '                        .WriteElementString("ID_Pomagala", RS_Nalog.Fields("Pomagalo").Value)

    '' DEO POMALAGLA
    '                        RS_NalogPomagalo.Filter = ""
    '                        RS_NalogPomagalo.Filter = "SifraNaloga = " & RS_Nalog.Fields("SifraNaloga").Value
    '                        For j = 4 To RS_NalogPomagalo.Fields.Count - 2 Step 2
    '                            If RS_NalogPomagalo.Fields(j).Value.ToString <> "" And RS_NalogPomagalo.Fields(j + 1).Value <> 0 Then 'Not IsDBNull(RS_NalogPomagalo.Fields(j).Value) Then
    '                                .WriteStartElement("DeoPomagala")
    '                                .WriteElementString("ID_DeoPomagala", RS_NalogPomagalo.Fields(j).Value)
    '                                If Not RS_NalogPomagalo.Fields("SifraOdrzavanja").Value = "" Then
    '                                    .WriteElementString("SifraOdrzavanja", RS_NalogPomagalo.Fields("SifraOdrzavanja").Value)
    '                                End If
    '                                .WriteElementString("Kolicina", RS_NalogPomagalo.Fields(j + 1).Value)
    '                                If j = 4 Then
    '                                    .WriteElementString("Cena", RS_Nalog.Fields("Cena").Value)
    '                                Else
    '                                    .WriteElementString("Cena", 0)
    '                                End If
    '                                .WriteElementString("ProcMarze", fa_xml.Fields("IznosMarze").Value) 'RS_Fakture.Fields("IznosMarze").Value)
    '                                .WriteElementString("ProcPoreza", RS_Nalog.Fields("pdv").Value)
    '                                If j = 4 Then
    '                                    .WriteElementString("ProcUcesca", RS_Nalog.Fields("Part").Value)
    '                                Else
    '                                    .WriteElementString("ProcUcesca", 0)
    '                                End If
    '                                .WriteElementString("IznosParticipacije", 0)
    '                                .WriteEndElement() ' end DeoPomagala
    '                            Else
    '                                Exit For
    '                            End If
    '                        Next j
    '                        .WriteEndElement() ' end Propisano Pomagalo

    '                        .WriteElementString("Kolicina", RS_Nalog.Fields("Kol").Value)
    '                        .WriteElementString("ID_Dijagnoza", RS_Nalog.Fields("Dijagnoza").Value)
    '                        .WriteElementString("DatumPropisivanjaPomagala", RS_Nalog.Fields("DatumPropisivanja").Value)
    ''************** PROMENA U DECIMALU
    '                        .WriteElementString("Cena", CDec(RS_Nalog.Fields("Cena").Value))
    '                        .WriteElementString("ProcMarze", "0")
    '                        .WriteElementString("ProcPoreza", RS_Nalog.Fields("pdv").Value)
    '                        .WriteElementString("ProcUcesca", RS_Nalog.Fields("Part").Value)
    '                        .WriteElementString("IznosParticipacije", fa_xml.Fields("IznosParticipacije").Value) ' RS_Fakture.Fields("IznosParticipacije").Value)
    '                        .WriteElementString("SifraLekara", RS_Nalog.Fields("SifraLekara").Value)

    ''start Misljenj lekara
    '                        RS_MisljenjeLekara.Filter = ""
    '                        RS_MisljenjeLekara.Filter = "SifraNaloga = " & RS_Nalog.Fields("SifraNaloga").Value
    '                        If RS_MisljenjeLekara.RecordCount > 0 Then
    '                            .WriteStartElement("MisljenjeLekara")
    '                            .WriteElementString("SifraZU", RS_MisljenjeLekara.Fields("SifraZU").Value)
    '                            .WriteElementString("SifraLekara", RS_MisljenjeLekara.Fields("SifraLekara").Value)
    '                            .WriteElementString("Broj", RS_MisljenjeLekara.Fields("Broj").Value)
    '                            .WriteEndElement() 'end Misljenj lekara
    '                        End If

    ''start Otpusna Lista
    '                        RS_OtpusnaLista.Filter = ""
    '                        RS_OtpusnaLista.Filter = "SifraNaloga = " & RS_Nalog.Fields("SifraNaloga").Value
    '                        If RS_OtpusnaLista.RecordCount > 0 Then
    '                            .WriteStartElement("OtpusnaLista")
    '                            .WriteElementString("SifraZU", RS_OtpusnaLista.Fields("SifraZU").Value)
    '                            .WriteElementString("Broj", RS_OtpusnaLista.Fields("Broj").Value)
    '                            .WriteElementString("Datum", RS_OtpusnaLista.Fields("Datum").Value)
    '                            .WriteElementString("DatumOd", RS_OtpusnaLista.Fields("DatumOd").Value)
    '                            .WriteElementString("DatumDo", RS_OtpusnaLista.Fields("DatumDo").Value)
    '                            .WriteEndElement() 'end Otpusna Lista
    '                        End If

    ''start Lekarska Konisija
    '                        RS_LekarskaKomisija.Filter = ""
    '                        RS_LekarskaKomisija.Filter = "SifraNaloga = " & RS_Nalog.Fields("SifraNaloga").Value
    '                        If RS_LekarskaKomisija.RecordCount > 0 Then
    '                            .WriteStartElement("LekarskaKomisija")
    '                            .WriteElementString("Broj", RS_LekarskaKomisija.Fields("Broj").Value)
    '                            .WriteElementString("Datum", RS_LekarskaKomisija.Fields("Datum").Value)
    '                            .WriteElementString("SifraLekara1", RS_LekarskaKomisija.Fields("SifraLekara1").Value)
    '                            .WriteElementString("SifraLekara2", RS_LekarskaKomisija.Fields("SifraLekara2").Value)
    '                            .WriteElementString("SifraLekara3", RS_LekarskaKomisija.Fields("SifraLekara3").Value)
    '                            .WriteEndElement() 'end Lekarska Konisija
    '                        End If
    '                        If RS_Nalog.Fields("TipObrasca").Value = "Broj 3" Then
    '                            .WriteElementString("DatumPrvogIzdavanjaPomagala", RS_Nalog.Fields("DatumPrvogIzdavanja").Value)
    '                            .WriteElementString("DatumOvereUMaticnojFilijali", RS_Nalog.Fields("DatumOvere").Value)
    '                            .WriteElementString("DatumPrijemaNaloga", RS_Nalog.Fields("DatumPrijema").Value)
    '                        End If
    '                        .WriteElementString("DatumIzdavanjaPomagala", RS_Nalog.Fields("DatumIzdavanja").Value)

    ''start Revers
    '                        If RS_Nalog.Fields("SifraReversa").Value <> "0" Then
    '                            .WriteStartElement("Revers")
    '                            .WriteElementString("SifraReversa", RS_Nalog.Fields("SifraReversa").Value)
    '                            .WriteElementString("BrojReversa", RS_Nalog.Fields("BrojReversa").Value)
    '                            .WriteElementString("DatumReversa", RS_Nalog.Fields("DatumReversa").Value)
    '                            .WriteEndElement() 'end Revers
    '                        End If

    ''.WriteElementString("RazloziNeispravnosti", "") ' RS_Nalog.Fields("RazloziNeispravnosti").Value)
    '                        .WriteEndElement() 'end nalog
    '                        RS_FaktureNalozi.MoveNext()
    '                    End If
    '                End If
    '            Next i
    '        Else
    '            MsgBox("Nalozi za ovu fakturu nisu promadjeni!", MsgBoxStyle.AbortRetryIgnore, "Upozorenje")
    '        End If

    '        .WriteEndElement() 'end faktura
    '        .WriteEndDocument() 'end FakturaZaNaloge
    '        .Flush()
    '        .Close()
    '    End With

    'End Sub

    'Private Sub posalji_mail()
    '    Dim _filter As String

    '    On Error Resume Next
    '    If salji_odmah Then
    '        RS_Filijale.Filter = ""
    '        Dim pomoc As String
    '        Dim _filter_prosao As Boolean
    '        If Not IsDBNull(AxSSOleDBGrid1.Columns(2).Value) Then
    '            pomoc = AxSSOleDBGrid1.Columns(2).Value & "'"
    '            If Not pomoc = "'" Then
    '                RS_Filijale.Filter = "Filijala Like '" & AxSSOleDBGrid1.Columns(2).Value & "'"
    '                _filter_prosao = True
    '            Else
    '                _filter_prosao = False
    '            End If
    '        End If

    '        Dim MyMail As MailMessage = New MailMessage
    '        'Dim iLoop1 As Integer

    '        'Dim sAttach As String = putanja
    '        'Dim delim As Char = ","
    '        'Dim sSubstr As String
    '        'For Each sSubstr In sAttach.Split(delim)
    '        '    Dim myAttachment As MailAttachment = New MailAttachment(sSubstr)
    '        '    MyMail.Attachments.Add(myAttachment)
    '        'Next

    '        If unesi_adresu And _filter_prosao Then
    '            If Not IsDBNull(RS_Filijale.Fields("mail").Value) Then
    '                MyMail.To = RS_Filijale.Fields("mail").Value
    '            Else
    '                'MyMail.To.Insert(1, CStr(" "))
    '                MyMail.To.Insert(1, "ana@ana.com")
    '            End If
    '        End If
    '        MyMail.From = ortom@bankerinter.net
    '        If unesi_poruku Then
    '            MyMail.Subject = "Fakture za mesec " & (Month(Today)) & " - ORTO-M Nis"
    '            MyMail.Body = "S' Postovanjem" & vbCrLf & "ORTO-M Nis"
    '        Else
    '            MyMail.Subject = InputBox("Unesite zaglavlje poruke", "Poruka")
    '            MyMail.Body = InputBox("Unesite tekst poruke", "Poruka")
    '        End If
    '        Dim myNeki As Mail.SmtpClient

    '        Dim myAttachment As Attachment = New Attachment(putanja)
    '        MyMail.Attachments.Add(myAttachment)
    '        myNeki.Send(MyMail)

    '        MsgBox("Poruka je poslata na adresu " & MyMail.To.ToString)

    '    End If

    'End Sub

#End Region

End Module