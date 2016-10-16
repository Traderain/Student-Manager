using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKJ2._0
{
    public partial class befizetesdialog : Form
    {
        public List<Payment> ModifiedList;
        public int ModIndex;
        public befizetesdialog(List<Payment> paymentlistList,int index)
        {
            InitializeComponent();
            textBox1.Text = paymentlistList[index].Jellege;
            textBox2.Text = paymentlistList[index].Mennyiség;
            ModifiedList = paymentlistList;
            ModIndex = index;
        }

        #region BTNs
        private void button2_Click(object sender, EventArgs e) //MÉGSE
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //OK
        {
            ModifiedList[ModIndex].Jellege = textBox1.Text;
            ModifiedList[ModIndex].Mennyiség = textBox2.Text;
            ModifiedList[ModIndex].date = dateTimePicker1.Value;
            Befizet parentT = (Befizet)this.Owner;
            parentT.SendFormDataBack(ModifiedList);
            this.Close();
        }
        #endregion
    }
}
