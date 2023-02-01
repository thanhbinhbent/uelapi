using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UELStudents.Data;

namespace UELStudents.Models
{
    public class Tuition
    {
       
        public string Id { get; set; }
    
        public string TuitionId { get; set; }
       
        public string StudentId { get; set; }
        public double AmountPaid { get; set; }
    }

   
}
