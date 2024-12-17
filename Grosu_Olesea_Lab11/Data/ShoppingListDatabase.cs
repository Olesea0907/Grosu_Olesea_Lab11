using System.Collections.Generic;
using System.Threading.Tasks;
using Grosu_Olesea_Lab11.Models;

namespace Grosu_Olesea_Lab11.Data
{
    public class ShoppingListDatabase 
    {
        IRestService restService;

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }

        public async Task<List<ShopList>> GetShopListsAsync()
        {
            return await restService.RefreshDataAsync();
        }


        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }

        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }
    }
}
