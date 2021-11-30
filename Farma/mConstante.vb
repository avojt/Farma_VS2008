Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.UserControl

Module mConstante

    Public _mCntNaselja_search As Control ' = New cntNaselja_search
    Public _mCntSastavnica_search As Control
    Public _mCntLab_Dn_search As Control
    Public Const _win_temp_path As String = "C:\WINDOWS\Temp\"
    Public _datumOD As DateTimePicker
    Public _datumDO As DateTimePicker
    Public _sve As Boolean = True
    Public _lista As ListView
    Public _listaArt As ListView
    Public _grid As DataGridView
    Public _mTab As TabControl.TabPageCollection
    Public _labHead As Label
    Public _lCount As Label
    Public _lStatus As ToolStripStatusLabel
    Public _mStatusBar As StatusStrip
    Public _spGlavni As SplitContainer
    Public _spRadni As SplitContainer
    Public _text_magacin As String = ""
    Public _text_partner As String = ""
    Public _text_grupa As String = ""
    Public _text_oj As String = ""
    Public _text_datum As String = ""
    Public _txtHeader As ToolStripTextBox
    Public _korak_nazad() As String
    Public _forma_zapovratak As Control
    Public _forma As String
    Public _korak_labHead() As String
    Public _povratak As Boolean = False
    Public _ima_promena As Boolean = False
    Public _upit_magacin As String = ""
    Public ID_vrsta_dokumenta As Integer = 0
    Public _naselja As String = ""

    Public _id_partner As Integer
    Public _partner_sifra As String
    Public _partner_naziv As String
    Public _partner_adresa As String
    Public _partner_opstina As String
    Public _partner_mesto As String
    Public _partner_drazava As String
    Public _partner_pib As String
    Public _partner_maticni As String
    Public _partner_registarski As String
    Public _partner_zr As String
    Public _partner_delatnost As String
    Public _partner_proizvodjac As Boolean
    Public _partner_dobavljac As Boolean
    Public _partner_kupac As Boolean
    Public _kontakt As String
    Public _mail As String
    Public _telefon As String

    Public _id_kontakt As Integer
    Public _kontakt_telefoni As Array = Array.CreateInstance(GetType(String), 30, 3)

    Public _id As String
    Public _broj_stavki As Integer
    Public _id_stavka() As Integer

    Public _id_pdv As Integer
    Public _pdv_opis As String
    Public _pdv_stopa As String
    Public _pdv_sifra As Integer
    Public _pdv_datum As Date
    Public _pdv_aktivan As Boolean

    Public _id_kategorija As Integer = 0
    Public _kategorija_naziv As String = ""
    Public _kategorija_sifra As String = ""
    Public _kategorija_prefix As String = ""

    Public _id_odlozeno As Integer
    Public _odlozeno_sifra As String
    Public _odlozeno_opis As String
    Public _odlozeno_odlozeno As String

    Public _id_grad As Integer
    Public _grad_naziv As String
    Public _grad_ptt As String
    Public _grad_pj As String
    Public _grad_aktivan As Boolean

    Public _id_opstina As Integer
    Public _opstina_naziv As String
    Public _opstina_ptt As String
    Public _opstina_pj As String
    Public _opstina_aktivan As Boolean

    Public _id_mesto As Integer
    Public _mesto_naziv As String
    Public _mesto_ptt As String
    Public _mesto_pj As String
    Public _mesto_aktivan As Boolean

    Public _id_oj As Integer
    Public _oj_sifra As String = ""
    Public _oj_naziv As String = ""
    Public _oj_adresa As String = ""
    Public _oj_id_mesta As Integer
    Public _oj_id_opstine As Integer
    Public _oj_strukturna As Boolean
    Public _oj_aktivan As Boolean

    Public _id_vrsta_oj As Integer
    Public _vrsta_oj_sifra As String = ""
    Public _vrsta_oj_naziv As String = ""
    Public _vrsta_oj_vodjenje_zaliha As Boolean
    Public _vrsta_oj_obj_robnog_poslovanja As Boolean
    Public _vrsta_oj_obj_blagajnickog_poslovanja As Boolean
    Public _vrsta_oj_prodajni_objekat As Boolean
    Public _vrsta_oj_fakturise As Boolean
    Public _id_vrsta_cenovnika As String = ""
    Public _vrsta_oj_minusne_zalihe As Boolean
    Public _vrsta_oj_auto_promena_cene As Boolean
    Public _vrsta_oj_minusne_rezervacije As Boolean

#Region "grupa artikla"
    Public _id_gr_art As Integer
    Public _gr_art_sifra As String = ""
    Public _gr_art_naziv As String = ""
    Public _gr_art_skraceno As String = ""
    Public _gr_art_nadredj_gr As String = ""
    Public _gr_art_poslednji_nivo As Boolean
    Public _gr_art_marza As Single
    Public _gr_art_pdv As Single
    Public _gr_art_aktivno As Boolean
    Public _gr_art_L1 As Boolean
    Public _gr_art_lek As Boolean
    Public _gr_art_izdajesena As String = ""
    Public _gr_art_opis_sifra As String = ""
    Public _gr_art_opis_naziv As String = ""
    Public _gr_art_opis_marza As String = ""
    Public _gr_art_opis_pdv As String = ""
    Public _gr_art_opis_lek As String = ""
    Public _gr_art_opis_l1 As String = ""
    Public _gr_art_opis_dokument As String = ""
    Public _grupa_art As String = ""
#End Region

    Public _vrsta_promene As String = ""
    Public _unesen_jkl As Boolean = True

    Public _id_jkl As Integer
    Public _jkl_sifra As String = ""
    Public _jkl_naziv As String = ""
    Public _jkl_pozitivna_lista As Boolean = False

    Public _id_genericko As Integer
    Public _genericko_sifra As String
    Public _genericko_naziv As String
    Public _genericko_ime_aktivan As Boolean

    Public _id_fo As Integer = 0
    Public _fo_sifra As String = ""
    Public _fo_naziv As String = ""
    Public _fo_skraceno As String = ""
    Public _fo_aktivan As Boolean = False

    Public _id_vrsta As Integer = 0
    Public _vrsta_sifra As String = ""
    Public _vrsta_naziv As String = ""
    Public _vrsta_prefix As String = ""
    Public _vrsta_izdajesena As String = ""

    Public _id_poz_lista As Integer
    Public _poz_lista_dat_promene As Date
    Public _poz_lista_jkl_sifra_l1 As String = ""
    Public _poz_lista_L1 As Boolean = False
    Public _poz_lista_l1_dat_OD As Date
    Public _poz_lista_l1_dat_DO As Date

    Public _id_vrsta_dok As Integer = 0
    Public _vrsta_dok_vrsta As Integer = 0
    Public _vrsta_dok_sifra As String = ""
    Public _vrsta_dok_opis As String = ""
    Public _vrsta_dok_naziv As String = ""
    Public _vrsta_dok_konto As String = ""
    Public _vrsta_dok_str_knjizenja As String = ""

    Public _novi_jkl_unesen As Boolean = False
    Public _novi_jkl_potreban As Boolean = False

    Public id_predhodnog_stanja As Integer
    Public id_predhodnog_stanja_stavka() As Integer

