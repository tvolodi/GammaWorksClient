using GammaWorksClient.Shared.Model;
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
    public class BaseTaskVM
    {
        Realm realmInstance;

        public BaseTaskVM()
        {
            realmInstance = Realm.GetInstance();
        }

    }
}
