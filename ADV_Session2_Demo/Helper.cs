using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Session2_Demo
{
    internal class Helper
    {
        public static int SumList (List<int> list)
        {
            int sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
            }
            return sum;
        }
    }
}
