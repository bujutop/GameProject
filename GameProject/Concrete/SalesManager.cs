using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class SalesManager : SpecialOfferSale,ISaleService
    {
        

        public void SellGame(Player player, Game game)
        {
            Console.WriteLine("New sale!");
            Console.WriteLine("Game: {0}" + "\n" + "Player:{1} {2}",game.NameOfGame,player.FirstName,player.LastName);
        }
        public override void DiscountSale(SpecialOffer specialOffer, Game game)
        {
            double discount;
            discount = game.Price - (specialOffer.DiscountPercent / 100 * game.Price);
            Console.WriteLine("{0} on {1} reduced the price to {2}TL with a {3}% discount rate.", specialOffer.NameOfOffer, game.NameOfGame, discount, specialOffer.DiscountPercent);
        }



    }
}
