
$(function () {
    $("#datepicker").datepicker({
        dateFormat: "dd/mm/yy"
    });

    $('#gotomeasurementsbtn').click(function () {
       window.location.href = '/Measurements/Index';
    });
    //Clicks for Navigation items
    $('#dashboard').click(function () {
        window.location.href = '/Home/Index';
        return false;
    });

});