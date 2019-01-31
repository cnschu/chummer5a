﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SINners.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class SINSearchResult
    {
        /// <summary>
        /// Initializes a new instance of the SINSearchResult class.
        /// </summary>
        public SINSearchResult() { }

        /// <summary>
        /// Initializes a new instance of the SINSearchResult class.
        /// </summary>
        public SINSearchResult(IList<SINnersList> sinLists = default(IList<SINnersList>), string errorText = default(string))
        {
            SinLists = sinLists;
            ErrorText = errorText;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sinLists")]
        public IList<SINnersList> SinLists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorText")]
        public string ErrorText { get; set; }

    }
}