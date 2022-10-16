using PARCIAL_II.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_II.DAL
{
    class FarmaciaSedDAL
    {
        private Database db;

        public object Id { get; private set; }

        public FarmaciaSedDAL()
        {
            db = new Database();
        }

        public DataTable getAllfarmacia_sedes()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM farmacia_sedes";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createfarmacia_sedes( FarmaciaSedBLL sede)
        {
            try
            {
                SqlConnection Con = db.GetConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO farmacia_sedes (nombre_sede, ubicacion_sede, email_sede) VALUES (@nom, @ub, @em, @id);";
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre_sede);
                    cmd.Parameters.AddWithValue("@ub", sede.Ubicacion_sede);
                    cmd.Parameters.AddWithValue("@em", sede.Email_sede);
                    cmd.Parameters.AddWithValue("@", sede.Id_sedes);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        internal bool updatefarmacia_sedes(FarmaciaSedBLL sede)
        {
            throw new NotImplementedException();
        }

        public bool updatefarmacia_sedes(InfEmpleadosBLL far, FarmaciaSedBLL sede, MedicinaCompBLL medc, MedicinaTienBLL medt, MedicinaVentBLL medv)
        {
            try
            {
                SqlConnection Con = db.GetConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE farmacia_sedes SET id_sede = @id, nombres =  @nom, ubicacion = @ub, mail = @em WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", sede.Id_sedes);
                    cmd.Parameters.AddWithValue("@nom", sede.Nombre_sede);
                    cmd.Parameters.AddWithValue("@ub", sede.Ubicacion_sede);
                    cmd.Parameters.AddWithValue("@em", sede.Email_sede);

                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        internal bool deletefarmacia_sedes(FarmaciaSedBLL sede)
        {
            throw new NotImplementedException();
        }

        public bool deletefarmacia_sedes(FarmaciaSedDAL sede)
        {
            try
            {
                SqlConnection Con = db.GetConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM farmacia_sedes WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", sede.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

   
