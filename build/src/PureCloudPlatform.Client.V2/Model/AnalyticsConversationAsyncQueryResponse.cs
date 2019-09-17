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
    /// AnalyticsConversationAsyncQueryResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsConversationAsyncQueryResponse :  IEquatable<AnalyticsConversationAsyncQueryResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversationAsyncQueryResponse" /> class.
        /// </summary>
        /// <param name="Conversations">Conversations.</param>
        /// <param name="Cursor">Optional cursor to indicate where to resume the results.</param>
        public AnalyticsConversationAsyncQueryResponse(List<AnalyticsConversation> Conversations = null, string Cursor = null)
        {
            this.Conversations = Conversations;
            this.Cursor = Cursor;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name="conversations", EmitDefaultValue=false)]
        public List<AnalyticsConversation> Conversations { get; set; }
        
        
        
        /// <summary>
        /// Optional cursor to indicate where to resume the results
        /// </summary>
        /// <value>Optional cursor to indicate where to resume the results</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsConversationAsyncQueryResponse {\n");
            
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AnalyticsConversationAsyncQueryResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsConversationAsyncQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsConversationAsyncQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsConversationAsyncQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conversations == other.Conversations ||
                    this.Conversations != null &&
                    this.Conversations.SequenceEqual(other.Conversations)
                ) &&
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
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
                
                if (this.Conversations != null)
                    hash = hash * 59 + this.Conversations.GetHashCode();
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                return hash;
            }
        }
    }

}
