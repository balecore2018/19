using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace _19.Pages
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    /// 
    
    public partial class Settings : Page
    {

        private MainWindow mainWindow;
        System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
        ColorDialog ColorDialog = new ColorDialog();

        public Settings()
        {
            InitializeComponent();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Access files(*.accdb)|*.accdb|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            ColorDialog.AllowFullOpen = true;
            ColorDialog.ShowHelp = false;
        }

        private void SelectColorApplication(object sender, RoutedEventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Color color = ColorDialog.Color;

                gr_header.Background = new SolidColorBrush(Color.FromArgb(color.A,color.R,color.G,color.B));
                gr_appliacation.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
            }
        }

        private void SelectScreenResolution(object sender, SelectionChangedEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = sender as System.Windows.Controls.ComboBox;
            TextBlock textBlock = comboBox.SelectedValue as TextBlock;
            string resolution = textBlock.Text;
            string[] separator = new string[1] { " x " };

            MainWindow.init.Width = int.Parse(resolution.Split(separator, StringSplitOptions.None)[0]);
            MainWindow.init.Height = int.Parse(resolution.Split(separator, StringSplitOptions.None)[1]);
        }

        private void OpenDataBaza(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_database.Text = openFileDialog.FileName;
            }
        }

        private void SelectColorText(object sender, RoutedEventArgs e)
        {

        }

        private void SelectFonts(object sender, RoutedEventArgs e)
        {

        }
    }
}
