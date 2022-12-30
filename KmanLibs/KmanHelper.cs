using System;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

namespace KmanLibs
{
    public static class Networking
    {
        public static void SetMasterClient(Player player)
        {
            PhotonNetwork.SetMasterClient(player);
            PhotonNetwork.CurrentRoom.SetMasterClient(player);
        }
        public static void RaiseEvent(byte EventCode, object Content, RaiseEventOptions eventOptions, SendOptions options)
        {
            PhotonNetwork.RaiseEvent(EventCode, Content, eventOptions, options);
        }
        public static void SendHook(object Message, string URI, object UserName, object ProfilePicture)
        {
            using (dWebHook dcWeb = new dWebHook())
            {
                dcWeb.ProfilePicture = ProfilePicture.ToString();
                dcWeb.UserName = UserName.ToString();
                dcWeb.WebHook = URI;
                dcWeb.SendMessage(Message.ToString());
            }
        }
    }
}
