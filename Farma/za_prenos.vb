Module za_prenos

    '#Region "maricni podaci"
    '    Private Sub btnMaticniPodaci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaticniPodaci.Click
    '        'postavi_panel(Imena.tabele.app_maticni_podaci.ToString)
    '        mdiMain.zatvori_kontrolu_desno()
    '        mdiMain.zatvori_kontrolu_levo()

    '        Dim myControl As New cntMeniMaticniPodaci
    '        myControl.Parent = mdiMain.splGlavni.Panel1
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()
    '        'myControl.Focus()

    '        podesi_boje()
    '        btnMaticniPodaci.BackColor = Color.LightSteelBlue

    '        _labHead = "ROBNO -> MATIČNI PODACI"
    '    End Sub

    '    Private Sub linkPrimRacuniUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Dim mForm As New frmUlazniRacuniUnos
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkPrimRacuniEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntUlazniRacuni.myUpdate()
    '    End Sub

    '    Private Sub linkPrispeliUlazniRacuni_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        prispeli_racuni(Imena.tabele.rm_ulazni_racuni.ToString)
    '    End Sub
    '    Private Sub linkPrimRacuniBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntUlazniRacuni.myDelete()
    '    End Sub
    '#End Region

    '#Region "racuni"
    '    Private Sub btnRacuni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIODoc.Click
    '        postavi_panel(Imena.tabele.rm_racun.ToString)
    '        mdiMain.zatvori_kontrolu_desno()

    '        Dim myControl As New cntRacuni
    '        myControl.Parent = mdiMain.splRadni.Panel2
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()
    '        myControl.BringToFront()

    '        podesi_boje()
    '        btnIODoc.BackColor = Color.LightSteelBlue

    '    End Sub
    '    Private Sub linkRacuniUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Select Case _tab
    '            Case Imena.tabele.rm_racun.ToString
    '                Dim mForm As New frmRacunUnos
    '                mForm.Show()
    '            Case Imena.tabele.rm_predracun.ToString()
    '                Dim mForm As New frmPredracuniUnos
    '                mForm.Show()
    '            Case Imena.tabele.rm_povratnica.ToString
    '                Dim mForm As New frmPovratnicaUnos
    '                mForm.Show()
    '        End Select
    '    End Sub
    '    Private Sub linkRacuniEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntRacuni.myUpdate()
    '    End Sub
    '    Private Sub linkRacuniPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Select Case _tab
    '            Case Imena.tabele.rm_racun.ToString
    '                _raport = Imena.tabele.rm_racun.ToString
    '                'Select Case chkCene.Checked
    '                '    Case True
    '                '        _sa_cenom = True
    '                '    Case False
    '                '        _sa_cenom = False
    '                'End Select
    '                cntRacuni.racun_prn()

    '            Case Imena.tabele.rm_predracun.ToString
    '                _raport = Imena.tabele.rm_predracun.ToString
    '                'Select Case chkCene.Checked
    '                '    Case True
    '                '        _sa_cenom = True
    '                '    Case False
    '                '        _sa_cenom = False
    '                'End Select
    '            Case Imena.tabele.rm_povratnica.ToString
    '                _raport = Imena.tabele.rm_povratnica.ToString

    '                cntRacuni.povratnica_prn()
    '        End Select

    '        Dim mForm As New frmPrint
    '        mForm.Show()
    '    End Sub
    '    Private Sub linkPrispeliRacuni_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        prispeli_racuni(Imena.tabele.rm_racun_head.ToString)
    '    End Sub
    '    Private Sub linkRacuniBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntRacuni.myDelete()
    '    End Sub
    '    Private Sub linkPunudaURn_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Select Case _tab
    '            Case Imena.tabele.rm_predracun.ToString
    '                selektuj_predracun(_id)

    '                selektuj_stavke(_id_predracun, "select * from dbo.predracun_stavka " & _
    '                            " where dbo.predracun_stavka.id_predracun_head = " & _id_predracun)
    '                _iz_ponude = True

    '                Dim mForm As New frmRacunUnos
    '                mForm.Show()
    '        End Select
    '    End Sub
    '#End Region

    '#Region "izvestaji"
    '    Private Sub btnIzvestaji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzvestaji.Click
    '        'postavi_panel(Imena.tabele.ostali_dokumenti.ToString)
    '        mdiMain.zatvori_kontrolu_desno()
    '        'mdiMain.zatvori_kontrolu_levo()

    '        Dim myControl As New cntOstaliDok
    '        myControl.Parent = mdiMain.splRadni.Panel2
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()

    '        postavi_panel(Imena.tabele.ostali_dokumenti.ToString)

    '        podesi_boje()
    '        btnIODoc.BackColor = Color.LightSteelBlue
    '    End Sub

    '#End Region

    '#Region "Kalkulacije"
    '    Private Sub linkKalkulacijeUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Dim mForm As New frmKalkulacijaUnos
    '        _kalk_iz_racuna = False
    '        mForm.Show()
    '    End Sub
    '    Private Sub linkKalkulacijeEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myUpdate()
    '    End Sub
    '    Private Sub linkKalkulacijePrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.Kalkulacija_prn()
    '    End Sub
    '    Private Sub linkKalkBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myDelete()
    '    End Sub
    '#End Region

    '#Region "Nivelacije"

    '    Private Sub linkNivelacijeUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Dim mForm As New frmNivelacijaUnos
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkNivelacijeEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myUpdate()
    '    End Sub

    '    Private Sub linkNivelacijePrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        _raport = Imena.tabele.rm_nivelacije.ToString
    '        Dim mForm As New frmPrint
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkNivelacijeBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myDelete()
    '    End Sub

    '#End Region

    '#Region "radni nalozi"
    '    Private Sub linkRadniNaloziUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Dim mForm As New frmRadniNalogUnos
    '        mForm.Show()
    '    End Sub
    '    Private Sub linkRadniNaloziEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myUpdate()
    '    End Sub
    '    Private Sub linkRadniNaloziPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        _raport = Imena.tabele.rm_radni_nalog_head.ToString
    '        Dim mForm As New frmPrint
    '        mForm.Show()
    '    End Sub
    '    Private Sub linkPotvrdaUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        slobodni_nalozi(Imena.tabele.rm_radni_nalog_head.ToString)
    '    End Sub
    '    Private Sub linkPotvrdaEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myUpdate_potvrde()
    '    End Sub
    '    Private Sub linkRadniNaloziBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myDelete()
    '    End Sub
    '#End Region

    '#Region "Putni Nalozi"
    '    Private Sub linkPutNaloziUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        Dim mForm As New frmPutniNalogUnos
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkPutNaloziEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myUpdate()
    '    End Sub

    '    Private Sub linkPutNaloziPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        _raport = Imena.tabele.fn_putni_nalog.ToString
    '        Dim mForm As New frmPrint
    '        mForm.Show()
    '    End Sub
    '    Private Sub linkPutRacunUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        slobodni_nalozi(Imena.tabele.fn_putni_nalog.ToString)
    '    End Sub

    '    Private Sub linkPutRacunEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myUpdate_putracun()
    '    End Sub
    '    Private Sub linkPRacunPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        _raport = Imena.tabele.fn_putni_racun.ToString
    '        Dim mForm As New frmPrint
    '        mForm.Show()
    '    End Sub
    '    Private Sub linkPutNaloziBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        cntOstaliDok.myDelete()
    '    End Sub
    '#End Region

    '#Region "trebovanja"
    '    Private Sub linkTrebUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '        postavi_panel(Imena.tabele.rm_trebovanje.ToString)
    '        mdiMain.zatvori_kontrolu_desno()

    '        Dim myControl As New cntTrebovanjeUnos
    '        myControl.Parent = mdiMain.splRadni.Panel2
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()
    '    End Sub

    '    Private Sub linkTrebEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    '    End Sub

    '    Private Sub linkTrebBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    '    End Sub

    '    Private Sub linkTrebPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    '    End Sub
    '#End Region

    '#Region "magacini"
    '    Private Sub btnMagacini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        postavi_panel(Imena.tabele.rm_magacini.ToString)
    '        mdiMain.zatvori_kontrolu_desno()

    '        Dim myControl As New cntMagacini
    '        myControl.Parent = mdiMain.splRadni.Panel2
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()

    '        podesi_boje()
    '        btnMagacini.BackColor = Color.LightSteelBlue
    '        btnMagacini.Enabled = False

    '        koraci_header("cntMagacini")
    '        _labHead = Ispisi_label()
    '_txtHeader.Size = New Size(_txtHeader.TextLength * 9.5, _txtHeader.Height)
    '    End Sub
    '    Private Sub linkMagacinUnos_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacinUnos.LinkClicked
    '        Dim mForm As New frmMagacinUnos
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkMagacinEdit_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacinEdit.LinkClicked
    '        cntMagacini.myUpdate()
    '    End Sub

    '    Private Sub linkMagacinBrisanje_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacinBrisanje.LinkClicked
    '        cntMagacini.myDelete()
    '    End Sub

    '    Private Sub linkMagacinPrint_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacinPrint.LinkClicked

    '    End Sub

    '    Private Sub linkMagacinLista_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacinLista.LinkClicked
    '        _stampa = Imena.vrsta_stampe.mag_lista.ToString
    '        cntMagacini.myPrn()
    '    End Sub
    '    Private Sub link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link.LinkClicked
    '        _stampa = Imena.vrsta_stampe.mag_popisna_lista.ToString
    '        cntMagacini.myPrn()
    '    End Sub
    '    Private Sub linkMagacinStanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacinStanje.LinkClicked
    '        _stampa = Imena.vrsta_stampe.mag_stanje.ToString
    '        cntMagacini.myPrn()
    '    End Sub
    '#End Region

    ' IZ ARTIKALA

    '#Region "PDV"
    '    Private Sub btnPdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPdv.Click
    '        mdiMain.zatvori_kontrolu_desno()

    '        Dim myControl As New cntPDV
    '        myControl.Parent = mdiMain.splGlavni.Panel2
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()
    '    End Sub

    '    '    Private Sub linkPdvUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPdvUnos.LinkClicked
    '    '        Dim mForm As New frmPdvUnos
    '    '        mForm.Show()
    '    '    End Sub

    '    '    Private Sub linkPdvEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPdvEdit.LinkClicked
    '    '        cntPDV.myUpdate()
    '    '    End Sub

    '    '    Private Sub linkPdvBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPdvBrisanje.LinkClicked
    '    '        cntPDV.myDelete()
    '    '    End Sub

    '    '    Private Sub linkPdvPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPdvPrint.LinkClicked
    '    '        _raport = Imena.tabele.app_pdv.ToString
    '    '        Dim mForm As New frmPrint
    '    '        mForm.Show()
    '    '    End Sub
    '#End Region

    '#Region "JKL"
    '    'Private Sub btnJklLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJklLista.Click
    '    '    postavi_panel(Imena.tabele.app_jkl.ToString)
    '    '    mdiMain.zatvori_kontrolu_desno()

    '    '    Dim myControl As New cntJKL
    '    '    myControl.Parent = mdiMain.splGlavni.Panel2
    '    '    myControl.Dock = DockStyle.Fill
    '    '    myControl.Show()
    '    'End Sub

    '    Private Sub linkJklUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJklUnos.LinkClicked
    '        'Dim mForm As New frmOjUnos
    '        'mForm.Show()
    '    End Sub

    '    Private Sub linkJklEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJklEdit.LinkClicked
    '        'cntNaselja.myUpdate()
    '    End Sub

    '    Private Sub linkJklBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJklBrisanje.LinkClicked
    '        'cntNaselja.myDelete()
    '    End Sub

    '    Private Sub linkJklPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJklPrint.LinkClicked
    '        _raport = Imena.tabele.app_naselja.ToString
    '        Dim mForm As New frmPrint
    '        mForm.Show()
    '    End Sub

    '#End Region

    '#Region "kategorije"
    '    Private Sub btnKategorije_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        mdiMain.zatvori_kontrolu_desno()

    '        Dim myControl As New cntKategorije
    '        myControl.Parent = mdiMain.splGlavni.Panel2
    '        myControl.Dock = DockStyle.Fill
    '        myControl.Show()
    '    End Sub

    '    Private Sub linkKategorijeUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJMUnos.LinkClicked
    '        Dim mForm As New frmKategorijeUnos
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkKategorijeEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJMEdit.LinkClicked
    '        cntKategorije.myUpdate()
    '    End Sub

    '    Private Sub linkKategorijeBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJMBrisanje.LinkClicked
    '        cntKategorije.myDelete()
    '    End Sub

    '    Private Sub linkKategorijePrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJMPrint.LinkClicked
    '        '_raport = Imena.tabele.fn_putni_nalog.ToString
    '        'Dim mForm As New frmPrint
    '        'mForm.Show()
    '    End Sub
    '#End Region

    '#Region "Grupe"
    '    'Private Sub btnGrupeArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupeArt.Click
    '    '    postavi_panel(Imena.tabele.app_artikl_grupa.ToString)
    '    '    mdiMain.zatvori_kontrolu_desno()

    '    '    Dim myControl As New cntGrupeArt
    '    '    myControl.Parent = mdiMain.splGlavni.Panel2
    '    '    myControl.Dock = DockStyle.Fill
    '    '    myControl.Show()
    '    'End Sub

    '    Private Sub linkGrArtUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrArtUnos.LinkClicked
    '        Dim mForm As New frmGrupeArtUnos
    '        mForm.Show()
    '    End Sub

    '    Private Sub linkGrArtEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrArtEdit.LinkClicked
    '        cntGrupeArt.myUpdate()
    '    End Sub

    '    Private Sub linkGrArtBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrArtBrisanje.LinkClicked
    '        cntGrupeArt.myDelete()
    '    End Sub

    '    Private Sub linkGrArtPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrArtPrint.LinkClicked
    '        '_raport = Imena.tabele.app_naselja.ToString
    '        'Dim mForm As New frmPrint
    '        'mForm.Show()
    '    End Sub
    '#End Region

    '#Region "Vrste artikla"
    '    'Private Sub btnVrsteArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVrsteArt.Click

    '    'End Sub

    '    'Private Sub linkVrsteArtUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkVrsteArtUnos.LinkClicked

    '    'End Sub

    '    'Private Sub linkVrsteArtEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkVrsteArtEdit.LinkClicked

    '    'End Sub

    '    'Private Sub linkVrsteArtBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkVrsteArtBrisanje.LinkClicked

    '    'End Sub

    '    'Private Sub linkVrsteArtPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkVrsteArtPrint.LinkClicked

    '    'End Sub
    '#End Region

End Module
