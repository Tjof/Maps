using GMap.NET;
using GMap.NET.MapProviders;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //aaaa.Background = new SolidColorBrush(Color.FromArgb(0, 10, 10, 10));
           
           // aaaa.MapProvider = OpenStreetMapProvider.Instance;// new GMap.NET.MapProviders.OpenStreetMapProvider()
            //aaaa.MapPoint = new Point(54, 54);
            gMap.MapProvider = GoogleMapProvider.Instance;
            gMap.Manager.Mode = AccessMode.ServerAndCache;
            GMapProvider.WebProxy = null;
            gMap.Position = new PointLatLng(62.03175418653, 129.731884002686);
            gMap.MinZoom = 1;
            gMap.MaxZoom = 20;
            gMap.Zoom = 10;

              
        }

        private void GMap_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           // gMap.FromLocalToLatLng
        }

        private void GMap_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var coord = e.GetPosition(sender as IInputElement);
            var point2 = gMap.FromLocalToLatLng((int)coord.X, (int)coord.Y);
            MessageBox.Show($"координаты на контроле {coord.X};{coord.X}{Environment.NewLine}Координаты на Земном шаре: {point2.Lat};{point2.Lng}");
        }
    }
}
