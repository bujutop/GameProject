using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entity;

namespace GameProject.Abstract
{
    interface IPlayerRegistrationService
    {
        void Delete(Player player);
        void SignUp(Player player);
        void Update(Player player);
    }
}
