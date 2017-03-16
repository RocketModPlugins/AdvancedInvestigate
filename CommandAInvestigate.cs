using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Chat;
using System.Collections.Generic;
using SDG.Unturned;

namespace AdvancedInvestigate
{
    public class CommandAInvestigate : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Both; }
        }

        public string Name
        {
            get { return "advancedinvestigate"; }
        }

        public string Help
        {
            get { return "This Plugin Gives Advanced Details that /investigate."; }
        }

        public string Syntax
        {
            get { return "<player>"; }
        }

        public List<string> Aliases
        {
            get { return new List<string>() { "ainvestigate", "ainv" }; }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer victim = UnturnedPlayer.FromName(command[0]);

            UnturnedChat.Say(caller, "Player: " + victim.CharacterName, Color.red);
            UnturnedChat.Say(caller, "SteamID64: " + victim.CSteamID, Color.red);
            UnturnedChat.Say(caller, "IP Address: " + AdvancedInvestigate.Main.GetIP(victim.CSteamID), Color.red);
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
              {
                  "advanced.investigate"
              };
            }
        }

    }
}