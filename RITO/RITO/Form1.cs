
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RITO_JASON_WRAPPER;

namespace RITO
{
    public partial class RITO : Form
    {
        private
        string Summoner_Name;
        MyJasonWrapper JW;
        public RITO()
        {
            InitializeComponent();
            JW = null;
        }

        private void buttonManualUpdate_Click(object sender, EventArgs e)
        {
            Summoner_Name = this.textBoxSummoner.Text.ToString();
            if (JW == null)
            {
                JW = new MyJasonWrapper(Summoner_Name.ToString());
            }
        }
    }
}
