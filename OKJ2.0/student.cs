using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKJ2._0
{
    #region Student [MAIN]
    public class Student //A tanuló class. Ez a main class.
    {
        public int Id { get; set; }
        public Details SDetails { get; set; }
        public List<Payment> SPayment { get; set; }

        public Student(int id)
        {
            Id = id;
            SPayment = new List<Payment>();
            SDetails = new Details();
        }

        public Student(int id, Details d, List<Payment> Plist)
        {
            this.Id = id;
            this.SDetails = d;
            this.SPayment = Plist;
        }

    }
    #endregion

    #region StudentEntry
    public class Studententry //Main formban a tanuló Idje meg a a neve. A datagridviewbe kell.
    {
        public int Id { get; set; }
        public StringValue Name { get; set; }

        public Studententry(Student a)
        {
            Id = a.Id;
            Name = a.SDetails.Nev;
        }
    }
    #endregion

    #region Tanfolyam enum
    public enum Tanf
    {
        Emelőgép = 0,
        Targonca = 1,
        Földmunkagép = 2,
        Útépítő = 3,
        Építési_anyagelőkészítő = 4,
        Nincs = 5
    }
    #endregion

    #region Vegz enum
    public enum Vegz
    {
        Nyolc_általános = 0,
        Szakmunkás_végzettség = 1,
        Érettség_bizonyítvány = 2,
        Főiskolai_végzettség = 3,
        Technikusi_végzettség = 4,
        Nincs = 5
    }
    #endregion

    #region Korábbi OKJ
    public enum JobStatus
    {
        Tanuló = 0,
        Alkalmazott = 1,
        Vállalkozó = 2,
        Munkanélküli = 3
    }
    #endregion

    #region Details
    public class Details //Tanuló adatai.
    {
        public StringValue Nev { get; set; } = new StringValue("Minta Ferenc");
        public string SzulHely { get; set; } = "Paks";
        public DateTime SzulIdo { get; set; } = DateTime.Today;
        public string Anyjaneve { get; set; } = "Minta Ágnes";
        public string Lakcim { get; set; } = "0000 Paks Minta utca 1.";
        public Vegz IskVegz { get; set; } = Vegz.Nincs;
        public string Taj { get; set; } = "ABC123";
        public string Tel { get; set; } = "012456789";
        public Tanf TipTanf { get; set; } = Tanf.Nincs;
        public string Tszama { get; set; } = "123";
        public string Bsz { get; set; } = "ABC123";
        public int PastOkj { get; set; } = 0;
        public JobStatus JStatus { get; set; } = JobStatus.Tanuló;

        public Details(string Neve,string szul_hely,DateTime szIdo,string anyjaneve,string lcim,int ivegz,string tajszam,string telefon,int tanf_tipus,string tan_szama,string bizszama,int voltokj,int munkaall)
        {
            this.Nev = new StringValue(Neve);
            this.SzulHely = szul_hely;
            this.SzulIdo = szIdo;
            this.Anyjaneve = anyjaneve;
            this.Lakcim = lcim;
            this.IskVegz = (Vegz) ivegz;
            this.Taj = tajszam;
            this.Tel = telefon;
            this.TipTanf = (Tanf) tanf_tipus;
            this.Tszama = tan_szama;
            this.Bsz = bizszama;
            this.PastOkj = voltokj;
            this.JStatus = (JobStatus) munkaall;
        }

        public Details()
        {
            
        }
    }
    #endregion

    #region Payment
    public class Payment //Befizetés class. A Befizetés formban használjuk.
    {
        public string Jellege;
        public string Mennyiség;
        public DateTime date;

        public Payment(string valu, string rea,DateTime d)
        {
            this.Mennyiség = valu;
            this.Jellege = rea;
            this.date = d;
        }
    }
    #endregion

    #region StringValue class
    public class StringValue //A MS retardált és csak így lehet megjeleníteni datagridview-ben.
    {
        public StringValue(string s)
        {
            Value = s;
        }
        public string Value { get; set; }
    }
    #endregion
}
