using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week5_MVCReviewSite.Models
{
    public class Week5_MVCReviewSiteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week5_MVCReviewSiteContext() : base("name=Week5_MVCReviewSiteContext")
        {
        }

        public System.Data.Entity.DbSet<Week5_MVCReviewSite.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<Week5_MVCReviewSite.Models.Category> Categories { get; set; }
    }
}
