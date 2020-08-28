using GammaWorksClient.Shared.Model;
using GammaWorksClient.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GammaWorksClient.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BaseTaskListPage : Page
    {

        private bool isFirstLoaded = true;

        public BaseTaskViewModel baseTaskViewModel = new BaseTaskViewModel();

        ObservableCollection<BaseTaskModel> baseTaskCollection;

        public BaseTaskListPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;

            // baseTaskViewModel.UpdateBaseTaskObsList();

            this.DataContext = baseTaskViewModel;
            baseTaskCollection = baseTaskViewModel.BaseTaskViewObsList;
            BaseTaskListView.ItemsSource = baseTaskCollection;
            
        }

        private void BaseTaskItemClickHndl(object sender, ItemClickEventArgs e)
        {
            BaseTaskModel baseTaskModel = (BaseTaskModel)e.ClickedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if(isFirstLoaded)
            {
                baseTaskViewModel.UpdateBaseTaskObsList();

                isFirstLoaded = false;
            }      
        }

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {          

            this.Frame.Navigate(typeof(BaseTaskView));
        }

        public void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditItem();
        }

        public void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void ItemDblTapHndl(object sender, DoubleTappedRoutedEventArgs e)
        {
            EditItem();
        }

        private void EditItem()
        {
            this.Frame.Navigate(typeof(BaseTaskView), BaseTaskListView.SelectedItem);
        }

        private void ItemTapHndl(object sender, TappedRoutedEventArgs e)
        {
            if(BaseTaskListView.SelectedItems.Count == 0)
            {
                EditBarButton.Visibility = Visibility.Collapsed;
                DeleteBarButton.Visibility = Visibility.Collapsed;
            }
            if (BaseTaskListView.SelectedItems.Count == 1)
            {
                EditBarButton.Visibility = Visibility.Visible;
                DeleteBarButton.Visibility = Visibility.Visible;
            }
            else if(BaseTaskListView.SelectedItems.Count > 1)
            {
                EditBarButton.Visibility = Visibility.Collapsed;
                DeleteBarButton.Visibility = Visibility.Visible;
            }
        }

        private void OnHoldingHndl(object sender, HoldingRoutedEventArgs e)
        {

        }

    }

}