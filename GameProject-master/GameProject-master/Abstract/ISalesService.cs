using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sale(Sales sales, Game game, Campaign campaign, Gamer gamer);
    }
}
