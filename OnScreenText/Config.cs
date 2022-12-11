namespace OnScreenText
{
    using Exiled.API.Interfaces;
    
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public string Title { get; set; } = "MY SERVER";

        public string Text { get; set; } = "Welcome to my server!";
    }
}