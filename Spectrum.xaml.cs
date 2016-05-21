using System.Collections.Generic;
using System.Windows.Controls;

namespace AudioSpectrum
{
    /// <summary>
    /// Interaction logic for Spectrum.xaml
    /// </summary>
    public partial class Spectrum : UserControl
    {
        int iBarSelected = 1;

        public Spectrum()
        {
            InitializeComponent();
        }

        public void Set(List<byte> data)
        {
            if (data.Count < 16) return;
            Bar01.Value = data[0];
            Bar02.Value = data[1];
            Bar03.Value = data[2];
            Bar04.Value = data[3];
            Bar05.Value = data[4];
            Bar06.Value = data[5];
            Bar07.Value = data[6];
            Bar08.Value = data[7];
            Bar09.Value = data[8];
            Bar10.Value = data[9];
            Bar11.Value = data[10];
            Bar12.Value = data[11];
            Bar13.Value = data[12];
            Bar14.Value = data[13];
            Bar15.Value = data[14];
            Bar16.Value = data[15];
            BarSelected.Value = data[iBarSelected - 1];
        }

        public int GetSelected()
        {
            return iBarSelected - 1;
        }

        private void Bar01_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 1;
        }

        private void Bar02_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 2;
        }

        private void Bar03_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 3;
        }

        private void Bar04_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 4;
        }

        private void Bar05_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 5;
        }

        private void Bar06_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 6;
        }

        private void Bar07_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 7;
        }

        private void Bar08_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 8;
        }

        private void Bar09_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 9;
        }

        private void Bar10_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 10;
        }

        private void Bar11_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 11;
        }

        private void Bar12_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 12;
        }

        private void Bar13_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 13;
        }

        private void Bar14_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 14;
        }

        private void Bar15_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 15;
        }

        private void Bar16_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            iBarSelected = 16;
        }
    }
}
