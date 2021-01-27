using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool PlayerCheck(Player player)
        {
            return true;
        }
    }
}
