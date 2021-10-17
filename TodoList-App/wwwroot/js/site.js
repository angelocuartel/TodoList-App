// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(function () {
    var PlaceholderElement = $('#modal-placeholder');
    $('button[data-toggle="ajax-modal"]').click(function (event) {

      //
  
            $.get($(this).data('url')).done(function (data) {
                PlaceholderElement.html(data);
                PlaceholderElement.find('.modal').modal('show');
            });

        
       
     

    });


});