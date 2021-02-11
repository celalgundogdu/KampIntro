using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
