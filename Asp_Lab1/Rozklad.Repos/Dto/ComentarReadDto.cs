using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repos.Dto
{
    public class ComentarReadDto
    {

        public int comentarId { get; set; }

        public BusSheduleReadDto busShedule { get; set; }
        public int sheduleId { get; set; }
        public DateTime date { get; set; }
        public string comentar { get; set; }
    }
}
