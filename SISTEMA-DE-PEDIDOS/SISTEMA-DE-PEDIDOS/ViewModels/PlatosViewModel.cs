using SISTEMA_DE_PEDIDOS.Base;
using SISTEMA_DE_PEDIDOS.Modelos;
using SISTEMA_DE_PEDIDOS.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SISTEMA_DE_PEDIDOS.ViewModels
{

    // coleccion para mostrar los platos en las ventanas
    public class PlatosViewModel:ViewModelBase 
{      
        public PlatosViewModel()
        {
            RepositoryPlatos repo = new RepositoryPlatos();
            List<Plato> lista = repo.GetPlatos();
            this.Platos = new ObservableCollection<Plato>(lista);
        }
        private ObservableCollection<Plato> _Platos;
        public ObservableCollection<Plato> Platos
        {
            get { return this._Platos; }
            set { 
                this._Platos = value;
                OnPropertyChanged("Platos");
                 }
        }
}
}
