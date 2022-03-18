using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    [Serializable]
    internal class StringData : ISerializable
    {
        private string dataItemOne = "First data";
        private string dataItemTwo = "Last data";

        public StringData()
        {

        }

        protected StringData(SerializationInfo info, StreamingContext context)
        {
            dataItemOne = info.GetString("Data #1").ToLower();
            dataItemTwo = info.GetString("Data #2").ToLower();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Data #1", dataItemOne.ToUpper());
            info.AddValue("Data #2", dataItemTwo.ToUpper());
        }

        public override string ToString()
        {
            return $"{dataItemOne} {dataItemTwo}";
        }
    }
}
