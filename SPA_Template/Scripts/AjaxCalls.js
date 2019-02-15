function testAPI(resume) {
    console.log(resume);
    $(".btn-pdf").addClass("btn-pdf-download");
    $.ajax({
        type: "POST",
        url: "/DesktopModules/SPA_Template/API/Resume/Save",
        data: JSON.stringify(resume),
        contentType: "application/json",
        dataType: "json"
    })
        .done(function (response) {
            console.log(response);

            $("body").append(
                "<a id='dl-link' style='display:none' href='" +
                response +
                "' download='resume'>Something</a>"
            );
            document.getElementById("dl-link").click();
            document.getElementById("dl-link").remove();
            $(".btn-pdf-download").addClass("btn-pdf");
            $(".btn-pdf").removeClass("btn-pdf-download");
        })
        .fail(function (response) {
            console.log(response);
        });
}
