using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class RepositoryHandle
    {
        internal Database.KitchenFanaticContext Context;

        public RepositoryHandle(Database.KitchenFanaticContext context) => Context = context;


        public void Save()
        {
            Context.SubmitChanges();
        }

    }
}
