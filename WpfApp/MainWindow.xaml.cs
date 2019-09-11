using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AppFeatures;
using WpfApp.Events;
using WpfApp.Models;

namespace WpfApp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        AppEvents appEvents = new AppEvents();
        private void BtnClickMe_Click(object sender, RoutedEventArgs e)
        {
            appEvents.Subscribe();
            MessageBox.Show("Subscribe!");
        }
        Features features = new Features();
        //MyClass mc = new MyClass();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCompute_Click(object sender, RoutedEventArgs e)
        {
            #region MyRegion


            //MessageBox.Show("" + sum);

            //string a = "23";
            //string b = "Buffalo";
            //string c = "Main Street";
            //StringBuilder sb = new StringBuilder();
            //sb.Append(a);
            //sb.Append(b);
            //sb.Append(c);
            //MessageBox.Show(sb.ToString());
            #endregion


            try
            {
                int val1 = Convert.ToInt32(txtVal1.Text);
                int val2 = Convert.ToInt32(txtVal2.Text);

                int r = val1 / val2;
            }
            catch (FormatException fe)
            {

                MessageBox.Show("Format Exception Occurred!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unknown Exception Occurred!");
            }
            finally
            {
                int prod = 0;
                int sum = features.Add(out prod, a: 200, b: 100);
                MessageBox.Show(sum.ToString());
                MessageBox.Show(prod.ToString());
            }





            //switch (sum)
            //{
            //    case 10:
            //        MessageBox.Show("sum is equal 10");
            //        break;
            //    case 20:
            //        MessageBox.Show("sum is equal 20");
            //        break;
            //    default:
            //        MessageBox.Show("sum is not equal to 10 or 20");
            //        break;
            //}


            //if (sum > 10)
            //{
            //    MessageBox.Show("sum is more than 10");
            //}
            //else if (sum < 10)
            //{
            //    MessageBox.Show("sum is less than 10");
            //}
            //else
            //{
            //    MessageBox.Show("sum is equal 10");
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            appEvents.Trigger();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SampleClass sampleClass = new SampleClass();
            sampleClass.AnotherMessage();

            Generics<string> generics = new Generics<string>();
            generics.Add("Hi!");

            Generics<SampleClass> generics1 = new Generics<SampleClass>();
            generics1.Add(sampleClass);

        }
    }
}
