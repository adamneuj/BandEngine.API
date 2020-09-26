using BandEngine.API.Authentication;
using BandEngine.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BandEngine.API.Models
{
    public class Band : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("User")]
        public Guid DataOwner { get; set; }
        public virtual ApplicationUser User { get; set; }


    }
}
