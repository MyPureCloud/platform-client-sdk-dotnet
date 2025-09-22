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
    /// ConversationIntentSuggestionsTopicSuggestionFeedback
    /// </summary>
    [DataContract]
    public partial class ConversationIntentSuggestionsTopicSuggestionFeedback :  IEquatable<ConversationIntentSuggestionsTopicSuggestionFeedback>
    {
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive
        }
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public RatingEnum? Rating { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationIntentSuggestionsTopicSuggestionFeedback" /> class.
        /// </summary>
        /// <param name="Rating">Rating.</param>
        public ConversationIntentSuggestionsTopicSuggestionFeedback(RatingEnum? Rating = null)
        {
            this.Rating = Rating;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationIntentSuggestionsTopicSuggestionFeedback {\n");

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
            return this.Equals(obj as ConversationIntentSuggestionsTopicSuggestionFeedback);
        }

        /// <summary>
        /// Returns true if ConversationIntentSuggestionsTopicSuggestionFeedback instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationIntentSuggestionsTopicSuggestionFeedback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationIntentSuggestionsTopicSuggestionFeedback other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();

                return hash;
            }
        }
    }

}
