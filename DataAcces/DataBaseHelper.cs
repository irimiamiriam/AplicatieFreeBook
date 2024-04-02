using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.DataAcces
{
    class DataBaseHelper
    {
        private static readonly string _connectionstring = SqlDataAccess.GetConnectionString();
        private static readonly string _cartipath = SqlDataAccess.GetCartiFile();
        private static readonly string _imprumuturipath = SqlDataAccess.GetImprumuturiFile();
        private static readonly string _utilizatoripath = SqlDataAccess.GetUtilizatoriFile();

        public static void Initialisation()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                DeleteDatabaseData(con);
                InsertIntoUtilizatori(con);
                InsertIntoCarti(con);
                InsertIntoImprumuturi(con);
            }
        }

       public static void DeleteDatabaseData(SqlConnection con)
        {
            SqlCommand cmdDeleteCarti = new SqlCommand("Delete from carti", con);
            SqlCommand cmdDeleteUtilizatori = new SqlCommand("Delete from utilizatori", con);
            SqlCommand cmdDeleteImprumuturi = new SqlCommand("Delete from imprumut", con);
            SqlCommand cmdResetCarti = new SqlCommand("DBCC CHECKIDENT (carti, RESEED, 0)",con);
            SqlCommand cmdResetImprumut= new SqlCommand("DBCC CHECKIDENT (imprumut, RESEED, 0)", con);
            cmdDeleteCarti.ExecuteNonQuery();
            cmdDeleteImprumuturi.ExecuteNonQuery();
            cmdDeleteUtilizatori.ExecuteNonQuery();
            cmdResetCarti.ExecuteNonQuery();
            cmdResetImprumut.ExecuteNonQuery();

        }
        
        public static void InsertIntoCarti(SqlConnection con)
        {
             
                string cmdInsert = "Insert into carti (titlu,autor ,gen) values (@titlu, @autor, @gen)";
                using (StreamReader reader = new StreamReader(_cartipath))
                {
                    while (reader.Peek() > 0)
                    {
                        string line = reader.ReadLine();
                        var splitedline = line.Split('*');
                        using (SqlCommand cmd = new SqlCommand(cmdInsert, con))
                        {
                            cmd.Parameters.AddWithValue("@titlu", splitedline[0]);
                            cmd.Parameters.AddWithValue("@autor", splitedline[1]);
                            cmd.Parameters.AddWithValue("@gen", splitedline[2]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

            

        }
        public static void InsertIntoUtilizatori(SqlConnection con)
        {
           
                string cmdInsert = "Insert into utilizatori values (@email, @parola, @nume, @prenume)";
                using (StreamReader reader = new StreamReader(_utilizatoripath))
                {
                    while (reader.Peek() > 0)
                    {
                        string line = reader.ReadLine();
                        var splitedline = line.Split('*');
                        using (SqlCommand cmd = new SqlCommand(cmdInsert, con))
                        {
                            cmd.Parameters.AddWithValue("@email", splitedline[0]);
                            cmd.Parameters.AddWithValue("@parola", splitedline[1]);
                            cmd.Parameters.AddWithValue("@nume", splitedline[2]);
                            cmd.Parameters.AddWithValue("@prenume", splitedline[3]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                

            }
        }
        public static void InsertIntoImprumuturi(SqlConnection con)
        {
            int idCarte = 0;
           
                string cmdInsert = "Insert into imprumut (id_carte,email,data_imprumut) values (@id, @email, @data)";
                string cmdFindId = "Select id_carte from carti where titlu=@titlu";
                
                using (StreamReader reader = new StreamReader(_imprumuturipath))
                {
                    while (reader.Peek() > 0)
                    {
                        string line = reader.ReadLine();
                        var splitedline = line.Split('*');

                      using(SqlCommand cmdFind = new SqlCommand(cmdFindId, con))
                     {
                            cmdFind.Parameters.AddWithValue("@titlu", splitedline[0]);
                        using (SqlDataReader reader1 = cmdFind.ExecuteReader())
                        {
                            reader1.Read();
                            idCarte = (int)reader1[0];
                        }
                     }

                        using (SqlCommand cmd = new SqlCommand(cmdInsert, con))
                        {
                            cmd.Parameters.AddWithValue("@id", idCarte);
                            cmd.Parameters.AddWithValue("@email", splitedline[1]);
                             string dateString = splitedline[2].Trim();
                            DateTime data = DateTime.ParseExact(dateString, "m/d/yyyy", null);
                            cmd.Parameters.AddWithValue("@data", data);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            
        }

        public static bool CheckEmail(string email)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from utilizatori where email = @email";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader= cmd.ExecuteReader();
                    if(reader.HasRows) { return false; }
                    else return true;
                }
            }
        }

        public static void CreateUser(UtilizatorModel utilizator)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdInsert = "Insert into utilizatori values (@email, @parola, @nume, @prenume)";
                using (SqlCommand cmd = new SqlCommand(cmdInsert, con))
                {
                    cmd.Parameters.AddWithValue("@email", utilizator.Email);
                    cmd.Parameters.AddWithValue("@parola", utilizator.Password);
                    cmd.Parameters.AddWithValue("@nume", utilizator.Nume);
                    cmd.Parameters.AddWithValue("@prenume", utilizator.Prenume);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static UtilizatorModel GetUtilizator(string email, string pass)
        {
            UtilizatorModel utilizator = new UtilizatorModel();
            using(SqlConnection con = new SqlConnection(_connectionstring)) 
            {
                con.Open();
                string cmdText = "Select * from utilizatori where email=@email and parola=@pass";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if(reader.HasRows)
                    {
                        utilizator.Email= reader[0].ToString();
                        utilizator.Password = reader[1].ToString();
                        utilizator.Nume= reader[2].ToString();
                        utilizator.Prenume= reader[3].ToString();
                    }
                }
            }
            return utilizator;
        }

        public static DataTable GetCartiDisponibile()
        {
           
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Titlu");
            dataTable.Columns.Add("Autor");
            dataTable.Columns.Add("Gen");
            using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from carti";
                using(SqlCommand cmd = new SqlCommand(cmdText, con)) 
                {
                    using(SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                        }
                    }
                }
            }

            return dataTable;
        }

        public static DataTable GetCartiImprumutate(string email)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Titlu");
            dataTable.Columns.Add("Autor");
            dataTable.Columns.Add("Data Imprumut");
            dataTable.Columns.Add("Data Disponibilitate");
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from imprumut where @email=email";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] detalii = CarteImprumut(Convert.ToInt32(reader[1]));
                            DateTime dataImprumut = DateTime.ParseExact(reader[3].ToString(), "M/d/yyyy hh:mm:ss tt", null);
                            DateTime dataDisponibil = dataImprumut.AddDays(30);
                            dataTable.Rows.Add(detalii[0], detalii[1], dataImprumut, dataDisponibil);

                        }
                    }
                }
            }

            return dataTable;
        }

        public static string[] CarteImprumut(int id)
        {
            string[] detaliicarte= new string[2];
            
            using(SqlConnection  con = new SqlConnection(_connectionstring)) 
            {
                con.Open();
                string cmdText = "Select titlu, autor from carti where id_carte=@id";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@id",id);
                    using(SqlDataReader reader= cmd.ExecuteReader())
                    {
                        reader.Read();
                        detaliicarte[0] = reader[0].ToString();
                        detaliicarte[1] = reader[1].ToString();

                    }
                }
            }
            return detaliicarte; 
        }

        public static int GetCarteId(string titlu)
        {
            int carteId = 0;
            using(SqlConnection con = new SqlConnection(_connectionstring)) 
            {
                con.Open();
                string cmdText = "Select id_carte from carti where titlu=@titlu";
                using(SqlCommand cmd= new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@titlu", titlu);
                    using(SqlDataReader reader= cmd.ExecuteReader()) 
                    {

                        while (reader.Read()) { carteId = Convert.ToInt32(reader[0]); }
                    }
                }
            }
            return carteId;
        }

    }
}
