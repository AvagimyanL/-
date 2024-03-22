using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlTypes;

namespace Приложение_Автосервис.Controller
{
    internal class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;


        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();

        }




        // Автомобили 
        public DataTable UpdateАвтомобили()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Автомобили", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddАвтомобили(string Марка, string Модель)  //Запрос на добавление данных в таблицу Автомобили
                                                              //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Автомобили (Марка, Модель) VALUES (@Марка, @Модель)", connection);
            command.Parameters.AddWithValue("Марка", Марка);
            command.Parameters.AddWithValue("Модель", Модель);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeАвтомобили(string Марка, string Модель, int Код_автомобиля)  //Запрос наизменение данных в таблице Автомобили
                                                                      //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Автомобили SET Марка = '" + Марка + "', Модель = '" + Модель + "' WHERE Код_автомобиля =  " + Код_автомобиля, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }


        public void DeleteАвтомобили(int Код_автомобиля)   //Запрос для удаления данных в таблице Сотрудники
                                                           //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Автомобили WHERE Код_автомобиля = {Код_автомобиля} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Должности

        public DataTable UpdateДолжности()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Должности", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddДолжности(string Должность)  //Запрос на добавление данных в таблицу Должности
                                                    //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Должности (Должность) VALUES (@Должность)", connection);
            command.Parameters.AddWithValue("Должность", Должность);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeДолжности(string Должность,  int Код_должности) 
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Должности SET Должность = '" + Должность + "' WHERE Код_должности =  " + Код_должности, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }


        public void DeleteДолжности(int Код_должности)  
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Должности WHERE Код_должности = {Код_должности} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        // Имя

        public DataTable UpdateИмена()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Имена", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddИмена(string Имя)  //Запрос на добавление данных в таблицу Имена
                                                    //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Имена (Имя) VALUES (@Имя)", connection);
            command.Parameters.AddWithValue("Имя", Имя);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeИмена(string Имя, int Код_имени)  //Запрос наизменение данных в таблице Имена
                                                                      //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            
            command = new OleDbCommand("UPDATE Имена SET Имя = '" + Имя + "' WHERE Код_имени =  " + Код_имени, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void DeleteИмена(int Код_имени)   //Запрос для удаления данных в таблице Имена
                                                 //(также в дальнейшем будет использоваться для кнопки)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Имена WHERE Код_имени = {Код_имени} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        //Клиенты

        public void AddКлиенты(string Фамилия, string Имя, string Отчество,
                    DateTime Дата_рождения,int Серия_паспорта, int Номер_паспорта, string Телефон)  
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Клиенты (Фамилия, Имя, Отчество,  Дата_рождения,Серия_паспорта, Номер_паспорта, Телефон) VALUES (@Фамилия, @Имя, @Отчество,  @Дата_рождения, @Серия_паспорта, @Номер_паспорта, @Телефон)", connection);
            command.Parameters.AddWithValue("Фамилия", Фамилия);
            command.Parameters.AddWithValue("Имя", Имя);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.Parameters.AddWithValue("Серия_паспорта", Серия_паспорта);
            command.Parameters.AddWithValue("Номер_паспорта", Номер_паспорта);
            command.Parameters.AddWithValue("Дата_рождения", Дата_рождения);
            command.Parameters.AddWithValue("Телефон", Телефон);

            command.ExecuteNonQuery();
            connection.Close();
        }


        public void DeleteКлиенты(int Код_клиента)   
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Клиенты WHERE Код_клиента = {Код_клиента} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable UpdateКлиенты()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);   
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;

        }

        public void ChangeКлиенты(string Фамилия, string Имя, string Отчество, DateTime Дата_рождения, int Серия_паспорта, int Номер_паспорта, string Телефон, int Код_клиента)               
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Клиенты SET Фамилия = '" + Фамилия + "', Имя = '" + Имя + "', Отчество = '" + Отчество + "', Серия_паспорта = " + Серия_паспорта + ", Номер_паспорта = " + Номер_паспорта + ", Дата_рождения = '" + Дата_рождения + "', Телефон = '" + Телефон + "'  WHERE Код_клиента =  " + Код_клиента, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Марки

        public DataTable UpdateМарки()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Марки", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddМарки(string Марка)  
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Марки (Марка) VALUES (@Марка)", connection);
            command.Parameters.AddWithValue("Марка", Марка);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeМарки(string Марка, int Код_марки)  
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Марки SET Марка = '" + Марка + "'  WHERE Код_марки =  " + Код_марки, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }


        public void DeleteМарки(int Код_марки)   
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Марки WHERE Код_марки = {Код_марки} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        // Мастера


        public void DeleteМастера(int Код_мастера)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Мастера WHERE Код_мастера = {Код_мастера} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable UpdateМастера()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Мастера", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;

        }

        public void ChangeМастера(string Фамилия, string Имя, string Отчество, int Серия_паспорта, int Номер_паспорта, string Телефона, int Оклад, string Должность, int Стаж,  int Код_мастера)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Мастера SET Фамилия = '" + Фамилия + "', Имя = '" + Имя + "', Отчество = '" + Отчество + "', Серия_паспорта = " + Серия_паспорта + ", Номер_паспорта = " + Номер_паспорта + ", Стаж = " + Стаж + ", Оклад = "+ Оклад +" , Телефона = '" + Телефона + "',Должность = '" + Должность + "'  WHERE Код_мастера =  " + Код_мастера, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddМастера(string Фамилия, string Имя, string Отчество, int Серия_паспорта, int Номер_паспорта, string Телефона, int Оклад, string Должность, int Стаж)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Мастера (Фамилия, Имя, Отчество,  Должность ,Серия_паспорта, Номер_паспорта, Телефона, Стаж, Оклад) VALUES (@Фамилия, @Имя, @Отчество,  @Должность, @Серия_паспорта, @Номер_паспорта, @Телефона, @Стаж, @Оклад  )", connection);
            command.Parameters.AddWithValue("Фамилия", Фамилия);
            command.Parameters.AddWithValue("Имя", Имя);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.Parameters.AddWithValue("Серия_паспорта", Серия_паспорта);
            command.Parameters.AddWithValue("Номер_паспорта", Номер_паспорта);
            command.Parameters.AddWithValue("Должность", Должность);
            command.Parameters.AddWithValue("Телефона", Телефона);
            command.Parameters.AddWithValue("Стаж", Стаж);
            command.Parameters.AddWithValue("Оклад", Оклад);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Модели

        public DataTable UpdateМодели()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Модели", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddМодели(string Модель)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Модели (Модель) VALUES (@Модель)", connection);
            command.Parameters.AddWithValue("Модель", Модель);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeМодели(string Модель, int Код_модели)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Модели SET Модель = '" + Модель + "'  WHERE Код_модели =  " + Код_модели, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteМодели(int Код_модели)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Модели WHERE Код_модели = {Код_модели} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Названия товаров

        public DataTable UpdateНазвания_товаров()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Названия_товаров", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddНазвания_товаров(string Название_товара)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Названия_товаров (Название_товара) VALUES (@Название_товара)", connection);
            command.Parameters.AddWithValue("Название_товара", Название_товара);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeНазвания_товаров(string Название_товара, int Код_названия_товара)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Названия_товаров SET Название_товара = '" + Название_товара + "'  WHERE Код_названия_товара =  " + Код_названия_товара, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteНазвания_товаров(int Код_названия_товара)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Названия_товаров WHERE Код_названия_товара = {Код_названия_товара} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Названия услуг

        public DataTable UpdateНазвания_услуг()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Названия_услуг", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddНазвания_услуг(string Название_услуги)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Названия_услуг (Название_услуги) VALUES (@Название_услуги)", connection);
            command.Parameters.AddWithValue("Название_услуги", Название_услуги);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeНазвания_услуг(string Название_услуги, int Код_названия_услуги)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Названия_услуг SET Название_услуги = '" + Название_услуги + "'  WHERE Код_названия_услуги =  " + Код_названия_услуги, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteНазвания_услуг(int Код_названия_услуги)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Названия_услуг WHERE Код_названия_услуги = {Код_названия_услуги} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //Отчества

        public DataTable UpdateОтчества()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Отчества", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddОтчества(string Отчество)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Отчества (Отчество) VALUES (@Отчество)", connection);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeОтчества(string Отчество, int Код_отчества)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Отчества SET Отчество = '" + Отчество + "'  WHERE Код_отчества =  " + Код_отчества, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteОтчества(int Код_отчества)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Отчества WHERE Код_отчества = {Код_отчества} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }



        // Продавцы

        public void DeleteПродавцы(int Код_продавца)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Продавцы WHERE Код_продавца = {Код_продавца} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable UpdateПродавцы()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Продавцы", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void ChangeПродавцы(string Фамилия, string Имя, string Отчество, int Серия_паспорта, int Номер_паспорта, string Телефона, int Оклад, int Код_продавца)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Мастера SET Фамилия = '" + Фамилия + "', Имя = '" + Имя + "', Отчество = '" + Отчество + "', Серия_паспорта = " + Серия_паспорта + ", Номер_паспорта = " + Номер_паспорта + ",  Оклад = " + Оклад + " , Телефона = '" + Телефона + "'  WHERE Код_продавца =  " + Код_продавца, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddПродавцы(string Фамилия, string Имя, string Отчество, int Серия_паспорта, int Номер_паспорта, string Телефона, int Оклад)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Мастера (Фамилия, Имя, Отчество, Серия_паспорта, Номер_паспорта, Телефона, Оклад) VALUES (@Фамилия, @Имя, @Отчество, @Серия_паспорта, @Номер_паспорта, @Телефона, @Оклад  )", connection);
            command.Parameters.AddWithValue("Фамилия", Фамилия);
            command.Parameters.AddWithValue("Имя", Имя);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.Parameters.AddWithValue("Серия_паспорта", Серия_паспорта);
            command.Parameters.AddWithValue("Номер_паспорта", Номер_паспорта);
            command.Parameters.AddWithValue("Телефона", Телефона);
            command.Parameters.AddWithValue("Оклад", Оклад);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Товары

        public DataTable UpdateТовары()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Товары", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddТовары(string Название_товара, string Марка,  int Цена )
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Товары (Название_товара, Марка, Цена) VALUES (@Название_товара, @Марка, @Цена)", connection);
            command.Parameters.AddWithValue("Название_товара", Название_товара);
            command.Parameters.AddWithValue("Марка", Марка);
            command.Parameters.AddWithValue("Цена", Цена);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeТовары(string Название_товара, string Марка, int Цена, int Код_товара)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Товары SET Название_товара = '" + Название_товара + "', Марка = '"+ Марка +"', Цена = '+ Цена +'  WHERE Код_товара =  " + Код_товара, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteТовары(int Код_товара)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Товары WHERE Код_товара = {Код_товара} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Услуги
        public DataTable UpdateУслуги()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Услуги", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddУслуги(string Название_услуги, int Цена)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Услуги (Название_услуги, Марка, Цена) VALUES (@Название_услуги, @Марка, @Цена)", connection);
            command.Parameters.AddWithValue("Название_услуги", Название_услуги);
            command.Parameters.AddWithValue("Цена", Цена);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeУслуги(string Название_услуги, int Цена, int Код_услуги)
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Услуги SET Название_услуги = '" + Название_услуги + "', Цена = '+ Цена +'  WHERE Код_услуги =  " + Код_услуги, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteУслуги(int Код_услуги)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Услуги WHERE Код_услуги = {Код_услуги} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        // Фамилии

        public DataTable UpdateФамилии()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Фамилии", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddФамилии(string Фамилия)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Фамилии (Фамилия) VALUES (@Фамилия)", connection);
            command.Parameters.AddWithValue("Фамилия", Фамилия);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ChangeФамилии(string Фамилия, int Код_фамилии)  
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Фамилии SET Фамилия = '" + Фамилия + "' WHERE Код_фамилии =  " + Код_фамилии, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void DeleteФамилии(int Код_фамилии) 
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Фамилии WHERE Код_фамилии = {Код_фамилии} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Чеки 


    }
}
