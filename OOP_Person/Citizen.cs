using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    class Citizen : Person, IHasId
    {
 
        public string Id { get; }


    }
}
