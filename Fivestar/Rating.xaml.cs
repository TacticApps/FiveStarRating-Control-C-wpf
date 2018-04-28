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

namespace Fivestar
{
    /// <summary>
    /// Interaction logic for Rating.xaml
    /// </summary>
    public partial class Rating : UserControl
    {

        SolidColorBrush orange = new SolidColorBrush(Color.FromRgb(255, 102, 0));
        SolidColorBrush clear = new SolidColorBrush(Color.FromRgb(255, 255, 255));
      public int selected = 0;


        public Rating()
        {
            InitializeComponent();
        }


  



        private void s1_MouseEnter(object sender, MouseEventArgs e)
        {
            s1.Fill = orange;
            s2.Fill = clear;
            s3.Fill = clear;
            s4.Fill = clear;
            s5.Fill = clear;
        }

        private void s2_MouseEnter(object sender, MouseEventArgs e)
        {
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = clear;
            s4.Fill = clear;
            s5.Fill = clear;
        }

        private void s3_MouseEnter(object sender, MouseEventArgs e)
        {
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = orange;
            s4.Fill = clear;
            s5.Fill = clear;
        }

        private void s4_MouseEnter(object sender, MouseEventArgs e)
        {
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = orange;
            s4.Fill = orange;
            s5.Fill = clear;

        }

        private void s5_MouseEnter(object sender, MouseEventArgs e)
        {
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = orange;
            s4.Fill = orange;
            s5.Fill = orange;

        }





        private void s1_MouseLeave(object sender, MouseEventArgs e)
        {
            s1.Fill = clear;
        }

        private void s2_MouseLeave(object sender, MouseEventArgs e)
        {
            s1.Fill = clear;
            s2.Fill = clear;
        }

        private void s3_MouseLeave(object sender, MouseEventArgs e)
        {
            s1.Fill = clear;
            s2.Fill = clear;
            s3.Fill = clear;


        }

        private void s4_MouseLeave(object sender, MouseEventArgs e)
        {
            s1.Fill = clear;
            s2.Fill = clear;
            s3.Fill = clear;
            s4.Fill = clear;
        }

        private void s5_MouseLeave(object sender, MouseEventArgs e)
        {
            s1.Fill = clear;
            s2.Fill = clear;
            s3.Fill = clear;
            s4.Fill = clear;
            s5.Fill = clear;
        }
        







        private void s1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = 1;
            s1.Fill = orange;
            s2.Fill = clear;
            s3.Fill = clear;
            s4.Fill = clear;
            s5.Fill = clear;
        }

        private void s2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = 2;
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = clear;
            s4.Fill = clear;
            s5.Fill = clear;
        }

        private void s3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = 3;
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = orange;
            s4.Fill = clear;
            s5.Fill = clear;
        }

        private void s4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = 4;
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = orange;
            s4.Fill = orange;
            s5.Fill = clear;
        }

        private void s5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selected = 5;
            s1.Fill = orange;
            s2.Fill = orange;
            s3.Fill = orange;
            s4.Fill = orange;
            s5.Fill = orange;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {

            if(selected == 1)
            {
                s1.Fill = orange;
                s2.Fill = clear;
                s3.Fill = clear;
                s4.Fill = clear;
                s5.Fill = clear;

            }

            if (selected == 2)
            {
                s1.Fill = orange;
                s2.Fill = orange;
                s3.Fill = clear;
                s4.Fill = clear;
                s5.Fill = clear;

            }

            if (selected == 3)
            {
                s1.Fill = orange;
                s2.Fill = orange;
                s3.Fill = orange;
                s4.Fill = clear;
                s5.Fill = clear;

            }

            if (selected == 4)
            {
                s1.Fill = orange;
                s2.Fill = orange;
                s3.Fill = orange;
                s4.Fill = orange;
                s5.Fill = clear;

            }

            if (selected == 5)
            {
                s1.Fill = orange;
                s2.Fill = orange;
                s3.Fill = orange;
                s4.Fill = orange;
                s5.Fill = orange;

            }

        }
    }
}
