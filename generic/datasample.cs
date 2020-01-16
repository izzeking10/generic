using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    public class Datasample<T>
    {
        private T theData;
        public Datasample(T theData)
        {
            this.theData = theData;
        }
    public T GetData()
        {
            return theData;
        }
    public String MyToString()
        {
            return theData.ToString();
        }
    public static T getMiddleElement(T[] arr)
        {
            T element = arr[arr.Length / 2];
            return element;
        }

    }
}