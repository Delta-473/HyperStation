using System;

namespace HyperStation.GameServer.Network.Packet.GameServer
{
    public enum PacketType
    {
        TEST,
        LOGIN,
        LOBBY,
        SESSION,
        COMMUNITY,
        GAMEROOM,
        CHAT,
        MATCH = 10,
        BATTLE,
        INTERLOBBY,
        GM,
        MASTER,
        LOG,
        MANAGER,
        ERROR = 98,
        ALLSERVER
    }
}
