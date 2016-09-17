using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        public ValueOutOfRangeException(Exception i_InnerException) : base("Value is out of range", i_InnerException)
        {
        }
    }
}
