using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Resolver
{
    public class RepositoryBDResolver
    {
        public static IRepository Get()
        {
            return new RepositoryDB();
        }
    }
}
