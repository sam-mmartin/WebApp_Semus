$(function () {
    var ProdutoID;
    $('.detailsPro').click(function () {
        ProdutoID = $(this).attr('name').split('_');
        var stockID = $('#EstoqueID').html().split('-');
        var href = "/Medicament/Edit?id=" + ProdutoID[0] + "&stockID=" + stockID[0];
        $('#editarPro').attr('href', href);
        $('#Availability').html(ProdutoID[1]);
        $('#Section').html(ProdutoID[2]);
        $('#Group').html(ProdutoID[3]);
        $('#FirstSG').html(ProdutoID[4]);
        $('#SecondSG').html(ProdutoID[5]);
        $('#ThirdSG').html(ProdutoID[6]);
        $('#Total').html(ProdutoID[7]);
        $('#Entrada').html(ProdutoID[8]);
        $('#dataEntrada').html(ProdutoID[9]);
        $('#Saida').html(ProdutoID[10]);
        $('#dataSaida').html(ProdutoID[11]);
        $('#user').html(ProdutoID[12]);
    });
});

$(function () {
    $('.detailsPed').click(function () {
        var pedido = $(this).attr('name').split('-');
        $('#idPedidoEstoque').html(pedido[0]);
        $('#estoqueSemus').html(pedido[1]);
        $('#dataEntrada').html(pedido[3]);
        $('#user').html(pedido[5]);

        if (pedido[2] == "1") {
            $('#tipoPedido').html("Medicamentos");
        }
        else {
            $('#tipoPedido').html("Suprimentos");
        }

        if (pedido[4] == "") {
            $('#dataFaturado').html("Em aberto");
        }
        else {
            $('#dataFaturado').html(pedido[4]);
        }
    });
});

$(function () {
    $('.detailsCom').click(function () {
        var compra = $(this).attr('name').split('-');
        $('#idPedidoCompra').html(compra[0]);
        $('#dataEntrada').html(compra[2]);
        $('#user').html(compra[4]);

        if (compra[1] == "1") {
            $('#tipoPedido').html("Medicamentos");
        }
        else {
            $('#tipoPedido').html("Suprimentos");
        }

        if (compra[3] == "") {
            $('#dataFaturado').html("Em aberto");
        }
        else {
            $('#dataFaturado').html(compra[3]);
        }
    });
});


