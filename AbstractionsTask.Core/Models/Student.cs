using AbstractionsTask.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask.Core.Models
{
    public class Student:Base
    {
        static int _count = 0;
        public Student()
        {
            _count++;
            Id= _count;
        }

       
    }
}
