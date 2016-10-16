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
    public partial class Tanulo : Form
    {
        public List<Student> StudentsList;
        public int CurrentId;
        public Tanulo(List<Student> tanulokList ,int id)
        {
            Form fc = Application.OpenForms["tanulo"];
            fc?.Close();
            InitializeComponent();
            VegetsegCombo.DataSource = Enum.GetNames(typeof(Vegz));
            TanfTipCombo.DataSource = Enum.GetValues(typeof(Tanf));
            jobstatusCB.DataSource = Enum.GetValues(typeof(JobStatus));
            okjbizszamCB.DataSource = Enumerable.Range(1, 10).ToArray();
            VegetsegCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TanfTipCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            jobstatusCB.DropDownStyle = ComboBoxStyle.DropDownList;
            okjbizszamCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentsList = tanulokList;
            CurrentId = id;
            UpdateValues(tanulokList.First(x => x.Id == id));          
        }

        #region Updates
        public void UpdateValues(Student t)
        {
            NevTextBox.Text = t.SDetails.Nev.Value;
            SzulHelyTextbox.Text = t.SDetails.SzulHely;
            szulidopicker.Value = t.SDetails.SzulIdo;
            AnyjaNeveTextBox.Text = t.SDetails.Anyjaneve;
            LakcimTextBox.Text = t.SDetails.Lakcim;
            VegetsegCombo.SelectedIndex = (int)t.SDetails.IskVegz;
            TAJTextBox.Text = t.SDetails.Taj;
            TelTextBox.Text = t.SDetails.Tel;
            TanfTipCombo.SelectedIndex = (int) t.SDetails.TipTanf;
            TanfSzamTextBox.Text = t.SDetails.Tszama;
            bszTextBox.Text = t.SDetails.Bsz;
            jobstatusCB.SelectedIndex = (int) t.SDetails.JStatus;
            okjbizszamCB.SelectedIndex = t.SDetails.PastOkj;
        }

        public void UpdatePayments(List<Payment> tpayments,int id)
        {
            StudentsList.First(x => x.Id == id).SPayment = tpayments;
        }
        #endregion

        #region Gombok
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form fc = Application.OpenForms["Befizet"];
            fc?.Close();
        }

        private void button1_Click(object sender, EventArgs e) //OK BTN
        {
          StudentsList.First(x => x.Id == CurrentId).SDetails.Nev =    new StringValue(NevTextBox.Text);
          StudentsList.First(x => x.Id == CurrentId).SDetails.SzulHely = SzulHelyTextbox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.SzulIdo =  szulidopicker.Value;
          StudentsList.First(x => x.Id == CurrentId).SDetails.Anyjaneve =    AnyjaNeveTextBox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.Lakcim =    LakcimTextBox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.IskVegz =   (Vegz)VegetsegCombo.SelectedIndex;
          StudentsList.First(x => x.Id == CurrentId).SDetails.Taj =    TAJTextBox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.Tel =    TelTextBox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.TipTanf =   (Tanf)TanfTipCombo.SelectedIndex;
          StudentsList.First(x => x.Id == CurrentId).SDetails.Tszama =    TanfSzamTextBox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.Bsz =    bszTextBox.Text;
          StudentsList.First(x => x.Id == CurrentId).SDetails.JStatus =    (JobStatus)jobstatusCB.SelectedIndex;
          StudentsList.First(x => x.Id == CurrentId).SDetails.PastOkj =    okjbizszamCB.SelectedIndex;
           Main parentT = (Main)this.Owner;
           parentT.UpdateStudents(StudentsList);
           this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Befizet befform = new Befizet(StudentsList.First(x => x.Id == CurrentId).SPayment, CurrentId))
            {
                befform.ShowDialog(this);
            }
        }
        #endregion
    }
}
