using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Adapters;

namespace GameProjectDemo.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            return true;
        }
    }
}
