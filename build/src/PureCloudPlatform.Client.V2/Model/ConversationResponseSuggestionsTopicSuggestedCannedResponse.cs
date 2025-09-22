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
    /// ConversationResponseSuggestionsTopicSuggestedCannedResponse
    /// </summary>
    [DataContract]
    public partial class ConversationResponseSuggestionsTopicSuggestedCannedResponse :  IEquatable<ConversationResponseSuggestionsTopicSuggestedCannedResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResponseSuggestionsTopicSuggestedCannedResponse" /> class.
        /// </summary>
        /// <param name="ResponseId">ResponseId.</param>
        /// <param name="LibraryId">LibraryId.</param>
        public ConversationResponseSuggestionsTopicSuggestedCannedResponse(Guid? ResponseId = null, Guid? LibraryId = null)
        {
            this.ResponseId = ResponseId;
            this.LibraryId = LibraryId;
            
        }
        


        /// <summary>
        /// Gets or Sets ResponseId
        /// </summary>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public Guid? ResponseId { get; set; }



        /// <summary>
        /// Gets or Sets LibraryId
        /// </summary>
        [DataMember(Name="libraryId", EmitDefaultValue=false)]
        public Guid? LibraryId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationResponseSuggestionsTopicSuggestedCannedResponse {\n");

            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
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
            return this.Equals(obj as ConversationResponseSuggestionsTopicSuggestedCannedResponse);
        }

        /// <summary>
        /// Returns true if ConversationResponseSuggestionsTopicSuggestedCannedResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationResponseSuggestionsTopicSuggestedCannedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationResponseSuggestionsTopicSuggestedCannedResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ResponseId == other.ResponseId ||
                    this.ResponseId != null &&
                    this.ResponseId.Equals(other.ResponseId)
                ) &&
                (
                    this.LibraryId == other.LibraryId ||
                    this.LibraryId != null &&
                    this.LibraryId.Equals(other.LibraryId)
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
                if (this.ResponseId != null)
                    hash = hash * 59 + this.ResponseId.GetHashCode();

                if (this.LibraryId != null)
                    hash = hash * 59 + this.LibraryId.GetHashCode();

                return hash;
            }
        }
    }

}
