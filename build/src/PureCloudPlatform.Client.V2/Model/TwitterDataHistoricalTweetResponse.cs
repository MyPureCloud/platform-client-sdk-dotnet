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
    /// TwitterDataHistoricalTweetResponse
    /// </summary>
    [DataContract]
    public partial class TwitterDataHistoricalTweetResponse :  IEquatable<TwitterDataHistoricalTweetResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterDataHistoricalTweetResponse" /> class.
        /// </summary>
        /// <param name="MatchingTweets">The count of matching tweets using the searchTerms..</param>
        /// <param name="PreviousNumberOfDays">The number of days used for the query.</param>
        /// <param name="UsageStatistics">The tweet usage of the org.</param>
        public TwitterDataHistoricalTweetResponse(long? MatchingTweets = null, int? PreviousNumberOfDays = null, TweetUsage UsageStatistics = null)
        {
            this.MatchingTweets = MatchingTweets;
            this.PreviousNumberOfDays = PreviousNumberOfDays;
            this.UsageStatistics = UsageStatistics;
            
        }
        


        /// <summary>
        /// The count of matching tweets using the searchTerms.
        /// </summary>
        /// <value>The count of matching tweets using the searchTerms.</value>
        [DataMember(Name="matchingTweets", EmitDefaultValue=false)]
        public long? MatchingTweets { get; set; }



        /// <summary>
        /// The number of days used for the query
        /// </summary>
        /// <value>The number of days used for the query</value>
        [DataMember(Name="previousNumberOfDays", EmitDefaultValue=false)]
        public int? PreviousNumberOfDays { get; set; }



        /// <summary>
        /// The tweet usage of the org
        /// </summary>
        /// <value>The tweet usage of the org</value>
        [DataMember(Name="usageStatistics", EmitDefaultValue=false)]
        public TweetUsage UsageStatistics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwitterDataHistoricalTweetResponse {\n");

            sb.Append("  MatchingTweets: ").Append(MatchingTweets).Append("\n");
            sb.Append("  PreviousNumberOfDays: ").Append(PreviousNumberOfDays).Append("\n");
            sb.Append("  UsageStatistics: ").Append(UsageStatistics).Append("\n");
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
            return this.Equals(obj as TwitterDataHistoricalTweetResponse);
        }

        /// <summary>
        /// Returns true if TwitterDataHistoricalTweetResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterDataHistoricalTweetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterDataHistoricalTweetResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MatchingTweets == other.MatchingTweets ||
                    this.MatchingTweets != null &&
                    this.MatchingTweets.Equals(other.MatchingTweets)
                ) &&
                (
                    this.PreviousNumberOfDays == other.PreviousNumberOfDays ||
                    this.PreviousNumberOfDays != null &&
                    this.PreviousNumberOfDays.Equals(other.PreviousNumberOfDays)
                ) &&
                (
                    this.UsageStatistics == other.UsageStatistics ||
                    this.UsageStatistics != null &&
                    this.UsageStatistics.Equals(other.UsageStatistics)
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
                if (this.MatchingTweets != null)
                    hash = hash * 59 + this.MatchingTweets.GetHashCode();

                if (this.PreviousNumberOfDays != null)
                    hash = hash * 59 + this.PreviousNumberOfDays.GetHashCode();

                if (this.UsageStatistics != null)
                    hash = hash * 59 + this.UsageStatistics.GetHashCode();

                return hash;
            }
        }
    }

}
