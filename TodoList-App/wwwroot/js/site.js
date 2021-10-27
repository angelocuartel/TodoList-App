


function showModal(urlPath, modalHolder,title,dataObject) {
   
    $.ajax({
        url: urlPath,
        type: 'GET',
        data: dataObject,
        success: partialView => {
            $(modalHolder).html('').html(partialView);
            $(modalHolder).find('.modal').modal('show').find('.modal-title').html(title);
            $.validator.unobtrusive.parse('form');
        }
    });


}


function InsertData(urlPath) {


    if ($('form').valid()) {

        $.ajax({
            url: urlPath,
            type: 'POST',
            data: $('form').serialize(),
            success: returnedJson => {

                $('.modal').modal('hide');


                if (!returnedJson.includes(`<div class ="modal fade"`)) {

                   
                    loadTable(returnedJson, '#table-holder');

                    $('.toast-container').append($('.toast').toast('show'));

                }

                else {
                    $('#modal-placeholder').html('').html(returnedJson);
                    $('#modal-placeholder').find('.modal').modal('show');
                }
            }
        });
    }
    

}

function loadTable(data,tableId) {
    $(tableId).html('').html(data);
}


function deleteItem(urlPath) {
    var value = $('#model-id').val();
    $.ajax({
        url: urlPath,
        type: 'POST',
        datatype:'json',
        data: { id: value},
        success: returnedJson => {

            $('.modal').modal('hide');
            loadTable(returnedJson, '#table-holder');
            $('.toast-container').append($('.toast').toast('show'));
        }
    });
}











