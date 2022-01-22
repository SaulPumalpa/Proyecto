using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SISTEMA_DE_PEDIDOS
{
    
    public partial class MasterPage : MasterDetailPage
    {
        public List<miMenu> miMenu { get; set; }
        public MasterPage()
        {
            InitializeComponent();
            miMenu = new List<miMenu>();
            miMenu pag1 = new miMenu() { Titulo = "Menu", Pagina = typeof(MainPage) };
            miMenu.Add(pag1);
            miMenu pag2 = new miMenu() { Titulo = "Iniciar Sesion", Pagina = typeof(Page1) };
            miMenu.Add(pag2);
            miMenu pag3 = new miMenu() { Titulo = "Carrito ", Pagina = typeof(Carrito) };
            miMenu.Add(pag3);
            this.lvsmenu.ItemsSource = miMenu;
            Detail= new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));

            this.lvsmenu.ItemSelected += Lvsmenu_ItemSelected;

        }

        private void Lvsmenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            miMenu pagina = e.SelectedItem as miMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina.Pagina));
            IsPresented = false;
        }
    }
}
