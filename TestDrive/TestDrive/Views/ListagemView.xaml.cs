using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", this.Preco); }
        }
    }

    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo() { Nome = "Azera V6", Preco = 85000.00 },
                new Veiculo() { Nome = "Livina S", Preco = 45000.00 },
                new Veiculo() { Nome = "Fiesta 2.0", Preco = 52087.80 },
                new Veiculo() { Nome = "HB20 S", Preco = 40450.30 },
                new Veiculo() { Nome = "C3 1.0", Preco = 22076.87 },
                new Veiculo() { Nome = "Uno Fire", Preco = 11034.00 },
                new Veiculo() { Nome = "Sentra 2.0", Preco = 53350.15 },
                new Veiculo() { Nome = "Astra Sedan", Preco = 39034.34 },
                new Veiculo() { Nome = "Vectra 2.0", Preco = 37000.00 },
                new Veiculo() { Nome = "Hilux 4x4", Preco = 90000.00 },
                new Veiculo() { Nome = "Montana", Preco = 57234.23 },
                new Veiculo() { Nome = "Outlander 2.4", Preco = 90300.15 },
                new Veiculo() { Nome = "Monza 2.0", Preco = 8030.00 },
                new Veiculo() { Nome = "Palio 1.6", Preco = 15040.00 }

            };

            this.BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            //DisplayAlert("TestDrive", String.Format("Você tocou no modelo {0} que custa {1}.",veiculo.Nome, veiculo.PrecoFormatado),"Ok");

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}
