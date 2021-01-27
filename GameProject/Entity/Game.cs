using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entity
{
    public class Game:IEntity
    {
        public string NameOfGame { get; set; }
        public double Price { get; set; }
    }
}