#Region "artikl"
    Public _id_artikl As Integer = 0
    Public _id_artikl_cena As Integer = 0
    Public _artikl_naziv As String
    Public _artikl_sifra As String
    Public _artikl_sifra_opis As String
    Public _artikl_id_jm As Integer
    Public _artikl_nabavna As Single
    Public _artikl_rabat As Single
    Public _artikl_id_pdv As Integer
    Public _artikl_cena As Single
    Public _artikl_kolicina As Single
    Public _artikl_marza As Single
    Public _artikl_id_grupa As Integer
    Public _artikl_id_podgrupa As Integer
    Public _artikl_id_fo As Integer
    Public _artikl_jkl As String
    Public _artikl_vrsta As String = ""
    Public _artikl_id_doza As Integer
    Public _artikl_id_proizvodjac As Integer
    Public _artikl_fabricko_ime As Single
    Public _artikl_genericko_ime As String = ""
    Public _artikl_lek As Boolean = False
    Public _artikl_nacin_izdavanja As String = ""
    Public _artikl_bar_kod As String = ""
    Public _artikl_humanitarna_pomoc As Boolean = False
    Public _zal_po_serbr As Boolean = False
    Public _zal_po_roku_trajanja As Boolean = False
    Public _zal_po_reg_adresi As Boolean = False
    Public _artikl_aktivan As Boolean = False
    Public _ponuda_iz_robe As Boolean = False
    Public _novi_artikl As Boolean = False
    Public _novi_artikl_sifra As String = ""
    Public _artikl_lista_ponude() As String
    Public _artikl_min_kolicina As Single
    Public _artikl_bod As Boolean = False
    Public _artikl_bod_cena As Single
    Public _artikl_euro As Single

    Public _id_cena_robe As Integer
    Public _cena_nab_zadnja As Single
    Public _cena_vp1 As Single
    Public _cena_vp2 As Single
    Public _cena_vp3 As Single
    Public _cena_mp As Single
    Public _pdv As Single
    Public _rabat As Single
    Public _marza As Single

    Public _id_doza As Integer = 0
    Public _doza_sifra As String = ""
    Public _doza_jm As String = ""
    Public _doza_br As Single = 0

#End Region

#Region "racuni"
    Public _id_racun As String
    Public _broj_racuna As String
    Public _id_racun_stavka() As Integer
    Public _id_predracun As String
    Public _id_predracun_stavka() As Integer
    Public _sifra_predracun As String
    Public _sifra_racun As String
    Public _rb As String
    Public _opis As String
    Public _datum_fakturisanja As Date
    Public _datum_prometa As Date
    Public _datum_valuta As Date
    Public _valuta As Integer
    Public _cena As Single
    Public _osnovica As Single
    Public _iznos As Single
    'Public _rabat As Integer
    'Public _pdv As Integer
    Public _pdv_iznos As Single
    Public _kolicina As Single
    Public _napomena As String
    Public _raport As String
    Public _print_all As Boolean
    Public _sql_za_print As String
    Public _tab As String = ""
    Public _tab_finansije As String = ""
    Public _sa_cenom As Boolean = True
    Public _broj_fakture As String
    Public _iz_ponude As Boolean = False
#End Region

    Public _od_datuma As Date
    Public _detaljna_stampa As Boolean = False

#Region "magacin"
    Public _id_magacin As Integer = 0
    Public _magacin_sifra As String = ""
    Public _magacin_naziv As String = ""
    Public _magacin_id_vrsta As Integer = 0
    Public _magacin_vodjenje_zaliha As Boolean
    Public _magacin_id_zaliha As Integer = 0
    Public _magacin_id_dozvoljenih() As Integer
    Public _magacin_stanje As Single = 0

    Public _mag_art_ulaz As Single = 0
    Public _mag_art_izlaz As Single = 0
    Public _mag_art_stanje As Single = 0
    Public _mag_art_cena As Single = 0
    Public _mag_art_pdv As Single = 0
    Public _mag_suma_ulaz As Single = 0
    Public _mag_suma_izlaz As Single = 0
    Public _mag_suma_stanje As Single = 0

    Public _id_promene As Integer = 0
    Public _mag_datum_promene As Date
    Public _mag_id_magacin As Integer = 0
    Public _mag_rb As Integer = 0
    Public _mag_id_vrsta_dok As Integer = 0
    Public _mag_id_dokumenta As Integer = 0
    Public _mag_broj_dok As String = ""
    Public _mag_ukupno_ulaz As Single = 0
    Public _mag_ukupno_izlaz As Single = 0
    Public _mag_ukupno_stanje As Single = 0
    Public _mag_novo_stanje As Boolean

    Public _id_vrsta_mag As Integer = 0
    Public _vrsta_mag_sifra As String = ""
    Public _vrsta_mag_naziv As String = ""

#End Region

    Public _id_jm As Integer = 0
    Public _jm_sifra As String = ""
    Public _jm_naziv As String = ""
    Public _jm_oznaka As String = ""
    Public _jm_br_decimala As Integer = 0

    Public otvorene_forme As ArrayList = New ArrayList(10)
    Public _nazivi As Array = Array.CreateInstance(GetType(String), 100, 3)
    Public _artikli As Array = Array.CreateInstance(GetType(String), 100, 8)
    Public _promena_cene As Array = Array.CreateInstance(GetType(Object), 50, 4)

    Public _slobodni_nalozi() As Integer

    Public _izdat As Boolean = True
    Public _unesen As Boolean = False
    Public _placeno As Boolean = True
    Public _proknjizen As Boolean = True

    Public _kalk_iz_racuna As Boolean = False
    Public _troskovi_iz_racuna As Single = 0

    Public _datum_od As DateTimePicker '= Today
    Public _datum_do As DateTimePicker '= Today
    Public _stavke As Boolean = True
    Public _promenjen_tab As Boolean = False

    Public _trebovanje As Boolean = False
    Public _lab_dnev As Boolean = False

