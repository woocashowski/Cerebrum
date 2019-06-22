using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Cerebrum
{
    class Download
    {
        public static List<Product> Products;
        //Products = new List<Przedmiot>();

        public static List<Product> generate()
        {
            //WszystkiePrzedmioty = new List<Przedmiot>();
            Products = new List<Product>();
            //Products.Add(new Product(1, 0, 0, 0, "woda"));
            //Console.WriteLine("{0} {1} {2} {3} {4}", Products[0].id, Products[0].protein, Products[0].fat, Products[0].carbs, Products[0].name);
            Random rand = new Random();
            for (uint i = 1; i <= 1000; i++)
            {
                Products.Add(new Product(i, Convert.ToUInt32(rand.Next(0, 31)), Convert.ToUInt32(rand.Next(0, 31)), Convert.ToUInt32(rand.Next(0, 31)), " nazwa "));
                //Console.WriteLine("{0} {1} {2} {3} {4}", Products[Convert.ToInt32(i)].id, Products[Convert.ToInt32(i)].protein, Products[Convert.ToInt32(i)].fat, Products[Convert.ToInt32(i)].carbs, Products[Convert.ToInt32(i)].name);
            }
            //Console.WriteLine("{0} {1} {2} {3} {4}", Products[2].id, Products[2].protein, Products[2].fat, Products[2].carbs, Products[2].name);
            return Products;
        }
        



        public static List<Product> download()
        {
            Products = new List<Product>();
            string connstring = @"server=mysql30.mydevil.net;userid=m1282_polsl;password=Projekt123;database=m1282_Produkty";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();

                string query = "SELECT * FROM Jedzenie;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Mieso");
                DataTable dt = ds.Tables["Mieso"];

                foreach (DataRow row in dt.Rows)
                {
                    /*foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "\t");
                    }
                    Console.Write(row[0] + "\t");
                    Console.Write(row[1] + "\t");
                    Console.Write(row[6] + "\t");
                    Console.Write(row[7] + "\t");
                    Console.Write(row[8] + "\t");
                    Console.Write("\n");*/
                    Products.Add(new Product(Convert.ToUInt32(row[0]), Convert.ToUInt32(row[8]), Convert.ToUInt32(row[7]), Convert.ToUInt32(row[6]), Convert.ToString(row[1])));

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            //System.Console.ReadLine();




            return Products;
        }
    }
}
