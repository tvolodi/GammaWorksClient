using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace GammaWorksClient.Shared.Model
{
    public class BaseTask : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Unique object id

        public long RegNo { get; set; } = 0; // Centerlized registered number

        public string Descr { get; set; } = "";

        public DateTimeOffset PlannedStart { get; set; } = DateTimeOffset.MinValue;
        public DateTimeOffset PlannedFinish { get; set; } = DateTimeOffset.MinValue;
        public DateTimeOffset ActualStart { get; set; } = DateTimeOffset.MinValue;
        public DateTimeOffset ActualFinish { get; set; } = DateTimeOffset.MinValue;

        public int Priority { get; set; } = 5;


        
    }
}
