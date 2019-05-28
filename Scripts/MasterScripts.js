$(window).load(function() {
    //$(document).ready(function () {
    var service = new webService(url);
    var intervalId = '';

    $('#btnAdd').click(function() {
        exportToExcel(view.val());
    });
}