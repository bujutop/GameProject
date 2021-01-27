using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public abstract class SpecialOfferSale : ISpecialOfferService
    {
        public void AddOffer(SpecialOffer specialOffer, Game game)
        {
            Console.WriteLine("{0} added on {1}", specialOffer.NameOfOffer, game.NameOfGame);
        }

        public void DeleteOffer(SpecialOffer specialOffer, Game game)
        {
            Console.WriteLine("{0} removed from {1}", specialOffer.NameOfOffer, game.NameOfGame);
        }

        public void UpdateOffer(SpecialOffer specialOffer, Game game)
        {
            Console.WriteLine("{0} updated for {1}", specialOffer.NameOfOffer, game.NameOfGame);
        }
        public abstract void DiscountSale(SpecialOffer specialOffer, Game game);
        

    }
}
