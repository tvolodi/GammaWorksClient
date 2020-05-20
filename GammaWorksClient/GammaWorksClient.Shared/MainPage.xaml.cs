using GammaWorksClient.Shared.Model;
using GammaWorksClient.Shared.UiTool;
using GammaWorksClient.Shared.Views;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private ObservableCollection<BaseTask> BaseTaskObsList { get; set; }       

        public MainPage()
        {
            this.InitializeComponent();

            BaseTaskObsList = new ObservableCollection<BaseTask>();
            BaseTask testBaseTask = new BaseTask
            {
                Descr = "Test task 1"                
            };
            BaseTaskObsList.Add(testBaseTask);
            testBaseTask = new BaseTask
            {
                Descr = "Test task 2"
            };
            BaseTaskObsList.Add(testBaseTask);

#if NETFX_CORE || __ANDROID__ || __IOS__ || __MACOS__

            var realm = Realm.GetInstance();

            realm.Write(() =>
            {
                realm.Add(testBaseTask);
            });

            var baseTasksCounter = realm.All<BaseTask>();

            int counter = baseTasksCounter.Count();

            realm.Write(() =>
            {
                realm.Add(new BaseTask { Descr = "Test task 3"});
            });

            int counter2 = baseTasksCounter.Count();


            var taskList = baseTasksCounter.ToList();
#endif
            // DataContext = BaseTaskObsList;
        }

        private void AddNewBaseTask(object sender, RoutedEventArgs e)
        {

        }

        private void EditBaseTask(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBaseTask(object sender, RoutedEventArgs e)
        {

        }

        private void MainNavView_LoadedHandler(object sender, RoutedEventArgs e)
        {
            // MainContentFrame.Navigate(typeof(BaseTaskView));
        }

        private void MainNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs e)
        {
            // MainContentFrame.Navigate(typeof(BaseTaskView));
        }


    }
}
