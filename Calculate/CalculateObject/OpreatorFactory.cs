using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.CalculateObject
{
    public class OpreatorFactory
    {
        public static Opreator CreateOpreator(char token)
        {
            Opreator opreator = null;

            switch (token)
            {
                case '+':
                    opreator = new OpreatorAdd();
                    break;

                case '-':
                    opreator = new OpreatorSub();
                    break;

                case 'x':
                    opreator = new OpreatorMul();
                    break;

                case '÷':
                    opreator = new OpreatorDiv();
                    break;
            }

            return opreator;
        }
    }
}