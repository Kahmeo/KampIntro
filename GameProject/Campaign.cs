using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignPrice { get; set; }
    }
}
