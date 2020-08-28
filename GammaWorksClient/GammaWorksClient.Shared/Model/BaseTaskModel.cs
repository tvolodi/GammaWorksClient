using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GammaWorksClient.Shared.Model
{
    public class BaseTaskModel : INotifyPropertyChanged
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

        private long regNo;
        public long RegNo
        {
            get
            {
                return this.regNo;
            }

            set
            {
                if(value != regNo)
                {
                    this.regNo = value;
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

        private DateTimeOffset plannedStart;
        public DateTimeOffset PlannedStart
        {
            get
            {
                return this.plannedStart;
            }

            set
            {
                if (value != plannedStart)
                {
                    this.plannedStart = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTimeOffset plannedFinish;
        public DateTimeOffset PlannedFinish
        {
            get
            {
                return this.plannedFinish;
            }

            set
            {
                if (value != plannedFinish)
                {
                    this.plannedFinish = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTimeOffset actualStart;
        public DateTimeOffset ActualStart
        {
            get
            {
                return this.actualStart;
            }

            set
            {
                if (value != actualStart)
                {
                    this.actualStart = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTimeOffset actualFinish;
        public DateTimeOffset ActualFinish
        {
            get
            {
                return this.actualFinish;
            }

            set
            {
                if (value != actualFinish)
                {
                    this.actualFinish = value;
                    OnPropertyChanged();
                }
            }
        }

        private string status;
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                if (value != status)
                {
                    this.status = value;
                    OnPropertyChanged();
                }
            }
        }

        private int priority;
        public int Priority
        {
            get
            {
                return this.priority;
            }

            set
            {
                if (value != priority)
                {
                    this.priority = value;
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
