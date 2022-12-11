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
            ev.Player.ShowHint($"\n\n\n\n\n\n\n\n\n\n\n\n\n{Config.Title}\n{Config.Text}", 2400f);
        }
    }
}