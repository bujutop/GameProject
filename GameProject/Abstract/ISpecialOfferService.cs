using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface ISpecialOfferService
    {
        void AddOffer(SpecialOffer specialOffer,Game game);
        void DeleteOffer(SpecialOffer specialOffer, Game game);
        void UpdateOffer(SpecialOffer specialOffer, Game game);


    }
}
