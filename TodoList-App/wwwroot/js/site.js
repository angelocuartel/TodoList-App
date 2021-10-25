






function showModal(urlPath, modalHolder) {

    $.get(urlPath, data => {

        $(modalHolder).html(data);
        $(modalHolder).find('.modal').modal('show');
        $.validator.unobtrusive.parse('form');
    })

};


function submitForm() {
    alert('valid');
    if ($('form').valid()) {
        alert('valid');
    }
}
