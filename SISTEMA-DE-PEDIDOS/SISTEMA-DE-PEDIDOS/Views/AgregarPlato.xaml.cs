using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SISTEMA_DE_PEDIDOS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AgregarPlato : ContentPage
{
    public AgregarPlato()
    {
        
    }
        private async void Button_ClickedTomarFoto(object sender, EventArgs e)
        {
            var opciones_almacenamiento = new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = "plato.jpg"
            };
            var foto = await CrossMedia.Current.TakePhotoAsync(opciones_almacenamiento);
            // MiImagen.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = foto.GetStream();
             //   foto.Dispose();
             //   return stream;
            //});
        }

        private async void Button_ClickedSubirFoto(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagen = await CrossMedia.Current.PickPhotoAsync();
                if (imagen != null)
                {
               //     MiImagen.Source = ImageSource.FromStream(() =>
                   // {
                   //     var stream = imagen.GetStream();
                    //    imagen.Dispose();
                   //     return stream;
                   // });
                }
            }
        }

        private void Button_ClickedAgregar(object sender, EventArgs e)
        {

            DisplayAlert(" ", "Elemento guardado con éxito", "Cerrar");
        }
    }
}