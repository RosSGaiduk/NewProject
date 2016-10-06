using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTask
{
    public abstract class ChemistryElement
    {
        public ChemistryElement() { }

        public ChemistryElement(string f, string t, string d, int g, 
            string v, int p, double aw, char or, string url)
        { }
        public int Id { get; set; }
        public GraphicModel GraphicModel { get; set; }
    }

    [Table("LujniMetals")]
    public class LujnyiMetal : ChemistryElement
    {
        public LujnyiMetal() {}
        public LujnyiMetal(string f, string t, string d, int g, string v, 
            int p, double aw, char or, string url,string formula,string natural)
        {
            FullName = f; TableTame = t; Description = d; Group = g; Valence = v; Period = p; AtomicWeight = aw;
            Orbital = or; //UrlOfImage = url;
            Formula = formula;
            NaturalName = natural;
        }
        public string FullName { get; set; }
        public string TableTame { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public string Valence { get; set; }
        public int Period { get; set; }
        public double AtomicWeight { get; set; }
        public char Orbital { get; set; }
        public string UrlOfImage { get; set; }
        public string NaturalName { get; set; }
        public string Formula { get; set; }
    }

    [Table("LujnozemelniMetals")]
    public class LujnozemelniMetal : ChemistryElement
    {

        public LujnozemelniMetal() { }
        public LujnozemelniMetal(string f, string t, string d, int g, string v,
            int p, double aw, char or, string url,string natural,string formula)
        {
            FullName = f; TableTame = t; Description = d; Group = g; Valence = v; Period = p; AtomicWeight = aw;
            Orbital = or; //UrlOfImage = url;
            Formula = formula;
            NaturalName = natural;
        }
        public string FullName { get; set; }
        public string TableTame { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public string Valence { get; set; }
        public int Period { get; set; }
        public double AtomicWeight { get; set; }
        public char Orbital { get; set; }
        public string UrlOfImage { get; set; }
        public string NaturalName { get; set; }
        public string Formula { get; set; }
    }

    [Table("GalogyenniGazy")]
    public class GalogyenniGazy : ChemistryElement
    {

        public GalogyenniGazy() { }
        public GalogyenniGazy(string f, string t, string d, int g, string v,
            int p, double aw, char or, string url, string natural, string formula)
        {
            FullName = f; TableTame = t; Description = d; Group = g; Valence = v; Period = p; AtomicWeight = aw;
            Orbital = or; //UrlOfImage = url;
            Formula = formula;
            NaturalName = natural;
        }
        public string FullName { get; set; }
        public string TableTame { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public string Valence { get; set; }
        public int Period { get; set; }
        public double AtomicWeight { get; set; }
        public char Orbital { get; set; }
        public string UrlOfImage { get; set; }
        public string NaturalName { get; set; }
        public string Formula { get; set; }
    }

    [Table("BlagorodniGazu")]
    public class BlagorodniGazu : ChemistryElement
    {

        public BlagorodniGazu() { }
        public BlagorodniGazu(string f, string t, string d, int g, string v,
            int p, double aw, char or, string url, string natural, string formula)
        {
            FullName = f; TableTame = t; Description = d; Group = g; Valence = v; Period = p; AtomicWeight = aw;
            Orbital = or; //UrlOfImage = url;
            Formula = formula;
            NaturalName = natural;
        }
        public string FullName { get; set; }
        public string TableTame { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public string Valence { get; set; }
        public int Period { get; set; }
        public double AtomicWeight { get; set; }
        public char Orbital { get; set; }
        public string UrlOfImage { get; set; }
        public string NaturalName { get; set; }
        public string Formula { get; set; }
    }

    [Table("NotMetals")]
    public class NotMetal : ChemistryElement
    {
        public NotMetal() { }
        public NotMetal(string f,string t,string d,int g,
            string v,int p,double aw,char or,string url)
        {
            FullName = f; TableTame = t; Description = d; Group = g; Valence = v; Period = p; AtomicWeight = aw;
            Orbital = or; UrlOfImage = url;
        }
        public string FullName { get; set; }
        public string TableTame { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public string Valence { get; set; }
        public int Period { get; set; }
        public double AtomicWeight { get; set; }
        public char Orbital { get; set; }
        public string UrlOfImage { get; set; }
        public string NaturalName { get; set; }
        public string Formula { get; set; }
    }
    [Table("Picture")]
    public class GraphicModel
    {
        public int Id { get; set; }
        public ChemistryElement ChemistryElement { get; set; }
    }
}
