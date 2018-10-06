//$(window).on("load", function () {

//    return $.ajax({
//        url: Url.Action("ProposersRow"),
//        //data: { 'clientRef': clientRef, 'polNo': polNo },
//        type: 'GET',
//        success: function (data) {
//            //Fill div with results

//            $("#uploadPolicyDiv").html(data);
//        },
//        error: function (xhr, status, error) {
//            alert(xhr.responseText);
//        }

//    });
//});





$(document).ready(function () {


    $('#prelimQuestions').on('change', function () {

        if (this.value == "Yes") {
            $("#preliminaryQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#prelimHideButton").click(function () {

        $("#preliminaryQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });


    $('#useOccupancy').on('change', function () {

        if (this.value == "Yes") {
            $("#useOccupancyQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#useOccupancyHideButton").click(function () {

        $("#useOccupancyQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });


    $('#Security').on('change', function () {

        if (this.value == "Yes") {
            $("#securityQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#securityHideButton").click(function () {

        $("#securityQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#Survey').on('change', function () {

        if (this.value == "Yes") {
            $("#surveyQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#surveyHideButton").click(function () {

        $("#surveyQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#od').on('change', function () {

        if (this.value == "Yes") {
            $("#odQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#odHideButton").click(function () {

        $("#odQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#buildingsContent').on('change', function () {

        if (this.value == "Yes") {
            $("#bcQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#bcHideButton").click(function () {

        $("#bcQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#CBprevIns').on('change', function () {

        if (this.value == "Yes") {
            $("#BPIQuestions").show();
            $("#bcQuestions").hide();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#bpiHideButton").click(function () {

        $("#BPIQuestions").hide();
        $("#bcQuestions").show();

    });

    $('#CCprevIns').on('change', function () {

        if (this.value == "Yes") {
            $("#CPIQuestions").show();
            $("#bcQuestions").hide();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#cpiHideButton").click(function () {

        $("#CPIQuestions").hide();
        $("#bcQuestions").show();

    });

    //$('#empDetails').on('change', function () {

    //    if (this.value == "Yes") {
    //        $("#EDQuestions").show();
    //        $("#divOne").hide();
    //        $("#divTwo").hide();
    //        $("#divThree").hide();
    //        $("#divFour").hide();
    //        $(".prelimhide").hide();
    //    } else {
    //        $("#callDate").hide();
    //    }
    //});

    //$("#EDHideButton").click(function () {

    //    $("#EDQuestions").hide();
    //    $("#divOne").show();
    //    $("#divTwo").show();
    //    $("#divThree").show();
    //    $("#divFour").show();
    //    $(".prelimhide").show();

    //});

    //$('#perDetails').on('change', function () {

    //    if (this.value == "Yes") {
    //        $("#PDQuestions").show();
    //        $("#divOne").hide();
    //        $("#divTwo").hide();
    //        $("#divThree").hide();
    //        $("#divFour").hide();
    //        $(".prelimhide").hide();
    //    } else {
    //        $("#callDate").hide();
    //    }
    //});

    //$("#PDHideButton").click(function () {

    //    $("#PDQuestions").hide();
    //    $("#divOne").show();
    //    $("#divTwo").show();
    //    $("#divThree").show();
    //    $("#divFour").show();
    //    $(".prelimhide").show();

    //});

    $('#caravan').on('change', function () {

        if (this.value == "Yes") {
            $("#caravanQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#caravanHideButton").click(function () {

        $("#caravanQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#boat').on('change', function () {

        if (this.value == "Yes") {
            $("#boatQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#boatHideButton").click(function () {

        $("#boatQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });


    $('#allRisks').on('change', function () {

        if (this.value == "Yes") {
            $("#allRisksQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#allRisksHideButton").click(function () {

        $("#allRisksQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#Bicycle').on('change', function () {

        if (this.value == "Yes") {
            $("#bicycleQuestions").show();
            $("#allRisksQuestions").hide();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#bicycleHideButton").click(function () {

        $("#bicycleQuestions").hide();
        $("#allRisksQuestions").show();
        //$("#divOne").show();
        //$("#divTwo").show();
        //$("#divThree").show();
        //$("#divFour").show();
        //$(".prelimhide").show();

    });

    $('#conviction').on('change', function () {

        if (this.value == "Yes") {
            $("#convictionQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#convictionHideButton").click(function () {

        $("#convictionQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#addItem').click(function () {
        $.ajax({
            url: this.href,
            cache: false,
            success: function (html) {
                $('#editorRows').append(html);
            }
        });
        return false;
    });

    $('#addconvItem').click(function () {
        $.ajax({
            url: this.href,
            cache: false,
            success: function (html) {
                $('#convictionRows').append(html);
            }
        });
        return false;
    });

    $('#addclaimsItem').click(function () {
        $.ajax({
            url: this.href,
            cache: false,
            success: function (html) {
                $('#claimsRow').append(html);
            }
        });
        return false;
    });

    $('#addSpecifiedItemsItem').click(function () {
        $.ajax({
            url: this.href,
            cache: false,
            success: function (html) {
                $('#SpecifiedItemsRow').append(html);
            }
        });
        return false;
    });

    $('#claims').on('change', function () {

        if (this.value == "Yes") {
            $("#claimsQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#claimsHideButton").click(function () {

        $("#claimsQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

    $('#specifiedItems').on('change', function () {

        if (this.value == "Yes") {
            $("#specifiedItemsQuestions").show();
            $("#divOne").hide();
            $("#divTwo").hide();
            $("#divThree").hide();
            $("#divFour").hide();
            $(".prelimhide").hide();
        } else {
            $("#callDate").hide();
        }
    });

    $("#specifiedItemsHideButton").click(function () {

        $("#specifiedItemsQuestions").hide();
        $("#divOne").show();
        $("#divTwo").show();
        $("#divThree").show();
        $("#divFour").show();
        $(".prelimhide").show();

    });

});
