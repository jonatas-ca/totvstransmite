using System.Collections.Generic;
using worker.portal.WrkNFe.Models;
using worker.portal.WrkNFe.Context;

namespace worker.portal.WrkNFe.Repository
{
    public class NFeRepository:IRepository
    {
        private NFeContext context;

        public NFeRepository(NFeContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<NFe> NFes => context.NFes;
    }
}