using System.Collections.Generic;

namespace Udemy_kurs.Models
{
    public class Model
    {
        public Make Make {get; set; }
        public int MakeId { get; set; }
        
        public ICollection<Model> Models { get; set; }


            }
}