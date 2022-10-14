using System;
using PARCIAL_II.BLL;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PARCIAL_II.DAL
{
    class MedicinaTienDAL
    {
        private Database db;
        public MedicinaTienDAL()
        {
            db = new Database();
        }
        public bool insertarstock(MedicinaTienBLL Stocks)
        {
            try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO medicina_tienda (id_compra, nombre_producto, fecha_vencimiento, cantidad, precio) VALUES (@idp, @nomp, @fech, @cant, @prec)";
                    cmd.Parameters.AddWithValue("@idp", Stocks.Id_producto);
                    cmd.Parameters.AddWithValue("@nomp", Stocks.Nombre_producto);
                    cmd.Parameters.AddWithValue("@fech", Stocks.Fecha_vencimiento);
                    cmd.Parameters.AddWithValue("@cant", Stocks.Cantidad);
                    cmd.Parameters.AddWithValue("@prec", Stocks.Precio);
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

        public bool actualizacionstock(MedicinaTienBLL StocksActu)
        {
            try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE medicina_tienda SET nombre_producto = @nomp, fecha_vencimiento = @fech, cantidad = @cant, precio = @prec WHERE id_producto = @idp";
                    cmd.Parameters.AddWithValue("@idp", StocksActu.Id_producto);
                    cmd.Parameters.AddWithValue("@nomp", StocksActu.Nombre_producto);
                    cmd.Parameters.AddWithValue("@fech", StocksActu.Fecha_vencimiento);
                    cmd.Parameters.AddWithValue("@cant", StocksActu.Cantidad);
                    cmd.Parameters.AddWithValue("@prec", StocksActu.Precio);
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

        public bool deletestock(MedicinaTienBLL StocksDel)
        {
            try
            {
                SqlConnection con = db.GetConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM medicina_tienda WHERE id_producto = @idp";
                    cmd.Parameters.AddWithValue("@idp", StocksDel.Id_producto);
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
