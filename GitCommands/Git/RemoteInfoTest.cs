﻿using GitCommands.Git;
using NUnit.Framework;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestContext = System.Object;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;

namespace GitCommandsTest.Git
{
    [TestClass]
    class RemoteInfoTest
    {
        [TestMethod]
        public void GetStringTestSingleLineOutput()
        {
            RemoteInfo remote =
                new RemoteInfo(
                    "* remote origin\n  Fetch URL: ssh://janusz@mikrus/home/git/SITU\n  Push  URL: ssh://janusz@mikrus/home/git/SITU\n  HEAD branch: master\n  Remote branches:\n    101019-kojryz                              tracked\n    AGNIESZKA                                  tracked\n    Analit                                     tracked\n    AutoZapis                                  tracked\n    BGWO                                       tracked\n    CS                                         tracked\n    CzyszczenieHintow                          tracked\n    DB_MetaStrukt                              tracked\n    DowSzkDoZgl                                tracked\n    EkspPrzel                                  tracked\n    FiltrZalacz                                tracked\n    Fix-IR-5-04-07                             tracked\n    Fix-IR-5-06-02                             tracked\n    Fix-IR-5-06-04                             tracked\n    Fix-IR-5-06-09                             tracked\n    GetPolicyTimes                             tracked\n    HEAD_GlowBenef                             tracked\n    HeadGlowBenef                              tracked\n    IR-5-04-04                                 tracked\n    IR-5-04-91                                 tracked\n    IR-DPZ                                     tracked\n    IR-GWAR-FIN                                tracked\n    IR-Prod                                    tracked\n    IR-ProdSrvSync                            tracked\n    IR-Prod-GrupRozRyz                         tracked\n    IR-Prod-korektaPol                         tracked\n    IR-RezWal                                  tracked\n    IR_InterZgloszHist                         tracked\n    JLS-800-001                                tracked\n    JLS-800/001                                tracked\n    KZ-REASSUMA                                tracked\n    LL-WyborAgePos                             tracked\n    MenuDoBazy                                 tracked\n    OptSzk                                     tracked\n    OptymalizacjaDP                            tracked\n    OptymalizacjaDPM1                          tracked\n    OptymalizacjaSzkodM1                       tracked\n    PZM-3W-kody                                tracked\n    PZM-4-05-DPZ                               tracked\n    PZM-Pokaz                                  tracked\n    PZM-Prod                                   tracked\n    PZM-ProdSrvSync                           tracked\n    PZM-Prod-DtKorPol                          tracked\n    PZM-fuzja                                  tracked\n    PZMSRV                                     tracked\n    PgDAC                                      tracked\n    RM-1587                                    tracked\n    RM1522                                     tracked\n    RM1537                                     tracked\n    RM1551                                     tracked\n    RM1553                                     tracked\n    RM1554-PZM                                 tracked\n    RM1570                                     tracked\n    RM1573                                     tracked\n    RM1589                                     tracked\n    RM1595                                     tracked\n    RM1618                                     tracked\n    RM1641                                     tracked\n    RM1644                                     tracked\n    RM1648                                     tracked\n    RM1653                                     tracked\n    RM1656                                     tracked\n    RM1836-pinechyNaSzk                        tracked\n    RM1837-oddWyplacRozliczenie                tracked\n    SzkOkrAnaNoweKol                           tracked\n    UBEZP_KRED_1                               tracked\n    UDZIALY                                    tracked\n    UnUzytSpr                                  tracked\n    UplywTerminNaWejsciu                       tracked\n    UruchomTylko3W                             tracked\n    WyliczPrzyrost                             tracked\n    WystawTest                                 tracked\n    ZgodnoscAnalitNowe                         tracked\n    ak-1700-dane-JLS                           tracked\n    ak-1803-SposPlatn                          tracked\n    ak-1897-filtrKtr                           tracked\n    ak-1912-CzasLSzk                           tracked\n    ak-2104-assercjaNaSpr                      tracked\n    ak-AnulRozlRyzDI                           tracked\n    ak-IR-Prod_AnalitRaport                    tracked\n    ak-IR-anulGrupRyz                          tracked\n    ak-KontaPolis                              tracked\n    ak-ZWROT-automPrzelew                      tracked\n    ak-anulGrupRyz                             tracked\n    ak-memLeak                                 tracked\n    bmtemp                                     tracked\n    controlling-analit                         tracked\n    floty                                      tracked\n    fuzja                                      tracked\n    fuzja-pzm                                  tracked\n    gp-1773-SrvMem                             tracked\n    gp-1787-OzlStat                            tracked\n    gp-1828-IR-KosztyDoPZM                     tracked\n    gp-1828-PZM-KosztyDoPZM                    tracked\n    gp-1858-ProwStawki                         tracked\n    gp-1890-WarProw                            tracked\n    gp-1891-Komornik                           tracked\n    gp-1910-ProwPrac                           tracked\n    gp-1925                                    tracked\n    gp-2097-ProwPracCd                         tracked\n    gp-2155-Monity                             tracked\n    gp-2163-ProwF                              tracked\n    gp-IR-Prod                                 tracked\n    gp-IR-Prod-AgeKonto                        tracked\n    gp-IR-Prod-BOPZM                           tracked\n    gp-IR-Prod-DPZ                             tracked\n    gp-IR-Prod-PZM                             tracked\n    gp-IR-Prod-PobDanAge                       tracked\n    gp-IR-Prod-URT                             tracked\n    gp-IR-bdefix                               tracked\n    gp-IR-rej                                  tracked\n    gp-InkRoz1203                              tracked\n    gp-Nalezn                                  tracked\n    gp-PZM-Prod-BOPZM                          tracked\n    gp-PZM-Prod-ProwDodFix                     tracked\n    gp-PZM-Prod-ie2                            tracked\n    gp-PZMSRV-ie                               tracked\n    gp-PZMSRV-poczekalnia                      tracked\n    gp-PolaczLublin                            tracked\n    gp-ProwDodNNW                              tracked\n    gp-RozRyzWznow                             tracked\n    gp-SPM                                     tracked\n    gp-SrvZmiany                               tracked\n    gp-ZKIRozRyz                               tracked\n    gp-ageblokprow                             tracked\n    gp-autowznowfiltr                          tracked\n    gp-daty                                    tracked\n    gp-datyrat                                 tracked\n    gp-dbupderr                                tracked\n    gp-diav                                    tracked\n    gp-dokudz                                  tracked\n    gp-ds2pola                                 tracked\n    gp-evaldrukhist                            tracked\n    gp-fbs                                     tracked\n    gp-fk                                      tracked\n    gp-fkszab                                  tracked\n    gp-fotex                                   tracked\n    gp-gmt                                     tracked\n    gp-hinty                                   tracked\n    gp-ink20                                   tracked\n    gp-inkroz                                  tracked\n    gp-kred                                    tracked\n    gp-memleak                                 tracked\n    gp-nadz-diff                               tracked\n    gp-ochra-przszk                            tracked\n    gp-ocwznow                                 tracked\n    gp-pekao-spm                               tracked\n    gp-pl-daty                                 tracked\n    gp-prowdod2012                             tracked\n    gp-prowdoduzup                             tracked\n    gp-rdptest                                 tracked\n    gp-reskrypt                                tracked\n    gp-ryzSerial                               tracked\n    gp-temp                                    tracked\n    gp-temp2                                   tracked\n    gp-temp3                                   tracked\n    gp-temp4                                   tracked\n    gp-temp6                                   tracked\n    gp-testdunit                               tracked\n    gp-utozsam                                 tracked\n    gp-wip                                     tracked\n    gp-wu                                      tracked\n    gp-wznowryz                                tracked\n    gp-zestufg                                 tracked\n    gt-master                                  tracked\n    jb-1499-NumPerSes                          tracked\n    jb-ExpUtozsam                              tracked\n    jb-ProfileReas                             tracked\n    jb-Rezerwy                                 tracked\n    jb-Spoldzielnia                            tracked\n    jb/KsiegRozInk                             tracked\n    jb/fixKtr                                  tracked\n    jb00offline                                tracked\n    jb1672-AutoPaczki                          tracked\n    jb1919-ZestRegr                            tracked\n    jbAVTrace                                  tracked\n    jbBlokDPMO                                 tracked\n    jbCienkiOperator                           tracked\n    jbCienkiOperatorPZM                        tracked\n    jbCzasKompilacji                           tracked\n    jbDelSzk2W                                 tracked\n    jbDokumRepo                                tracked\n    jbLeniwePolaczenie                         tracked\n    jbMTM                                      tracked\n    jbMemLeak                                  tracked\n    jbNumBlokSes                               tracked\n    jbObligoOstrz                              tracked\n    jbPolWystWOkr                              tracked\n    jbPrawaDost                                tracked\n    jbProfileReasProd                          tracked\n    jbProfileSrednie                           tracked\n    jbPrzekazSzkoda                            tracked\n    jbPustyLikwid                              tracked\n    jbRevIdx                                   tracked\n    jbRezSzk                                   tracked\n    jbRyzUzyt                                  tracked\n    jbSAK                                      tracked\n    jbSitSrvRunner                             tracked\n    jbSzkUFG                                   tracked\n    jbUfg                                      tracked\n    jbUsunRaport                               tracked\n    jbUzgPZM                                   tracked\n    jbWyciagKB                                 tracked\n    jbZestCC                                   tracked\n    jbZglSprawcy                               tracked\n    jbZgloszDrugaPoz                           tracked\n    jbZmianaRyzSzk                             tracked\n    klasyfikacje_klucza_statystycznego         tracked\n    klasyfikacje_kluczy_stat_PZM               tracked\n    kojRyz-next                                tracked\n    kojryz-test                                tracked\n    kontrolaOC_Komunik                         tracked\n    korektaPol                                 tracked\n    ksieg_opt                                  tracked\n    ktrPojNier_podnies7                        tracked\n    ktrPojNier_podnies8                        tracked\n    kz-ufg-blady                               tracked\n    last_sql_queue                             tracked\n    ll-2014-UlatwKsieg                         tracked\n    ll-Assistance                              tracked\n    ll-DGL                                     tracked\n    ll-DGL-RyzWal                              tracked\n    ll-DGLFix                                  tracked\n    ll-DGLOstrzIgnor                           tracked\n    ll-DPPolRozl                               tracked\n    ll-DrukZawlaszcz                           tracked\n    ll-DrukiOddzialy                           tracked\n    ll-GRR-dtBrakOdp                           tracked\n    ll-GRR-poprKoszManip                       tracked\n    ll-GRR-poprawaKosztManip                   tracked\n    ll-GRR-poprawaNumerowania                  tracked\n    ll-GRR-zapisUnPolisyAneksowej              tracked\n    ll-GRRDataWyst                             tracked\n    ll-GRRDataWystawienia                      tracked\n    ll-GRRDtWystawienia                        tracked\n    ll-GRRSzkodyWRozl                          tracked\n    ll-GRRUbcy                                 tracked\n    ll-GRRWycieki                              tracked\n    ll-GenAnalit_na_3W                         tracked\n    ll-GrupSklad                               tracked\n    ll-HistOper                                tracked\n    ll-IRProd-GRR                              tracked\n    ll-IRProdPracPrzycz                        tracked\n    ll-JednoRyzNaPoj                           tracked\n    ll-KolLacznieRozRyz                        tracked\n    ll-KontrolaZglosz                          tracked\n    ll-KtrNaPol                                tracked\n    ll-ObligoNaPoz                             tracked\n    ll-OkresRyzRozlZdaSzk                      tracked\n    ll-Oper-Posr2                              tracked\n    ll-PZMDokSprzed                            tracked\n    ll-PZMSRV-PojazdRej                        tracked\n    ll-PZMSRV-WD                               tracked\n    ll-PZMSRV_WystDopr                         tracked\n    ll-PZM_Przekod                             tracked\n    ll-PojazdRej                               tracked\n    ll-PolRejPodobneBlad                       tracked\n    ll-PorowKsieAnalit                         tracked\n    ll-PrawaDost_RaportOper                    tracked\n    ll-PrzyczPracow                            tracked\n    ll-RM1661-GrupRyz                          tracked\n    ll-RM1690-Bledy                            tracked\n    ll-RM1746                                  tracked\n    ll-RM1758                                  tracked\n    ll-RM1776                                  tracked\n    ll-RM1793                                  tracked\n    ll-RM1938-operBlok                         tracked\n    ll-RM1957-Rezerwy                          tracked\n    ll-RM1962-SzkZlikw                         tracked\n    ll-RM1975-AnalizaPolis                     tracked\n    ll-RM1975-PoprAnalizaPolis                 tracked\n    ll-RM2001-Videotel                         tracked\n    ll-RM2069-MemLeak                          tracked\n    ll-RM2091-KodPocztNier                     tracked\n    ll-RM2131-ControllingAnalit                tracked\n    ll-RM2145-BlankietPrzel                    tracked\n    ll-RM2150-SkryptRoznice                    tracked\n    ll-RM2153-ProwFakWydr                      tracked\n    ll-RM2153-ProwFaktWydr                     tracked\n    ll-RM2170-TermPlatn                        tracked\n    ll-RRMO-RDP                                tracked\n    ll-RapOper                                 tracked\n    ll-RaportOperat2                           tracked\n    ll-RezKosztLikw                            tracked\n    ll-RozKomunikat                            tracked\n    ll-RozRyzGwar                              tracked\n    ll-RozlRyzMO                               tracked\n    ll-RyzNaDzien                              tracked\n    ll-SwRent_DaneWyplat                       tracked\n    ll-SzkoRezKoszLikw                         tracked\n    ll-SzkodaInfoGrid                          tracked\n    ll-SzkodaInfo_IRProd_Pzm                   tracked\n    ll-TerminyPlatnosci                        tracked\n    ll-TestCapsule                             tracked\n    ll-TestObjDokum                            tracked\n    ll-WyborSrv                                tracked\n    ll-Wyciek                                  tracked\n    ll-WydrProwDod                             tracked\n    ll-WydrukiAgencji                          tracked\n    ll-WystDopr                                tracked\n    ll-ZOPy_Nieoplac                           tracked\n    ll-ZmianaLikw                              tracked\n    ll-ZmianaLikwGrp                           tracked\n    ll-bledySzkDecDGL                          tracked\n    ll-blokadaDokEwid                          tracked\n    ll-filtrPojazdow                           tracked\n    ll-kolejnoscDokProw                        tracked\n    ll-maxLpPoczKoncDGL                        tracked\n    ll-naliczAmor                              tracked\n    ll-podzial-unitTest                        tracked\n    ll-polDokBlady                             tracked\n    ll-powtPrzedmUbez                          tracked\n    ll-powtRyz                                 tracked\n    ll-przedmUsun                              tracked\n    ll-ufgTestForm                             tracked\n    ll-wybIni                                  tracked\n    ll-wybProdCombo                            tracked\n    ll-zerowyOkresGrr                          tracked\n    ll-zestDefPosumowania                      tracked\n    ll-zopy-nieoplac                           tracked\n    master                                     tracked\n    mm-CzynneWgSkl                             tracked\n    mm-ErrRptSaveDb                            tracked\n    mm-IR-Prod-BrokenBuild                     tracked\n    mm-MasZmOszac                              tracked\n    mm-PlacMedKontaktRola                      tracked\n    mm-PuDodajUczPolInnegoOdd                  tracked\n    mm-SpmPulaZakres                           tracked\n    mm-SumaMaxSzkWOkr                          tracked\n    mm-SzkodaAutoKoszt                         tracked\n    mm-SzkodaAutoKoszt2                        tracked\n    mm-SzkodyBrakDokum                         tracked\n    mm-UmGwKolLimity                           tracked\n    mm-ZaangazStareMO                          tracked\n    mm-ZwrotyOdszkod                           tracked\n    mm-med-fix                                 tracked\n    mm-wydruki-rtf                             tracked\n    mm-wydruki-rtf-2                           tracked\n    mm-zaangaz_na_gk                           tracked\n    mm_except                                  tracked\n    monit_opt                                  tracked\n    normalizacja_numeru_konta                  tracked\n    ochra-lpoperator                           tracked\n    ochra-zalnotspr                            tracked\n    ochra-zglint-12                            tracked\n    optymalizacja_koj_wb                       tracked\n    optymalizacja_prowdod                      tracked\n    pl-100826-edpol                            tracked\n    pl-100906-ewiddroper                       tracked\n    pl-100907-floty                            tracked\n    pl-100908-optzop                           tracked\n    pl-100928-odmbrakdok                       tracked\n    pl-101004-sprznalez                        tracked\n    pl-101019-grpedryz                         tracked\n    pl-1719-SzukTeczki                         tracked\n    pl-AktKtrSzk                               tracked\n    pl-KtrAgePosr                              tracked\n    pl-KtrKorespIR                             tracked\n    pl-NietypoweRaty                           tracked\n    pl-PrawaDoLogowania                        tracked\n    pl-SpoldzielniaSlowniki                    tracked\n    pl-UFG-OC-AC                               tracked\n    pl-VideotelWybor                           tracked\n    pl-WybRyzOpen                              tracked\n    pl-ZapytaniaZdalne                         tracked\n    pl-analitimporttask                        tracked\n    pl-autowyplata                             tracked\n    pl-blokOzlZglSzkAuto                       tracked\n    pl-daty                                    tracked\n    pl-dokdostzu                               tracked\n    pl-dpzframe                                tracked\n    pl-filtrzgl                                tracked\n    pl-grpedryz                                tracked\n    pl-grupowanieocac                          tracked\n    pl-infoexpert                              tracked\n    pl-infoexpert-pzm                          tracked\n    pl-infoexpert-pzmsrv                       tracked\n    pl-infoexpert-s1                           tracked\n    pl-kdzwyzka                                tracked\n    pl-lpktrpoj                                tracked\n    pl-lpktrpoj2                               tracked\n    pl-paramOCK                                tracked\n    pl-parametry                               tracked\n    pl-polana30                                tracked\n    pl-policja                                 tracked\n    pl-printpolinr                             tracked\n    pl-przekazyKodP                            tracked\n    pl-saknowedow                              tracked\n    pl-videotele                               tracked\n    pl-wu                                      tracked\n    pl-zalacznik                               tracked\n    plOdbiorcaOdszkodowania                    tracked\n    plZestDefNadz                              tracked\n    platnosciWWalucie                          tracked\n    powiazaniePojazdu                          tracked\n    pu_wczytaje_koniec                         tracked\n    re-nowa-reas                               tracked\n    re-nowa-reas-rach                          tracked\n    re-nowa-reas-umowa                         tracked\n    refs/remotes/origin/FIX-5-06-12            stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-IR-5-04-00         stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-IR-5-04-01         stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-IR-5-04-91         stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-IR-5-06-06         stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-PZM-4-07-13        stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-PZM-4-09-00        stale (use 'git remote prune' to remove)\n    refs/remotes/origin/FIX-PZM-5-07-13        stale (use 'git remote prune' to remove)\n    refs/remotes/origin/IR-Prod-Fix            stale (use 'git remote prune' to remove)\n    refs/remotes/origin/PZM-FIX-4-09-02        stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-1823                stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-1873-SysSladAkt     stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-1886-ZestOper       stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-1910-ProwPracCd     stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-1927-InspOper       stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-2078-KursyWalut     stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-IR-Prod-BlokMO      stale (use 'git remote prune' to remove)\n    refs/remotes/origin/gp-SPM-Prod            stale (use 'git remote prune' to remove)\n    refs/remotes/origin/plNaleznosci           stale (use 'git remote prune' to remove)\n    rk-4-06-00-15                              tracked\n    rk-Ewid201                                 tracked\n    rk-KontrolaAge                             tracked\n    rk-KtrAdres                                tracked\n    rk-MainMenuAkwiz                           tracked\n    rk-RozlRyzMO                               tracked\n    rk-Test-IR-5-06-03-04                      tracked\n    rk-VideotelNrRej                           tracked\n    rk-form-ksie-pzm                           tracked\n    rk-ocena-oc-ac                             tracked\n    rk-podum-prow                              tracked\n    rk-sortwydrser                             tracked\n    rk-tak-tak                                 tracked\n    rk-taryfa-oc-ac                            tracked\n    rkAgeZest                                  tracked\n    rkAktOsobaPU                               tracked\n    rkEksportPU                                tracked\n    rkKontrolaPrzedm                           tracked\n    rkKorektaAutoKoszt                         tracked\n    rkPowodKorPol                              tracked\n    rkShowKtrMenu                              tracked\n    rkSzkodyZlikw                              tracked\n    rm-LimityProwForm                          tracked\n    rm-newProfil                               tracked\n    showDP3W                                   tracked\n    situ-2-6-06                                tracked\n    situ-2-7-02                                tracked\n    tw-3Ddziel                                 tracked\n    tw-BlobyWyciagow                           tracked\n    tw-WyplatyFaktorPlusCol                    tracked\n    tw-alokacja2                               tracked\n    tw-alokacjaKosztówAdm                     tracked\n    tw_ErrDlgOnPrintScr                        tracked\n    tw_ErrDlgOnPrintScr_PZM                    tracked\n    tw_KojWyciagBank                           tracked\n    tw_KtrPojNier_podnies6                     tracked\n    tw_dodatkowe_sprawdzenia_pojazdu_na_ryzyku tracked\n    tw_eksport_danych_agencji                  tracked\n    tw_eksport_danych_agencji_IR               tracked\n    tw_eksport_danych_agencji_PZM              tracked\n    tw_eksport_danych_agentow                  tracked\n    tw_ir_integracja_z_redmine                 tracked\n    tw_ktrPojNierFix_PodniesBaze               tracked\n    tw_main_menu_zestawienia_ogolne            tracked\n    tw_prowSegm                                tracked\n    tw_prowSegm2                               tracked\n    tw_pzm_integracja_z_redmine                tracked\n    tw_rozpisywanie_wykazow                    tracked\n    tw_strukturabazy                           tracked\n    tw_testktrpojnier                          tracked\n    tw_umUbezpKtr_podnies                      tracked\n    tw_zatwierdznie_wyciagow_main_menu         tracked\n    tw_zestawienie_UdzialWRezerwach            tracked\n    umbra                                      tracked\n    wrat_nazwa_rach                            tracked\n    wyciagi_bankowe_IR                         tracked\n    xjMainMenu                                 tracked\n    zatwierdzanie_wyciagow                     tracked\n    zatwierdzanie_wyciagow_bankowych           tracked\n    zestawienia_definiowalne                   tracked\n  Local branches configured for 'git pull':\n    DowSzkDoZgl         merges with remote origin/DowSzkDoZgl\n    IR-Prod             merges with remote IR-Prod\n    IR-ProdSrvSync     merges with remote IR-ProdSrvSync\n    RM1656              merges with remote RM1656\n    RM1836-pinechyNaSzk merges with remote RM1836-pinechyNaSzk\n    UruchomTylko3W      merges with remote UruchomTylko3W\n    gp-temp             merges with remote gp-temp\n    jb/KsiegRozInk      merges with remote jb/KsiegRozInk\n    jbNumBlokSes        merges with remote jbNumBlokSes\n    kz-ufg-blady        merges with remote kz-ufg-blady\n    pl-dokdostzu        merges with remote pl-dokdostzu\n    re-nowa-reas        merges with remote re-nowa-reas\n  Local refs configured for 'git push':\n    DowSzkDoZgl         pushes to DowSzkDoZgl         (up to date)\n    IR-Prod             pushes to IR-Prod             (local out of date)\n    IR-ProdSrvSync     pushes to IR-ProdSrvSync     (local out of date)\n    RM1656              pushes to RM1656              (fast-forwardable)\n    RM1836-pinechyNaSzk pushes to RM1836-pinechyNaSzk (up to date)\n    UruchomTylko3W      pushes to UruchomTylko3W      (up to date)\n    gp-temp             pushes to gp-temp             (local out of date)\n    jb-ExpUtozsam       pushes to jb-ExpUtozsam       (up to date)\n    jb/KsiegRozInk      pushes to jb/KsiegRozInk      (up to date)\n    jbNumBlokSes        pushes to jbNumBlokSes        (local out of date)\n    kz-ufg-blady        pushes to kz-ufg-blady        (local out of date)\n    pl-dokdostzu        pushes to pl-dokdostzu        (fast-forwardable)\n    re-nowa-reas        pushes to re-nowa-reas        (local out of date)\n");
            Assert.Pass("boomshakalaka");
        }
    }
}
