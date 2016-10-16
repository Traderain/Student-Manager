using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OKJ2._0
{
    public partial class Main : Form
    {
        public string Savefilename = "";

        public List<Student> Tanulos;
        public int CurrentTanuloId = 0;

        public List<Student> GetTanuloList()
        {
            return Tanulos;
        }
        public Main()
        {
            InitializeComponent();
            Tanulos = new List<Student>();
            MainFormUpdate();
        }

        #region Fájl TOOLSTIPMENU
        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Load  
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "XML Fájlok|*.xml";
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                Savefilename = ofDialog.FileName;
                ConsoleLog(Load(Savefilename)
                    ? $" A {ofDialog.FileName}-ból az adatok be lettek töltve!"
                    : "Hiba a betöltés közben!");
            }
            else
                ConsoleLog("Hiba a megnyitás közben :s");

            #endregion
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void mentésMáskéntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveas = new SaveFileDialog();
            saveas.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveas.Filter = "XML Fájlok|*.xml";
            saveas.DefaultExt = "xml";
            saveas.AddExtension = true;

            if (saveas.ShowDialog() == DialogResult.OK)
            {
                Savefilename = saveas.FileName;
                ConsoleLog($"Mentve {saveas.FileName} néven!");
                Save();
            }
            else
                ConsoleLog($"Hiba a mentés közben :s");
        }
        #endregion

        #region Tanuló TOOLSTRIP
        private void kijelöltTörláseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in tanuloMemberDGV.SelectedRows)
                Tanulos.RemoveAll(x => x.Id == (int) r.Cells[0].Value);
            MainFormUpdate();
            ConsoleLog($"A kijelölt tanulók törölve lettek!");
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentTanuloId != 0)
            {
                using (Tanulo settingsForm = new Tanulo(Tanulos, CurrentTanuloId))
                    settingsForm.ShowDialog(this);
                ConsoleLog($"A {CurrentTanuloId} szerkesztve!");
            }
            else
                ConsoleLog("HIBA: ID-> 0");
        }

        private void újTanulóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsoleLog($"Az új tanuló létrehozva!");
            Tanulos.Add(new Student(FindHighestId()+1));
            MainFormUpdate();
        }
        #endregion

        #region Methods 
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region ConfirmClosing
            DialogResult exitResult = MessageBox.Show("Biztos ,hogy ki szeretnél lépni?\nMinden nem mentett adat el fog veszni!",
                "Figyelem!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (exitResult == DialogResult.No)
                e.Cancel = true;

            #endregion
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"OKJ Tanulónyílvántartó v0.1a",@"BUILD 2016-07-09",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tanuloMemberDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (tanuloMemberDGV.SelectedRows.Count > 0)
                CurrentTanuloId = (int) tanuloMemberDGV.SelectedRows[0].Cells[0].Value;
            using (Tanulo settingsForm = new Tanulo(Tanulos, CurrentTanuloId))
                settingsForm.ShowDialog(this);
            ConsoleLog($"Az ID:{CurrentTanuloId} szerkesztve!");
        }

        private void tanuloMemberDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (tanuloMemberDGV.SelectedRows.Count > 0)
                CurrentTanuloId = (int) tanuloMemberDGV.SelectedRows[0].Cells[0].Value;
        }
        public void UpdateStudents(List<Student> newlist)
        {
            Tanulos = newlist;
            MainFormUpdate();
        }
        public void MainFormUpdate()
        {
            var tanuloQry = Tanulos.Select(x => new { ID = x.Id, x.SDetails.Nev.Value });
            tanuloMemberDGV.DataSource = tanuloQry.ToArray();
            tanuloMemberDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (var i = 0; i < tanuloMemberDGV.Columns.Count; i++)
            {
                tanuloMemberDGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tanuloMemberDGV.Columns[i].ReadOnly = true;
            }
        }

        public void Save()
        {
            if (Savefilename == "")
            {
                #region SaveAS
                MessageBox.Show("A fájl még nem lett mentve kérlek válaszd ki a nevet és helyet!", "Figyelem!", MessageBoxButtons.OK);
                SaveFileDialog saveas = new SaveFileDialog();
                saveas.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveas.Filter = "XML Fájlok|*.xml";
                saveas.DefaultExt = "xml";
                saveas.AddExtension = true;

                if (saveas.ShowDialog() == DialogResult.OK)
                {
                    Savefilename = saveas.FileName;
                    XDocument saveFileX = new XDocument(
                    new XElement("tanulok_lista",
                    from t in Tanulos
                    select new XElement("tanulo",
                                new XAttribute("ID", t.Id),
                           new XElement("details",
                                new XElement("nev", t.SDetails.Nev.Value),
                                new XElement("anyja_neve", t.SDetails.Anyjaneve),
                                new XElement("bizonyitvany_szama", t.SDetails.Bsz),
                                new XElement("iskolai_vegzettseg", (int)t.SDetails.IskVegz),
                                new XElement("munka_statusz", (int)t.SDetails.JStatus),
                                new XElement("lakcim", t.SDetails.Lakcim),
                                new XElement("volt_okj", t.SDetails.PastOkj),
                                new XElement("szuletesi_hely", t.SDetails.SzulHely),
                                new XElement("szuletesi_ido", t.SDetails.SzulIdo.ToString("yyyy MMMM dd")),
                                new XElement("taj", t.SDetails.Taj),
                                new XElement("telefon", t.SDetails.Tel),
                                new XElement("tanfolyam_tipus", (int)t.SDetails.TipTanf),
                                new XElement("tanfolyam_szama", t.SDetails.Tszama)),
                            new XElement("befizetesek",
                                  from entry in t.SPayment
                                  select new XElement("befizetes",
                                                                 new XElement("tipus", entry.Jellege),
                                                                 new XElement("mennyiseg", entry.Mennyiség),
                                                                 new XElement("datum", entry.date))))));

                    saveFileX.Save(Savefilename);
                    ConsoleLog($"Mentve {Savefilename} néven!");
                }
                else
                {
                    ConsoleLog($"Hiba a mentés közben :s");
                }
                #endregion
            }
            else
            {
                #region Save
                XDocument saveFileX = new XDocument(
                new XElement("tanulok_lista",
                from t in Tanulos
                select new XElement("tanulo",
                            new XAttribute("ID", t.Id),
                       new XElement("details",
                            new XElement("nev", t.SDetails.Nev.Value),
                            new XElement("anyja_neve", t.SDetails.Anyjaneve),
                            new XElement("bizonyitvany_szama", t.SDetails.Bsz),
                            new XElement("iskolai_vegzettseg", (int)t.SDetails.IskVegz),
                            new XElement("munka_statusz", (int)t.SDetails.JStatus),
                            new XElement("lakcim", t.SDetails.Lakcim),
                            new XElement("volt_okj", t.SDetails.PastOkj),
                            new XElement("szuletesi_hely", t.SDetails.SzulHely),
                            new XElement("szuletesi_ido", t.SDetails.SzulIdo.ToString("yyyy MMMM dd")),
                            new XElement("taj", t.SDetails.Taj),
                            new XElement("telefon", t.SDetails.Tel),
                            new XElement("tanfolyam_tipus", (int)t.SDetails.TipTanf),
                            new XElement("tanfolyam_szama", t.SDetails.Tszama)),
                        new XElement("befizetesek",
                              from entry in t.SPayment
                            select new XElement("befizetes",
                                                           new XElement("tipus", entry.Jellege),
                                                           new XElement("mennyiseg", entry.Mennyiség),
                                                           new XElement("datum", entry.date))))));

                saveFileX.Save(Savefilename);
                ConsoleLog("Mentve!");
                #endregion
            }
            MainFormUpdate();
        }

        public new bool Load(string path)
        {
            #region XMLLoadMagic
            try
            {
                var xDoc = XDocument.Load(path);
                List<Student> UpdatedTanulos = new List<Student>(xDoc
                    .Descendants("tanulo")
                        .Select(x => new Student(Convert.ToInt32(x.Attribute("ID").Value),
                                                new Details(x.Element("details").Element("nev").Value,
                                                            x.Element("details").Element("szuletesi_hely").Value,
                                                            DateTime.Parse(x.Element("details").Element("szuletesi_ido").Value.ToString()),
                                                            x.Element("details").Element("anyja_neve").Value,
                                                            x.Element("details").Element("lakcim").Value,
                                                            Convert.ToInt32(x.Element("details").Element("iskolai_vegzettseg").Value),
                                                            x.Element("details").Element("taj").Value,
                                                            x.Element("details").Element("telefon").Value,
                                                            Convert.ToInt32(x.Element("details").Element("tanfolyam_tipus").Value),
                                                            x.Element("details").Element("tanfolyam_szama").Value,
                                                            x.Element("details").Element("bizonyitvany_szama").Value,
                                                            Convert.ToInt32(x.Element("details").Element("volt_okj").Value),
                                                            Convert.ToInt32(x.Element("details").Element("munka_statusz").Value)),
                                                new List<Payment>(x.Element("befizetesek").Elements("befizetes")
                                                                        .Select(z => new Payment(
                                                                                            z.Element("mennyiseg").Value,
                                                                                            z.Element("tipus").Value,
                                                                                            DateTime.Parse(z.Element("datum").Value)))))));
                Tanulos = UpdatedTanulos;
                Savefilename = path;
                this.Text = @"OKJ Tanulókezelő -" + Savefilename;
                MainFormUpdate();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Hibás fájl. Az adatokat nem sikerült betölteni X(",@"HIBA!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            #endregion
        }

        public int FindHighestId()
        {
            return (!Tanulos.Any()) ? 0 : Tanulos.OrderByDescending(x => x.Id).First().Id;
        }

        public void ConsoleLog(string s)
        {
            konzol.Text = konzol.Text + @"
" + s + @" - " + DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }
        #endregion
    }
}
