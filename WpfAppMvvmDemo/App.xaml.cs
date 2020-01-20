using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppMvvmDemo.Views;

namespace WpfAppMvvmDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return new Shell();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<IRegionManager>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //base.ConfigureModuleCatalog(moduleCatalog);

            moduleCatalog.AddModule<PatientModule.PatientModule>();


            //将MedicineModule模块设置为按需加载
            var medicineModuleType = typeof(MedicineModule.MedicineModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = medicineModuleType.Name,
                ModuleType = medicineModuleType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.OnDemand
            });
        }
    }
}
