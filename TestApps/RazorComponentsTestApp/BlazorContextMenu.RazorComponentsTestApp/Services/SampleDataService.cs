﻿using BlazorContextMenu.TestAppsCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorContextMenu.RazorComponentsTestApp.Services
{
    public class SampleDataService : ISampleDataService
    {
        public Task<string[]> GetSampleData()
        {
            return Task.FromResult(new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            });
        }
    }
}
