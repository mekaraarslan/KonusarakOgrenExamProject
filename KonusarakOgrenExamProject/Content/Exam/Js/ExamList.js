function RemoveExam(examId) {
    Swal.fire({
        title: '',
        text: "Sınav kalıcı olarak silinecek. Onaylıyor musunuz?",
        icon: 'question',
        showCancelButton: true,
        cancelButtonText: "Hayır",
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Evet, Sil!'
    }).then((result) => {
        if (result.value) {
            window.location.href = '/Exam/Remove/' + examId;
        }
    })
}