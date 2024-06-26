$(document).ready(() => {
    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

    //Disable the send button until connection is established.
    document.getElementById("send-btn").disabled = true;

    connection.on("ReceiveMessage", function (message) {
        var p = document.createElement("p");
        p.classList.add("chat-message-me");
        p.innerText = `${message}`;
        document.getElementById("messages").appendChild(p);
    });

    connection.start().then(function () {
        document.getElementById("send-btn").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });

    document.getElementById("send-btn").addEventListener("click", function (event) {
        var message = $("#message-textbox > input").val();
        connection.invoke("SendMessage", message).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });
})