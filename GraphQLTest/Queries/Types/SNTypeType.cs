using GraphQL.Types;
using GraphQLTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.Queries.Types
{
    public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}
