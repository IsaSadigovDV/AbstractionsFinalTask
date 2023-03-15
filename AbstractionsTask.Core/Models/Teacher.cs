using AbstractionsTask.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask.Core.Models
{
    public class Teacher:Base
    {
        static int _count = 0;

        public Teacher()
        {
            _count++;
            Id = _count;
        }
        
    }
}
