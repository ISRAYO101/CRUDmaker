using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Tako.Acciones
{
   public class cBorrado
    {
        public static void BorradoAnimes()
        {
          
            Principal? form = Application.OpenForms["Principal"] as Principal;
            if (form != null)
            {
                string name = form.GuardarNombre();

                string delete = "DELETE FROM TBLINFOGRAL WHERE NOMBRE=@NOMBRE";
                SqlCommand cmdB = new SqlCommand(delete, CX.CargarDGV());

                if (MessageBox.Show("Quieres BORRAR todos los datos sobre: " + name, "AVISO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmdB.Parameters.AddWithValue("@NOMBRE", name);
                    cmdB.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show(" Operacion Cancelada ");
                }

            }
        }

    }
}
