using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        public Veiculo Veiculo { get; set; }

        private const double FREIO_ABS = 800;
        private const double AR_CONDICIONADO = 1000;
        private const double MP3_PLAYER = 500;

        private bool temFreioABS;
        public bool TemFreioABS
        {
            get
            {
                return temFreioABS;
            }
            set
            {
                this.temFreioABS = value;
                //OnPropertyChanged();
                OnPropertyChanged(nameof(this.ValorTotal));
            }
        }
        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R${0}", FREIO_ABS);
            }
        }

        private bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                this.temArCondicionado = value;
                //OnPropertyChanged();
                OnPropertyChanged(nameof(this.ValorTotal));
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R${0}", AR_CONDICIONADO);
            }
        }

        private bool temMP3Player;
        public bool TemMP3Player
        {
            get
            {
                return temMP3Player;
            }
            set
            {
                this.temMP3Player = value;
                //OnPropertyChanged();
                OnPropertyChanged(nameof(this.ValorTotal));
            }
        }
        public string TextoMP3Player
        {
            get
            {
                return string.Format("MP3 Player - R${0}", MP3_PLAYER);
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total R${0}", this.Veiculo.Preco + (this.TemFreioABS ? FREIO_ABS : 0) + (this.TemArCondicionado ? AR_CONDICIONADO : 0) + (this.TemMP3Player ? MP3_PLAYER : 0));
            }
        }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            //this.Title = this.veiculo.Nome; //Coloquei no Xaml na propriedade Title

            this.BindingContext = this;
        }

        private void ButtonProximo_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("TestDrive", "Isto é um teste", "Ok");
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }

        private void SwitchCellFreio_OnChanged(object sender, ToggledEventArgs e)
        {
            //DisplayAlert("TestDrive", e.Value.ToString(), "Ok");
            if (e.Value)
            {
                //this.TotalAcessorio += 
            }
            else
            {

            }
        }

        private void SwitchCellAr_OnChanged(object sender, ToggledEventArgs e)
        {

        }

        private void SwitchCellPlayer_OnChanged(object sender, ToggledEventArgs e)
        {

        }
    }
}