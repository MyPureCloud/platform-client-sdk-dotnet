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
    /// FeedbackAddRequest
    /// </summary>
    [DataContract]
    public partial class FeedbackAddRequest :  IEquatable<FeedbackAddRequest>
    {
        /// <summary>
        /// Agent’s rating for the system-generated summary.
        /// </summary>
        /// <value>Agent’s rating for the system-generated summary.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RatingEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative
        }
        /// <summary>
        /// Agent’s rating for the system-generated summary.
        /// </summary>
        /// <value>Agent’s rating for the system-generated summary.</value>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public RatingEnum? Rating { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAddRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeedbackAddRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAddRequest" /> class.
        /// </summary>
        /// <param name="Summary">Agent's summary for the conversation (required).</param>
        /// <param name="Rating">Agent’s rating for the system-generated summary..</param>
        public FeedbackAddRequest(string Summary = null, RatingEnum? Rating = null)
        {
            this.Summary = Summary;
            this.Rating = Rating;
            
        }
        


        /// <summary>
        /// Agent's summary for the conversation
        /// </summary>
        /// <value>Agent's summary for the conversation</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedbackAddRequest {\n");

            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(obj as FeedbackAddRequest);
        }

        /// <summary>
        /// Returns true if FeedbackAddRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FeedbackAddRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackAddRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) &&
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
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
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();

                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();

                return hash;
            }
        }
    }

}
