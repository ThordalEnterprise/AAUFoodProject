using System;
using SQLite;

namespace AAUFoodProject.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }

}
