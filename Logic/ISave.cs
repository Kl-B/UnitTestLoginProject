using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface ISave
    {
        public List<User> Load();
        public void Save(List<User> users);
    }
}
