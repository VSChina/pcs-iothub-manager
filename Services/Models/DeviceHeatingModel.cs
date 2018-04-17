using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.IoTSolutions.IotHubManager.Services.Models
{
    public class DeviceHeatingModel
    {
        [JsonProperty(PropertyName = "HeatingSwitch")]
        public bool HeatingSwitch { get; set; }
    }
}
