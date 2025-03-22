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
    /// SocialMediaDetailMessageContainer
    /// </summary>
    [DataContract]
    public partial class SocialMediaDetailMessageContainer :  IEquatable<SocialMediaDetailMessageContainer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaDetailMessageContainer" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="NormalizedMessage">NormalizedMessage.</param>
        /// <param name="EscalationInfo">EscalationInfo.</param>
        public SocialMediaDetailMessageContainer(string Id = null, ConversationNormalizedMessage NormalizedMessage = null, SocialMediaMessageEscalationInfo EscalationInfo = null)
        {
            this.Id = Id;
            this.NormalizedMessage = NormalizedMessage;
            this.EscalationInfo = EscalationInfo;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets NormalizedMessage
        /// </summary>
        [DataMember(Name="normalizedMessage", EmitDefaultValue=false)]
        public ConversationNormalizedMessage NormalizedMessage { get; set; }



        /// <summary>
        /// Gets or Sets EscalationInfo
        /// </summary>
        [DataMember(Name="escalationInfo", EmitDefaultValue=false)]
        public SocialMediaMessageEscalationInfo EscalationInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaDetailMessageContainer {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
            sb.Append("  EscalationInfo: ").Append(EscalationInfo).Append("\n");
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
            return this.Equals(obj as SocialMediaDetailMessageContainer);
        }

        /// <summary>
        /// Returns true if SocialMediaDetailMessageContainer instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialMediaDetailMessageContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialMediaDetailMessageContainer other)
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
                    this.NormalizedMessage == other.NormalizedMessage ||
                    this.NormalizedMessage != null &&
                    this.NormalizedMessage.Equals(other.NormalizedMessage)
                ) &&
                (
                    this.EscalationInfo == other.EscalationInfo ||
                    this.EscalationInfo != null &&
                    this.EscalationInfo.Equals(other.EscalationInfo)
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

                if (this.NormalizedMessage != null)
                    hash = hash * 59 + this.NormalizedMessage.GetHashCode();

                if (this.EscalationInfo != null)
                    hash = hash * 59 + this.EscalationInfo.GetHashCode();

                return hash;
            }
        }
    }

}
