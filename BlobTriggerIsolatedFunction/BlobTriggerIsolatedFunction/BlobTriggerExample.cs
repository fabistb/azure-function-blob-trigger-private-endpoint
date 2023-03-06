using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace BlobTriggerIsolatedFunction;

public static class BlobTriggerExample
{
    [Function("BlobTriggerExample")]
    public static void Run([BlobTrigger("example-trigger/{name}", Connection = "StorageConnection")] string myBlob, string name,
        FunctionContext context)
    {
        var logger = context.GetLogger("BlobTriggerCSharp");
        logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {myBlob}");
        
    }
}