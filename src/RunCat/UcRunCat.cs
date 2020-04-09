using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunCat
{
    public partial class UcRunCat : UserControl
    {
        private readonly List<Image> _image;
        private int _currentImageIndex;
        private int _runnerTimerIntervalMax = 100;
        private readonly Timer _runnerTimer;
        private readonly Timer cpuCounterRefreshTimer;
        private PerformanceCounter _cpuCounter;

        public UcRunCat()
        {
            InitializeComponent();

            cpuCounterRefreshTimer = new Timer
            {
                Interval = _runnerTimerIntervalMax
            };

            cpuCounterRefreshTimer.Tick += _cpuCounterRefreshTimer_Tick;

            _runnerTimer = new Timer();
            _runnerTimer.Tick += RunnerTimerTick;
            _runnerTimer.Interval = _runnerTimerIntervalMax;

            _image = LoadResource("cat.cat_page", 5);
        }

        public void Run()
        {
            _runnerTimer.Start();
            cpuCounterRefreshTimer.Start();
        }

        private void _cpuCounterRefreshTimer_Tick(object sender, EventArgs e)
        {
            var cpuUsage = GetCpuUsage();
            _runnerTimer.Interval = ComputeTimerInterval(cpuUsage);
        }

        private void RunnerTimerTick(object sender, EventArgs e)
        {
            SetImageSource(_image[_currentImageIndex]);

            if (_currentImageIndex == _image.Count - 1)
            {
                _currentImageIndex = 0;
            }
            else
            {
                _currentImageIndex++;
            }
        }

        private void SetImageSource(Image image)
        {
            if (image == null)
            {
                return;
            }

            pictureBox1.Invoke(new Action(() => { pictureBox1.Image = image; }));
        }

        private List<Image> LoadResource(string prefix, int imageCount)
        {
            var resources = new List<Image>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            for (int i = 0; i < imageCount; i++)
            {
                var image = Image.FromStream(assembly.GetManifestResourceStream($"RunCat.images.{prefix}{i}.png"));
                resources.Add(image);
            }

            return resources;
        }

        private float GetCpuUsage()
        {
            if (_cpuCounter == null)
            {
                _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            }

            return _cpuCounter.NextValue();
        }

        private int ComputeTimerInterval(float cpuUsage)
        {
            var interval = _runnerTimerIntervalMax - (cpuUsage / 100 * _runnerTimerIntervalMax);
            if (interval < 1)
            {
                interval = 1;
            }

            return (int)interval;
        }
    }
}
