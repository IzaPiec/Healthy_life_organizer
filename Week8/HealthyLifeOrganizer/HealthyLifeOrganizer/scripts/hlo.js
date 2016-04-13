
$(function () {
    $("#datepicker").datepicker();

    $('#gotomeasurementsbtn').click(function () {
        window.location.href = '/Measurements/Index';
    });
    //Clicks for Navigation items
    $('#dashboard').click(function () {
        console.log("navigation works");
        window.location.href = '/Home/Index';
        return false;
    });

});