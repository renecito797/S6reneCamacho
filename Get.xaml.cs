using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6reneCamacho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Get : ContentPage
    {

        //private const string Url = "130.1.16.232/moviles/post.php";
        private const string Url = "http://127.0.0.1/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<S6reneCamacho.Datos> _post;
        public Get()
        {
            InitializeComponent();
        }

        private async void btnget_Clicked(object sender, EventArgs e)
        {
            try { 
            var content = await client.GetStringAsync(Url);
            List<S6reneCamacho.Datos> posts = JsonConvert.DeserializeObject<List<S6reneCamacho.Datos>>(content);
            _post = new ObservableCollection<S6reneCamacho.Datos>(posts);

            mylistview.ItemsSource = _post;
            }

            catch (Exception ex)
            {
                await DisplayAlert("Error", ""+ ex, "Salir");
            }
        }
    }
}