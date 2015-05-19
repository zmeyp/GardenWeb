

function populateTag(url, tag) {

    var hashTag = "#" + tag;

    $.get(url)
        .then(function (response) {
            $(hashTag).html(response);
        });

}