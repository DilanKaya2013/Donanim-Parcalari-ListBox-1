using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donanım_Parçaları_ListBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstTumparcalar.Items.Count; i++)
            {
                if (lstTumparcalar.Items[i].ToString()=="Hoparlör"||
                    lstTumparcalar.Items[i].ToString() == "Mikrofon"||
                    lstTumparcalar.Items[i].ToString() == "Monitör" ||
                    lstTumparcalar.Items[i].ToString() == "Klavye" )

                {
                    lstDisdonanim.Items.Add(lstTumparcalar.Items[i]);
                }
                else
                {
                    lstİcdonanım.Items.Add(lstTumparcalar.Items[i]);
                }
            }  
        }
    }
}
