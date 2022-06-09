using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bus
{
    class DataBase
    {
        
        public SqlConnection con {get; set;}
        public DataBase() 
        {
            con = new SqlConnection(@"Data Source=DESKTOP-L4CO6B8\SQLEXPRESS;Initial Catalog=Test232;Integrated Security=True");
        }

        public DataView getBus() 
        {
            DataTable data = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand("Select * from Router", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                data.Load(sdr);
                con.Close();
                return data.DefaultView;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return data.DefaultView;
            }
           
        }

        public void insertNewBus(string model, DateTime time) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"Insert into Table_1 values ('{model}', '{time}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataView getBusTable()
        {
            DataTable data = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Table_1", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                data.Load(sdr);
                con.Close();
                return data.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return data.DefaultView;
            }

        }

        public DataView getSelectedValue(string table, int index) 
        {
            DataTable data = new DataTable();
                SqlCommand cmd = new SqlCommand($"Select * from {table} where id = {index}", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                data.Load(sdr);
                con.Close();
                return data.DefaultView;
            
        }
    }
}
