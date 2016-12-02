using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;
using HomeTask;


namespace ConsoleApplication1
{
    class Program
    {
        //static void insertIntoChemistryElement(ChemistryElement chElem, MySqlCommand command)
        //{
        //    command.CommandText = "INSERT INTO ChemistryElement "+
        //        "(FullName,TableName,Description,Groupp,Valence,Period,AtomicWeight,Orbital,GraphicModel,Formula,NaturalName)"+ 
        //        "Values (?ful,?tbl,?dscr,?grp,?vlns,?per,?aw,?orbt,?grphic,?frml,?ntral)";
        //    command.Prepare();
        //    command.Parameters.AddWithValue("?ful", chElem.FullName);
        //    command.Parameters.AddWithValue("?tbl", chElem.TableTame);
        //    command.Parameters.AddWithValue("?dscr", chElem.Description);
        //    command.Parameters.AddWithValue("?grp", chElem.Group);
        //    command.Parameters.AddWithValue("?vlns", chElem.Valence);
        //    command.Parameters.AddWithValue("?per", chElem.Period);
        //    command.Parameters.AddWithValue("?aw", chElem.AtomicWeight);
        //    command.Parameters.AddWithValue("?orbt", chElem.Orbital);
        //    command.Parameters.AddWithValue("?grphic", chElem.GraphicModel);
        //    command.Parameters.AddWithValue("?frml", chElem.Formula);
        //    command.Parameters.AddWithValue("?ntral", chElem.NaturalName);
        //    command.ExecuteNonQuery();
        //}
        

        static void Main(string[] args)
        {



            ChemisrtyService chemistryService = new ChemisrtyService();
            chemistryService.connect();

            chemistryService.open();
            MySqlCommand command = chemistryService.getConnection().CreateCommand();
            chemistryService.setCommand(command);

            ChemistryElement chElem = new ChemistryElement("FullName1", "TableName",
               "Desciption1", 12, "IV", 5, 2.0, 't', "C:/", "Formula1", "Natural1");
          
            //chemistryService.add(chElem);
            //ChemistryElement chem = chemistryService.findOne(2);
            //List<ChemistryElement> chemElements = chemistryService.findAll();

            //foreach(ChemistryElement ch in chemElements){
                //Console.Write("----------------------------------------------------\n");
                //Console.WriteLine(ch);
                //Console.Write("----------------------------------------------------\n");
            //}

            chemistryService.delete(2);
            chemistryService.close();
            
            


            //command.CommandText = "select * from ChemistryElement";

            //MySqlDataReader reader = command.ExecuteReader();
            //int i = 0;
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString()+","+reader[1].ToString()+","+reader[2].ToString());
            //    i++;
            //}

            //Console.Write(i);
            Console.ReadKey();
        }
    }
}
