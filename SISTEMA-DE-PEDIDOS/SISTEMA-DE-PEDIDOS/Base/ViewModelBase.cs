using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SISTEMA_DE_PEDIDOS.Base
{
    //Para actualizar todas las listas
    public  class ViewModelBase: INotifyPropertyChanged
{
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
}
}
