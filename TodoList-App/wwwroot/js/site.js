﻿






function showModal(urlPath, modalHolder,title) {

    $.get(urlPath, data => {

        $(modalHolder).html(data);
        $(modalHolder).find('.modal').modal('show').find('.modal-title').html(title);
        $.validator.unobtrusive.parse('form');
    })

};


function submitForm() {

    if ($('form').valid()) {
        alert('valid');
    }
}


function InsertData(urlPath) {

    if ($('form').valid()) {

        $.ajax({
            url: urlPath,
            type:'POST',
            data: $('form').serialize(),
            success: data => {

                alert('success');
            }
        });
    }

}