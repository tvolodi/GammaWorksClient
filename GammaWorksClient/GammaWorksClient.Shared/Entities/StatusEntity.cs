using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace GammaWorksClient.Shared.Model
{
    public class StatusEntity: RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Unique object id

        public string Code { get; set; } = "Default";

        public string Descr { get; set; } = "";
        
    }
}
