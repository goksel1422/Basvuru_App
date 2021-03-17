var sayi = 0;

$("#basvuruVeri").on("click", function () {
    if ($("#BasvuruVeri").text() == "") {
        var url = $("#BasvuruVeri").data("url");
        $.get(url, function (data) {
            $("#BasvuruVeri").html(data);
        });
    }
});

$("#sertifikalar").on("click", function () {
    if ($("#Sertifika").text() == "") {
        var url = $("#Sertifika").data("url");
        $.get(url, function (data) {
            $("#Sertifika").html(data);
        });
    }
});

$("#deneyimler").on("click", function () {
    if ($("#Deneyim").text() == "") {
        var url = $("#Deneyim").data("url");
        $.get(url, function (data) {
            $("#Deneyim").html(data);
        });
    }
});

$("#seminer").on("click", function () {
    if ($("#Seminer").text() == "") {
        var url = $("#Seminer").data("url");
        $.get(url, function (data) {
            $("#Seminer").html(data);
        });
    }
});
$("#proje").on("click", function () {
    if ($("#Proje").text() == "") {
        var url = $("#Proje").data("url");
        $.get(url, function (data) {
            $("#Proje").html(data);
        });
    }
});
$("#yabanciDil").on("click", function () {
    if ($("#YabanciDil").text() == "") {
        var url = $("#YabanciDil").data("url");
        $.get(url, function (data) {
            $("#YabanciDil").html(data);
        });
    }
});
$("#referans").on("click", function () {
    if ($("#Referans").text() == "") {
        var url = $("#Referans").data("url");
        $.get(url, function (data) {
            $("#Referans").html(data);
        });
    }
});