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

    [Table("Metals")]
    public class Metal : ChemistryElement
    {

        public Metal() {}
        public Metal(string f, string t, string d, int g, string v, 
            int p, double aw, char or, string url)
        {
            FullName = f; TableTame = t; Description = d; Group = g; Valence = v; Period = p; AtomicWeight = aw;
            Orbital = or; //UrlOfImage = url;
        }

        public string FullName { get; set; }
        public string TableTame { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public string Valence { get; set; }
        public int Period { get; set; }
        public double AtomicWeight { get; set; }
        public char Orbital { get; set; }

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
    }

    [Table("Picture")]
    public class GraphicModel
    {
        public int Id { get; set; }
        public ChemistryElement ChemistryElement { get; set; }
    }
}
