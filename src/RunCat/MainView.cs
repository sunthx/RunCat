using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunCat
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            Load += MainView_Load;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ucRunCat1.Run();
        }
    }
}
