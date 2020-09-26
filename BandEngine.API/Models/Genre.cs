using BandEngine.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandEngine.API.Models
{
    public class Genre : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string GenreName { get; set; }
    }
}
