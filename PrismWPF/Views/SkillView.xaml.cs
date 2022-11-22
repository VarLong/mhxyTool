using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PrismWPF.Views
{
    /// <summary>
    /// ViewB.xaml 的交互逻辑
    /// </summary>
    public partial class SkillView : UserControl
    {
        public SkillView()
        {
            InitializeComponent();
        }

        private void Flipper_OnIsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
    => System.Diagnostics.Debug.WriteLine($"Card is flipped = {e.NewValue}");

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
            string s = key.GetValue("").ToString();
            string ekey = s.Substring(2, s.Length - 4);

            //Hyperlink link = sender as Hyperlink;
            //Process.Start(s, link.NavigateUri.ToString());
            //Process.Start("edge.exe", "https://xyq.163.com/tools/");

        
        }
    }


}
