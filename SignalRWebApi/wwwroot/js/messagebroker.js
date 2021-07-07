
"use strict"

const signalrConnection = new signalR.HubConnectionBuilder()
    .withUrl("/messagebroker")
    .build();

signalrConnection.start().then(function () {
    console.log("SignalR Hub Connected");
}).catch(function (err) {
    return console.error(err.toString());
});

let messageCount = 0;
//const watchId=navigator.geolocation.watchPosition(scrollMap, handleError);
signalrConnection.on("onMessageReceived", function (eventMessage) {
    console.log(eventMessage);
    messageCount++;
    
    const msgCount = document.getElementById("messageCount");
    const ul = document.getElementById("messages");
    const li = document.createElement("li");
    li.innerText = messageCount.toString();

    for (const prop in eventMessage) {
        const newDiv = document.createElement("div");
        const classAttrib = document.createAttribute("style");
        classAttrib.value = "font-size: 80%";
        newDiv.setAttributeNode(classAttrib);
        const newContent = document.createTextNode(`${prop}:${eventMessage[prop]}`);
        newDiv.appendChild(newContent);
        li.appendChild(newDiv);
    }
    ul.appendChild(li);
    window.scrollTo(0, document.body.scrollHeight);
   
});

function scrollMap(position) {
    const { latitude, longitude } = position.coords;
}