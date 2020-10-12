$('.list-group-item').click(function (e) {
    var baseId = "#" + $(this).parent().get(0).id + " a";
    $(baseId).removeClass('active');
    $(this).addClass('active');
});

$('#btnExamControl').click(function () {
    var answers = [];
    var isContinue = true;
    $('.exam .question .list-group').each(function (i) {
        var listId = "#" + $(this).attr('id') + " a";
        $(listId).each(function (i) {
            if ($(this).hasClass('active')) {
                var model = {
                    id: $(this).filter('.active').attr('data-id'),
                    answer: $(this).filter('.active').attr('data-answer')
                };
                answers.push(model);
            }
        });
    });

    if (Object.keys(answers).length != 4) {
        isContinue = false;
    }

    if (isContinue) {
        $('#loader').show();

        var _examId = $('#examId').val();
        $('#btnExamControl').prop('disabled', true);

        $.ajax({
            url: '/Exam/ExamAnswerControl',
            type: 'POST',
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            data: { answerModels: answers, examId: _examId },
            success: function (result) {
                $('#loader').hide();

                $('.exam .question .list-group').each(function (i) {
                    var listId = "#" + $(this).attr('id') + " a";

                    $(listId).each(function (i) {
                        if ($(this).hasClass('active')) {
                            var answerLink = this;
                            var id = $(this).filter('.active').attr('data-id');

                            result.forEach(function (e, a) {
                                if (e.id == id) {
                                    if (e.isCorrectAnswer) {
                                        $(answerLink).css("background-color", "green");
                                        $(answerLink).css("border-color", "green");
                                    }
                                    else {
                                        $(answerLink).css("background-color", "red");
                                        $(answerLink).css("border-color", "red");

                                        var answerGroup = answerLink.closest('div');

                                        for (var i = 0; i < 4; i++) {
                                            if ($(answerGroup).children().get(i).attributes[1].nodeValue == e.correctAnswer) {
                                                //var answer = $($(answerGroup).children().get(i)).attr("data-answer");
                                                $($(answerGroup).children().get(i)).css("border-color", "green").css("background-color", "green").css("color", "white");
                                            }
                                        }
                                    }
                                }
                            });
                        }
                    });
                });

                var count = 3;
                var timer = setInterval(function () {
                    if (count < 0) {

                        if (count == -1) {
                            Swal.fire({
                                title: '',
                                text: "Sınav listesine yönlendirme yapılsın mı?",
                                icon: 'question',
                                showCancelButton: true,
                                cancelButtonText: "Hayır",
                                confirmButtonColor: '#d33',
                                cancelButtonColor: '#3085d6',
                                confirmButtonText: 'Evet, Git!'
                            }).then((result) => {
                                if (result.value) {
                                    location.href = "/Exam/ExamPage";
                                }
                            });
                        }
                    }
                    else {
                        $('#examMessage').html('<div class="alert alert-warning alert-dismissible fade show" role="alert"> <strong>' + count + '</strong> saniye sonra yönlendirme yapılacak. <button type="button" class="close" data-dismiss="alert" aria-label="Close"> <span aria-hidden="true">&times;</span> </button> </div>');
                    }
                    count--;
                }, 1000);
            },
            error: function (hata) {
                $('#loader').hide();
                alert('Beklenmeyen bir hata! Sayfayı yenileyip tekrar deneyiniz.');
            }
        });
    }
    else {
        Swal.fire('Lütfen tüm soruları cevaplayınız.')
    }
});