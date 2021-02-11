using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Remove()
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
