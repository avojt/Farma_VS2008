Public Class frmPrint

    Private Sub frmPrint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim putanja As String = My.Application.Info.DirectoryPath & "\izvestaji\"
        'Dim putanja As String = "E:\projekti\Farma\Farma\izvestaji\"
        'Dim putanja As String = PrintString

        Select Case _raport

            'POSTAVKE
            Case Imena.tabele.app_partneri.ToString
                Report.ReportSource = putanja & "rptPartneri.rpt"

            Case Imena.tabele.rm_artikli.ToString
                Select Case _print_all
                    Case True
                        Report.ReportSource = putanja & "app\rptArtikli_all.rpt"
                    Case False
                        Report.ReportSource = putanja & "app\rptArtikli_all.rpt" ' putanja & "app\rptArtikli_PopisnaLista.rpt"
                End Select

            Case Imena.tabele.app_jkl.ToString
                Report.ReportSource = putanja & "app\rptJKL.rpt"

            Case Imena.tabele.app_genericko_ime.ToString
                Report.ReportSource = putanja & "app\rptGenericko.rpt"

            Case Imena.tabele.app_fo.ToString
                Report.ReportSource = putanja & "app\rptFO.rpt"

            Case Imena.tabele.app_jm.ToString
                Report.ReportSource = putanja & "app\rptJM.rpt"

            Case Imena.tabele.app_artikl_grupa.ToString
                Report.ReportSource = putanja & "app\rptGrupeArt.rpt"

            Case Imena.tabele.app_pdv.ToString
                Report.ReportSource = putanja & "app\rptPdv.rpt"

            Case Imena.tabele.app_konto.ToString
                Report.ReportSource = putanja & "app\rptKontniPlan.rpt"

            Case Imena.tabele.app_naselja.ToString
                Report.ReportSource = putanja & "app\rptNaselja.rpt"

            Case Imena.tabele.app_organizacione_jedinice.ToString
                Select Case _detaljna_stampa
                    Case True
                        Report.ReportSource = putanja & "app\rptOJDetalji.rpt"
                    Case False
                        Report.ReportSource = putanja & "app\rptOJ.rpt"
                        'Report.SelectionFormula = _sql_za_print
                End Select

                'ROBNO-MATERIJALNO
            Case Imena.tabele.rm_ulazni_dokument.ToString
                Report.ReportSource = putanja & "rm\rptUlazni_Dokument.rpt"

            Case Imena.tabele.rm_izlazni_dokument.ToString
                Report.ReportSource = putanja & "rm\rptIzlazni_Dokument.rpt"

            Case Imena.tabele.rm_povratnica.ToString
                Report.ReportSource = putanja & "rm\rptPovratnica.rpt"

            Case Imena.tabele.rm_radni_nalog_head.ToString
                Report.ReportSource = putanja & "rptRadniNalog.rpt"

            Case Imena.tabele.rm_nivelacije.ToString
                Report.ReportSource = putanja & "rm\rptNivelacija.rpt"

            Case Imena.tabele.rm_kalkulacija.ToString
                Report.ReportSource = putanja & "rm\rptKalkulacija.rpt"

            Case Imena.tabele.rm_dnevni_promet.ToString
                Report.ReportSource = putanja & "rm\rptDnevni_Promet-kumulat.rpt"

            Case Imena.tabele.rm_int_dostav_ulaz.ToString
                Report.ReportSource = putanja & "rm\rptIntD_ulaz.rpt"

            Case Imena.tabele.rm_knjizno_odobrenje_ulaz.ToString
                Report.ReportSource = putanja & "rm\rptKO_ulaz.rpt"

            Case Imena.tabele.rm_knjizno_zaduzenje_ulaz.ToString
                Report.ReportSource = putanja & "rm\rptKZ_ulaz.rpt"

            Case Imena.tabele.rm_povracaj_robe.ToString
                Report.ReportSource = putanja & "rm\rptPovracaj_robe.rpt"

            Case Imena.tabele.rm_int_dostav_izlaz.ToString
                Report.ReportSource = putanja & "rm\rptIntD_izlaz.rpt"

            Case Imena.tabele.rm_knjizno_odobrenje_izlaz.ToString
                Report.ReportSource = putanja & "rptKO_izlaz.rpt"

            Case Imena.tabele.rm_knjizno_zaduzenje_izlaz.ToString
                Report.ReportSource = putanja & "rm\rptKZ_izlaz.rpt"

            Case Imena.tabele.rm_popis.ToString
                Report.ReportSource = putanja & "rm\rptPopis.rpt"

            Case Imena.tabele.rm_trebovanje.ToString
                Report.ReportSource = putanja & "rm\rptTrebovanje.rpt"

            Case Imena.tabele.rm_mag_interni_prenos.ToString
                Report.ReportSource = putanja & "rm\rptMagInterniPrenos.rpt"

            Case Imena.tabele.rm_interni_prenos.ToString
                Report.ReportSource = putanja & "rm\rptInterniPrenos.rpt"

            Case Imena.tabele.rm_promet_art_detaljno.ToString
                Report.ReportSource = putanja & "rm\rptPromet_art_detaljno.rpt"

            Case Imena.tabele.rm_promet_art_kumulativ.ToString
                Report.ReportSource = putanja & "rm\rptPromet_art_kumulativ.rpt"

            Case Imena.tabele.rm_promet_mag_stanje.ToString
                Report.ReportSource = putanja & "rm\rptPromet_mag_stanje.rpt"

            Case Imena.tabele.rm_promet_neslaganje.ToString
                Report.ReportSource = putanja & "rm\rptPromet_neslaganje.rpt"

            Case Imena.tabele.rm_analiza_ulaz.ToString
                Report.ReportSource = putanja & "rm\rptAnaliza_ulaz.rpt"

            Case Imena.tabele.rm_analiza_izlaz.ToString
                Report.ReportSource = putanja & "rm\rptAnaliza_izlaz.rpt"

            Case Imena.tabele.rm_analiza_lager.ToString
                Report.ReportSource = putanja & "rm\rptAnaliza_lagera.rpt"

            Case Imena.tabele.rm_specifikacija_nivelacija.ToString
                Report.ReportSource = putanja & "rm\rptSpecifikacija_nivelacija.rpt"

            Case Imena.tabele.rm_specifikacija_ulaz.ToString
                Report.ReportSource = putanja & "rm\rptSpecifikacija_ulaz.rpt"

            Case Imena.tabele.rm_specifikacija_izlaz.ToString
                Report.ReportSource = putanja & "rm\rptSpecifikacija_izlaz.rpt"

            Case Imena.tabele.rm_specifikacija_lager.ToString
                Report.ReportSource = putanja & "rm\rptSpecifikacija_lager.rpt"

            Case Imena.tabele.rm_magacini.ToString
                Report.ReportSource = putanja & "rm\rptMagacini.rpt"
            Case Imena.tabele.rm_magacini_popisna_lista.ToString
                Report.ReportSource = putanja & "rm\rptMagacinPopisnaLista.rpt"
            Case Imena.tabele.rm_magacini_stanje.ToString
                Report.ReportSource = putanja & "rm\rptMagacinStanje.rpt"


                ' FINANSIJSKO
            Case Imena.tabele.fn_putni_nalog.ToString
                Report.ReportSource = putanja & "rptPutniNalog.rpt"

            Case Imena.tabele.fn_putni_racun.ToString
                Report.ReportSource = putanja & "rptPutniRacun.rpt"

            Case Imena.tabele.virmani.ToString
                Select Case _sa_cenom
                    Case True
                        Report.ReportSource = putanja & "rptVirman.rpt"
                    Case False
                        Report.ReportSource = putanja & "rptVirmanBlank.rpt"
                End Select

            Case Imena.tabele.fn_nalog.ToString
                Report.ReportSource = putanja & "finansijsko\rptNalog.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_analitika_kumulativ.ToString
                Report.ReportSource = putanja & "finansijsko\rptAnalitika_kumulativ.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_analitika_kartica.ToString
                Report.ReportSource = putanja & "finansijsko\rptAnalitika_kartica.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_glavna_knjiga_kartica.ToString
                Report.ReportSource = putanja & "finansijsko\rptGlavna_knjiga_kartica.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_analitika_pregled_po_kontima_analitika.ToString
                Report.ReportSource = putanja & "finansijsko\rptAnalitika_po_kontima - analitika.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_analitika_pregled_po_kontima_sintetika.ToString
                Report.ReportSource = putanja & "finansijsko\rptAnalitika_po_kontima - sintetika.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_kartica_po_analitici.ToString
                Report.ReportSource = putanja & "finansijsko\rptKartica_po_analitici.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_bruto_bilans_sintetika.ToString
                Report.ReportSource = putanja & "finansijsko\rptBruto_bilans - sintetikla.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_bruto_bilans_analitika.ToString
                Report.ReportSource = putanja & "finansijsko\rptBruto_bilans - analitika.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_otvorene_stavke_otv.ToString
                Report.ReportSource = putanja & "finansijsko\rptOtv_st_pregled_otvorenih.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_otvorene_stavke_zat.ToString
                Report.ReportSource = putanja & "finansijsko\rptOtv_st_pregled_zatvorenih.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.fn_otvorene_stavke_izvod.ToString
                Report.ReportSource = putanja & "finansijsko\rptOtv_st_izvod.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

                'PROIZVODNJA
            Case Imena.tabele.pr_sastavnica.ToString
                Report.ReportSource = putanja & "proizvodnja\rptSastavnica.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.pr_lab_dn.ToString
                Report.ReportSource = putanja & "proizvodnja\rptLab_dn.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.pr_lab_dn_trebovanje.ToString
                Report.ReportSource = putanja & "proizvodnja\rptLab_dn_trebovanje.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

            Case Imena.tabele.pr_lab_dn_rekapitulacija.ToString
                Report.ReportSource = putanja & "proizvodnja\rptLab_dn_rekapit.rpt"
                Report.DisplayGroupTree = False
                Report.Zoom(1)

        End Select

    End Sub

End Class