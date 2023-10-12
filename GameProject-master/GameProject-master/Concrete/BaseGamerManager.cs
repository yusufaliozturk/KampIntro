using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    //MicroService
    public class BaseGamerManager : IGamerService // Bir manager sınıfının içinde başka bir manager sınıfı kullanılacaksa asla onu newleme yani onun constructi oluşturulur.
    {
        IGamerCheckService _gamerCheckService; // BaseGamerManager'ın içerisinde bir doğrulama servisi oluşturulmuştur.
        public BaseGamerManager(IGamerCheckService gamerCheckService)  // Bu doğrulama servisi asla kimlik paylaşım servisinin kendisi değildir, soyutudur.
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to db: " + gamer.FirstName);
        }
        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine("Saved to db: " + gamer.FirstName);
            }
            else 
            {
                Console.WriteLine("Please check your informations");   
            }
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to db: " + gamer.FirstName);
        }

        
    }
}
