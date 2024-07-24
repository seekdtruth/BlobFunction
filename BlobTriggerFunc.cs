using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace BlobFunction
{
    public class BlobTriggerFunc
    {
        private readonly ILogger<BlobTriggerFunc> _logger;

        public BlobTriggerFunc(ILogger<BlobTriggerFunc> logger)
        {
            _logger = logger;
        }

        [Function(nameof(BlobTriggerFunc))]
        public async Task Run([BlobTrigger("blobtrigger-workitems/{name}", Connection = "")] string content, string name)
        {
            _logger.LogInformation($"C# Blob Trigger processed blob\n Name: {name} \n Data: {content}");
        }
    }
}
