using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using Projektanker.Icons.Avalonia;
using Projektanker.Icons.Avalonia.MaterialDesign;
using Stardrop.Utilities;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Stardrop
{
    class Program
    {
        internal static Helper helper = new Helper();
        internal static readonly string defaultProfileName = "Default";
        internal static string defaultGamePath = @"E:\SteamLibrary\steamapps\common\Stardew Valley\";
        internal static string defaultModPath = @"E:\SteamLibrary\steamapps\common\Stardew Valley\Mods\";
        internal static string defaultHomePath = @"E:\SteamLibrary\steamapps\common\Stardew Valley\Stardrop\";
        internal static string smapiLogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StardewValley", "ErrorLogs");
        internal static readonly Regex gameDetailsPattern = new Regex(@"SMAPI (?<smapiVersion>.+) with Stardew Valley (?<gameVersion>.+) on (?<system>.+)");

        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            // Register icon provider(s)
            IconProvider.Register<MaterialDesignIconProvider>();

            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
        }
    }
}
