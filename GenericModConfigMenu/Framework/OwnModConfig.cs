using StardewModdingAPI.Utilities;

namespace GenericModConfigMenu.Framework
{
    /// <summary>The mod configuration for Generic Mod Config Menu itself.</summary>
    internal class OwnModConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The theme to use for drawing the menu.</summary>
        public string Theme { get; set; } = "automatic";

        /// <summary>A keybind which opens the menu.</summary>
        public KeybindList OpenMenuKey = new KeybindList(StardewModdingAPI.SButton.None);

        /// <summary>The number of field rows to offset when scrolling a config menu.</summary>
        public int ScrollSpeed { get; set; } = 120;
    }
}
