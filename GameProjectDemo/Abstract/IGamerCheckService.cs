using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckPerson(Gamer gamer);

    }
}
