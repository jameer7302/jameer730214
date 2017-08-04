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
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
namespace pricey_kathu1
{
    /// <summary>
    /// Interaction logic for splashwindow.xaml
    /// </summary>
    public partial class splashwindow : Window
    {
        private MainWindow m_mainWindow;

        private DispatcherTimer splashAnimationTimer;

        private const string Loading = "Loading";
        public splashwindow()
        {
            InitializeComponent();
            InitializeComponent();

            splashAnimationTimer = new DispatcherTimer();
            splashAnimationTimer.Interval = TimeSpan.FromMilliseconds(500);
            splashAnimationTimer.Tick += new EventHandler(splashAnimationTimer_Tick);
            splashAnimationTimer.Start();

            m_mainWindow = new MainWindow();

            m_mainWindow.ReadyToShow += new MainWindow.ReadyToShowDelegate(m_mainWindow_ReadyToShow);

            m_mainWindow.Closed += new EventHandler(m_mainWindow_Closed);
        }
    }
}
