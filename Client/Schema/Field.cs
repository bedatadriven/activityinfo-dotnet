﻿using System;
using Newtonsoft.Json;

namespace ActivityInfo.Schema
{
    public class Field : FormElement
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("relevanceCondition")]
        public string RelevanceCondition { get; set; }
       
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonIgnore]
        public FieldType Type { get; set; }

        public Field()
        {
        }

    }
}
