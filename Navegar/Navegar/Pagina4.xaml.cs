using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Navegar
{
    public partial class Pagina4 : PhoneApplicationPage
    {
        public Pagina4()
        {
            InitializeComponent();
        }

        private void btncalcular1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	calcular();
        }
		
		
		private void calcular()
        {

            if (btnedad1.Text == "" || btnesta1.Text == "" || btnpeso1.Text == "")
            {
                MessageBox.Show("llena todos los campos");
            }



            else


            {
                float peso;
                float estatura;
                double edad;
                double resultado;

                peso = float.Parse(btnpeso1.Text);
                estatura = float.Parse(btnesta1.Text);
                edad = float.Parse(btnedad1.Text);




                if (ccka1.IsChecked == true || cckb1.IsChecked == true || cckm1.IsChecked == true)
                {
                                        
                    {
                        if (cckb1.IsChecked == true)
                        {
                            resultado = (66.473 + (13.752 * peso) + (5.0033 * estatura) - (6.755 * edad)) * 1.0;
                            lblresultado.Text = resultado.ToString();

                        }
                        else if (cckm1.IsChecked == true)
                        {
                            resultado = (66.473 + (13.752 * peso) + (5.0033 * estatura) - (6.755 * edad)) * 1.4;
                            lblresultado.Text = resultado.ToString();
                        }
                        else if (ccka1.IsChecked == true)
                        {
                            resultado = (66.473 + (13.752 * peso) + (5.0033 * estatura) - (6.755 * edad)) * 1.8;
                            lblresultado.Text = resultado.ToString();
                        }

                        else

                        {
                            MessageBox.Show("debes seleccionar un nivel de actividad");
                        }

                    }
                }
            }
        }

		private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
                if (MessageBox.Show("Seguro que deseas salir de la Pagina?", "Salir de la Pagina", MessageBoxButton.OKCancel)
                    != MessageBoxResult.OK)
                {
                    e.Cancel = true;
                }
		}
    }
}