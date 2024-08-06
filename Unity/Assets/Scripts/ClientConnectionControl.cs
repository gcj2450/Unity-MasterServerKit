using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Msk;

public class ClientConnectionControl : MonoBehaviourMskClientCallbacks
{
    private void Start()
    {
        MasterServerKit.Client.ConnectToMaster();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("ClientConnectionControl OnConnectedToMaster");

        // Invoked when connect to the master success.
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.isPrivate = false;
        roomOptions.maxPlayers = 10;
        MasterServerKit.Client.CreateRoom("GameRoom1", roomOptions);
    }

    public override void OnCreatedRoom(string roomName, string ip, ushort port)
    {
        Debug.Log($"OnCreatedRoom:roomName: {roomName},ip: {ip}, port: {port}");
        base.OnCreatedRoom(roomName, ip, port);
    }
}
