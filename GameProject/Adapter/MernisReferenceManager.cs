using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;
using System.Threading.Tasks;
using MernisReferenceService;

namespace GameProject.Adapter
{
    public class MernisReferenceManager : IPlayerCheckService
    {
        public bool PlayerCheck(Player player)
        {
            return TaskAsync(player).Result;
        }
        public static async Task<bool> TaskAsync(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalId), player.FirstName, player.LastName, player.YearOfBirth));
            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}