using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Comentar
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int comentarId { get; set; }

        public int sheduleId { get; set; }
        public DateTime date { get; set; }
        public string comentar { get; set; }

        public virtual ICollection<BusShedule> BusShedules { get; set; }
    }
}
