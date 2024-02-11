using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using NhlPlayers.Infrastructure;
using NhlPlayers.WPF.Settings;
using System.Windows;

namespace NhlPlayers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }
        

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new FolderHandler(new ApplicationSetting()).InitFolders();
        }

    }
}
