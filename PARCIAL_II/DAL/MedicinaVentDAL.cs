using PARCIAL_II.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_II.DAL
{
    class MedicinaVentDAL
    {
        Database db;

        public MedicinaVentDAL()
        {
            db = new Database();
        }
        public bool insertarventa(MedicinaVentBLL Venta)
        {
            try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ventas_medicina (id_venta, id_producto, id_empleado, cantidad, precio) VALUES (@id, @idp, @idv, @cant, @prec)";
                    cmd.Parameters.AddWithValue("@id", Venta.Id_venta);
                    cmd.Parameters.AddWithValue("@idp", Venta.Id_producto);
                    cmd.Parameters.AddWithValue("@idv", Venta.Id_empleado);
                    cmd.Parameters.AddWithValue("@cant", Venta.Cantidad);
                    cmd.Parameters.AddWithValue("@prec", Venta.Precio);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool actualizarventa(MedicinaVentBLL VentaActu, MedicinaTienBLL Vent, InfEmpleadosBLL empleado)
        {
           try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE ventas_medicina SET id_venta = @idv, id_producto = @idp, id_empleado = @ide,  = cantidad = @cant, precio = @prec WHERE id_venta = @idv";
                    cmd.Parameters.AddWithValue("@idv", VentaActu.Id_venta);
                    cmd.Parameters.AddWithValue("@idp", Vent.Id_producto);
                    cmd.Parameters.AddWithValue("@ide", empleado.Id_empleado);
                    cmd.Parameters.AddWithValue("@cant", VentaActu.Cantidad);
                    cmd.Parameters.AddWithValue("@prec", VentaActu.Precio);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool eliminarVenta(MedicinaVentBLL VentaDel)
        {
            try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM ventas_medicina WHERE id_venta =@idv";
                    cmd.Parameters.AddWithValue("@idv", VentaDel.Id_venta);
                    cmd.ExecuteNonQuery();
                    con.Close();

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
