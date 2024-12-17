using System.Collections.Generic;
using System.Threading.Tasks;
using Grosu_Olesea_Lab11.Models;

namespace Grosu_Olesea_Lab11.Data
{
    public interface IRestService // Ensure interface is public
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
