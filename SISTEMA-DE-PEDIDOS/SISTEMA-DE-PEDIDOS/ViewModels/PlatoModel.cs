using SISTEMA_DE_PEDIDOS.Base;
using SISTEMA_DE_PEDIDOS.Modelos;
using SISTEMA_DE_PEDIDOS.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SISTEMA_DE_PEDIDOS.ViewModels
{
    //Se representa un unico plato
    public class PlatoModel:ViewModelBase

{
        RepositoryPlatos repo;
        public PlatoModel()
        {
            this.repo = new RepositoryPlatos();
            this.Plato =new Plato();
        }

        public Command InsertarPLato
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarPlato(this.Plato.Codigo, Plato.Nombre, Plato.Precio, Plato.Categoria,
                        Plato.Descripcion, Plato.Imagen);
                });
            }
        }

        public Command ModificarPLato
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ModificarPlato(this.Plato.Codigo, Plato.Nombre, Plato.Precio, Plato.Categoria,
                        Plato.Descripcion, Plato.Imagen);
                });
            }
        }

        public Command EliminarPLato
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarPlato(this.Plato.Codigo);
                });
            }
        }

        private Plato _Plato;

        public Plato Plato
        {
            get { return this._Plato; }
            set
            {
                this._Plato = value;
                OnPropertyChanged("Plato");
            }
        }

    }
}
