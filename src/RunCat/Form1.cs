using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunCat
{
    public partial class Form1 : Form
    {
        private List<Image> _image;
        private int _currentImageIndex = 0;
        private int _runerTimerIntervalMax = 500;
        private readonly Timer _runerTimer;
        private readonly Timer _cpuCounterRefreshTimer;
        private PerformanceCounter _cpuCounter;

        public Form1()
        {
            InitializeComponent();

            _cpuCounterRefreshTimer = new Timer();
            _cpuCounterRefreshTimer.Interval = 1000;
            _cpuCounterRefreshTimer.Tick += _cpuCounterRefreshTimer_Tick;

            _runerTimer = new Timer();
            _runerTimer.Tick += RunerTimerTick;

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _image = LoadResouces("cat.cat_page", 5);

            _runerTimer.Interval = _runerTimerIntervalMax;
            _runerTimer.Start();

            _cpuCounterRefreshTimer.Start();
        }

        private void _cpuCounterRefreshTimer_Tick(object sender, EventArgs e)
        {
            var cpuUseage = GetCpuUseage();
            _runerTimer.Interval = ComputeTimerInterval(cpuUseage);
        }

        private void RunerTimerTick(object sender, EventArgs e)
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

        private List<Image> LoadResouces(string prefix,int imageCount)
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

        private float GetCpuUseage()
        {
            if (_cpuCounter == null)
            {
                _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            }

            return _cpuCounter.NextValue();
        }

        private int ComputeTimerInterval(float cpuUseage)
        {
            if (cpuUseage < 1)
            {
                return _runerTimerIntervalMax;
            }

            var interval = cpuUseage / 100 * _runerTimerIntervalMax;
            return (int) interval;
        }
    }
}
