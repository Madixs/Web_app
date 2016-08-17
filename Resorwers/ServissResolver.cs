using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Repository;

namespace Resolvers
{
    public class ServissResolver
    {
        public static IServiss Get()
        {
            var repository = new RepositoryDB();
            return new Serviss(repository);
        }
    }
}
