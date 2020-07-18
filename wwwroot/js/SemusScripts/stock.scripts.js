$(function () {
    var select;
    var group;
    let url;
    var level = 0;
    $("#Section").click(function () {
        select = document.querySelector("#PharmacologicalGroup");
        group = $("#Section option:selected").val();
        url = "/Medicament/DynamicList?id=" + group;
        CreateComponentView(url, select);
    });

    $("#PharmacologicalGroup").click(function () {
        level = 1;
        select = document.querySelector("#FirstSubGroup");
        group = $("#PharmacologicalGroup option:selected").val();
        url = "/Medicament/SubDynamicList?level=" + level + "&id=" + group;
        CreateComponentView(url, select);
    });

    $("#FirstSubGroup").click(function () {
        level = 2;
        select = document.querySelector("#SecondSubGroup");
        group = $("#FirstSubGroup option:selected").val();
        url = "/Medicament/SubDynamicList?level=" + level + "&id=" + group;
        CreateComponentView(url, select);
    });

    $("#SecondSubGroup").click(function () {
        level = 3;
        select = document.querySelector("#ThirdSubGroup");
        group = $("#SecondSubGroup option:selected").val();
        url = "/Medicament/SubDynamicList?level=" + level + "&id=" + group;
        CreateComponentView(url, select);
    });
});

function CreateComponentView(url, object) {
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);

    xhr.addEventListener("load", () => {
        if (xhr.status === 200) {
            object.innerHTML = xhr.responseText;
        }
    });

    setTimeout(() => xhr.send(), 100);
}