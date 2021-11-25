using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace UnitTestLoginProject
{
    public class Mocktime : ITime
    {
        DateTime _now = DateTime.Now;

        public DateTime Now()
        {
            return _now;
        }

        public void ChangeTimeTo(DateTime newNow)
        {
            _now = newNow;
        }
    }
}
