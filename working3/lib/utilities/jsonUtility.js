export const SendJSONObjectToSocket = (socket, obj, replacer = null) => {
    socket.send(JSON.stringify(obj, replacer ? replacer : JSONReplacer));
}

export const SendJSONObjectToSockets = (sockets, obj, replacer = null) => {
    sockets.forEach(socket => {
        socket.send(JSON.stringify(obj, replacer ? replacer : JSONReplacer));
    });
}

function JSONReplacer(key, value) {
    if (key == "playerSockets") return undefined;
    else if (key == "socket") return undefined;
    else if (key == "password") return undefined;
    else if (key == "lobby") return undefined;
    else return value;
}