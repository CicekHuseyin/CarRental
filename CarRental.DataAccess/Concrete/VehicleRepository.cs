using CarRental.Entities.Concrete;
using System.Data;
using System.Data.SqlClient;

namespace CarRental.DataAccess.Concrete
{
    public class VehicleRepository : GenericRepository<Vehicle>
    {
        /// <summary>
        /// Sistemde kayıtlı tüm araçları listeler.
        /// </summary>
        /// <returns>Vehicle listesi</returns>
        /// <exception cref="Exception">
        /// Araç listesi getirilirken hata oluştuğunda fırlatılır.
        /// </exception>
        public override List<Vehicle> GetAll()
        {
            List<Vehicle> list = new();

            try
            {
                SqlCommand cmd = new("SELECT * FROM Vehicles", connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Vehicle
                    {
                        Id = (int)reader["Id"],
                        Plate = reader["Plate"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        ProductionYear = (int)reader["ProductionYear"],
                        Kilometer = (int)reader["Kilometer"],
                        Color = reader["Color"].ToString(),
                        DailyPrice = (decimal)reader["DailyPrice"],
                        IsAvailable = (bool)reader["IsAvailable"]
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Araç listesi getirilirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return list;
        }

        /// <summary>
        /// Yeni bir aracı veritabanına ekler.
        /// </summary>
        /// <param name="v">Eklenecek araç bilgileri</param>
        /// <exception cref="Exception">
        /// Araç ekleme işlemi sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Add(Vehicle v)
        {
            try
            {
                SqlCommand cmd = new(
                    @"INSERT INTO Vehicles
                  (Plate, Brand, Model, ProductionYear, Kilometer, Color, DailyPrice, IsAvailable)
                  VALUES (@p,@b,@m,@py,@k,@c,@d,@a)", connection);

                cmd.Parameters.AddWithValue("@p", v.Plate);
                cmd.Parameters.AddWithValue("@b", v.Brand);
                cmd.Parameters.AddWithValue("@m", v.Model);
                cmd.Parameters.AddWithValue("@py", v.ProductionYear);
                cmd.Parameters.AddWithValue("@k", v.Kilometer);
                cmd.Parameters.AddWithValue("@c", v.Color);
                cmd.Parameters.AddWithValue("@d", v.DailyPrice);
                cmd.Parameters.AddWithValue("@a", v.IsAvailable);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Araç eklenirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Mevcut bir aracın bilgilerini günceller.
        /// </summary>
        /// <param name="v">Güncellenecek araç bilgileri</param>
        /// <exception cref="Exception">
        /// Araç güncelleme işlemi sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Update(Vehicle v)
        {
            try
            {
                SqlCommand cmd = new(
                @"UPDATE Vehicles SET
                Plate = @p,
                Brand = @b,
                Model = @m,
                ProductionYear = @py,
                Kilometer = @k,
                Color = @c,
                DailyPrice = @d,
                IsAvailable = @a
              WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@p", v.Plate);
                cmd.Parameters.AddWithValue("@b", v.Brand);
                cmd.Parameters.AddWithValue("@m", v.Model);
                cmd.Parameters.AddWithValue("@py", v.ProductionYear);
                cmd.Parameters.AddWithValue("@k", v.Kilometer);
                cmd.Parameters.AddWithValue("@c", v.Color);
                cmd.Parameters.AddWithValue("@d", v.DailyPrice);
                cmd.Parameters.AddWithValue("@a", v.IsAvailable);
                cmd.Parameters.AddWithValue("@id", v.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Araç güncellenirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip aracı siler.
        /// </summary>
        /// <param name="id">Silinecek aracın Id değeri</param>
        /// <exception cref="Exception">
        /// Araç silme işlemi sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Delete(int id)
        {
            try
            {
                SqlCommand cmd = new(
                    "DELETE FROM Vehicles WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Araç silinirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip aracı getirir.
        /// </summary>
        /// <param name="id">Araç Id değeri</param>
        /// <returns>
        /// Araç bulunursa Vehicle nesnesi, bulunamazsa null.
        /// </returns>
        /// <exception cref="Exception">
        /// Araç bilgisi getirilirken hata oluştuğunda fırlatılır.
        /// </exception>
        public override Vehicle GetById(int id)
        {
            Vehicle vehicle = null;

            try
            {
                SqlCommand cmd = new(
                    "SELECT * FROM Vehicles WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    vehicle = new Vehicle
                    {
                        Id = (int)reader["Id"],
                        Plate = reader["Plate"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        ProductionYear = (int)reader["ProductionYear"],
                        Kilometer = (int)reader["Kilometer"],
                        Color = reader["Color"].ToString(),
                        DailyPrice = (decimal)reader["DailyPrice"],
                        IsAvailable = (bool)reader["IsAvailable"]
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Araç bilgisi getirilirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return vehicle;
        }
    }
}
