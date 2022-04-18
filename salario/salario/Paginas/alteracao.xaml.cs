using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salario.banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace salario.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class alteracao : ContentPage
    {
        public alteracao()
        {
            InitializeComponent();
            btn_editar.Clicked += Editarfuncionarios;
        }

    }
}