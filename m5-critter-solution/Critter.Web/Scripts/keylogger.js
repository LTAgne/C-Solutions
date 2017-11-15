$(document).ready(function (event) {
    
    $("body").keypress(function (event) {        
        console.log(String.fromCharCode(event.keyCode));
    });
});