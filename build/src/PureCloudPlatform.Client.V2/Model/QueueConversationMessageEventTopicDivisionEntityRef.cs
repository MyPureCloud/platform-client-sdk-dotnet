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
    /// QueueConversationMessageEventTopicDivisionEntityRef
    /// </summary>
    [DataContract]
    public partial class QueueConversationMessageEventTopicDivisionEntityRef :  IEquatable<QueueConversationMessageEventTopicDivisionEntityRef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationMessageEventTopicDivisionEntityRef" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="DateDivisionUpdated">The time the entity division was last updated..</param>
        public QueueConversationMessageEventTopicDivisionEntityRef(string Id = null, string SelfUri = null, DateTime? DateDivisionUpdated = null)
        {
            this.Id = Id;
            this.SelfUri = SelfUri;
            this.DateDivisionUpdated = DateDivisionUpdated;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// The time the entity division was last updated.
        /// </summary>
        /// <value>The time the entity division was last updated.</value>
        [DataMember(Name="dateDivisionUpdated", EmitDefaultValue=false)]
        public DateTime? DateDivisionUpdated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationMessageEventTopicDivisionEntityRef {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  DateDivisionUpdated: ").Append(DateDivisionUpdated).Append("\n");
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
            return this.Equals(obj as QueueConversationMessageEventTopicDivisionEntityRef);
        }

        /// <summary>
        /// Returns true if QueueConversationMessageEventTopicDivisionEntityRef instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationMessageEventTopicDivisionEntityRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationMessageEventTopicDivisionEntityRef other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.DateDivisionUpdated == other.DateDivisionUpdated ||
                    this.DateDivisionUpdated != null &&
                    this.DateDivisionUpdated.Equals(other.DateDivisionUpdated)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.DateDivisionUpdated != null)
                    hash = hash * 59 + this.DateDivisionUpdated.GetHashCode();

                return hash;
            }
        }
    }

}
