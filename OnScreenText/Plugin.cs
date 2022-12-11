using System;
using System.Linq;
using Exiled.Events.EventArgs;

namespace OnScreenText
{
    using Exiled.API.Features;
    
    public class Plugin : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += PlayerOnVerified;
        }
        
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= PlayerOnVerified; 
        }

        private void PlayerOnVerified(VerifiedEventArgs ev)
        {
            ev.Player.ShowHint($"{String.Concat(Enumerable.Repeat("\n", Config.NewLines))}{Config.Title}\n{Config.Text}", 2400f);
        }
    }
}