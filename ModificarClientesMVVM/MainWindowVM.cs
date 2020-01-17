using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificarClientesMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        Tema_6Entities contexto;
        public ObservableCollection<CLIENTE> listaClientes { get; set; }
        public CLIENTE seleccionado { get; set; }


        public MainWindowVM()
        {
            contexto = new Tema_6Entities();
            contexto.CLIENTES.Load();

            listaClientes = contexto.CLIENTES.Local;
        }

        public bool puedeEjecutar()
        {
            return seleccionado != null;
        }

        public void guardarCambios()
        {
            contexto.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
