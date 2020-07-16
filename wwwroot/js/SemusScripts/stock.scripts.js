$(function () {
    var count = 0;
    $("#addSubGroup").click(function () {
        count++;
        $.getJSON('/SubGroup/Add?level=' + count, addSubGroupCallBack);
    });

    function addSubGroupCallBack(json) {
        var $subGroup = document.querySelector('#subGroup');
        var cardinal;

        if (count == 1) {
            cardinal = "First";
        } else if (count == 2) {
            cardinal = "Second";
        } else if (count == 3) {
            cardinal == "Third";
        }

        div = "<div class='form-group'>";
        label = "<label class='control-label'>Subgrupo</label>";
        select = "<select id='" + cardinal + "SubGroup' name='" + cardinal + "SubGroup' class='form-control'>";
        option = "";

        $.each(JSON.parse(json), function (key, value) {
            console.log(key);
            option += "<option value='" + value.Description + "'>" + value.Description + "</option>";
        });

        selectClose = "</select>";
        span = "<span class='text-danger field-validation-valid' data-valmsg-for='" + cardinal + "SubGroup' data-valmsg-replace='true'></span>";

        divClose = "</div>";

        HTML = div + label + select + option + selectClose + span + divClose;
        $subGroup.insertAdjacentHTML('beforeend', HTML);
    }
});

$(function () {
    var lista = document.querySelector("#PharmacologicalGroup");

    $("#Section").click(function () {
        var section = $("#Section option:selected").val();
        console.log(section);
        let url = "/Medicament/DynamicList?description=" + section;

        var xhr = new XMLHttpRequest();
        xhr.open("GET", url, true);

        xhr.addEventListener("load", () => {
            if (xhr.status === 200) {
                lista.innerHTML = xhr.responseText;
            }
        });

        setTimeout(() => xhr.send(), 100);
    });
});