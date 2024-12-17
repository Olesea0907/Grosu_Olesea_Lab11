using Grosu_Olesea_Lab11.Data;
using Grosu_Olesea_Lab11.Models;

namespace Grosu_Olesea_Lab11;

public partial class ListEntryPage : ContentPage
{
    public ListEntryPage()
    {
        InitializeComponent();
    }

    // Se încarcă datele la afișarea paginii
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            listView.ItemsSource = await App.Database.GetShopListsAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Unable to load data: {ex.Message}", "OK");
        }
    }


    // Eveniment pentru adăugarea unei liste noi
    async void OnShopListAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new ShopList()
        });
    }

    // Eveniment pentru selectarea unei liste existente
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as ShopList
            });
        }
    }
}
