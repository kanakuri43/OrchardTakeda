using OrchardTakeda.Views;
using Prism.Ioc;
using System.Windows;

namespace OrchardTakeda
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.Dashboard>();
            containerRegistry.RegisterForNavigation<Views.OrderEntry>();
            containerRegistry.RegisterForNavigation<Views.PrintLabel>();
        }
    }
}
