using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName=="Ahmet" && gamer.LastName=="Çomaklı"&& gamer.NationaltyId=="11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
