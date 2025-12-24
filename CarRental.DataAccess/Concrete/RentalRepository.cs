using CarRental.Entities.Concrete;
using System.Data;
using System.Data.SqlClient;

namespace CarRental.DataAccess.Concrete
{
    public class RentalRepository : GenericRepository<Rental>
    {
        /// <summary>
        /// Yeni bir kiralama kaydını veritabanına ekler.
        /// </summary>
        /// <param name="entity">Eklenecek kiralama bilgileri</param>
        /// <exception cref="Exception">
        /// Kiralama ekleme işlemi sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Add(Rental entity)
        {
            try
            {
                SqlCommand cmd = new(
                @"INSERT INTO Rentals
                (VehicleId, CustomerId, RentDate, ReturnDate, TotalPrice)
                VALUES (@v,@c,@rd,@ret,@t)", connection);

                cmd.Parameters.AddWithValue("@v", entity.VehicleId);
                cmd.Parameters.AddWithValue("@c", entity.CustomerId);
                cmd.Parameters.AddWithValue("@rd", entity.RentDate);
                cmd.Parameters.AddWithValue("@ret",
                entity.ReturnDate == null ? DBNull.Value : entity.ReturnDate);
                cmd.Parameters.AddWithValue("@t", entity.TotalPrice);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama eklenirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip kiralama kaydını siler.
        /// </summary>
        /// <param name="id">Silinecek kiralamanın benzersiz kimliği</param>
        /// <exception cref="Exception">
        /// Kiralama silme işlemi sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Delete(int id)
        {
            try
            {
                // Önce kiralamaya ait VehicleId alınır
                SqlCommand getVehicleCmd = new(
                    "SELECT VehicleId FROM Rentals WHERE Id = @id", connection);

                getVehicleCmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                object vehicleIdObj = getVehicleCmd.ExecuteScalar();

                if (vehicleIdObj == null)
                    throw new Exception("Kiralama kaydı bulunamadı.");

                int vehicleId = Convert.ToInt32(vehicleIdObj);

                // Kiralama silinir
                SqlCommand deleteCmd = new(
                    "DELETE FROM Rentals WHERE Id = @id", connection);

                deleteCmd.Parameters.AddWithValue("@id", id);
                deleteCmd.ExecuteNonQuery();

                // Araç tekrar müsait yapılır
                SqlCommand updateVehicleCmd = new(
                    "UPDATE Vehicles SET IsAvailable = 1 WHERE Id = @vid", connection);

                updateVehicleCmd.Parameters.AddWithValue("@vid", vehicleId);
                updateVehicleCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama silinirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm kiralama işlemlerini listeler.
        /// </summary>
        /// <returns>
        /// Kiralama kayıtlarını içeren liste.
        /// </returns>
        /// <exception cref="Exception">
        /// Kiralama listesi getirilirken hata oluştuğunda fırlatılır.
        /// </exception>
        public override List<Rental> GetAll()
        {
            List<Rental> list = new();

            try
            {
                SqlCommand cmd = new("SELECT * FROM Rentals", connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Rental
                    {
                        Id = (int)reader["Id"],
                        VehicleId = (int)reader["VehicleId"],
                        CustomerId = (int)reader["CustomerId"],
                        RentDate = (DateTime)reader["RentDate"],
                        ReturnDate = reader["ReturnDate"] == DBNull.Value
                            ? null
                            : (DateTime?)reader["ReturnDate"],
                        TotalPrice = (decimal)reader["TotalPrice"]
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama listesi getirilirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return list;
        }

        /// <summary>
        /// Belirtilen Id değerine sahip kiralama kaydını getirir.
        /// </summary>
        /// <param name="id">Kiralamanın benzersiz kimliği</param>
        /// <returns>
        /// Kiralama bulunursa Rental nesnesi, bulunamazsa null.
        /// </returns>
        /// <exception cref="Exception">
        /// Kiralama bilgisi getirilirken hata oluştuğunda fırlatılır.
        /// </exception>
        public override Rental GetById(int id)
        {
            Rental rental = null;

            try
            {
                SqlCommand cmd = new(
                    "SELECT * FROM Rentals WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    rental = new Rental
                    {
                        Id = (int)reader["Id"],
                        VehicleId = (int)reader["VehicleId"],
                        CustomerId = (int)reader["CustomerId"],
                        RentDate = (DateTime)reader["RentDate"],
                        ReturnDate = reader["ReturnDate"] == DBNull.Value
                            ? null
                            : (DateTime?)reader["ReturnDate"],
                        TotalPrice = (decimal)reader["TotalPrice"]
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama bilgisi getirilirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return rental;
        }

        /// <summary>
        /// Mevcut bir kiralama kaydının bilgilerini günceller.
        /// </summary>
        /// <param name="entity">Güncellenecek kiralama bilgileri</param>
        /// <exception cref="Exception">
        /// Kiralama güncelleme işlemi sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Update(Rental entity)
        {
            try
            {
                SqlCommand cmd = new(
                @"UPDATE Rentals SET
                VehicleId = @v,
                CustomerId = @c,
                RentDate = @rd,
                ReturnDate = @ret,
                TotalPrice = @t
              WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@v", entity.VehicleId);
                cmd.Parameters.AddWithValue("@c", entity.CustomerId);
                cmd.Parameters.AddWithValue("@rd", entity.RentDate);
                cmd.Parameters.AddWithValue("@ret",
                    entity.ReturnDate == null ? DBNull.Value : entity.ReturnDate);
                cmd.Parameters.AddWithValue("@t", entity.TotalPrice);
                cmd.Parameters.AddWithValue("@id", entity.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama güncellenirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
