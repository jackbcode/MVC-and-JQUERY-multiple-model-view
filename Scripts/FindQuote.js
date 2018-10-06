$(document).ready(function () {
    $("#UploadQuote").click(function () {

        var clientRef = $('#clientRef').val();
        $("#uploadQuoteDiv").html("Loading...");
        return $.ajax({
            url: '@Url.Action("UploadQuoteDB")',
            data: { 'clientRef': clientRef },
            type: 'GET',
            success: function (result) {
                //print result in new window
                var w = window.open();
                $(w.document.body).html(result);


            });

    });





});
