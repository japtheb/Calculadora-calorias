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
    public partial class Pagina3 : PhoneApplicationPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

      private void btncalcular2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	   calcular2();
        }
		
		 private void calcular2()
        
        {
            if (btnesta2.Text == "" || btnedad2.Text == "" || btnpeso2.Text == "")
            {
                MessageBox.Show("llena todos los campos");
            }

            double pesom;
            double alturam;
            double edadm;
            double resultado1;

            pesom = float.Parse(btnpeso2.Text);
            alturam = float.Parse(btnesta2.Text);
            edadm = float.Parse(btnedad2.Text);


            if (ccka2.IsChecked == true || cckb2.IsChecked == true || cckm2.IsChecked == true)
            {



                if (cckb2.IsChecked == true)
                {
                    resultado1 = (655.0955 + (9.463 * pesom) + (1.8496 * alturam) - (4.6756 * edadm)) * 1.0;
                    txtresultadom.Text = resultado1.ToString();



                }
                else if (cckm2.IsChecked == true)
                {
                    resultado1 = (655.0955 + (9.463 * pesom) + (1.8496 * alturam) - (4.6756 * edadm)) * 1.4;
                    txtresultadom.Text = resultado1.ToString();


                }
                else if (ccka2.IsChecked == true)
                {
                    resultado1 = (655.0955 + (9.463 * pesom) + (1.8496 * alturam) - (4.6756 * edadm)) * 1.8;
                    txtresultadom.Text = resultado1.ToString();
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar un indice de actividad");

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