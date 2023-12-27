using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Tako.Acciones
{
    public class cEditar
    {
        public static void EditarData()
        {
            Principal? form = Application.OpenForms["Principal"] as Principal;
            if (form != null)
            {
                string name = form.GuardarNombre();
                DateTime Date = form.GuardarFecha();
                string studio = form.GuardarEstudio();
                string points = form.GuardarPuntaje();
                string Gen = form.GuardarChk();

                string update = "UPDATE TBLINFOGRAL SET NOMBRE=@NOMBRE, FECHAEMISIÓN=@FECHAEMISIÓN, GENERO= @GENERO, " +
                    "ESTUDIO=@ESTUDIO, CALIFPERSONAL=@CALIFPERSONAL WHERE NOMBRE=@NOMBRE";
                SqlCommand cmdG = new SqlCommand(update, CX.CargarDGV());
                cmdG.Parameters.AddWithValue("@NOMBRE", name);
                cmdG.Parameters.AddWithValue("@FECHAEMISIÓN", Date);
                cmdG.Parameters.AddWithValue("@GENERO", Gen);
                cmdG.Parameters.AddWithValue("@ESTUDIO", studio);
                cmdG.Parameters.AddWithValue("@CALIFPERSONAL", points);

                
                if (MessageBox.Show("Vas a Guardar edicion sobre: " + name, "AVISO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        cmdG.ExecuteNonQuery();
                        MessageBox.Show("Datos Modificados");
                }
                else
                {
                    MessageBox.Show(" Operacion Cancelada ");
                }
                
        }   }
    }
}
