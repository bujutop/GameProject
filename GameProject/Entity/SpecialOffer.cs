using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entity
{
    public class SpecialOffer:IEntity
    {
        public string NameOfOffer { get; set; }
        public double DiscountPercent { get; set; }
    }
}
