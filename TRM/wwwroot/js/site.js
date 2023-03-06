$(".availseats").each(function () {
        var a = $(this).text();
    var b = parseInt(a);
    if (b == 0)
    {
        $(this).css("background-color", "red");
        $(this).html("Seats filled");
    }
});