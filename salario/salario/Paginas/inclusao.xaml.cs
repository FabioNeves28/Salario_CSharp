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
    public partial class inclusao : ContentPage
    {
        public inclusao()
        {
            InitializeComponent();
            btn_enviar.Clicked += cadastrar;
        }
        public void cadastrar(object sender, EventArgs args)
        {
            string nome = txt_nome.Text;
            string cargo = txt_cargo.Text;
            string vh = txt_vh.Text;
            string ht = txt_ht.Text;
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.InserirFuncionario(nome, cargo, vh, ht);
            DisplayAlert("Mensagem", "Registro gravado com Sucesso!", "OK");
        }
    }
    }

