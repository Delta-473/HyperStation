using System;
using HyperStation.GameServer.Network.Packet.Battle;
using HyperStation.GameServer.Network.Packet.Chat;
using HyperStation.GameServer.Network.Packet.Community;
using HyperStation.GameServer.Network.Packet.Error;
using HyperStation.GameServer.Network.Packet.GameRoom;
using HyperStation.GameServer.Network.Packet.Lobby;
using HyperStation.GameServer.Network.Packet.Login;
using HyperStation.GameServer.Network.Packet.Session;
using HyperStation.GameServer.Network.Packet.GameServer;
using ProtoBuf;

namespace HyperStation.GameServer.Network
{
    [ProtoContract]
    public class Header
    {
        public override string ToString()
        {
            if (this.packetType_0 == PacketType.LOGIN)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Login.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.LOBBY)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Lobby.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.SESSION)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Session.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.COMMUNITY)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Community.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.GAMEROOM)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.GameRoom.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.CHAT)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Chat.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.BATTLE)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Battle.PacketId)this.int_0);
            }
            if (this.packetType_0 == PacketType.ERROR)
            {
                return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, (Packet.Error.PacketId)this.int_0);
            }
            return string.Format("nPacketType[{0}] nPacketId[{1}]", this.packetType_0, this.int_0);
        }

        [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
        public PacketType packetType_0;

        [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
        public int int_0;
    }
}
