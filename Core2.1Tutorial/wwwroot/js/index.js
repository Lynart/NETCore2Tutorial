$(document).ready(function () {
    //Javascript is async, so the below will never work because "theForm"
    //doesn't exist yet

    var theForm = document.getElementById("theForm");
    theForm.hidden = true;

    var button = document.getElementById("buyButton");
    button.addEventListener("click", function () {
        alert("Buying Item");
    });

    var theForm = $("#theForm");
    theForm.hide();

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.toggle(1000);
    })

});