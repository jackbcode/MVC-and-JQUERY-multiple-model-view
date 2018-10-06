$(document).ready(function () {
    $("#UploadPolicy").click(function () {

        var clientRef = $('#clientRef').val();
        $("#uploadPolicyDiv").html("Loading...");
        return $.ajax({
            url: '@Url.Action("UploadPolicyDB")',
            data: { 'clientRef': clientRef },
            type: 'GET',
            success: function (result) {
                //print result in new window
                var w = window.open();
                $(w.document.body).html(result);


            });

    });





});