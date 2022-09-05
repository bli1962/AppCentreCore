
//function loadJs(sourceUrl) {
//	if (sourceUrl.Length == 0) {
//		console.error("Invalid source URL");
//		return;
//	}

//	var tag = document.createElement('script');
//	tag.src = sourceUrl;
//	tag.type = "text/javascript";

//	tag.onload = function () {
//		console.log("Script loaded successfully");
//	}

//	tag.onerror = function () {
//		console.error("Failed to load script");
//	}

//	document.body.appendChild(tag);
//}

function selectElementContents(el) {
    var body = document.body, range, sel;

    if (document.createRange && window.getSelection) {
        range = document.createRange();
        sel = window.getSelection();
        sel.removeAllRanges();


        //range.selectNodeContents(
        //    document.getElementsByTagName("div")["report_container"]);
        range.selectNodeContents(
            document.getElementsByTagName("div")[el]);

        //range.selectNodeContents(
        //    document.getElementById(el));

        sel.addRange(range);
    }
    document.execCommand("Copy");
}


// Function to hide the Spinner
function hideSpinner() {
    document.getElementById('spinner')
        .style.display = 'none';
}

function showSpinner() {
    //document.getElementById('spinner').removeAttr("style");
    document.getElementById('spinner').style.removeProperty("display");

}

function showPrompt(message) {
    return prompt(message, 'Type anything here');
}

function AlertSuccesse(message) {
    alert("warning", message);
}
function AlertMessage(message) {
    alert(message);
}

