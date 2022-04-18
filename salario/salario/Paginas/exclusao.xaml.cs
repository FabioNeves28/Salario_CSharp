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
    public partial class exclusao : ContentPage
    {
        public exclusao()
        {
            InitializeComponent();
            btn_excluir.Clicked += excluir_funcionario;
        }


        public void excluir_funcionario(object sender, EventArgs args)
        {
            string codigo = txt_codigo.Text;
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.Excluirfuncionarios(codigo);
            DisplayAlert("Mensagem", "Registro excluido com Sucesso!", "OK");
        }
    }
}