#Region "paneli - KONTEJNERI"

    Public _mPanRoba As TableLayoutPanel
    Public _mPanUlRacuni As TableLayoutPanel
    Public _mPanIzRacuni As TableLayoutPanel
    Public _mPanPovratnica As TableLayoutPanel
    Public _mPanPdvObracun As TableLayoutPanel

    Public _mPanNivel As TableLayoutPanel
    Public _mPanPutniNal As TableLayoutPanel
    Public _mPanRadniNal As TableLayoutPanel
    Public _mPanVirm As TableLayoutPanel
    Public _mPanTrebovanja As TableLayoutPanel

    Public _mPanArtikli_kontejn As TableLayoutPanel
    Public _mPanArtikli_meni As TableLayoutPanel
    Public _mLinkArtikli_search As LinkLabel
    Public _mLinkArtikli_edit As LinkLabel
    Public _mLinkPozitivna_lista As LinkLabel

    Public _mPanGrupe_kontejn As TableLayoutPanel
    Public _mPanGrupe_meni As TableLayoutPanel
    Public _mLinkGrupe_search As LinkLabel

    Public _mPanJKL_kontejn As TableLayoutPanel
    Public _mPanJKL_meni As TableLayoutPanel
    Public _mLinkJKL_search As LinkLabel

    Public _mPanJM_kontejn As TableLayoutPanel
    Public _mPanJM_meni As TableLayoutPanel
    Public _mLinkJM_search As LinkLabel

    Public _mPanGenerIme_kontejn As TableLayoutPanel
    Public _mPanGIme_meni As TableLayoutPanel
    Public _mLinkGIme_search As LinkLabel

    Public _mPanPDV_kontejn As TableLayoutPanel
    Public _mPanPDV_meni As TableLayoutPanel
    Public _mLinkPDV_search As LinkLabel

    Public _mPanFO_kontejn As TableLayoutPanel
    Public _mPanFO_meni As TableLayoutPanel
    Public _mLinkFO_search As LinkLabel

    Public _mPanDnProm As TableLayoutPanel
    Public _mPanDnProm_kontejn As TableLayoutPanel
    Public _mPanDnProm_meni As TableLayoutPanel
    Public _mLinkDnProm_search As LinkLabel

    Public _mPanIntDosUlaz As TableLayoutPanel
    Public _mPanIntDosUlaz_kontejn As TableLayoutPanel
    Public _mPanIntDosUlaz_meni As TableLayoutPanel
    Public _mLinkIntDosUlaz_search As LinkLabel

    Public _mPanNivelacija As TableLayoutPanel
    Public _mPanNivelacija_kontejn As TableLayoutPanel
    Public _mPanNivelacija_meni As TableLayoutPanel
    Public _mLinkNivelacija_search As LinkLabel

    Public _mPanMagIntPrenos_kontejn As TableLayoutPanel
    Public _mPanMagIntPrenos_meni As TableLayoutPanel
    Public _mLinkMagIntPrenos_search As LinkLabel

    Public _mPanPovracajRobe_kontejn As TableLayoutPanel
    Public _mPanPovracajRobe_meni As TableLayoutPanel
    Public _mLinkPovracajRobe_search As LinkLabel

    Public _mPanPopis As TableLayoutPanel
    Public _mPanPopis_kontejn As TableLayoutPanel
    Public _mPanPopis_meni As TableLayoutPanel
    Public _mLinkPopis_search As LinkLabel

    Public _mPanTrebovanja_kontejn As TableLayoutPanel
    Public _mPanTrebovanja_meni As TableLayoutPanel
    Public _mLinkTrebovanja_search As LinkLabel

    Public _mPanIntPrenos_kontejn As TableLayoutPanel
    Public _mPanIntPrenos_meni As TableLayoutPanel
    Public _mLinkIntPrenos_search As LinkLabel

    Public _mPanIntDosIzlaz As TableLayoutPanel
    Public _mPanIntDosIzlaz_kontejn As TableLayoutPanel
    Public _mPanIntDosIzlaz_meni As TableLayoutPanel
    Public _mLinkIntDosIzlaz_search As LinkLabel

    Public _mPanKnjOdobIzlaz As TableLayoutPanel
    Public _mPanKnjOdobIzlaz_kontejn As TableLayoutPanel
    Public _mPanKnjOdobIzlaz_meni As TableLayoutPanel
    Public _mLinkKnjOdobIzlaz_search As LinkLabel

    Public _mPanKnjZaduzIzlaz As TableLayoutPanel
    Public _mPanKnjZaduzIzlaz_kontejn As TableLayoutPanel
    Public _mPanKnjZaduzIzlaz_meni As TableLayoutPanel
    Public _mLinkKnjZaduzIzlaz_search As LinkLabel

    Public _mPanPromet As TableLayoutPanel
    Public _mPanPromet_kontejn As TableLayoutPanel
    Public _mPanPromet_meni As TableLayoutPanel
    Public _mLinkKartica As LinkLabel
    Public _mLinkMagacin As LinkLabel
    Public _mLinkNeslaganje As LinkLabel

    Public _mPanSpecifikacije As TableLayoutPanel
    Public _mPanSpecifikacije_kontejn As TableLayoutPanel
    Public _mPanSpecifikacije_meni As TableLayoutPanel
    Public _mLinkSpec_ulaz As LinkLabel
    Public _mLinkSpec_izlaz As LinkLabel
    Public _mLinkSpec_nivelacije As LinkLabel

    Public _mPanPartneri As TableLayoutPanel
    Public _mPanPartneri_kontejn As TableLayoutPanel
    Public _mPanPartneri_meni As TableLayoutPanel
    Public _mLinkPartneri_search As LinkLabel

    Public _mPanOJ As TableLayoutPanel
    Public _mPanOJ_kontejn As TableLayoutPanel
    Public _mPanOJ_meni As TableLayoutPanel
    Public _mLinkOJ_search As LinkLabel

    Public _mPanNaselja As TableLayoutPanel
    Public _mPanNaselja_kontejn As TableLayoutPanel
    Public _mPanNaselja_meni As TableLayoutPanel
    Public _mLinkNaselja_search As LinkLabel

    Public _mPanMagacini_kontejn As TableLayoutPanel
    Public _mPanUlazRacuni_kontejn As TableLayoutPanel
    Public _mPanRacuni_kontejn As TableLayoutPanel

    Public _mPanKalkulacije_kontejn As TableLayoutPanel
    Public _mPanRadniNalozi_kontejn As TableLayoutPanel
    Public _mPanPutNalog_kontejn As TableLayoutPanel
    Public _mPanVirmani_kontejn As TableLayoutPanel
    Public _mPanFinansije_kontejn As TableLayoutPanel
    Public _mPanNivelacije_kontejn As TableLayoutPanel
    Public _mTableButtons As TableLayoutPanel
    Public _mTableButtons_podmeni As TableLayoutPanel
    Public _mTableGlavni As TableLayoutPanel

    Public _mPanUlazRobe As TableLayoutPanel
    Public _mPanUlazRobe_kontejn As TableLayoutPanel
    Public _mPanUlazRobe_meni As TableLayoutPanel
    Public _mLinkUlazRobe_search As LinkLabel
    Public _mLinkUlazRobe_edit As LinkLabel

    Public _mPanIzlazRobe As TableLayoutPanel
    Public _mPanIzlazRobe_kontejn As TableLayoutPanel
    Public _mPanIzlazRobe_meni As TableLayoutPanel
    Public _mLinkIzlazRobe_search As LinkLabel
    Public _mLinkIzlazRobe_edit As LinkLabel

