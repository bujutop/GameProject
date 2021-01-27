using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class PlayerAccountManager : PlayerRegistrationService
    {
        IPlayerCheckService playerCheckService;

        public PlayerAccountManager(IPlayerCheckService playerCheckService)
        {
            this.playerCheckService = playerCheckService;
        }

        public override void SignUp(Player player)
        {
            if (playerCheckService.PlayerCheck(player))
            {
                base.SignUp(player);
            }
            else
            {
                throw new Exception("Invalid info");
            }

            
        }
        public override void Update(Player player)
        {
            if (playerCheckService.PlayerCheck(player))
            {
                base.Update(player);
            }
            else
            {
                throw new Exception("Invalid info");
            }


        }
        public override void Delete(Player player)
        {
            if (playerCheckService.PlayerCheck(player))
            {
                base.Delete(player);
            }
            else
            {
                throw new Exception("Invalid info");
            }

        }

    }
}
