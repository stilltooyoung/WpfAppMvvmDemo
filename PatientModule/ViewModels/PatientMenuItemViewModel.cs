using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PatientModule.ViewModels
{
    public class PatientMenuItemViewModel
    {
        private readonly IRegionManager regionManager;

        public PatientMenuItemViewModel(IRegionManager regionManager)
        {
            LoadPatientContentCommand = new DelegateCommand(LoadMathsContent);
            this.regionManager = regionManager;
        }
        public ICommand LoadPatientContentCommand { get; }

        private void LoadMathsContent()
        {
            regionManager.RequestNavigate("ContentRegion", "PatientContentView");
        }
    }
}
