using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace GammaWorksClient.Shared.Model
{
    public class BaseTaskEntity: RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Unique object id

        public long RegNo { get; set; } = 0; // Centerlized registered number

        public string Descr { get; set; } = "";

        public long PlannedStart { get; set; } = DateTimeOffset.Now.Ticks;
        public long PlannedFinish { get; set; } = DateTimeOffset.Now.Ticks;
        public long ActualStart { get; set; } = 0;
        public long ActualFinish { get; set; } = 0;

        public string Status { get; set; } = "New";

        public int Priority { get; set; } = 5;


        
    }
}
