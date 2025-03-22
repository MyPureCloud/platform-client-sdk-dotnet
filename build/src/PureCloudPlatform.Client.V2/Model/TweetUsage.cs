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
    /// TweetUsage
    /// </summary>
    [DataContract]
    public partial class TweetUsage :  IEquatable<TweetUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetUsage" /> class.
        /// </summary>
        /// <param name="IngestionLimit">Ingestion limit.</param>
        /// <param name="TweetCount">The number of tweets consumed.</param>
        /// <param name="DateStart">The start of the usage period for the currently consumed tweets. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public TweetUsage(long? IngestionLimit = null, long? TweetCount = null, DateTime? DateStart = null)
        {
            this.IngestionLimit = IngestionLimit;
            this.TweetCount = TweetCount;
            this.DateStart = DateStart;
            
        }
        


        /// <summary>
        /// Ingestion limit
        /// </summary>
        /// <value>Ingestion limit</value>
        [DataMember(Name="ingestionLimit", EmitDefaultValue=false)]
        public long? IngestionLimit { get; set; }



        /// <summary>
        /// The number of tweets consumed
        /// </summary>
        /// <value>The number of tweets consumed</value>
        [DataMember(Name="tweetCount", EmitDefaultValue=false)]
        public long? TweetCount { get; set; }



        /// <summary>
        /// The start of the usage period for the currently consumed tweets. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start of the usage period for the currently consumed tweets. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TweetUsage {\n");

            sb.Append("  IngestionLimit: ").Append(IngestionLimit).Append("\n");
            sb.Append("  TweetCount: ").Append(TweetCount).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
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
            return this.Equals(obj as TweetUsage);
        }

        /// <summary>
        /// Returns true if TweetUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of TweetUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TweetUsage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IngestionLimit == other.IngestionLimit ||
                    this.IngestionLimit != null &&
                    this.IngestionLimit.Equals(other.IngestionLimit)
                ) &&
                (
                    this.TweetCount == other.TweetCount ||
                    this.TweetCount != null &&
                    this.TweetCount.Equals(other.TweetCount)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
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
                if (this.IngestionLimit != null)
                    hash = hash * 59 + this.IngestionLimit.GetHashCode();

                if (this.TweetCount != null)
                    hash = hash * 59 + this.TweetCount.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                return hash;
            }
        }
    }

}
