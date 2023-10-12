using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager baseGamerManager = new BaseGamerManager(new GamerCheckManager()); //Doğrulama yapmak için başka bir sınıfa ihtiyaç duyar.(Hangi doğrulama sınıfını kullanmak istersek onu yazarız.))
            Gamer gamer1 = new Gamer() {FirstName="Şerife",LastName="Yaman",NationaltyId="22222222222"};
            Gamer gamer2 = new Gamer() {FirstName="Ahmet",LastName="Çomaklı",NationaltyId= "11111111111" };

            baseGamerManager.Save(gamer1);
            baseGamerManager.Delete(gamer2);
            baseGamerManager.Update(gamer2);

            Game game1 = new Game() {GameName="Game1",GamePrice=1000};
            Campaign campaign1= new Campaign() {CampaignName="Kampanya1" };
            BaseCampaignManager baseCampaignManager = new BaseCampaignManager();
            baseCampaignManager.Enter(campaign1);
            baseCampaignManager.Update(campaign1);
            baseCampaignManager.Delete(campaign1 ); 

            Sales sales1 = new Sales();
            BaseSalesManager baseSalesManager = new BaseSalesManager();
            baseSalesManager.Sale(sales1,game1,campaign1,gamer2);
            Console.WriteLine();
        }
    }
}