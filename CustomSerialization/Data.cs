using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    [Serializable]
    internal class Data
    {
        private string dataItemOne = "Data .....";
        private string dataItemTwo = "..... Data";

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }

        public override string ToString()
        {
            return $"{dataItemOne} {dataItemTwo}";
        }
    }
}
