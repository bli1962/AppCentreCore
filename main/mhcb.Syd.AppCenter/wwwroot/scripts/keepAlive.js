//The JavaScript code will call the CheckConnectionAsync method whenever the browser tab visibility changes,
// helping maintain the connection for your Blazor Server app.

//.addEventListener is a method in JavaScript used to attach an event handler to a specified element. 
//This allows you to execute a function when a particular event occurs on that element
document.addEventListener("visibilitychange", async function () {
    if (document.visibilityState === 'visible') {
        try {
            await DotNet.invokeMethodAsync('mhcb.Syd.AppCenter', 'CheckConnectionAsync');
            console.log("Connection active");
        } catch (error) {
            console.log("Connection lost, reloading page...");
            window.location.reload();
        }
    }
});
