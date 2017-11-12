﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNET_WEB_MVC.Models
{
    public class ASPNET_WEB_MVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ASPNET_WEB_MVCContext() : base("name=ASPNET_WEB_MVCContext")
        {
        }

        public System.Data.Entity.DbSet<ASPNET_WEB_MVC.Models.Atleta> Atletas { get; set; }
    }
}
