using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ModulMon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Models.PPortalContext _context = new Models.PPortalContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Projects.Load();

            this.comboBoxProjects.ItemsSource = _context.Projects.ToList().Where(p => p.PlantId == 1); ;
            this.comboBoxProjects.DisplayMemberPath = "Name";
            this.comboBoxProjects.SelectedValuePath = "Id";

            //_context.MaterialImages.Load();
            //this.imageToShow.Source = LoadImage(_context.MaterialImages.ToList()[1].Image);
        }

        private void comboBoxProjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var existingImages = _context.MaterialImages.Where(i => i.ScreenNum == 0).Select(i => i.MatId);
            
            // Nur Materialien mit vorhandenem Bild laden
            var mats = _context.Materials.Where(p => p.ProjectId == (int)this.comboBoxProjects.SelectedValue).OrderBy(p => p.MatNum).Where(p => existingImages.Contains(p.Id)).ToList();
            
            // alle Materialien laden (auch die ohne Bild)
            // var mats = _context.Materials.Where(p => p.ProjectId == (int)this.comboBoxProjects.SelectedValue).OrderBy(p => p.MatNum).ToList();
            
            if (mats == null)
                return;

            listBoxMaterials.ItemsSource = mats;
            listBoxMaterials.DisplayMemberPath = "MatNum";
            listBoxMaterials.SelectedValuePath = "Id";
        }

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        private void listBoxMaterials_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxMaterials.SelectedValue != null)
            {
                this.labelSelectedMaterial.Content = ((Models.Material)listBoxMaterials.SelectedItem).MatNum;
                var img = _context.MaterialImages.Where(id => id.MatId == (int)listBoxMaterials.SelectedValue).ToList().FirstOrDefault();
                if (img != null)
                {
                    this.imageToShow.Source = LoadImage(img.Image);
                }
                else
                    this.imageToShow.Source = null;
            }
        }
        private void btnRuesten_Click(object sender, RoutedEventArgs e)
        {
            Ruesten();
        }

        private void Ruesten()
        {
            if (MainGrid.ColumnDefinitions[0].ActualWidth != 0)
                MainGrid.ColumnDefinitions[0].Width = new GridLength(0);
            else
                MainGrid.ColumnDefinitions[0].Width = new GridLength(251, GridUnitType.Star);
        }
    }
}
