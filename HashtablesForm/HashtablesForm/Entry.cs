using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtablesForm
{
    class Entry
    {
        //Property for key so that it can be reached from outside the class
        public object key { get; private set; }
        //Property for value so it can be reached from outside the class
        public object value { get; private set; }

        /// <summary>
        /// Constuctor for Entry with parameter key and value that is set to classes variables key and value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Entry(object key, object value)
        {
            this.key = key;
            this.value = value;
        }

        /// <summary>
        /// Bool method with parameter object to compare two keys with each other
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Entry keyValue = (Entry)obj;
            return key.Equals(keyValue.key);
        }
    }
}
