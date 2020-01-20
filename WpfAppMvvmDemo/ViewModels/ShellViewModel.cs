using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WpfAppMvvmDemo.ViewModels
{
    public class ShellViewModel:BindableBase
    {
        IModuleManager _moduleManager;
        public ShellViewModel(IModuleManager moduleManager)
        {
            _moduleManager = moduleManager;
            _moduleManager.LoadModuleCompleted += _moduleManager_LoadModuleCompleted;
        }
        private ICommand _loadMedicineModuleCommand;
        public ICommand LoadMedicineModuleCommand =>
            _loadMedicineModuleCommand ?? (_loadMedicineModuleCommand = new DelegateCommand(ExecuteLoadMedicineModuleCommand));
        void ExecuteLoadMedicineModuleCommand()
        {
            _moduleManager.LoadModule("MedicineModule");
        }

        private void _moduleManager_LoadModuleCompleted(object sender, LoadModuleCompletedEventArgs e)
        {
            MessageBox.Show($"{e.ModuleInfo.ModuleName}模块被加载了");
        }

    }
}
