
var sertifikalar = [];
var sem_kurs = [];
var referanslar = [];
var deneyim = [];
var byabancidil = [];
var projeler = [];
var basvurular = {
    "sertifikalar": sertifikalar,
    "sem_kurs": sem_kurs,
    "referanslar": referanslar,
    "deneyim": deneyim,
    "byabancidil": byabancidil,
    "projeler": projeler,
    "BOnYazi": "",
    "Hobiler": "",
    "MeslekID": "",
    "AskerliID": "",
    "bolum_id": "",
    "Ucret_Beklenti": "",
    "TCalSure": "",
    "KID": "",
}



$("#Post").on("click", function () {
    basvurular.BOnYazi = $("#onYazi").val();
    basvurular.Hobiler = $("#hobiler").val();
    basvurular.MeslekID = $("#BmeslekId").val();
    basvurular.AskerliID = $("#askerlik").val();
    basvurular.bolum_id = $("#bolumler").val();
    basvurular.Ucret_Beklenti = $("#range_1").val();
    basvurular.TCalSure = $("#range_2").val();
    basvurular.KID = $("#kisiler").val();
    $('#sertifikaTablo').children(".tablo").each(function (index) {
        sertifikalar[index] = {
            "SertifikaAdi": $(this).children(".sertifikaAdi").text(),
            "Alindigi_Kurum": $(this).children(".alindigiKurum").text(),
            "AlimTar": $(this).children(".alimTarihi").text(),
        };

    });
    $('#seminerTablo').children(".tablo").each(function (index) {
        sem_kurs[index] = {
            "EgitimAdi": $(this).children(".seminerAdi").text(),
            "Egitim_Kurumu": $(this).children(".egitimKurum").text(),
            "Egitmen_Adi": $(this).children(".egitmenAdi").text(),
            "Egitmen_Soyadi": $(this).children(".egitmenSoyAdi").text(),
            "Bas_Tar": $(this).children(".baslamaTarihi").text(),
            "Bitis_Tar": $(this).children(".bitisTarihi").text(),
        };
    });

    $('#referansTablo').children(".tablo").each(function (index) {
        referanslar[index] = {
            "RefAdi": $(this).children(".referansAdi").text(),
            "RefSoyad": $(this).children(".referanSoyad").text(),
            "RefMail": $(this).children(".referansMail").text(),
            "RefTel": $(this).children(".referansTel").text(),
        };
    });

    $('#deneyimTablo').children(".tablo").each(function (index) {
        deneyim[index] = {
            "FirmaAdi": $(this).children(".deneyimKurum").text(),
            "BaslamaTar": $(this).children(".baslamaTarihi").text(),
            "IlID": $(this).children(".deneyimYeriVal").text(),
            "MeslekID": $(this).children(".meslekVal").text(),
            "BitisTar": $(this).children(".bitisTarihi").text(),
            "IsTanimi": $(this).children(".isTanimi").text(),
        };
    });

    $('#yabanciDilTablo').children(".tablo").each(function (index) {
        byabancidil[index] = {
            "DilID": $(this).children(".dilAdiVal").text(),
            "BasSeviyeID": $(this).children(".dilSeviyesiVal").text(),
        };
    });

    $('#projeTablo').children(".tablo").each(function (index) {
        projeler[index] = {
            "ProjeAdi": $(this).children(".projeAdi").text(),
            "Proje_Aciklama": $(this).children(".projeAciklamasi").text(),
        };
    });
    debugger;

    $.ajax({
        type: "POST",
        url: '/Kullanici/YeniBasvuruEkle',
        data: { b1: basvurular },
        dataType: "json",

        success: function (result) {
            console.log(result);
        },
        error: function (xhr, ajaxOptions, thrownError) {
        }
    });

});