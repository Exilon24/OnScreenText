namespace OnScreenText
{
    using Exiled.API.Interfaces;
    using System.ComponentModel;
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Title of the text.")]
        public string Title { get; set; } = "MY SERVER";
        
        [Description("Actual text content")]
        public string Text { get; set; } = "Welcome to my server!";
        
        [Description("How many lines down should the hint appear.")]
        public int NewLines { get; set; } = 14;

        [Description("How much time should each refresh take")]
        public float RefreshRate { get; set; } = 10f;
    }
}