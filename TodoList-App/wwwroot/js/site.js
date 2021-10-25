function showModal(urlPath, modalHolder) {

    $.get(urlPath, data => {

        $(modalHolder).html(data);
        $(modalHolder).find('.modal').modal('show');
    })

    };
