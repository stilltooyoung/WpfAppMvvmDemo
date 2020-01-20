using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MedicineModule.ViewModels
{
    public class MedicineMenuItemViewModel
    {
        private readonly IRegionManager regionManager;

        public MedicineMenuItemViewModel(IRegionManager regionManager)
        {
            LoadMedicineContentCommand = new DelegateCommand(LoadMedicineContent);
            this.regionManager = regionManager;
        }
        public ICommand LoadMedicineContentCommand { get; }

        private void LoadMedicineContent()
        {
            regionManager.RequestNavigate("ContentRegion", "MedicineContentView");

        }
    }
}
