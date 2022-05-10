using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6reneCamacho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insertar : ContentPage
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void INSERTAR_Clicked(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();

            parametros.Add("codigo", txtCodigo.Text);
            parametros.Add("nombre", txtNombre.Text);  
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);

            cliente.UploadValues("http://127.0.0.1/moviles/post.php", "POST", parametros);
        }
        
        private void REGRESAR_Clicked(object sender, EventArgs e)
        {

        }
    }
}