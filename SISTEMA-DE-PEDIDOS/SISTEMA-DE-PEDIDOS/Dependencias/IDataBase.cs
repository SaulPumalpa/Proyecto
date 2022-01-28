using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_PEDIDOS.Dependencias
{
    public interface IDataBase
{
        SQLite.SQLiteConnection GetConnection();
}
}
