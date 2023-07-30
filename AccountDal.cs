using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//hespların listeleneceği yer

//SqlConnection("bağlantı bilgilerini ve nereye Bağlanacağımızı belirttiğimiz yer",hanig veri tabanına bağlanacağımızı belirtiyoruz,veri tabanına windows authentication ile bağlan, )




namespace BankAccountsProject1
{

    class AccountDal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=BankAccount;integrated security=true");//Bağlantı nesnesi oluşturuldu

            /*uzaktaki veri tabınına bağlanmak için
            
            integrated security=true;uid=  ...   ;password =...*/




        public List<Account> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * From Accounts ", _connection);//Sorguyu bağlantı nesnesine gönderiyoruz

            SqlDataReader reader = command.ExecuteReader();


            List<Account> accounts = new List<Account>();

            while (reader.Read())
            {
                Account account = new Account
                {
                    //Veri tabanındaki kolonların içindeki değerleri account nesnesinin içine atıyoruz
                    Id = (int)reader["Id"],
                    CustomerName = (string)reader["CustomerName"],
                    Location = (string)reader["Location"],
                    Balance = (decimal)reader["Balance"],
                    PhoneNumber = (int)reader["PhoneNumber"],
                    AccountType = (string)reader["AccountType"],

                };

                accounts.Add(account);



                //reader.Read()-->reader'ı(kayıtları) tek tek oku
            }





            reader.Close();

            _connection.Close();


            return accounts;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) //Bağlantı durumu kapalı ise
            {


                _connection.Open();//Bağlantıyı açmak için

            }
        }

        public void Add(Account account)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert Into Accounts values(@cName,@location,@balance,@pNumber,@aType)", _connection);
            command.Parameters.AddWithValue("@cName", account.CustomerName);
            command.Parameters.AddWithValue("@location", account.Location);
            command.Parameters.AddWithValue("@balance", account.Balance);
            command.Parameters.AddWithValue("@pNumber", account.PhoneNumber);
            command.Parameters.AddWithValue("@aType", account.AccountType);
            command.ExecuteNonQuery();
            /* ExecuteNonQuery() metodu, bir SQL sorgusunu çalıştırır ve sorgudan etkilenen satır sayısını döndürür. 
             * Bu örnekte, kod veritabanına veri eklemek için kullanıldığından, ExecuteNonQuery() metodu kullanılır.
             * Bu metot geriye veri döndürmediğinden, sadece sorgudan etkilenen satır sayısını döndürür1.*/

            _connection.Close();

        }

        public void Update(Account account)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Accounts set CustomerName=@cName,Location=@location,Balance=@balance,PhoneNumber=@pNumber,AccountType=@aType where Id=@ıd", _connection);
            command.Parameters.AddWithValue("@cName", account.CustomerName);
            command.Parameters.AddWithValue("@location", account.Location);
            command.Parameters.AddWithValue("@balance", account.Balance);
            command.Parameters.AddWithValue("@pNumber", account.PhoneNumber);
            command.Parameters.AddWithValue("@aType", account.AccountType);
            command.Parameters.AddWithValue("@ıd", account.Id);
            command.ExecuteNonQuery();
            /* ExecuteNonQuery() metodu, bir SQL sorgusunu çalıştırır ve sorgudan etkilenen satır sayısını döndürür. 
             * Bu örnekte, kod veritabanına veri eklemek için kullanıldığından, ExecuteNonQuery() metodu kullanılır.
             * Bu metot geriye veri döndürmediğinden, sadece sorgudan etkilenen satır sayısını döndürür1.*/

            _connection.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Accounts where Id=@ıd", _connection);
      
            command.Parameters.AddWithValue("@ıd",id);
            command.ExecuteNonQuery();
            /* ExecuteNonQuery() metodu, bir SQL sorgusunu çalıştırır ve sorgudan etkilenen satır sayısını döndürür. 
             * Bu örnekte, kod veritabanına veri eklemek için kullanıldığından, ExecuteNonQuery() metodu kullanılır.
             * Bu metot geriye veri döndürmediğinden, sadece sorgudan etkilenen satır sayısını döndürür1.*/

            _connection.Close();

        }









        public DataTable GetAll2()
        {


            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * From Accounts ", _connection);//Sorguyu bağlantı nesnesine gönderiyoruz

            SqlDataReader reader = command.ExecuteReader();

            /*Gönderilen komutu çalıştırmak için.ExecuteReader() Methodu duruma göre değişiklik gösterecek.ExecuteReader()'in geri dönüş 
            tipi SqlDataReader olduğu için reader nesnesi oluşturuldu.
            */

            /*
             SqlDataReader sınıfından türetilen bir nesne kullanarak veriler okunur ve daha sonra DataTable sınıfından türetilen bir nesneye yüklenir(Load Methodu ile). 
            */



            DataTable dataTable = new DataTable();

            /* .Net ortamında geliştirilen uygulamalarda veritabanı ile ilgili işlemler sıkça yapılmaktadır. 
                                                   * Bu işlemlerle ilgili olarak uygulamalarda veritabanına bağlanmak, veritabanındaki verileri uygulama ortamına çekmek ve bu verilerin, yapılacak olan işlemler için uygun hale getirilmesini sağlamak hemen her uygulamada rastlanmaktadır.
                                                   * "DataTable" nesnesi de bu gibi işlemler, yani veritabanından veri çekilmesi işlemleri için en kullanışlı nesnelerden biridir. 
                                                   * DataTable sınıfı bellekteki tabloların satırlarını "DataRow" nesnesi ile, sütunlarını ise "DataColumn" nesnesi ile temsil eder. */

            dataTable.Load(reader);

            reader.Close();

            _connection.Close();


            return dataTable;

        }









    }

}
