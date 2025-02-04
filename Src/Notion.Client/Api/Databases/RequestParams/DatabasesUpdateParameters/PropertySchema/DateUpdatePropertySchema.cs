﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class DateUpdatePropertySchema : UpdatePropertySchema, IUpdatePropertySchema
    {
        [JsonProperty("date")]
        public Dictionary<string, object> Date { get; set; }
    }
}
