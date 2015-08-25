using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;

namespace KBOEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {

        KBOBase.BaseInterface database;

        public MainWindow()
        {
            InitializeComponent();

            // Insert code required on object creation below this point.
        }

        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {

            loadKBData();

            TreeViewItem tvi = new TreeViewItem();
            TreeViewItem tvi2 = new TreeViewItem();


            Image img = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("Images/SmallIcon.png", UriKind.Relative);
            bi3.EndInit();
            //img.Stretch = Stretch.Fill;
            img.Source = bi3;

            TextBlock tb = new TextBlock();
            tb.Text = "Эксперимент Вачаева";
            tb.Margin = new Thickness(10, 0, 15, 0);

            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            sp.Children.Add(img);
            sp.Children.Add(tb);

            tvi.Header = sp;


            this.tvEntities.Items.Add(tvi);

        }

        private object createEntityUI(KBOBase.KBOEntity Entity)
        {
            Image entityUIImage = new Image();
            BitmapImage entityUIBitmap = new BitmapImage();
            entityUIBitmap.BeginInit();
            entityUIBitmap.UriSource = new Uri("Images/SmallIcon.png", UriKind.Relative);
            entityUIBitmap.EndInit();
            entityUIImage.Source = entityUIBitmap;

            TextBlock entityTextBox = new TextBlock();
            entityTextBox.Text = Entity.Name;
            entityTextBox.Margin = new Thickness(10, 0, 15, 0);

            StackPanel entityStackPanel = new StackPanel();
            entityStackPanel.Orientation = Orientation.Horizontal;
            entityStackPanel.Children.Add(entityUIImage);
            entityStackPanel.Children.Add(entityTextBox);
            entityStackPanel.Tag = Entity.Id;

            return entityStackPanel;

        }

        private void loadKBData()
        {
            this.database = new KBOBase.EmptyBase();
            this.label_Status.Content = database.connect(null);
            
        }

      
    }
}
