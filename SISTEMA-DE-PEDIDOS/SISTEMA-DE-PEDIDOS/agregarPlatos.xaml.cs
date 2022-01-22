using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace SISTEMA_DE_PEDIDOS
{
    public partial class agregarPlatos : ContentPage
    {
        
        public agregarPlatos()
        {
            
        }

        private async void Button_ClickedTomarFoto(object sender, EventArgs e)
        {
            var opciones_almacenamiento =new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = "plato.jpg"
            } ;
            var foto = await CrossMedia.Current.TakePhotoAsync(opciones_almacenamiento) ;
            MiImagen.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async void Button_ClickedSubirFoto(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagen = await CrossMedia.Current.PickPhotoAsync();
                if (imagen != null)
                {
                    MiImagen.Source = ImageSource.FromStream(() =>
                    {
                        var  stream = imagen.GetStream();
                        imagen.Dispose();
                        return stream;
                    } );
                }
            }
        }

        private void Button_ClickedAgregar(object sender, EventArgs e)
        {
            string nombreP = txtNombrePlato.Text;
            double precioP = Convert.ToDouble(txtPrecio.Text);
            var imagen = MiImagen;
            Navigation.PushAsync(new listaPlatos(nombreP, precioP));
            DisplayAlert(" ", "Elemento guardado con éxito", "Cerrar");

            txtNombrePlato.Text=" ";
            txtPrecio.Text=" ";
            MiImagen =null;
        }
    }
}