#End Region

    Public _mPanKategorije As TableLayoutPanel
    Public _mPanOdlozeno As TableLayoutPanel
    Public _mPanSifrePlacanja As TableLayoutPanel
    Public _mPanKontniPlan As TableLayoutPanel
    Public _mPanSemeZaKnjizenje As TableLayoutPanel
    Public _mPanPdv As TableLayoutPanel
    Public _mPanMagacini As TableLayoutPanel
    Public _mOJ As TableLayoutPanel
    Public _mGradovi As TableLayoutPanel
    Public _mOpstine As TableLayoutPanel
    Public _mMesta As TableLayoutPanel
    Public _mJKL As TableLayoutPanel
    Public _mGrupeArt As TableLayoutPanel
    Public _mVrsteArt As TableLayoutPanel

    Public _mPanNalozi As TableLayoutPanel
    Public _mPanIzvodi As TableLayoutPanel
    Public _mPanOStavke As TableLayoutPanel

    Public _mSpliter As SplitContainer
    Public _mSpliter_zatvoren As Boolean

#Region "DOKUMENTI"

#Region "dokument"
    Public _id_dokument As Integer
    Public _id_dokument_stavka() As Integer
    Public _dokument_broj_stavki As Integer
    Public _id_vrsta_dokumenta As Integer
    Public _sifra_dokumenta As String

    Public _rm_dokument_pdv_osnovica As Single
    Public _rm_dokument_pdv As Single

    Public _dok_id_vrsta_dokumenta As Integer
    Public _dok_sifra_dokumenta As String
    Public _dok_broj As Integer
    Public _dok_id_magacina As Integer
    Public _dok_id_partner As Integer
    Public _dok_datum_fakture As Date
    Public _dok_datum As Date
    Public _dok_opis As String
    Public _dok_ukupno As Single
    Public _dok_ztroskovi As Single
    Public _dok_rabat As Single
    Public _dok_marza As Single
    Public _dok_razlika_uceni As Single
    Public _dok_pdv_osnovica As Single
    Public _dok_pdv As Single
    Public _dok_svega As Single
    Public _dok_zakljucen As Boolean

    Public _broj_dokumenta As String = ""
    Public _vrsta_dokumenta As Integer = 0
    Public _za_naplatu As Single = 0

    Public _dok_st_rb As String = ""
    Public _dok_st_roba_sifra As String = ""
    Public _dok_st_roba_naziv As String = ""
    Public _dok_st_roba_jm As String = ""
    Public _dok_st_kolicina As Single
    Public _dok_st_nab_cena As Single
    Public _dok_st_rabat As Single
    Public _dok_st_zav_troskovi As Single
    Public _dok_st_cena_kostanja As Single
    Public _dok_st_nab_vred As Single
    Public _dok_st_marza As Single
    Public _dok_st_pdv As Single
    Public _dok_st_prod_cena As Single
    Public _dok_st_pdv_iznos As Single
    Public _dok_st_prod_vred As Single

    Public _id_storno As Integer
    Public _id_storno_stavka() As Integer
    Public _dok_storno_broj As Integer
    Public _dok_vrsta As String = ""

#End Region

#Region "putni nalog"
    Public _id_pnalog As Integer
    Public _pnalog_broj As String
    Public _pnalog_organizacija As String
    Public _pnalog_radnik As String
    Public _pnalog_radno_mesto As String
    Public _pnalog_dana As Date
    Public _pnalog_mesto As String
    Public _pnalog_zadatak As String
    Public _pnalog_prevoz As String
    Public _pnalog_dnevnica As Single
    Public _pnalog_zadrzavanje As Date
    Public _pnalog_nateret As String
    Public _pnalog_akontacija As Single

    Public _id_putni_racun As Integer
    Public _pnalog_odlazak As String
    Public _pnalog_odlazak_sat As Single
    Public _pnalog_povratak As String
    Public _pnalog_povratak_sat As Single
    Public _pnalog_broj_sati As Single
    Public _pnalog_broj_dnevnica As Single
    Public _pnalog_dinara As Single
    Public _pnalog_svega_dnevnica As Single
    Public _pnalog_svega As Single
    Public _pnalog_za_isplatu As Single
    Public _pnalog_broj_priloga As Integer
    Public _pnalog_u As String
    Public _pnalog_racun_dana As Date

    Public _pn_racun_prevoz() As Integer
    Public _pn_racun_ostalo() As Integer
#End Region

#Region "radni nalog"
    Public _id_radni_nalog As Integer
    Public _broj As String = ""
    Public _grad_nalog As String = ""
    Public _objekat As String = ""
    Public _adresa_nalog As String = ""
    Public _telefon_nalog As String = ""
    Public _kontakt_nalog As String = ""
    Public _popravka As Boolean = False
    Public _servis As Boolean = False
    Public _ispitivanje As Boolean = False
    Public _preventiva As Boolean = False
    Public _polazak_datum As Date
    Public _polazak_vreme As String = ""
    Public _povratak_datum As Date
    Public _povratak_vreme As String = ""
    Public _vozilo_naziv As String = ""
    Public _vozilo_registracija As String = ""
    Public _kilometraza As String = ""
    Public _id_radni_nalog_materijal() As Integer
    Public _id_radni_nalog_potvrda As String = ""
    Public _id_radni_nalog_potvrda_stavka() As Integer
    Public _id_radni_nalog_broj As String = ""
    Public _montaza As Boolean = False
    Public _montaza_end As Boolean
    Public _montaza_datum As Date
    Public _popravka_end As Boolean
    Public _popravka_datum As Date
    Public _servis_end As Boolean
    Public _servis_datum As Date
    Public _ispitivanje_end As Boolean
    Public _ispitivanje_datum As Date
    Public _ugovor As Boolean
    Public _ugovor_end As Boolean
    Public _ugovor_datum As Date
    Public _napomene As String
    Public _id_radni_nalog_izvrsioci() As Integer
#End Region

#Region "povracaj robe"
    Public _id_povracaj As Integer
    Public _id_pov_robe_stavka() As Integer
    Public _pov_robe_broj_stavki As Integer

    Public _rm_pov_robe_pdv_osnovica As Single
    Public _rm_pov_robe_pdv As Single

    Public _pov_robe_broj As Integer
    Public _pov_robe_id_magacina As Integer
    Public _pov_robe_id_dobavljac As Integer
    Public _pov_robe_datum_fakture As Date
    Public _pov_robe_datum As Date
    Public _pov_robe_opis As String
    Public _pov_robe_ukupno As Single
    Public _pov_robe_ztroskovi As Single
    Public _pov_robe_rabat As Single
    Public _pov_robe_razlika_uceni As Single
    Public _pov_robe_pdv_osnovica As Single
    Public _pov_robe_pdv As Single
    Public _pov_robe_svega As Single
    Public _pov_robe_zakljucena As Boolean
    Public _pov_robe_id_vrsta_dokumenta As Integer
