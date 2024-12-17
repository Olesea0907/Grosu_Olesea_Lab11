using Grosu_Olesea_Lab11.Models;

namespace Grosu_Olesea_Lab11;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }

    // Handler pentru butonul Save
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        slist.Date = DateTime.UtcNow; // Actualizează data curentă

        // Salvează lista în baza de date
        await App.Database.SaveShopListAsync(slist);

        // Navighează înapoi la pagina anterioară
        await Navigation.PopAsync();
    }

    // Handler pentru butonul Delete
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;

        // Șterge lista din baza de date
        await App.Database.DeleteShopListAsync(slist);

        // Navighează înapoi la pagina anterioară
        await Navigation.PopAsync();
    }
}
