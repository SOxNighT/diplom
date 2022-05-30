
window.onscroll = function () {
    scrollFunction();
    console.log(document.documentElement.scrollTop);
};

function scrollFunction() {
    if (
        document.documentElement.scrollTop > 200
    ) {
        $("#scroll-up").css({
            "top": Math.floor(document.documentElement.clientHeight * 0.9),
            "left": Math.floor(document.documentElement.clientWidth * 0.1)
        }).show();
    } else {
        $('#scroll-up').hide();
    }
}


function backToTop() {
    const offsetPosition =  -document.documentElement.scrollTop;
    window.scrollBy({
        top: offsetPosition,
        behavior: 'smooth'
    });
}


var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
    return new bootstrap.Popover(popoverTriggerEl)
})

