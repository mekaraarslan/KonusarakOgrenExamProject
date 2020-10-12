$('#Question_Title').change(function () {
    var selectedValue = $('#Question_Title option:selected').attr('data-id');
    $('#loader').show();
    if (selectedValue != '-1') {
        $.ajax({
            url: '/Exam/GetTextContent',
            type: 'POST',
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            data: { id: selectedValue },
            success: function (result) {
                $('#loader').hide();
                $('#Question_Content').val('');
                $('#Question_Content').val(result);
            },
            error: function (hata) {
                $('#loader').hide();
                alert('Beklenmeyen bir hata! Sayfayı yenileyip tekrar deneyiniz.');
            }
        });
    }
});