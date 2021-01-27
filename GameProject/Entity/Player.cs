using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entity
{
    public class Player:IEntity
    {
        public long NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string Nickname { get; set; }
    }
}
