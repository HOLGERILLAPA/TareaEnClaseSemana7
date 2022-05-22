using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace TareaEnClaseSemana7
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection(); //Implementado en cada proyecto de Android, iOS

    }
}
