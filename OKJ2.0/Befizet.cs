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
    public partial class Befizet : Form
    {
        public List<Payment> TransactionList;
        public int CurrentId;

        public Befizet(List<Payment> currentPayment,int studnetId)
        {
            Form fc = Application.OpenForms["Befizet"];
            fc?.Close();
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionList = currentPayment;
            CurrentId = studnetId;
            BefizetesekFormUpdate();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridView1.SelectedRows.Count <= 0) return;
            using (var befizetesdialog = new befizetesdialog(TransactionList, e.RowIndex))
                befizetesdialog.ShowDialog(this);
        }

        #region Helper Methods
        public void SendFormDataBack(List<Payment> modifiedTList) //Ezel küldi vissza a bevitt adatokat a befizetesformdialog
        {
            TransactionList = modifiedTList;
            BefizetesekFormUpdate();
        }

        public void BefizetesekFormUpdate() //Datagridview frissitése
        {           
            dataGridView1.DataSource = TransactionList.Select(x => new {Dátum = x.date.ToString("yyyy MMMM dd"),Jellege = x.Jellege, Mennyiség = x.Mennyiség}).ToArray();
            for (var i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }
        #endregion

        #region ToolStip
        private void kijelöltTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                TransactionList.RemoveAt(r.Index);
            BefizetesekFormUpdate();    
        }

        private void újBefizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionList.Add(new Payment("1000", "Új Befizetés",DateTime.Now));
            BefizetesekFormUpdate();
        }

        private void összesTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Dialog
            DialogResult exitResult = MessageBox.Show(@"Biztos ,hogy törölni szeretnéd az összes befizetést?",
                                                      @"Figyelem!",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning,
                                                       MessageBoxDefaultButton.Button2);
            #endregion
            if (exitResult == DialogResult.Yes)
            {
                TransactionList = new List<Payment>();
                BefizetesekFormUpdate();
            }
            BefizetesekFormUpdate();
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var befizetesdialog = new befizetesdialog(TransactionList, dataGridView1.SelectedRows[0].Index))
                befizetesdialog.ShowDialog(this);
        }
        #endregion

        #region BTNs
        private void button1_Click(object sender, EventArgs e) //OK gomb
        {
            Tanulo parentT = (Tanulo) this.Owner;
            parentT.UpdatePayments(TransactionList,CurrentId);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Mégse BTN
        {
            this.Close();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Egyenleg: " + TransactionList.Sum(x => Convert.ToUInt32(x.Mennyiség));
        }
    }
}
