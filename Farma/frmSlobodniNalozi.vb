Public Class frmSlobodniNalozi

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With _lista
            If .CheckedItems.Count > 1 Then
                MsgBox("Mozete izabrati samo jedan broj")
                Exit Sub
            ElseIf .CheckedItems.Count = 0 Then
                MsgBox("Prvo izabrati jedan broj")
                Exit Sub
            Else
                Select Case _mTabela
                    Case Imena.tabele.rm_radni_nalog_head.ToString
                        _id_radni_nalog_broj = RTrim(_lista.CheckedItems.Item(0).Text)
                        Dim mForm As New frmPotvrdaUnos
                        mForm.Show()
                    Case Imena.tabele.fn_putni_nalog.ToString
                        _id_pnalog = RTrim(_lista.CheckedItems.Item(0).Text)
                        Dim mForm As New frmPutniRacunUnos
                        mForm.Show()
                End Select

            End If
        End With
        Me.Close()
    End Sub
End Class