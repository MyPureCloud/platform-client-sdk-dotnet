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
    /// ConsultTransferResponse
    /// </summary>
    [DataContract]
    public partial class ConsultTransferResponse :  IEquatable<ConsultTransferResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransferResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsultTransferResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransferResponse" /> class.
        /// </summary>
        /// <param name="DestinationParticipantId">Participant ID to whom the call is being transferred. (required).</param>
        public ConsultTransferResponse(string DestinationParticipantId = null)
        {
            // to ensure "DestinationParticipantId" is required (not null)
            if (DestinationParticipantId == null)
            {
                throw new InvalidDataException("DestinationParticipantId is a required property for ConsultTransferResponse and cannot be null");
            }
            else
            {
                this.DestinationParticipantId = DestinationParticipantId;
            }
        }
        
        /// <summary>
        /// Participant ID to whom the call is being transferred.
        /// </summary>
        /// <value>Participant ID to whom the call is being transferred.</value>
        [DataMember(Name="destinationParticipantId", EmitDefaultValue=false)]
        public string DestinationParticipantId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultTransferResponse {\n");
            sb.Append("  DestinationParticipantId: ").Append(DestinationParticipantId).Append("\n");
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
            return this.Equals(obj as ConsultTransferResponse);
        }

        /// <summary>
        /// Returns true if ConsultTransferResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultTransferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultTransferResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DestinationParticipantId == other.DestinationParticipantId ||
                    this.DestinationParticipantId != null &&
                    this.DestinationParticipantId.Equals(other.DestinationParticipantId)
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
                if (this.DestinationParticipantId != null)
                    hash = hash * 59 + this.DestinationParticipantId.GetHashCode();
                return hash;
            }
        }
    }

}
