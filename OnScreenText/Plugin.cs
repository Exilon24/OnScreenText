using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.Events.EventArgs;
using MEC;

namespace OnScreenText
{
    using Exiled.API.Features;
    
    public class Plugin : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += PlayerOnVerified;
            Exiled.Events.Handlers.Server.RoundEnded += ServerOnRoundEnded;
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= PlayerOnVerified; 
            Exiled.Events.Handlers.Server.RoundEnded -= ServerOnRoundEnded;
        }
        
        private void ServerOnRoundEnded(RoundEndedEventArgs ev)
        {
            Timing.KillCoroutines();
        }

        private void PlayerOnVerified(VerifiedEventArgs ev)
        {
            Timing.RunCoroutine(RefreshMessage(ev.Player));
        }

        private IEnumerator<float> RefreshMessage(Player plr)
        {
            while (true)
            {
                plr.ShowHint($"{String.Concat(Enumerable.Repeat("\n", Config.NewLines))}{Config.Title}\n{Config.Text}", Config.RefreshRate + 1f);
                yield return Timing.WaitForSeconds(Config.RefreshRate);
            }
        }
    }
}