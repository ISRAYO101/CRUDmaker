using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CRUD_Tako.Acciones
{
    public class cAgregar
    {
        
        public static void GuardarData() 
        {
   
             Principal? form = Application.OpenForms["Principal"] as Principal;
             if (form != null)
             {
                string name = form.GuardarNombre();
                DateTime Date = form.GuardarFecha();
                string studio = form.GuardarEstudio();
                string points = form.GuardarPuntaje();
                string Gen = form.GuardarChk();

                string insert = "INSERT INTO TBLINFOGRAL (NOMBRE, FECHAEMISIÓN, GENERO, ESTUDIO, CALIFPERSONAL)" +
                "VALUES (@NOMBRE,@FECHAEMISIÓN,@GENERO, @ESTUDIO, @CALIFPERSONAL);";
                SqlCommand cmdG = new SqlCommand(insert, CX.CargarDGV());
                cmdG.Parameters.AddWithValue("@NOMBRE", name);
                cmdG.Parameters.AddWithValue("@FECHAEMISIÓN", Date);
                cmdG.Parameters.AddWithValue("@GENERO", Gen);
                cmdG.Parameters.AddWithValue("@ESTUDIO", studio);
                cmdG.Parameters.AddWithValue("@CALIFPERSONAL", points);

                cmdG.ExecuteNonQuery();
             }
    
                MessageBox.Show("Nuevo Anime Agregado ('u')");

        } 
    }
}