#End Region

#Region "knjizno odobrenje - izlaz"
    Public _id_ko_iz As Integer
    Public _id_ko_iz_stavka() As Integer
    Public _ko_iz_broj_stavki As Integer

    Public _rm_ko_iz_pdv_osnovica As Single
    Public _rm_ko_iz_pdv As Single

    Public _ko_iz_broj As Integer
    Public _ko_iz_id_magacina As Integer
    Public _ko_iz_id_dobavljac As Integer
    Public _ko_iz_datum_fakture As Date
    Public _ko_iz_datum As Date
    Public _ko_iz_opis As String
    Public _ko_iz_ukupno As Single
    Public _ko_iz_ztroskovi As Single
    Public _ko_iz_rabat As Single
    Public _ko_iz_razlika_uceni As Single
    Public _ko_iz_pdv_osnovica As Single
    Public _ko_iz_pdv As Single
    Public _ko_iz_svega As Single
    Public _ko_iz_zakljucena As Single
    Public _ko_iz_id_vrsta_dokumenta As Integer
#End Region

#Region "knjizno zaduzenje - izlaz"
    Public _id_kz_iz As Integer
    Public _id_kz_iz_stavka() As Integer
    Public _kz_iz_broj_stavki As Integer

    Public _rm_kz_iz_pdv_osnovica As Single
    Public _rm_kz_iz_pdv As Single

    Public _kz_iz_broj As Integer
    Public _kz_iz_id_magacina As Integer
    Public _kz_iz_id_dobavljac As Integer
    Public _kz_iz_datum_fakture As Date
    Public _kz_iz_datum As Date
    Public _kz_iz_opis As String
    Public _kz_iz_ukupno As Single
    Public _kz_iz_ztroskovi As Single
    Public _kz_iz_rabat As Single
    Public _kz_iz_razlika_uceni As Single
    Public _kz_iz_pdv_osnovica As Single
    Public _kz_iz_pdv As Single
    Public _kz_iz_svega As Single
    Public _kz_iz_zakljucena As Boolean
    Public _kz_iz_id_vrsta_dokumenta As Integer
#End Region

#Region "popis"
    Public _id_popis As Integer
    Public _id_popis_stavka() As Integer
    Public _pop_broj_stavki As Integer
    Public _pop_broj As String
    Public _pop_datum As Date
    Public _pop_id_magacina As Integer
    Public _pop_zakljucen As Boolean
    Public _pop_vrednost As Single
#End Region

#Region "nivelacije"
    Public _id_nivelacije As Integer = 0
    Public _id_nivelacije_st As Integer = 0
    Public _id_nivelacije_stavke() As Integer
    Public _nivelacije_datum As Date
    Public _nivelacije_broj As String
    Public _nivelacije_stara_vrednost As Integer = 0
    Public _nivelacije_nova_vrednost As Single = 0
    Public _nivelacije_razlika_uceni As Single = 0
    Public _nivelacije_stari_iznos_pdv As Single = 0
    Public _nivelacije_novi_iznos_pdv As Single = 0
    Public _nivelacije_razlika_pdv As Single = 0
    Public _nivelacije_unesena As Boolean
    Public _nivelacije_id_magacin As Integer = 0
    Public _nivelacije_id_artikl As Integer = 0
    Public _nivelacije_automatska As Boolean
    Public _nivelacije_vezni_dokument_id As String
    Public _nivelacije_vezni_dokument_broj As String
#End Region

#Region "trebovanje"
    Public _id_trebovanje As Integer = 0
    Public _id_trebovanje_stavka() As Integer
    Public _treb_broj As String
    Public _treb_datum As Date
    Public _treb_id_magacin As Integer = 0
    Public _treb_vrednost As Single = 0
    Public _treb_zakljuceno As Boolean
#End Region

#Region "mip"
    Public _id_mip As Integer = 0
    Public _id_mip_parni As Integer = 0
    Public _id_mip_stavka() As Integer
    Public _id_mip_stavka_parni() As Integer
    Public _mip_broj As Integer = 0
    Public _id_magacina_iz As Integer = 0
    Public _id_magacina_u As Integer = 0
    Public _mip_datum As Date
    Public _mip_opis As String = ""
    Public _mip_ukupno As Single = 0
    Public _mip_ztroskovi As Single = 0
    Public _mip_rabat As Single = 0
    Public _mip_razlika_uceni As Single = 0
    Public _mip_pdv_osnovica As Single = 0
    Public _mip_pdv As Single = 0
    Public _mip_svega As Single = 0
    Public _mip_zakljucena As Boolean
    Public _mip_id_vrsta_dokumenta As Integer = 0
#End Region

#Region "interna dostav"
    Public _id_int_dost As Integer
    Public _int_dost_broj As Integer
    Public _int_dost_id_magacina As Integer
    Public _int_dost_id_dobavljac As Integer
    Public _int_dost_datum_fakture As Date
    Public _int_dost_datum As DateTime
    Public _int_dost_opis As String
    Public _int_dost_ukupno As Single
    Public _int_dost_ztroskovi As Single
    Public _int_dost_rabat As Single
    Public _int_dost_razlika_uceni As Single
    Public _int_dost_pdv_osnovica As Single
    Public _int_dost_pdv As Single
    Public _int_dost_svega As Single
    Public _int_dost_zakljucena As Boolean
    Public _int_dost_id_vrsta_dokumenta As Integer

    Public _id_int_dost_stavka() As Integer
    Public _int_dost_broj_stavki As Integer

    Public _rm_int_dost_pdv_osnovica As Single
    Public _rm_int_dost_pdv As Single

#End Region

#Region "interni prenos"
    Public _id_int_pr As Integer = 0
    Public _id_int_pr_stavka() As Integer
    Public _int_pr_broj As Integer = 0
    Public _int_pr_id_magacina As Integer = 0
    Public _int_pr_datum As Date
    Public _int_pr_opis As String = ""
    Public _int_pr_ukupno As Single = 0
    Public _int_pr_pdv_osnovica As Single = 0
    Public _int_pr_pdv As Single = 0
    Public _int_pr_svega As Single = 0
    Public _int_pr_zakljucena As Boolean
    Public _int_pr_id_vrsta_dokumenta As Integer = 0
#End Region

