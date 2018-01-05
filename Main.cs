using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedInvestigate
{
    public class Main : RocketPlugin
    {
        public static Main Instance;

        protected override void Load()
        {
            Instance = this;

            Logger.Log("Plugin Loaded");
        }

        protected override void Unload()
        {

        }

        private void FixedUpdate()
        {
        }

        public static string GetIP(CSteamID id)
        {
            P2PSessionState_t sessionState;
            SteamGameServerNetworking.GetP2PSessionState(id, out sessionState);
            return Parser.getIPFromUInt32(sessionState.m_nRemoteIP);
        }
    }
}
