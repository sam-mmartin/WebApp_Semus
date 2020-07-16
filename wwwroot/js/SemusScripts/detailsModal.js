$(function () {
    var ProdutoID;
    $('.detailsPro').click(function () {
        ProdutoID = $(this).attr('name').split('_');
        var stockID = $('#EstoqueID').html().split('-');
        var href = "/Medicament/Edit?id=" + ProdutoID[0] + "&stockID=" + stockID[0];
        $('#editarPro').attr('href', href);
        $('#Section').html(ProdutoID[1]);
        $('#Group').html(ProdutoID[2]);
        $('#FirstSG').html(ProdutoID[3]);
        $('#SecondSG').html(ProdutoID[4]);
        $('#ThirdSG').html(ProdutoID[5]);
        $('#Total').html(ProdutoID[6]);
        $('#Entrada').html(ProdutoID[7]);
        $('#dataEntrada').html(ProdutoID[8]);
        $('#Saida').html(ProdutoID[9]);
        $('#dataSaida').html(ProdutoID[10]);
        $('#user').html(ProdutoID[11]);
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


