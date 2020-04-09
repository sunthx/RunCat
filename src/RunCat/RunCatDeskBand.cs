using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDeskBand;

namespace RunCat
{
    [ComVisible(true)]
    [Guid("AC63DE3B-1A75-4228-913A-4CFF0256F896")]
    [CSDeskBandRegistration(Name = "RunCat", ShowDeskBand = true)]
    public class RunCatDeskBand : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;

        public RunCatDeskBand()
        {
            Options.MinHorizontalSize = new DeskBandSize(40,40);
            _control = new MainView();
        }

        protected override Control Control => _control;
    }
}
