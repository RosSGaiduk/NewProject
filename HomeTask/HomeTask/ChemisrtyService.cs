using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;

namespace HomeTask
{
    class ChemisrtyService
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader = null;
        private string myConnectionString = "Database=chemistry_book;Data Source=localhost;User Id=root;Password=123456root";

        public ChemisrtyService() {
              
        }
        public ChemisrtyService(MySqlConnection conn, MySqlCommand comm) { connection = conn;  command = comm; }
        public MySqlConnection getConnection(){ return connection; }
        public MySqlCommand getCommand() { return command; }
        public void setConnection(MySqlConnection conn) { connection = conn; }
        public void setCommand(MySqlCommand comm) { command = comm; }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////MAIN QUERIES////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void add(ChemistryElement chElem)
        {
            command.CommandText = "INSERT INTO ChemistryElement " +
               "(FullName,TableName,Description,Groupp,Valence,Period,AtomicWeight,Orbital,GraphicModel,Formula,NaturalName)" +
               "Values (?ful,?tbl,?dscr,?grp,?vlns,?per,?aw,?orbt,?grphic,?frml,?ntral)";
            command.Prepare();
            command.Parameters.AddWithValue("?ful", chElem.FullName);
            command.Parameters.AddWithValue("?tbl", chElem.TableTame);
            command.Parameters.AddWithValue("?dscr", chElem.Description);
            command.Parameters.AddWithValue("?grp", chElem.Group);
            command.Parameters.AddWithValue("?vlns", chElem.Valence);
            command.Parameters.AddWithValue("?per", chElem.Period);
            command.Parameters.AddWithValue("?aw", chElem.AtomicWeight);
            command.Parameters.AddWithValue("?orbt", chElem.Orbital);
            command.Parameters.AddWithValue("?grphic", chElem.GraphicModel);
            command.Parameters.AddWithValue("?frml", chElem.Formula);
            command.Parameters.AddWithValue("?ntral", chElem.NaturalName);
            command.ExecuteNonQuery();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ChemistryElement findOne(int id)
        {
            command.CommandText = "Select * from ChemistryElement where id = ?id";
            command.Prepare();
            command.Parameters.AddWithValue("?id", id);
            reader = command.ExecuteReader();
            reader.Read();
            ChemistryElement chemistryElement;

            try
            {
                string str = reader[8].ToString();
                char c = str[0];
                chemistryElement = new ChemistryElement(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(),
                int.Parse(reader[6].ToString()), double.Parse(reader[7].ToString()), c, reader[9].ToString(), reader[10].ToString(), reader[11].ToString());
                //Console.Write(chemistryElement);
                reader.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                return null;
            }
          
            return chemistryElement;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<ChemistryElement> findAll()
        {
            List<ChemistryElement> chemistryElements = new List<ChemistryElement>();
            command.CommandText = "Select * from ChemistryElement";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string str = reader[8].ToString();
                char c = str[0];
                chemistryElements.Add(new ChemistryElement(int.Parse(reader[0].ToString()),reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()),
                    reader[5].ToString(),int.Parse(reader[6].ToString()), double.Parse(reader[7].ToString()),c, reader[9].ToString(), 
                    reader[10].ToString(), reader[11].ToString()));
            }
            reader.Close();
            return chemistryElements;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void delete(int id)
        {
            command.CommandText = "Delete from ChemistryElement where id = ?id1";
            command.Prepare();
            command.Parameters.AddWithValue("?id1", id);
            command.ExecuteNonQuery();
        }
        

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public void connect()
        {
            try
            {
                connection = new MySqlConnection(myConnectionString);
                Console.WriteLine("connected");
            }
            catch (MySqlException e)
            {
                Console.Write("Error:" + e.ToString());
            }
        }

        public void open(){  connection.Open();}
        public void close() { connection.Close(); }
    }
}
