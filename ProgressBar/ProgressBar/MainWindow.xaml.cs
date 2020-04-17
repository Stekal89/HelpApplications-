using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool mFinished = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickbtnTest(object sender, RoutedEventArgs e)
        {
            pbMyBar.Visibility = Visibility.Visible;
            //pbMyBar.IsIndeterminate = true;
            BackgroundWorker worker = new BackgroundWorker();
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerAsync();

        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("All Done");
            //pbMyBar.IsIndeterminate = false;
            pbMyBar.Value = 0;
            pbMyBar.Visibility = Visibility.Hidden;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
           
            //worker.ReportProgress(0);
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(new TimeSpan(0,0,1));
            //    worker.ReportProgress((i + 1) * 10);
            //}
            while (!mFinished)
            {
                worker.ReportProgress(0);
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(new TimeSpan(0, 0, 0, 0, 50));
                    worker.ReportProgress((i + 1) * 10);
                }
                worker.ReportProgress(0);
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbMyBar.Value = e.ProgressPercentage;
        }

        private void ClickbtnFinished(object sender, RoutedEventArgs e)
        {
            mFinished = true;
        }
    }
}
