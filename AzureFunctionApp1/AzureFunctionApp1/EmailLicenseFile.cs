using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionApp1
{
    public static class EmailLicenseFile
    {
        [FunctionName("EmailLicenseFile")]
        public static void Run([BlobTrigger("licenses/{name}",
            Connection = "AzureWebJobStorage")]string licenseFileContents,
            string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed" +
                               $" blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
