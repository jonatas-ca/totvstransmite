using System.Collections.Generic;
using worker.portal.WrkNFe.Models;

namespace worker.portal.WrkNFe.Repository
{
    public interface IRepository
    {
         IEnumerable<NFe> NFes {get;}
    }
}