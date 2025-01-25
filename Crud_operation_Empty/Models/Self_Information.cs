using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_operation_Empty.Models
{
    public class Self_Information
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public long Mono { get; set; }
    }
}