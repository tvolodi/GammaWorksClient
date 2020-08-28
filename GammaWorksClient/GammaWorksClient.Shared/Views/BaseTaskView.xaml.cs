using GammaWorksClient.Shared.Model;
using GammaWorksClient.Shared.ViewModel;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GammaWorksClient.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BaseTaskView : Page
    {
        private BaseTaskModel baseTask;

        private TimePicker timePicker;

        public BaseTaskView()
        {
            this.InitializeComponent();

            timePicker = new TimePicker();
            


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            BaseTaskViewModel.SaveBaseTaskDB(baseTask);

            Frame parent = this.Parent as Frame;
            if (parent.CanGoBack) parent.GoBack();

            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            baseTask = e.Parameter as BaseTaskModel;
            if(baseTask == null)
            {
                baseTask = new BaseTaskModel
                {
                    Id = Guid.NewGuid().ToString(),
                    PlannedStart = DateTimeOffset.Now,
                    PlannedFinish = DateTimeOffset.Now
                };                
            }
            this.DataContext = baseTask;
            
        }
    }
}
