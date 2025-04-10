using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalcial_app
{
    public class TestForLinq
    {
        private readonly int[] numbers = [ 0, 1, 2, 3, 4, 5, 6 ];
        private readonly IEnumerable<int> test_numbers;
        private readonly IEnumerable<int> numQuery1;

        string[] groupingQuery = ["carrots", "cabbage", "broccoli", "beans", "barley"];

        public TestForLinq()
        {
            test_numbers = from _ in numbers
                          where (_ % 2 == 0)
                          select _;

                    
         numQuery1 =
            from num in numbers2
            where num % 2 == 0
            orderby num
            select num;

            IEnumerable<IGrouping<char, string>> queryFoodGroups =
    from item in groupingQuery
    group item by item[0];

            var test  = from item in queryFoodGroups
                        select new { item.Key };
        }

        private  int[] numbers2 = [ 5, 10, 8, 3, 6, 12 ];


        public void Test() => test_numbers.ToList().ForEach(num => Console.WriteLine(num));
    }
}