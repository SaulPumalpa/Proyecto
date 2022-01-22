using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SISTEMA_DE_PEDIDOS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }
        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //Datos de estudiante
            string usuario = "administrador2022";
            string contraseña = "uisrael2022";

            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                usuario = txtUsuario.Text;
                Navigation.PushAsync(new agregarPlatos());
                // abrir pantalla  de registro y enviar usuario
                DisplayAlert("USUARIO CONECTADO", "BIENVENIDO", "Cerrar");
            }
            else
            {
                DisplayAlert("ERROR", "Usuario o Contraseña Incorrecto", "Cerrar");
            }
        }
    }
}