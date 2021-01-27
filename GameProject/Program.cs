using System;
using GameProject.Concrete;
using GameProject.Abstract;
using GameProject.Entity;
using MernisReferenceService;
using GameProject.Adapter;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player
            {
                FirstName = "Nurettin",
                LastName = "Ayıpettin",
                NationalId = 85941736744,
                YearOfBirth = 1881,
                Nickname = "CokPisOynarım_5334"
            };
            Game game = new Game { NameOfGame="Call of Duty",Price=1000};

            SpecialOffer specialOffer  = new SpecialOffer { NameOfOffer = "Super Discount", DiscountPercent = 20 };
            
            PlayerAccountManager playerAccountManager = new PlayerAccountManager(new PlayerCheckManager());
            playerAccountManager.SignUp(player);
            Console.WriteLine("----");

            SalesManager salesManager = new SalesManager();
            salesManager.SellGame(player,game);
            Console.WriteLine("----");


            SpecialOfferManager specialOfferManager = new SpecialOfferManager();
            specialOfferManager.AddOffer(specialOffer, game);
            Console.WriteLine("----");
            salesManager.DiscountSale(specialOffer, game);


        }
    }
}
