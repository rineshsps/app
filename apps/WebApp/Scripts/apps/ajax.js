$.ajax({
    type: 'get',
    contentType: 'application/json; charset=UTF-8',
    url: 'people',
    success: function (result) {
        var res = JSON.stringify(result);
        $("#value").text(res);
        console.log($("#value").text());
    }
});