using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace BlobFunction
{
    public class Blob
    {
        private readonly ILogger<Blob> _logger;

        public Blob(ILogger<Blob> logger)
        {
            _logger = logger;
        }

        [Function(nameof(Blob))]
        public async Task Run([BlobTrigger("samples-workitems/{name}", Connection = "")] string stream, string name)
        {
            _logger.LogInformation("function ran!");
        }
    }
}
