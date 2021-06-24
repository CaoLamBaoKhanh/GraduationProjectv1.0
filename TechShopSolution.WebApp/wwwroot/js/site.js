﻿
var SiteController = function () {
    this.initialize = function () {
        regsiterEvents();
        loadCart();
    }
    function loadCart() {
        $.ajax({
            type: "GET",
            url: "/Cart/GetListItems",
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
            }
        });
    }
    function regsiterEvents() {
        // Write your JavaScript code.
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            const idProduct = $(this).data('id');
            $.ajax({
                type: "POST",
                url: '/Cart/AddToCart/' + idProduct,
                success: function (res) {
                    $('#lbl_number_items_header').text(res.length);
                    var x = document.getElementById("snackbar");
                    $('.ReultMessage').text("Thêm vào giỏ hàng thành công");

                    // Add the "show" class to DIV
                    x.className = "show";

                    // After 3 seconds, remove the show class from DIV
                    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
                },
                error: function (err) {
                    console.log(err);
                }
            })
        });
        $('body').on('click', '.btn-buy-now', function (e) {
            e.preventDefault();
            const idProduct = $(this).data('id');
            $.ajax({
                type: "POST",
                url: '/Cart/AddToCart/' + idProduct,
                success: function (res) {
                    $('#lbl_number_items_header').text(res.length);
                    window.location = "/gio-hang";
                },
                error: function (err) {
                    console.log(err);
                }
            })
        });
    }
    
}
