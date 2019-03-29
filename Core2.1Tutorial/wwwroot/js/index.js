//Javascript is async, so the below will never work because "theForm"
//doesn't exist yet

var theForm = document.getElementById("theForm");
theForm.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    alert("Buying Item");
});