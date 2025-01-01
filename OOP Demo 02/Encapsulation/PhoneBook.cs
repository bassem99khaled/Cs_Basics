using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02.Encapsulation
{
    internal class PhoneBook
    {
        #region Fields
        //private string[] names;
        //private long[] numbers;
        //private  int size;

        //#endregion

        //// Getter
        //public ulong GetNumber(string name)
        //{
        //    if (names is not null && numbers is not null)
        //        for (int i = 0; i < size; i++)
        //            if (name == names[i])
        //                return numbers[i];

        //    return 0;
        //}

        //// Setter

        //public void SetNumber(string name, ulong value)
        //{
        //    if(names is not null && numbers is not null)
        //    {
        //        for(int i =0; i < size; i++)
        //        {
        //            if (name == names[i])
        //                numbers[i] = value; // Update
        //            return;
        //        }
        //    }
        //}
        #endregion

        #region Properties

        //public int sizes
        //{
        //    get { return sizes; }
        //}


        // *********** Indexer : is a special Property [ Named always with  "this" keyword && can take parameters]

        //public long this[string name]
        //{
        //    get
        //    {
        //        if (names is not null && numbers is not null)
        //            for (int i = 0; i < size; i++)
        //                if (name == names[i])
        //                    return (long)numbers[i];

        //        return -1;
        //    }
        //    set
        //    {
        //        {
        //            if (names is not null && numbers is not null)
        //            {
        //                for (int i = 0; i < size; i++)
        //                {
        //                    if (name == names[i])
        //                        numbers[i] = value; // Update
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}

        //public string this[int index]
        //{
        //    get { return $"{index + 1} , Name = {names[index]} , Number = {numbers[index]}"; }
        //}
        #endregion

        #region Constructors
        //public PhoneBook(int size) 
        //{
        //this.size = size;
        //names = new string[size];
        //numbers = new ulong[size];
        //}

        #endregion

        #region methods
        //public void addperson(int position , string name , ulong number)
        //{
        //    if ( name is not null && numbers is not null && position < size)
        //    {
        //        names[position] = name;
        //        numbers[position] = number;
        //    }    
        //}
        #endregion


    }
}
