$(function () {
    var medicament;
    var quantity;
    $("#btnAdd").click(function () {
        quantity = $("#quantity").val();
        if (quantity == "") {
            alert("Informe a quantidade!");
        } else {
            medicament = $("#txtMedicament").val().split('-');
            $.getJSON('/Verifications/MedicamentAvailability?id=' + medicament[0] + '&quantity=' + quantity, medicamentAvailabilityCallBack);
        }
    });
    function medicamentAvailabilityCallBack(json) {
        var $lista = document.querySelector("#listaProdutos");
        var $tableTitle = document.querySelector('#tableTitle');
        var $tableRow = document.querySelector('#tableRows');

        if (json.permitir) {
            if ($tableTitle.childElementCount != 0) {
                $('#infoExcedeu').html("Selecione o produto da lista, indique a quantidade e adicione ao carrinho.");
                $("#tableTitle th").remove();
                $("#tableRows td").remove();
            }
            li = "<li class='list-group-item d-flex justify-content-between lh-condensed'>";
            div = "<div><h6 class='my-0'>" + medicament[1] + "</h6>";
            small = "<small class='text-muted'>";
            input = "<input onclick='desabilitar()' type='checkbox' name='produtos' checked value='" + medicament[0] + "/" + quantity + "'/> ";
            tagFechar = medicament[2] + "</small></div>";
            span = "<span class='text-muted'>" + quantity + "</span></li>"
            HTMLNOVO = li + div + small + input + tagFechar + span;

            $lista.insertAdjacentHTML('afterbegin', HTMLNOVO);
            var contador = parseInt($('#cart_quantidade').html(), 10) + 1;
            $('#cart_quantidade').html(contador)
        } else {
            th = "<th>Descrição</th><th>Quantidade</th>";
            td = "<td>" + json.name + "</td><td>" + json.quantity + "</td>";

            $("#tableTitle th").remove();
            $("#tableRows td").remove();
            $tableTitle.insertAdjacentHTML('afterbegin', th);
            $tableRow.insertAdjacentHTML('afterbegin', td);
            $('#infoExcedeu').html('A quantidade informada excede a quantidade total deste produto no estoque!');
            $('#tableVerificaProduto').show();
        }
    }
});

function desabilitar() {
    $("input[name='produtos']").each(function () {
        $(this).change(function () {
            $(this).closest('li').remove();
        });
    });
    var contador = parseInt($("#cart_quantidade").html(), 10) - 1;
    $('#cart_quantidade').html(contador);
}