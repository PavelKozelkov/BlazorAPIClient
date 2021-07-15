using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class RESTSpaceXDataService : ISpaceXDataService
    {
        public Task<LaunchDto[]> GetAllLaunches()
        {
            throw new System.NotImplementedException();
        }
    }
}