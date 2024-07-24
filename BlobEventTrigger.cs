using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace BlobFunction
{
    public class BlobEventTrigger
    {
        private readonly ILogger<BlobEventTrigger> _logger;

        public BlobEventTrigger(ILogger<BlobEventTrigger> logger)
        {
            _logger = logger;
        }

        [Function(nameof(BlobEventTrigger))]
        public async Task Run([BlobTrigger("eventgrid-workitems/{name}", Source = BlobTriggerSource.EventGrid, Connection = "")] string content, string name)
        {
            _logger.LogInformation($"C# Blob Trigger (using Event Grid) processed blob\n Name: {name} \n Data: {content}");
        }
    }
}
