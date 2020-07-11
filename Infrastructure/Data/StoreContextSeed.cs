using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class ExampleContextSeed
    {
        public static async Task SeedAsync(ExampleContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
              var logger = loggerFactory.CreateLogger<ExampleContext>();
              logger.LogError(ex.Message);
            }

        }
    }
}