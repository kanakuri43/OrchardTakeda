using OrchardTakeda.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrchardTakeda.ViewModels
{
    public class DashboardViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public DashboardViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            AddOrderButton = new DelegateCommand(AddOrderButtonExecute);
            PrintButton = new DelegateCommand(PrintButtonExecute);

        }
        public DelegateCommand AddOrderButton { get; }
        public DelegateCommand PrintButton { get; }
        public DelegateCommand SettingButton { get; }

        private void AddOrderButtonExecute()
        {
            // 受注登録へ移動
            var p = new NavigationParameters();
            _regionManager.RequestNavigate("ContentRegion", nameof(OrderEntry), p);

        }
        private void PrintButtonExecute()
        {
            // ラベル印刷へ移動
            var p = new NavigationParameters();
            _regionManager.RequestNavigate("ContentRegion", nameof(PrintLabel), p);

        }
    }
}
