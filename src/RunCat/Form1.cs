using System;
using System.Drawing;
using System.Windows.Forms;

namespace RunCat
{
    public partial class Form1 : Form
    {
        bool _isMouseDown;
        Point _currentFormLocation;
        Point _currentMouseOffset;

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ucRunCat1.Run();
            await ucRunCat2.Run();
            await ucRunCat3.Run();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _isMouseDown = true;
            _currentFormLocation = Location;
            _currentMouseOffset = MousePosition;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown) return;
            Point pt = MousePosition;
            var rangeX = _currentMouseOffset.X - pt.X; //计算当前鼠标光标的位移，让窗体进行相同大小的位移
            var rangeY = _currentMouseOffset.Y - pt.Y; //计算当前鼠标光标的位移，让窗体进行相同大小的位移
            Location = new Point(_currentFormLocation.X - rangeX, _currentFormLocation.Y - rangeY);
        }
    }
}
