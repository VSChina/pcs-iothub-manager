﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using Microsoft.Azure.IoTSolutions.IotHubManager.WebService.Runtime;
using Newtonsoft.Json;

namespace Microsoft.Azure.IoTSolutions.IotHubManager.WebService.v1.Models
{
    public class StatusApiModel
    {
        public string Message { get; set; }
        public DateTime CurrentTime => DateTime.UtcNow;
        public DateTime StartTime => Uptime.Start;
        public TimeSpan UpTime => Uptime.Duration;

        [JsonProperty(PropertyName = "$metadata")]
        public Dictionary<string, string> Metadata => new Dictionary<string, string>
        {
            { "$type", "Status;" + Version.Number },
            { "$uri", "/" + Version.Path + "/status" }
        };
    }
}