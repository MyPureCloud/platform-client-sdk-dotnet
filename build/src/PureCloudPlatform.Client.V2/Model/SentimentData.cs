using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SentimentData
    /// </summary>
    [DataContract]
    public partial class SentimentData :  IEquatable<SentimentData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentData" /> class.
        /// </summary>
        /// <param name="Insights">The sentiment insights extracted from the conversation.</param>
        public SentimentData(SentimentInsights Insights = null)
        {
            this.Insights = Insights;
            
        }
        


        /// <summary>
        /// The sentiment insights extracted from the conversation
        /// </summary>
        /// <value>The sentiment insights extracted from the conversation</value>
        [DataMember(Name="insights", EmitDefaultValue=false)]
        public SentimentInsights Insights { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentimentData {\n");

            sb.Append("  Insights: ").Append(Insights).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SentimentData);
        }

        /// <summary>
        /// Returns true if SentimentData instances are equal
        /// </summary>
        /// <param name="other">Instance of SentimentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentimentData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Insights == other.Insights ||
                    this.Insights != null &&
                    this.Insights.Equals(other.Insights)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Insights != null)
                    hash = hash * 59 + this.Insights.GetHashCode();

                return hash;
            }
        }
    }

}
