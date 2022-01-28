using SISTEMA_DE_PEDIDOS.Dependencias;
using SISTEMA_DE_PEDIDOS.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SISTEMA_DE_PEDIDOS.Repository
{
    public class RepositoryPlatos
    {
        private SQLiteConnection cn;

        public RepositoryPlatos()
        {
            this.cn = DependencyService.Get<IDataBase>().GetConnection();
        }


        // METODOS 

        public void CrearBD()
        {
            this.cn.DropTable<Plato>();
            this.cn.CreateTable<Plato>();  
        }

        public List<Plato> GetPlatos()
        {
            var consulta = from datos in cn.Table<Plato>()
                           select datos;
            return consulta.ToList();
        }
        public Plato BuscarPlato(int num)
        {
            var consulta = from datos in cn.Table<Plato>()
                           where datos.Codigo == num
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void InsertarPlato(int num, string nom, double precio, string cat, string des, Type imagen)
        {
            Plato plat = new Plato ();
            plat.Codigo = num;
            plat.Nombre = nom;
            plat.Precio = precio;
            plat.Categoria = cat;
            plat.Descripcion = des;
            plat.Imagen = imagen;

            this.cn.Insert(plat);
        }

        public void ModificarPlato(int num, string nom, double precio, string cat, string des, Type imagen)
        {
            Plato plat = this.BuscarPlato(num);
            plat.Codigo = num;
            plat.Nombre = nom;
            plat.Precio = precio;
            plat.Categoria = cat;
            plat.Descripcion = des;
            plat.Imagen = imagen;

            this.cn.Update(plat);
        }

        public void EliminarPlato(int num)
        {
            Plato plat =this.BuscarPlato(num);
            this.cn.Delete(plat);
        }


    }
}
