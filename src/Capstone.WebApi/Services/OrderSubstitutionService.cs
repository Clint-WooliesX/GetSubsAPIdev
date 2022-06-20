using System.Threading.Tasks;
using Refit;
using Capstone.WebApi.Models;
using System.Net.Http;
using Capstone.WebApi.Models;
using System.Text.Json;

namespace Capstone.WebApi.Services
{
    /*  public interface IArticleServiceApi
      {
          [Get("/articles/{referenceNumber}")]
          Task<DTOOrder> GetArticle(string referenceNumber);
      }*/
    public class OrderSubstitutionService : IOrderSubstitutionService
    {
        private readonly HttpClient _httpClient;

        public OrderSubstitutionService(HttpClient client) // an arraya? how loop it ? 
        {
            _httpClient = client;
            client.DefaultRequestHeaders.Add("User-Agent", "C# App");
            client.DefaultRequestHeaders.Add("x-api-key", "8463b411-1510-4037-a1e5-95c42fa26b69");

        }

        public async Task<SmartSubsReturn[]> GetSubstitutionOfOrder(DTOOrder[] order)
        {
            SmartSubsReturn[] returnedOrdersArr = new SmartSubsReturn[] { };
            for(int i = 0; i < order.Length; i++)
            {
                HttpResponseMessage subbedOrders = await _httpClient.GetAsync($"https://ofk8saae.uat.wx-d.net/smart-subs/stores/{order[i].branchID}/recommendation/{order[i].stockCode}?Quantity={order[i].Quantity}&BranchId={order[i].fulfilmentStoreKey}");
                string returnedOrders = await subbedOrders.Content.ReadAsStringAsync();
                SmartSubsReturn subbedOrder = JsonSerializer.Deserialize<SmartSubsReturn>(returnedOrders);                

                returnedOrdersArr[i] = subbedOrder;

            }
            return returnedOrdersArr;
        }
    }

    // look to make method function asynchronously => WORRY LATER
}
