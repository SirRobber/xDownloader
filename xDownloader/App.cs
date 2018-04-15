using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xDownloader
{
    static class App
    {
        static Database db;
        public static Database DB
        {
            get
            {
                if (db == null)
                    db = new Database();
                return db;
            }
        }
    }
}
