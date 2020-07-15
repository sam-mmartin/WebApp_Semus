$(function () {
    var count = 0;
    var second = 0;
    var third = 0
    $("#addSubGroup").click(function () {
        count += 1;
        var cardinal;
        var $indice = document.querySelector('#subGroupID');
        var $names = document.querySelector('#subGroupForms');

        if (count == 1) {
            cardinal = "First";
            input = "<input asp-for='" + cardinal + "SubGroup' class='form-control' value='"
                + $("input[name='ID']").val()
                + "."
                + count + "' />";
        } else if (count == 2) {
            cardinal = "Second";
            second += 1;
            input = "<input asp-for='" + cardinal + "SubGroup' class='form-control' value='"
                + $("input[name='ID']").val()
                + "." + second
                + "." + count
                + "' />";
        } else {
            cardinal = "Third";
            third += 1;
            input = "<input asp-for='" + cardinal + "SubGroup' class='form-control' value='"
                + $("input[name='ID']").val()
                + "." + third
                + "." + second
                + "." + count
                + "' />";
        }

        div = "<div class='form-group'>";
        label = "<label class='control-label'>Indice</label > "
        span = "<span asp-validation-for='" + cardinal + "SubGroup' class='text-danger'></span>";
        close = "</div>";
        HTMLNOVO = div + label + input + span + close;

        $indice.insertAdjacentHTML('afterbegin', HTMLNOVO);

        div = "<div class='form-group'>";
        label = "<label class='control-label'>Subgrupo " + count + "</label > ";
        input = "<input asp-for='" + cardinal + "SubGroupName' class='form-control' />";
        span = "<span asp-validation-for='" + cardinal + "SubGroupName' class='text-danger'></span>";
        close = "</div>";
        HTMLNOVO = div + label + input + span + close;

        $names.insertAdjacentHTML('afterbegin', HTMLNOVO);
    });
});