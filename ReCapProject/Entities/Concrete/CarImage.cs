using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public DateTime Date;

        [Key]
        public int CarImageID { get; set; }
        public int CarID { get; set; }
        public string ImagePath { get; set; }
        public DateTime? ImageDate { get; set; }
    }
}
