using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckService gamerCheckService;
        // bir manager sınıfının icerisinde baska bir manager sınıfı kullanılacaksa onu new'leme
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            this.gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (gamerCheckService.CheckPerson(gamer) == true)
            {
                Console.WriteLine("Oyuncu eklendi");
            }
            else
            {
                throw new Exception("Kullanıcı bilgileri doğru değil");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
