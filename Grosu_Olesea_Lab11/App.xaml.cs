using Grosu_Olesea_Lab11.Data;

namespace Grosu_Olesea_Lab11
{
    public partial class App : Application
    {
        // Proprietatea statică pentru accesul global la baza de date
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            InitializeComponent();

            // Inițializează baza de date folosind instanța RestService
            Database = new ShoppingListDatabase(new RestService());

            // Setează pagina de pornire principală
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
