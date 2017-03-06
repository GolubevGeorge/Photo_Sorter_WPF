using Photo_SorterWP.Model;
using Photo_SorterWPF.Data;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Photo_SorterWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sortBtn_Click(object sender, RoutedEventArgs e)
        {
            if (new PathStringValidation().Validate(pathString.Text) == null)
            {
                pathString.Text = null;
            }
            else
            {
                mainListView.ItemsSource = new Photo(pathString.Text).Sort();
            }

            if (pathString.Text != String.Empty)
            {
                clearBtn.IsEnabled = true;
            }
        }

        private void extractBtn_Click(object sender, RoutedEventArgs e)
        {
            if (new PathStringValidation().Validate(pathString.Text) == null)
            {
                pathString.Text = null;
            }
            else
            {
                mainListView.ItemsSource = new Extractor().Extract(pathString.Text);
            }

            if (pathString.Text != String.Empty)
            {
                clearBtn.IsEnabled = true;
            }

        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            mainListView.ItemsSource = null;

            clearBtn.IsEnabled = false;
        }

        private async void pathString_TextChangedAsync(object sender, TextChangedEventArgs e)
        {
            txtBlockTotal.Text = "Counting...";
            txtBlockTotal.Text = await new View.FilesInFolder().CountAsync(pathString.Text);
        }

        private void eventsViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PhotoWindow phWin = new PhotoWindow();
            phWin.Owner = Window.GetWindow(this);
            //phWin.ShowDialog();

            try
            {
                if (mainListView.SelectedItems.Count > 0)
                {
                    PhotoModel image = (PhotoModel)mainListView.SelectedItems[0];

                    string imagePath = image.Path + @"\" + image.Name;

                    phWin.preViewImage.Source = new BitmapImage(new Uri(imagePath));

                    phWin.Title = image.Name;

                    phWin.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid file extension", "Photo Sorter");
            }
        }

        #region TreeView

        private object dummyNode = null;

        public string SelectedImagePath { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = s;
                item.Tag = s;
                item.FontWeight = FontWeights.Normal;
                item.Items.Add(dummyNode);
                item.Expanded += new RoutedEventHandler(folder_Expanded);
                foldersItem.Items.Add(item);
            }

        }

        void folder_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)sender;
            if (item.Items.Count == 1 && item.Items[0] == dummyNode)
            {
                item.Items.Clear();
                try
                {
                    foreach (string s in Directory.GetDirectories(item.Tag.ToString()))
                    {
                        TreeViewItem subitem = new TreeViewItem();
                        subitem.Header = s.Substring(s.LastIndexOf("\\") + 1);
                        subitem.Tag = s;
                        subitem.FontWeight = FontWeights.Normal;
                        subitem.Items.Add(dummyNode);
                        subitem.Expanded += new RoutedEventHandler(folder_Expanded);
                        item.Items.Add(subitem);
                    }
                }
                catch (Exception) { }
            }
        }

        private void foldersItem_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeView tree = (TreeView)sender;
            TreeViewItem temp = ((TreeViewItem)tree.SelectedItem);

            if (temp == null)
                return;
            SelectedImagePath = "";
            string temp1 = "";
            string temp2 = "";
            while (true)
            {
                temp1 = temp.Header.ToString();
                if (temp1.Contains(@"\"))
                {
                    temp2 = "";
                }
                SelectedImagePath = temp1 + temp2 + SelectedImagePath;
                if (temp.Parent.GetType().Equals(typeof(TreeView)))
                {
                    break;
                }
                temp = ((TreeViewItem)temp.Parent);
                temp2 = @"\";
            }


            pathString.Text = SelectedImagePath;

        }

        #endregion

    }
}
