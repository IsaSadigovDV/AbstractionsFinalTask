using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask.Interfaces
{
    public interface IService
    {
        public void Create();
        public void GetAll();
        public void GetById();
        public void Delete();
        public void Update();

    }
}
