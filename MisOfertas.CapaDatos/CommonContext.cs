using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos
{
    public class CommonContext : DbContext
    {
        #region Singleton
        private static CommonContext instance;
        public static CommonContext GetInstance()
        {
            if (instance == null)
                return new CommonContext();

            return instance;
        } 
        #endregion

        public CommonContext() : base("DefaultConnection")
        {
            instance = this;
        }

        public DbSet<User> Users { get; set; }


    }
}
