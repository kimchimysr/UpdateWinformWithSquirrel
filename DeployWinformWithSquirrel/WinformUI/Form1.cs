using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text += $" v{Application.ProductVersion}";
            CheckForUpdate();
        }

        private async Task CheckForUpdate()
        {
            using (var manager = new UpdateManager(@"https://raw.githubusercontent.com/kimchimysr/UpdateWinformWithSquirrel/main/Releases/"))
            {
                await manager.UpdateApp();
            }
        }
    }
}