#Region "virman"
    Public _virman_svrha As String = ""
    Public _virman_poverilac As String = ""
    Public _virman_adresa As String = ""
    Public _virman_sif_placanja As String = ""
    Public _virman_valuta As String = ""
    Public _virman_iznos As Single = 0
    Public _virman_mod_zaduzenje As String = ""
    Public _virman_pnb_zaduzenje As String = ""
    Public _virman_rn_poverilac As String = ""
    Public _virman_mod_odobrenje As String = ""
    Public _virman_pnb_odobrenje As String = ""
    Public _virman_hitno As Boolean
    Public _virmani As Array = Array.CreateInstance(GetType(String), 3, 50)
    Public _virmani_iznos() As Single
    Public _virmani_hitno() As Boolean
#End Region

#Region "nalog za knjizenje"
    Public _id_nalog As Integer = 0
    Public _id_nalog_stavka() As Integer
    Public _id_nalog_storno As Integer = 0
    Public _nal_datum As Date
    Public _nal_vrsta As String = ""
    Public _nal_broj As Integer = 0
    Public _nal_duguje As Single = 0
    Public _nal_potrazuje As Single = 0
    Public _nal_proknjizen As Boolean
    Public _nal_storniran As Boolean
    Public _nal_napomena As String = ""
    Public _nal_st_konto_analitika As String = ""
    Public _nal_st_konto_sintetika As String = ""
    Public _nal_st_opis As String = ""
    Public _nal_st_iznos As Single = 0
    Public _nal_st_strana As String = ""
    Public _nal_st_zatvorena As String = ""
    Public _po_semi As Boolean = False
    Public _nal_print_all As Boolean

    Public _id_nal_stavka As Integer = 0
    Public _stavka_rb As Integer = 0
    Public _stavka_opis_sifra As String = ""
    Public _stavka_opis As String = ""
    Public _stavka_konto As String = ""
    Public _stavka_analitika As String = ""
    Public _stavka_duguje As Single = 0
    Public _stavka_potrazuje As Single = 0
    Public _stavka_brDok As String = ""
    Public _stavka_datDok As String = ""
    Public _stavka_valuta As String = ""
    Public _stavka_zatvorena As Boolean = False

    Public _id_os As Integer = 0
    Public _id_os_stavka() As Integer
    Public _os_red_broj As Integer = 0
    Public _os_konto As String = ""
    Public _os_analitika As String = ""
    Public _os_id_dug As Integer = 0
    Public _os_id_pot As Integer = 0
    Public _os_saldo As Single = 0

#End Region

#Region "virman"
    Public _id_konto As Integer = 0
    Public _konto_Sifra As String = ""
    Public _konto_Godina_Vaznosti_Od As String = ""
    Public _konto_naziv As String = ""
    Public _konto_Dozvoljeno_Knjizenje As Boolean
    Public _konto_Devizno_Knjizenje As Boolean
    Public _konto_Tip_Konta As String = ""
    Public _konto_ima_analitiku As Boolean
    Public _konto_Vrsta_Analitike_Sifra As String = ""
    Public _konto_Vrsta_Subanalitike_Sifra As String = ""
    Public _konto_Vrsta_Mesta_Troska_Sifra As String = ""
    Public _konto_Pocetno_Stanje As Boolean
    Public _konto_Nivo_Pocetnog_Stanja As String = ""
    Public _konto_Nivo_Zatvaranja As String = ""
    Public _konto_Aktiva_Pasiva As String = ""
    Public _konto_Bilansno_Vanbilansno As String = ""
    Public _konto_Vazi_Do As Date
    Public _konto_Ispravke As Boolean
    Public _konto_Pasiviziran As Boolean

    Public _id_sema As Integer = 0
    Public _sema_sifra As String = ""
    Public _sema_naziv As String = ""
    Public _id_sema_stavka() As Integer



#End Region

#Region "izvod"
    Public _id_izvod As Integer
    Public _izvod_broj As String
    Public _izvod_datum As Date
    Public _izvod_svega_duguje As Decimal
    Public _izvod_svega_potrazuje As Decimal
    Public _izvod_stanje As Decimal
    Public _izvod_proknjizen As Boolean
    Public _id_izvod_stavka() As Integer
#End Region

#Region "dnevni promet"
    Public _id_dnevni_promet As Integer = 0
    Public _dp_datum_promene As Date 'datetime
    Public _dp_datum_vreme_promene As Date 'datetime
    Public _dp_id_magacin As Integer = 0
    Public _dp_id_oj As Integer = 0
    Public _dp_id_partnera As Integer = 0
    Public _dp_rb As Integer = 0
    Public _dp_id_vrsta_dok As Integer = 0
    Public _dp_broj_dok As String = ""
    Public _dp_id_dokumenta As Integer = 0
    Public _dp_ukupno_ulaz As Single = 0
    Public _dp_ukupno_izlaz As Single = 0
    Public _dp_ukupno_stanje As Single = 0
    Public _dp_novo_stanje As Boolean
    Public _dp_zakljucen As Boolean

    Public _id_dp_stavka As Integer = 0
    Public _dp_id_artikl As Integer = 0
    Public _dp_art_ulaz As Single = 0
    Public _dp_art_izlaz As Single = 0
    Public _dp_art_stanje As Single = 0
    Public _dp_art_cena As Single = 0
    Public _dp_art_pdv As Single = 0
    Public _dp_suma_ulaz As Single = 0
    Public _dp_suma_izlaz As Single = 0
    Public _dp_suma_stanje As Single = 0
    Public _dp_novo_stanje_stavka As Boolean
#End Region

#End Region

#Region "finansijsko"
    Public _oj As Boolean

    Public _mPanNalog As TableLayoutPanel
    Public _mPanNalog_kontejn As TableLayoutPanel
    Public _mPanNalog_meni As TableLayoutPanel
    Public _mLinkNalog_search As LinkLabel
    Public _mLinkNalog_edit As LinkLabel

    Public _mPanKonta As TableLayoutPanel
    Public _mPanKonta_kontejn As TableLayoutPanel
    Public _mPanKonta_meni As TableLayoutPanel
    Public _mLinkKonta_search As LinkLabel
    Public _mLinkKonta_edit As LinkLabel

    Public _mPanKartice As TableLayoutPanel
    Public _mPanKartice_kontejn As TableLayoutPanel
    Public _mPanKartice_meni As TableLayoutPanel
    Public _mLinkKartice_search As LinkLabel
    Public _mLinkKartice_edit As LinkLabel

    Public _mPanAnalPart As TableLayoutPanel
    Public _mPanAnalPart_kontejn As TableLayoutPanel
    Public _mPanAnalPart_meni As TableLayoutPanel
    Public _mLinkAnalPart_search As LinkLabel

    Public _mPanAnalOstalo As TableLayoutPanel
    Public _mPanAnalOstalo_kontejn As TableLayoutPanel
    Public _mPanAnalOstalo_meni As TableLayoutPanel
    Public _mLinkAnalOstalo_search As LinkLabel

    Public _mPanAlati As TableLayoutPanel
    Public _mPanAlati_kontejn As TableLayoutPanel
    Public _mPanAlati_meni As TableLayoutPanel
    Public _mLinkAlati_search As LinkLabel

