using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class calculator
    {
        public enum Operation
        {
            NONE,
            NUMBER,
            PLUS,
            MINUS,
            EQUAL,
        };
        public Operation oper ;
        public int fnumber, snumber;
        public calculator()
        {
            oper = Operation.NONE;
            fnumber = 0;
            snumber = 0;
        }
        public void savef(string s)
        {
            fnumber = int.Parse(s);
        }
        public void saves(string s)
        {
            snumber = int.Parse(s);
        }
        public int getresplus()
        {
            return fnumber + snumber;
        }
    }
}
