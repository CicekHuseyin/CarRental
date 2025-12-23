using CarRental.DataAccess.Db;
using CarRental.Entities.Concrete;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace CarRental.DataAccess.Concrete
{

    public class CustomerRepository : GenericRepository<Customer>
    {
        /// <summary>
        /// Yeni bir müşteri kaydını veritabanına ekler.
        /// </summary>
        /// <param name="entity">Eklenecek müşteri bilgileri</param>
        /// <exception cref="Exception">
        /// Müşteri ekleme işlemi sırasında bir hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Add(Customer entity)
        {
            try
            {
                SqlCommand cmd = new(
                    "INSERT INTO Customers (FullName, Phone, TC) VALUES (@fn,@p,@tc)",
                    connection);

                cmd.Parameters.AddWithValue("@fn", entity.FullName);
                cmd.Parameters.AddWithValue("@p", entity.Phone);
                cmd.Parameters.AddWithValue("@tc", entity.TC);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri eklenirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Yeni bir müşteri kaydını veritabanına ekler.
        /// </summary>
        /// <param name="entity">Eklenecek müşteri bilgileri</param>
        /// <exception cref="Exception">
        /// Müşteri ekleme işlemi sırasında bir hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Delete(int id)
        {
            try
            {
                SqlCommand cmd = new(
                    "DELETE FROM Customers WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri silinirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm müşterileri listeler.
        /// </summary>
        /// <returns>
        /// Müşteri listesini içeren koleksiyon.
        /// </returns>
        /// <exception cref="Exception">
        /// Müşteri listesi getirilirken bir hata oluştuğunda fırlatılır.
        /// </exception>
        public override List<Customer> GetAll()
        {
            List<Customer> list = new();

            try
            {
                using SqlConnection conn = SqlConnectionFactory.GetConnection();
                conn.Open();
                Console.WriteLine("Connection açıldı. State: " + conn.State);

                using SqlCommand cmd = new SqlCommand("SELECT Id, FullName, Phone, TC FROM Customers", conn);
                using SqlDataReader reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer
                        {
                            Id = reader.GetInt32(0),
                            FullName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                            Phone = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                            TC = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                        };
                        list.Add(customer);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("SQL Hatası: " + sqlEx.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genel Hata: " + ex.Message);
                throw;
            }

            return list;
        }

        /// <summary>
        /// Belirtilen Id değerine sahip müşteri bilgisini getirir.
        /// </summary>
        /// <param name="id">Müşterinin benzersiz kimliği</param>
        /// <returns>
        /// Müşteri bulunursa müşteri nesnesi, bulunamazsa null.
        /// </returns>
        /// <exception cref="Exception">
        /// Müşteri bilgisi getirilirken bir hata oluştuğunda fırlatılır.
        /// </exception>
        public override Customer GetById(int id)
        {
            Customer customer = null;

            try
            {
                SqlCommand cmd = new(
                    "SELECT * FROM Customers WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        Id = (int)reader["Id"],
                        FullName = reader["FullName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        TC = reader["TC"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri bilgisi getirilirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            return customer;
        }

        /// <summary>
        /// Mevcut bir müşteri kaydının bilgilerini günceller.
        /// </summary>
        /// <param name="entity">Güncellenecek müşteri bilgileri</param>
        /// <exception cref="Exception">
        /// Müşteri güncelleme işlemi sırasında bir hata oluştuğunda fırlatılır.
        /// </exception>
        public override void Update(Customer entity)
        {
            try
            {
                SqlCommand cmd = new(
                   @"UPDATE Customers SET
                    FullName = @fn,
                    Phone = @p,
                    TC = @tc
                    WHERE Id = @id", connection);

                cmd.Parameters.AddWithValue("@fn", entity.FullName);
                cmd.Parameters.AddWithValue("@p", entity.Phone);
                cmd.Parameters.AddWithValue("@tc", entity.TC);
                cmd.Parameters.AddWithValue("@id", entity.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri güncellenirken hata oluştu.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

    }
}