#End Region

#Region "proizvodanja"
    Public _mPanSastavnica As TableLayoutPanel
    Public _mPanSastavnica_kontejn As TableLayoutPanel
    Public _mPanSastavnica_meni As TableLayoutPanel
    Public _mLinkSastavnica_search As LinkLabel

    Public _mPanLabDn As TableLayoutPanel
    Public _mPanLabDn_kontejn As TableLayoutPanel
    Public _mPanLabDn_meni As TableLayoutPanel
    Public _mLinkLabDn_search As LinkLabel

    Public _id_sastavnica As Integer
    Public _sas_art_sifra As String = ""
    Public _sas_art_naziv As String = ""
    Public _sas_art_cena As Single = 0
    Public _sas_jm_recept As String = ""
    Public _sas_kolicina As Single = 0
    Public _sas_odobrena As Boolean
    Public _sas_datum_unosa As Date
    Public _sas_datum_prestanka As Date
    Public _sas_ukupno As Single
    Public _sas_vrednost As Single
    Public _sas_radna_taksa As Single = 0
    Public _radna_taksa As Single = 0

    Public _id_sas_stavka() As Integer
    Public _sas_st_rb As String = ""
    Public _sas_st_sifra As String = ""
    Public _sas_st_naziv As String = ""
    Public _sas_st_radna_taksa As Integer
    Public _sas_st_jm As String = ""
    Public _sas_st_kolicina As Single
    Public _sas_st_jm_skladistenja As String = ""
    Public _sas_st_kolicina_skladistenja As Single
    Public _sas_st_cena As Single
    Public _sas_st_vrednist As Single

    Public _id_lab_dn As Integer
    Public _lab_dn_broj As String = ""
    Public _lab_dn_datum_od As Date
    Public _lab_dn_datum As Date
    Public _lab_dn_vred_preparata As Single
    Public _lab_dn_vred_materijala As Single
    Public _lab_dn_radna_taksa As Single
    Public _lab_dn_zakljuen As Boolean

    Public _id_lab_dn_stavka() As Integer
    Public _id_lab_dn_st As Integer
    Public _lab_dn_st_rb As Integer
    Public _lab_dn_st_sifra As String = ""
    Public _lab_dn_st_naziv As String = ""
    Public _lab_dn_st_kolicina As Single
    Public _lab_dn_st_cena As Single
    Public _lab_dn_st_vrednost As Single
    Public _lab_dn_st_rad_taksa As Single

    Public _id_lab_dn_st_ut As Integer
    Public _lab_dn_st_ut_sifra As String = ""
    Public _lab_dn_st_ut_naziv As String = ""
    Public _lab_dn_st_ut_kolicina As Single
    Public _lab_dn_st_ut_kol_sklad As Single
    Public _lab_dn_st_ut_cena As Single
    Public _lab_dn_st_ut_vrednost As Single
    Public _lab_dn_st_ut_rad_taksa As Single

