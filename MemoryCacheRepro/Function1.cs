using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Runtime.Caching;
using System.Collections.Generic;

namespace MemoryCacheRepro
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            ObjectCache cache = MemoryCache.Default;
            //string cachedName = cache["name"] as string;

            //if (cachedName== null)
            //{
            //    CacheItemPolicy policy = new CacheItemPolicy();

            //    List<string> names = new List<string>();
            //    names.Add(name);

            //    policy.ChangeMonitors.Add(new
            //        HostFileChangeMonitor(names));

            //    cache.Set("name", name, policy);
            //}

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
