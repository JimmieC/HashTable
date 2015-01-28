using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtablesForm
{
    class Hashtable
    {
        //Instans vairable linked list of type object that will store all values in a list
        private LinkedList<object> insertionOrder = new LinkedList<object>();
        //Instans variable of type entry that will be the hashtable
        private LinkedList<Entry>[] table;
        
        /// <summary>
        /// Constructor for Hashtables with int size as parameter, this will determine how many positions the hashtable will have
        /// </summary>
        /// <param name="size"></param>
        public Hashtable(int size)
        {
            //Initiate table with size equal to in parameter
            table = new LinkedList<Entry>[size];
            //for loop that creates a linked list at each point in the table list
            for (int i = 0; i < size; i++)
            {
                table[i] = new LinkedList<Entry>();
            }
        }

        /// <summary>
        /// Method to calculate the postion in the hashtable from the key given in the parameter, returns an int that will be equal to 
        /// a position in the table
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int HashIndex(object key)
        {
            int hashCode = key.GetHashCode();
            hashCode = hashCode % table.Length;
            return (hashCode < 0) ? -hashCode : hashCode;
        }

        /// <summary>
        /// Method to return a value if there is one equal to the given key otherwise returns null
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(object key)
        {
            int hashIndex = HashIndex(key);
            if (table[hashIndex].Contains(new Entry(key, null)))
            {
                Entry entry = table[hashIndex].Find(new Entry(key, null)).Value;
                return entry.value;
            }
            return null;
        }

        /// <summary>
        /// Method put to add a value to the hashtable through a key. First we declare an in called hashindex which is equaled to
        /// the returned value of the the method Hashindex which has parameter of put method parameter key. This returns a position. 
        /// Then at table position hashindex we add a new entry with the put methods parameters key and value.  We also add the value
        /// to the list insertionorder
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Put(object key, object value)
        {
            int hashIndex = HashIndex(key);
            table[hashIndex].AddFirst(new Entry(key, value));
            insertionOrder.AddFirst(value);
        }

        /// <summary>
        /// Method remove which simply uses the the hashindex method on the input key to retrieve the position in the hashindex
        /// where it should remove the first value in the linkedlist at that postion. 
        /// </summary>
        /// <param name="key"></param>
        public void Remove(object key)
        {
            table[HashIndex(key)].RemoveFirst();
        }

        /// <summary>
        /// Method to return the linkedlist insertion order
        /// </summary>
        /// <returns></returns>
        public LinkedList<object> GetInsertionOrder()
        {
            return insertionOrder;
        }

   
    }
}
