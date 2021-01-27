using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public abstract class PlayerRegistrationService
       

    {
        
        public virtual void Delete(Player player)
        {
            Console.WriteLine("Delete successful. Goodbye {0} {1}!", player.FirstName, player.LastName);
        }

        public virtual void SignUp(Player player)
        {
            Console.WriteLine("Sign-up successful. Welcome {0} {1}!", player.FirstName, player.LastName);
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("User info updated.");
        }
    }

   
    
}
