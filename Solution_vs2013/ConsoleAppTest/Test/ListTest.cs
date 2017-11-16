using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Test
{
    class ListTest
    {
        public void Do()
        {
            var list = new List<int>() { 1, 1, 2, 3, 556, 6 };
            list = list.Distinct().ToList();
            var list2 = list.ConvertAll(m =>
            {
                return m.ToString();
            });
            var f = list.ToDictionary(
                (m) =>
                {
                    return m;
                },
                (n) =>
                {
                    return n.ToString();
                });
        }
    }


}
