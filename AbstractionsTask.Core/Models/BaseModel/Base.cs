using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask.Core.Models.BaseModel
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNo { get; set; }


        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Surname: {Surname} Group No: {GroupNo}";
        }
    }
}
