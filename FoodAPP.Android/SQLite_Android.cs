using System;
using System.IO;
using FoodAPP.Model;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof (FoodAPP.Droid.SQLite_Android))]
namespace FoodAPP.Droid
{
    public class SQLite_Android : ISQLite
    {
     

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}
