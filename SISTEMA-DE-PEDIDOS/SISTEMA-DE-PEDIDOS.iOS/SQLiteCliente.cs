using Foundation;
using SISTEMA_DE_PEDIDOS.Dependencias;
using SISTEMA_DE_PEDIDOS.iOS;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteCliente))]


namespace SISTEMA_DE_PEDIDOS.iOS
{
    
    internal class SQLiteCliente : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}