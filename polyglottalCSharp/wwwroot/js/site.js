// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function() {
    console.log( "ready!" );
    zoomin(50, 3, 1100);
});

function zoomin(interval, sizeChangeEveryInterval, stopResizeWhenSizeReached){
    var timeout = setInterval(function(){
        var target = $(".zoom-in")
        var bgposx = target.css('background-position-x') ? parseInt(target.css('background-position-x')) : 0;
        target.css('background-position-x',(bgposx - sizeChangeEveryInterval) + "px");
        var bgposy = target.css('background-position-y') ? parseInt(target.css('background-position-y')) : 0;
        target.css('background-position-y',(bgposy - sizeChangeEveryInterval) + "px");
        var bgsize = !isNaN(parseInt(target.css('background-size'))) ? parseInt(target.css('background-size')) : 100;
        target.css('background-size',(bgsize + sizeChangeEveryInterval) + "px");
        if(stopResizeWhenSizeReached < bgsize) clearInterval(timeout)
    }, interval)
}