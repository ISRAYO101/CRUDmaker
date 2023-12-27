using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUD_Tako.Acciones
{
    public class CX
    {
        public static SqlConnection CargarDGV(){

        SqlConnection connect = new SqlConnection(" Data Source= LAPTOP-5MRSR4VJ; Initial CATALOG= EXCALIBUR ;Integrated Security=True; ");
         //SqlConnection connect = new SqlConnection(" Server= LAPTOP-5MRSR4VJ; DATABASE= EXCALIBUR ;Integrated Security=True; ");
            connect.Open();
         return connect;
        
        }

        public static DataTable LlenarDatos()
        {  
            CargarDGV();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM TBLINFOGRAL";
            SqlCommand cmd = new SqlCommand(consulta, CargarDGV());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static string GuardarGeneros(CheckedListBox checkedList)
        {
            StringBuilder checados = new StringBuilder();
            for (int i = 0; i < checkedList.Items.Count; i++)
            {
                if (checkedList.GetItemChecked(i))
                {
                    checados.AppendLine(checkedList.Items[i].ToString());
                    checados.AppendLine( " " );
                     
                }
            }
            return checados.ToString();
        }



    }

} 


