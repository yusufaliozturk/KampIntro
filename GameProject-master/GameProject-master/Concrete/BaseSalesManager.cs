using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class BaseSalesManager : ISalesService
    {
        public void Sale(Sales sales, Game game, Campaign campaign, Gamer gamer)
        {
            
            
            Console.WriteLine($"{game.GameName} oyunu {gamer.FirstName} {gamer.LastName} kullanıcısına {campaign.CampaignName} kampanyasıyla {game.GamePrice} TL'ye satılmıştır. ");
            
        }

    }
}
