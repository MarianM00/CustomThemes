using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;

namespace CustomThemes.SplashScreen
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window, INotifyPropertyChanged
    {
        DispatcherTimer delayTime = new DispatcherTimer();
        Thread _process;
        private int _percentProcess;
        private const int timeSleep = 10;
        private const double realTime = 2; // real  time around 2 seconds
        private int circle = ((int)(realTime * 1000) / timeSleep);
        private volatile bool _isRunning = true;

        public int PercentProccess
        {
            get { return _percentProcess; }
            set
            {
                _percentProcess = value;
                OnPropertyChanged("PercentProccess");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string Property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
        }

        public SplashScreen()
        {
            this.DataContext = this;
            InitializeComponent();
            delayTime.Tick += new EventHandler(dt_Tick);
            delayTime.Interval = new TimeSpan(0, 0, 0, 0, 2400);
            _process = new Thread(process);
            _process.Start();
            delayTime.Start();
        }

        private void process()
        {
            for (int i = 0; i < circle + 20 && _isRunning; i++)
            {
                double a = ((double)i / (double)circle) * 100;
                PercentProccess = (int)Math.Round(a, 1);
                Thread.Sleep(timeSleep);
            }
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            delayTime.Stop();
            this.Close();
            _isRunning = false; // Setează variabila pentru a opri firul de execuție în mod controlat
                                // Nu mai este necesar să utilizezi _process.Abort();
        }
    }

}
