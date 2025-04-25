﻿namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;
                double etanol= Convert.ToDouble(txt_etanol.Text);
                double gasolina= Convert.ToDouble(txt_gasolina.Text);
                


                string msg = "";

                if (etanol <= (gasolina * 0.7) )
                {
                    msg = ("O Etanol está compensando para o seu "+ marca+" "+ modelo);
                } else
                    {
                    msg = ("A Gasolina está compensando para o seu "+ marca + " "+modelo);
                    }

                DisplayAlert("Calculado", msg, "OK");

            }catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } // Fecha metodo
    }// Fecha Class

}// Fecha nameSpace
