using GammaWorksClient.Shared.Model;
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

            baseTaskListView.ItemsSource = BaseTaskObsList;

            // DataContext = BaseTaskObsList;
        }
    }
}
