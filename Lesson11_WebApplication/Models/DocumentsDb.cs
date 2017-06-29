using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson11_WebApplication.Models
{
    public class DocumentsDb : DbContext
    {
        public IDbSet<Document> Documents { get; set; }
    }
}