#End Region

    Public mProiz_kontrola As New clsProizvodnja_kontrole

    Public mRob_kontrola As New clsRobno_kontrole
    Public mRob_Dokument As New clsRobno_dokument
    Public _mLabel As Label
    Public _dok_kolone() As String

    Public _mButton As Button
    Public _mCombo As ComboBox
    Public _mLabNaselja As Label
    Public _mTabela As String
    Public _mGrid As DataGridView
    Public _mTableAdapter As System.Data.SqlClient.SqlDataAdapter ' DataSet1.radni_nalog_headDataTable
    Public _mBindingSource As BindingSource
    Public _mDataSet As DataSet ' DataSet1
    Public _mmnuOdlozeno As ToolStripMenuItem
    Public _sql_os As String = ""
    Public _strana As String = ""
    Public _stampa As String = ""

    Public Enum Selekcija
        po_id
        po_sifri
        po_nazivu
        po_oznaci
        _like
    End Enum

    Public Enum Lager
        lager
        popis
        stanje
        trebovanje
    End Enum

    Public Enum vrsta_promene
        unos
        editovanje
        edit_iz_unosa
    End Enum

    Public Enum vrsta_dokumenta
        racun_ulaz = 1
        dostavnica = 2
        interna_dostavnica_ulaz = 3
        kalkulacija = 4
        racun_izlaz = 5
        otptemnica = 6
        interna_dostavnica_izlaz = 7
        recept = 8
        nalog = 9
        nivelacija_cena = 10
        knjizno_odobrenje_ulaz = 11
        knjizno_zaduzenje_ulaz = 12
        povracaj_robe = 13
        knjizno_odobrenje_izlaz = 14
        knjizno_zaduzenje_izlaz = 15
    End Enum

    Public Class Imena

        Enum tabele
            app_gradovi
            app_gradovi_racuni
            app_artikl_grupa
            app_info_co
            app_info_co_banke
            app_info_co_telefoni
            app_jkl
            app_genericko_ime
            app_fo
            app_jm
            app_odlozeno
            app_opstine
            app_opstine_racuni
            app_mesta
            app_naselja
            app_organizacione_jedinice
            app_organizacione_jedinice_detalji
            app_partneri
            app_partneri_kontakt
            app_partneri_kontakt_telefon
            app_partneri_telefon
            app_pdv
            app_vrsta_oj
            app_vrste_dokumenata
            app_vrste_artikla
            app_maticni_podaci
            app_konto
            app_kontni_plan

            fn_izvod_stanje
            fn_izvodi
            fn_izvodi_head
            fn_otvorene_stavke_otv
            fn_otvorene_stavke_zat
            fn_otvorene_stavke_izvod
            fn_otvorene_stavke_saglasnost
            fn_nalog
            fn_nalog_head
            fn_nalog_stavka
            fn_analitika_kumulativ
            fn_analitika_kartica
            fn_analitika_pregled_po_kontima_analitika
            fn_analitika_pregled_po_kontima_sintetika
            fn_kartica_po_analitici
            fn_bruto_bilans
            fn_bruto_bilans_sintetika
            fn_bruto_bilans_analitika
            fn_dnevnik
            fn_glavna_knjiga
            fn_glavna_knjiga_kartica
            fn_sema_za_knjizenje_head
            fn_sema_za_knjizenje_stavka
            fn_sema
            fn_sifre_sema
            fn_putni_nalog
            fn_putni_racun
            fn_putni_racun_ostalo
            fn_putni_racun_prevoz

            rm_dnevni_promet
            rm_dnevni_promet_head
            rm_dnevni_promet_stavka
            rm_artikli
            rm_artikli_cene
            rm_dokumenti

            pr_lab_dn
            pr_lab_dn_head
            pr_lab_dn_prn
            pr_lab_dn_stavka
            pr_lab_dn_stavka_utroseno
            pr_lab_dn_trebovanje
            pr_lab_dn_rekapitulacija

            pr_sastavnica
            pr_sastavnica_head
            pr_sastavnica_prn
            pr_sastavnica_stavka

            rm_ulazni_dokument
            rm_ulazni_dokument_head
            rm_ulazni_dokument_pdv
            rm_ulazni_dokument_prn

            rm_izlazni_dokument
            rm_izlazni_dokument_head
            rm_izlazni_dokument_pdv
            rm_izlazni_dokument_prn

            rm_kalkulacija
            rm_kalkulacija_head
            rm_rm_kalkulacija_pdv
            rm_int_dostav_ulaz
            rm_int_dostav_ulaz_head
            rm_int_dostav_ulaz_pdv
            rm_int_dostav_ulaz_stavka
            rm_knjizno_odobrenje_ulaz
            rm_knjizno_odobrenje_ulaz_head
            rm_knjizno_odobrenje_ulaz_pdv
            rm_knjizno_odobrenje_ulaz_stavka
            rm_knjizno_zaduzenje_ulaz
            rm_knjizno_zaduzenje_ulaz_head
            rm_knjizno_zaduzenje_ulaz_pdv
            rm_knjizno_zaduzenje_ulaz_stavka
            rm_povracaj_robe
            rm_povracaj_robe_head
            rm_povracaj_robe_pdv
            rm_povracaj_robe_stavka
            rm_int_dostav_izlaz
            rm_int_dostav_izlaz_head
            rm_int_dostav_izlaz_pdv
            rm_int_dostav_izlaz_stavka
            rm_knjizno_odobrenje_izlaz
            rm_knjizno_odobrenje_izlaz_head
            rm_knjizno_odobrenje_izlaz_pdv
            rm_knjizno_odobrenje_izlaz_stavka
            rm_knjizno_zaduzenje_izlaz
            rm_knjizno_zaduzenje_izlaz_head
            rm_knjizno_zaduzenje_izlaz_pdv
            rm_knjizno_zaduzenje_izlaz_stavka
            rm_popis
            rm_popis_head
            rm_popis_stavka
            rm_mag_interni_prenos
            rm_mag_interni_prenos_head
            rm_mag_interni_prenos_stavka
            rm_interni_prenos
            rm_interni_prenos_head
            rm_interni_prenos_pdv
            rm_interni_prenos_stavka
            rm_promet_art_detaljno
            rm_promet_art_kumulativ
            rm_promet_mag_stanje
            rm_promet_neslaganje
            rm_specifikacija_ulaz
            rm_specifikacija_izlaz
            rm_specifikacija_lager
            rm_specifikacija_nivelacija
            rm_analiza_ulaz
            rm_analiza_izlaz
            rm_analiza_lager

            rm_kategorizacija
            rm_nivelacije
            rm_nivelacije_head
            rm_magacini
            rm_magacini_popisna_lista
            rm_magacin_promene
            rm_magacini_stanje
            rm_povratnica
            rm_povratnica_head
            rm_predracun
            rm_predracun_head
            rm_predracun_stavka
            rm_racun
            rm_racun_head
            rm_radni_nalog
            rm_radni_nalog_head
            rm_radni_nalog_izvrsioci
            rm_radni_nalog_materijal
            rm_radni_nalog_potvrda
            rm_sifre_placanja
            rm_ulazni_racuni
            rm_ulazni_racuni_head
            rm_vodjenje_zaliha
            rm_vrste_magacina
            rm_trebovanje
            rm_trebovanje_head
            rm_trebovanje_stavke

            promet_kartica
            promet_stanje
            ostali_dokumenti
            virmani
            fin_stanje
            kraj

        End Enum

        Enum panel
            PanArtikli_kontejn
            PanGrupe_kontejn
            PanVrste_kontejn
            PanJKL_kontejn
            PanJM_kontejn
            PanGenerIme_kontejn
            PanPDV_kontejn

            PanArtikli_meni
            PanGenerIme_meni
            PanVrste_meni
            PanJKL_meni
            PanJM_meni
            PanPDV_meni

            PanPartneri_kontejn
            PanMagacini_kontejn
            PanUlazRacuni_kontejn
            PanRacuni_kontejn
            PanTrebovanja_kontejn
            PanKalkulacije_kontejn
            PanRadniNalozi_kontejn
            PanPutNalog_kontejn
            PanVirmani_kontejn
            PanFinansije_kontejn
            PanNivelacije_kontejn

            mTableButtons

            PanKategorije
            PanOdlozeno
            PanPartneri
            PanSifrePlacanja
            PanKontniPlan
            PanSemeZaKnjizenje
            PanPdv
            PanMagacini

            PanNalozi
            PanIzvodi
            PanOStavke
        End Enum

        Enum strana_knjizenja
            duguje
            potrazuje
        End Enum

        Enum vrsta_stampe
            mag_lista
            mag_popisna_lista
            mag_stanje
        End Enum

        Enum naselja
            grad
            opstina
            mesto
        End Enum
    End Class

    Public Property mLista()
        Get
            mLista = _lista
        End Get
        Set(ByVal value)
            value = mLista
        End Set
    End Property

    Public Property mTab(ByVal _mTab)
        Get
            mTab = _mTab
        End Get
        Set(ByVal value)
            _mTab = value
        End Set
    End Property

    Public Property mPanelF(ByVal _mPanelF)
        Get
            mPanelF = _mPanelF
        End Get
        Set(ByVal value)
            _mPanelF = value
        End Set
    End Property

    Public Property mPanelK(ByVal _mPanelK)
        Get
            mPanelK = _mPanelK
        End Get
        Set(ByVal value)
            _mPanelK = value
        End Set
    End Property

    Public Property mTxtHead() As ToolStripTextBox
        Get
            Return _txtHeader
        End Get
        Set(ByVal value As ToolStripTextBox)
            _txtHeader = value
        End Set
    End Property

    'Shared Property mPanGenerIme_meni() As TableLayoutPanel
    '    Get
    '        Return _panGIme_meni
    '    End Get
    '    Set(ByVal value As TableLayoutPanel)
    '        _panGIme_meni = value
    '    End Set
    'End Property

    'Enum BoilingPoints
    '    Celcius = 100
    '    Fahrenheit = 212
    'End Enum 'BoilingPoints

    '<FlagsAttribute()> _
    'Enum Colors
    '    Red = 1
    '    Green = 2
    '    Blue = 4
    '    Yellow = 8
    'End Enum 'Colors

End Module
