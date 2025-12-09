using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.ChartGenerator
{
    /// <summary>
    /// Query options for the Chart Generator API
    /// </summary>
    public class ChartGeneratorQueryOptions
    {
        /// <summary>
        /// The type of chart you want to generate (e.g. bar, line, pie)
        /// Example: bar
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The labels for the data points on the chart
        /// Example: ["Q1", "Q2", "Q3", "Q4"]
        /// </summary>
        [JsonProperty("data[labels]")]
        public string Data[labels] { get; set; }

        /// <summary>
        /// The label for the first dataset
        /// Example: Users
        /// </summary>
        [JsonProperty("data[datasets][0][label]")]
        public string Data[datasets][0][label] { get; set; }

        /// <summary>
        /// The data for the first dataset
        /// Example: [50, 60, 70, 180]
        /// </summary>
        [JsonProperty("data[datasets][0][data]")]
        public string Data[datasets][0][data] { get; set; }

        /// <summary>
        /// The label for the second dataset (optional)
        /// Example: Revenue
        /// </summary>
        [JsonProperty("data[datasets][1][label]")]
        public string Data[datasets][1][label] { get; set; }

        /// <summary>
        /// The data for the second dataset (optional)
        /// Example: [100, 200, 300, 400]
        /// </summary>
        [JsonProperty("data[datasets][1][data]")]
        public string Data[datasets][1][data] { get; set; }
    }
}
