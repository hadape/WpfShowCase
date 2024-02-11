using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using NhlPlayers.BL;
using NhlPlayers.BL.Services;
using NhlPlayers.Core.ViewModels;
using NhlPlayers.Infrastructure;
using NhlPlayers.Infrastructure.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IInfrastrucutreSetting, ApplicationSetting>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IBLSetting, ApplicationSetting>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IDialogHandler, DialogHandler>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IFileHandler, FileHandler>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IImportService, ImportService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IPlayerService, PlayerService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IPlayerMemoryService, PlayerMemoryService>();



            RegisterAppStart<ListingPlayerViewModel>();
        }
    }
}
