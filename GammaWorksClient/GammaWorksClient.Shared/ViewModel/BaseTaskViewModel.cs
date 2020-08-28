using GammaWorksClient.Shared.Mappers;
using GammaWorksClient.Shared.Model;
using GammaWorksClient.Shared.UiTool;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Uno.Disposables;

namespace GammaWorksClient.Shared.ViewModel
{
    public class BaseTaskViewModel
    {
        private static Realm realmInstance;

        public ObservableCollection<BaseTaskModel> BaseTaskViewObsList = new ObservableCollection<BaseTaskModel>();

        // private RelayCommand openNewBaseTaskViewCommand;

        public BaseTaskViewModel()
        {
            var realmConfig = new RealmConfiguration() { SchemaVersion = 3 };
            realmInstance = Realm.GetInstance(realmConfig);
        }

        public void UpdateBaseTaskObsList()
        {

#if NETFX_CORE || __ANDROID__ || __IOS__ || __MACOS__

            UpdateBaseTaskObsListLocalDB();

#else

            UpdateBaseTaskObsListRemoteDB();
#endif

        }

        public static void SaveBaseTaskDB(BaseTaskModel baseTaskModel)
        {
#if NETFX_CORE || __ANDROID__ || __IOS__ || __MACOS__

            SaveBaseTaskLocalDB(baseTaskModel);

#elif __WASM__

            SaveBaseTaskRemoteDB(baseTaskModel);
#endif
        }

        private static void SaveBaseTaskLocalDB(BaseTaskModel baseTaskModel)
        {

            BaseTaskEntity baseTaskEntity = BaseTaskMapper.BaseTaskModelToEntity(baseTaskModel);
            realmInstance.Write(() =>
            {
                long timeInTicks = baseTaskEntity.PlannedStart;
                realmInstance.Add<BaseTaskEntity>(baseTaskEntity, true);
            });
        }


        private void UpdateBaseTaskObsListLocalDB()
        {
            //using (var trans = realmInstance.BeginWrite())
            //{
            //    realmInstance.RemoveAll<BaseTaskEntity>();
            //    trans.Commit();
            //}

            var baseTaskList = realmInstance.All<BaseTaskEntity>().ToList();


            for (int i = 0; i < baseTaskList.Count; i++)
            {
                BaseTaskEntity baseTask = baseTaskList[i];
                BaseTaskModel baseTaskModel = BaseTaskMapper.BaseTaskEntityToModel(baseTask);
                BaseTaskViewObsList.Add(baseTaskModel);
            }
            baseTaskList.TryDispose();
        }

        private void UpdateBaseTaskObsListRemoteDB()
        {

        }

        private void SaveBaseTaskRemoteDB(BaseTaskModel baseTaskModel)
        {

        }

    }


}
