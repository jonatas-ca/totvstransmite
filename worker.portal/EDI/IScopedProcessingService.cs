using System.Threading;
using System.Threading.Tasks;

namespace worker.portal.EDI
{
    public interface IScopedProcessingService
    {
        Task DoWork(CancellationToken stoppingToken);
    }
}