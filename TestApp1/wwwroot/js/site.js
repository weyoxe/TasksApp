$(document).ready(function () {
    $('#Tasks').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true,
        columns: [
                null,
                null,
                null,
                null,
                null,
                { orderable: false },
            ]
    });
});