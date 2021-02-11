using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISaleService
    {
        void Order(Gamer gamer, Game game);
        void CampaignOrder(Campaign campaign, Gamer gamer, Game game);

    }
}
