using System;
using System.IO;
using AAUFoodProject.Model;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(AAUFoodProject.Droid.SQLite_Android))]
namespace AAUFoodProject.Droid
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
