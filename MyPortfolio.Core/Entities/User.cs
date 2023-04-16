using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MyPortfolio.Core.Models
{
    public class User
    {
        
        [Key]
        public int Id { get; set; }
        public User () { 

        }
        public User (int id) { Id = id; }
    }
}
