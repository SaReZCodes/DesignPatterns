using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class CollectionClass : IEnumerable
    {
        string[] array = { "arr1", "arr2", "arr3", "arr4" };
        public IEnumerator GetEnumerator()
        {
            foreach (var item in array)
            {
                yield return item;
            }
        }
    }
}
