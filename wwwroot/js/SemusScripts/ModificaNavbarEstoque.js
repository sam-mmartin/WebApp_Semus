$(function () {
    $('#Medicamentos').click(function () {
        var estoqueID = $('#EstoqueID').html().split('-');
        var href = "/Medicament/Index?stockID=" + estoqueID[0];
        $('#Medicamentos').attr('href', href);
    });

    $('#Orders').click(function () {
        var estoqueID = $('#EstoqueID').html().split('-');
        var href = "/Order/Index?stockID=" + estoqueID[0];
        $('#Orders').attr('href', href);
    });

    $('#novoPedido1').click(function () {
        var estoqueID = $('#EstoqueID').html().split('-');
        var href = "/PedidoEstoque/Create?estoqueID=" + estoqueID[0] + "&TipoProduto=1";
        $('#novoPedido1').attr('href', href);
    });

    $('#novoPedido2').click(function () {
        var estoqueID = $('#EstoqueID').html().split('-');
        var href = "/PedidoEstoque/Create?estoqueID=" + estoqueID[0] + "&TipoProduto=2";
        $('#novoPedido2').attr('href', href);
    });

    $('#compras1').click(function () {
        var href = "/PedidoCompra/Index?tipoProduto=1";
        $('#compras1').attr('href', href);
    });

    $('#compras2').click(function () {
        var href = "/PedidoCompra/Index?tipoProduto=2";
        $('#compras2').attr('href', href);
    });

    $('#novaCompras1').click(function () {
        var href = "/PedidoCompra/Create?tipoProduto=1";
        $('#novaCompras1').attr('href', href);
    })

    $('#novaCompras2').click(function () {
        var href = "/PedidoCompra/Create?tipoProduto=2";
        $('#novaCompras2').attr('href', href);
    })

    $('#FaturarPedido').click(function () {
        $('#FaturarPedido').attr('data-toggle', 'modal');
        $('#FaturarPedido').attr('data-target', '#ModalFaturarPedido');
        $("#ModalFaturarPedido form").attr('action', '/PedidoEstoque/Details');
        $("#ModalFaturarPedido form").attr('method', 'post');
    });
});

