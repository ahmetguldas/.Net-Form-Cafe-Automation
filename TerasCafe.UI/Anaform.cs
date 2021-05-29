using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerasCafe.UI
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiUrunler)
            {
                new UrunlerForm().ShowDialog();
            }
            else if (e.ClickedItem == tsmiGecmisSiparisler)
            {
                new GecmisSiparislerForm().ShowDialog();
            }
        }
    }
}
