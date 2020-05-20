using GammaWorksClient.Shared.Model;
using GammaWorksClient.Shared.UiTool;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GammaWorksClient.Shared.ViewModel
{
    public class BaseTaskViewModel
    {
        Realm realmInstance;

        // private RelayCommand openNewBaseTaskViewCommand;

        public BaseTaskViewModel()
        {
            realmInstance = Realm.GetInstance();
        }
    }
}
