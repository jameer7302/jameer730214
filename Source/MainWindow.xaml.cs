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
using System.IO;
using Microsoft.Win32;
using System.Windows.Threading;
using System.Reflection;
using System.Resources;
using System.Diagnostics;
using System.Media;

using System.Threading;

namespace pricey_kathu1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
      
        public MainWindow()
        {
            InitializeComponent();
        }
       
      
     
        private void letterClick(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"D:\practice files\pricey kathu1\pricey kathu1\images\premam.wav", UriKind.RelativeOrAbsolute);
            var player = new MediaPlayer();
            player.Open(uri);
            player.Play();
            MessageBox.Show("Hello " + name.Text +" !"+" Here's a letter from ECE-011 !");
            Window2 sec = new Window2();
            sec.Show();
        }

        private void aboutClick(object sender, RoutedEventArgs e)
        {
            Window1 sec = new Window1();
            sec.Show();
        }

        private void clearClick(object sender, RoutedEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            name.Clear();
            reply.Clear();
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

        private void saveClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialogue = new SaveFileDialog();
            if (saveFileDialogue.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialogue.FileName, reply.Text);
            }
        }

        private void reply_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void msaveClick(object sender, RoutedEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            SaveFileDialog saveFileDialogue = new SaveFileDialog();
            if (saveFileDialogue.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialogue.FileName, mreply.Text);
            }
             

        }

      

        private void playClick(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"D:/practice files/pricey kathu1/pricey kathu1/bin/Debug/premam.mp3", UriKind.RelativeOrAbsolute);
            var player = new MediaPlayer();
            player.Open(uri);
            player.Play();
        }

       
        private void areplyClick(object sender, ContextMenuEventArgs e)
        {

        }

        private void asaveClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialogue = new SaveFileDialog();
            if (saveFileDialogue.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialogue.FileName, areply.Text);
            }
        }

        private void areply_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       

        
       
        }

      
    }

