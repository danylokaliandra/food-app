using System;
using SQLite;

namespace FoodAPP.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
