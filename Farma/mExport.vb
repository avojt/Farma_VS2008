Option Explicit On

Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports Microsoft.Office.Interop.Word


Module mExport
    Public Sub Export_Word(ByVal sql As String, Optional ByVal sWordFile As String = "", Optional ByVal LastPageCount As Boolean = False)
        On Error GoTo 0
        Dim file_name As String
        Dim file_path As String
        Dim file_title As String
        Dim CN As New SqlConnection
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.ConnectionString = CNNString
        CN.Open()

        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "select * from prn_promet" ' sql"
            DR = .ExecuteReader()
        End With

        Dim oWord As Microsoft.Office.Interop.Word.Application
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'oWord.DoEvents() ???

        If sWordFile = "" Then sWordFile = My.Application.Info.DirectoryPath & "Resenje.doc"
        file_name = sWordFile
        file_title = file_name.Substring(file_name.LastIndexOf("\") + 1)
        file_path = file_name.Substring(0, file_name.LastIndexOf("\"))

        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oRow As Microsoft.Office.Interop.Word.Row
        'Dim oCell As Word.Cell

        oWord = New Microsoft.Office.Interop.Word.Application 'STARTUJE WORD
        oWord.ChangeFileOpenDirectory(file_path)
        'Try
        oWord.Documents.Open( _
            FileName:=file_title.ToString, _
            ConfirmConversions:=False, _
            ReadOnly:=False, _
            AddToRecentFiles:=False, _
            PasswordDocument:="", _
            PasswordTemplate:="", _
            Revert:=False, _
            WritePasswordDocument:="", _
            WritePasswordTemplate:="", _
            Format:=Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatAuto)
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'oWord.Visible = True
        ''Cursor.Current = System.Windows.Forms.Cursors.Default
        'If oWord.Documents.Count > 0 Then oWord.Documents.Close()
        'oWord.Application.Quit() 'ZATVORIO JE WORD
        ''oWord = Nothing
        'Exit Sub
        'End Try

        If oWord.ActiveDocument.Bookmarks.Count > 0 Then oWord.ActiveDocument.Tables.Item(1).Delete()

        oWord.ActiveDocument.Tables.Add(oWord.ActiveDocument.Range, 1, 5)
        oWord.ActiveDocument.Bookmarks.Add("Tabela", oWord.ActiveDocument.Range)

        oWord.Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:="Tabela")
        oWord.ActiveDocument.Bookmarks.Item("Tabela").Select()

        oTable = oWord.ActiveDocument.Tables.Item(1)

        Dim i As Integer = 1
        Dim sSum As Long

        oTable.Rows.Add()
        oTable.Cell(i, 1).Range.InsertAfter("БМ")
        oTable.Cell(i, 3).Range.InsertAfter("Бр.бирача на БМ")
        oTable.Cell(i, 4).Range.InsertAfter("Бр.страна по БМ")
        i = i + 1

        While DR.Read
            oRow = oTable.Rows.Item(i)
            oTable.Rows.Add()
            oTable.Cell(i, 1).Range.InsertAfter(DR("BM"))
            oTable.Cell(i, 3).Range.InsertAfter(DR("Biraca"))
            'oTable.Cell(i, 4).Range.InsertAfter(Math.Ceiling(DR("Biraca") / BiracaPerPage) + IIf(LastPageCount, 1, 0))
            sSum = sSum + DR("Biraca")
            i = i + 1
        End While
        oRow = oTable.Rows.Item(i)
        oTable.Rows.Add() '(oRow.Index)

        oTable.Cell(i, 2).Range.InsertAfter("Укупно лица:")
        oTable.Cell(i, 2).Range.Bold = True
        oTable.Cell(i, 3).Range.InsertAfter(sSum)
        oTable.Cell(i, 3).Range.Bold = True

        'oWord.ActiveDocument.SaveEncoding = 1251
        oWord.Application.ActiveDocument.LanguageDetected = True
        'oWord.ActiveDocument.SaveFormsData = True
        'oWord.ActiveDocument.Type = Word.WdDocumentType.wdTypeDocument
        oWord.ToggleKeyboard()
        oWord.ActiveDocument.Save()
        oWord.Visible = True
        Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub

0:      MessageBox.Show("Грешка настала приликом извршења програма" & Environment.NewLine, "Бирачки спискови", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub

    End Sub

    Sub Add( _
                ByVal Range As Microsoft.Office.Interop.Word.Range, _
                ByVal NumRows As Integer, _
                ByVal NumColumns As Integer, _
                Optional ByRef DefaultTableBehavior As Object = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent, _
                Optional ByRef AutoFitBehavior As Object = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent) 'As Word.Tables
        'Return Add
    End Sub

End Module
