using GammaWorksClient.Shared.Model;
using GammaWorksClient.Shared.UiTool;
using GammaWorksClient.Shared.ViewModel;
using GammaWorksClient.Shared.Views;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GammaWorksClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void MainNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs e)
        {
            // MainContentFrame.Navigate(typeof(BaseTaskView));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BaseTaskListPage baseTaskListPage = MainNavigationFrame.Navigate<BaseTaskListPage>();
        }

        private void BaseTaskItemClickHndl(object sender, ItemClickEventArgs e)
        {
            BaseTaskModel baseTask = (BaseTaskModel)e.ClickedItem;

            MainNavigationFrame.Navigate(typeof(BaseTaskView));
        }

        private void MainNavView_BackRequested(object sender, NavigationViewBackRequestedEventArgs e)
        {
            OnBackRequested();
            var evArg = e;
        }

        private bool OnBackRequested()
        {

            if (MainNavigationFrame.CanGoBack)
            {
                MainNavigationFrame.GoBack();
                return true;
            }
            else return false;

            DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
            // dateTimeOffset.
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }
    }
}
