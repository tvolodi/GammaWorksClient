using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GammaWorksClient.Shared.Model
{
    public class StatusModel : INotifyPropertyChanged
    {

        private string id;
        public string Id
        {
            get
            {
                return this.id;
            }
                
            set
            {
                if(value != id)
                {
                    this.id = value;
                    OnPropertyChanged();
                }
            }
        }

        private string code;
        public string Code
        {
            get
            {
                return this.code;
            }

            set
            {
                if(value != code)
                {
                    this.code = value;
                    OnPropertyChanged();
                }
            }
        }

        private string descr;
        public string Descr
        {
            get
            {
                return this.descr;
            }

            set
            {
                if (value != descr)
                {
                    this.descr = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string member="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(member));
        }
    }
}
