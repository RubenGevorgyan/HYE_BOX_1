using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace HYE_BOX.Models
{
    public class Data_context:DbContext
    {

        public System.Data.Entity.DbSet<HYE_BOX.Models.DataModel> Data { get; set; }
    }
}   