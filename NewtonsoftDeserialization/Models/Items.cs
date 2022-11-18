using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewtonsoftDeserialization.Models
{
    public class Items
    {
        public string Id { get; set; }
        public string SelfLink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }

        public Items(string id, string selfLink, VolumeInfo volume)
        {
            Id = id;
            SelfLink = selfLink;
            VolumeInfo = volume;
        }
    }
}
