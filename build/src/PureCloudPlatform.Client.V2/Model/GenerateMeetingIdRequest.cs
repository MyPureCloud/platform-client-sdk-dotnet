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
    /// GenerateMeetingIdRequest
    /// </summary>
    [DataContract]
    public partial class GenerateMeetingIdRequest :  IEquatable<GenerateMeetingIdRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMeetingIdRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateMeetingIdRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMeetingIdRequest" /> class.
        /// </summary>
        /// <param name="ConferenceId">The conferenceId for which to generate a meetingId.</param>
        /// <param name="Ephemeral">Boolean flag for ephemeral status of the created record (required).</param>
        /// <param name="ExpireTimeDays">Number of days the meetingId record will remain active.</param>
        public GenerateMeetingIdRequest(string ConferenceId = null, bool? Ephemeral = null, int? ExpireTimeDays = null)
        {
            this.ConferenceId = ConferenceId;
            this.Ephemeral = Ephemeral;
            this.ExpireTimeDays = ExpireTimeDays;
            
        }
        


        /// <summary>
        /// The conferenceId for which to generate a meetingId
        /// </summary>
        /// <value>The conferenceId for which to generate a meetingId</value>
        [DataMember(Name="conferenceId", EmitDefaultValue=false)]
        public string ConferenceId { get; set; }



        /// <summary>
        /// Boolean flag for ephemeral status of the created record
        /// </summary>
        /// <value>Boolean flag for ephemeral status of the created record</value>
        [DataMember(Name="ephemeral", EmitDefaultValue=false)]
        public bool? Ephemeral { get; set; }



        /// <summary>
        /// Number of days the meetingId record will remain active
        /// </summary>
        /// <value>Number of days the meetingId record will remain active</value>
        [DataMember(Name="expireTimeDays", EmitDefaultValue=false)]
        public int? ExpireTimeDays { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateMeetingIdRequest {\n");

            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
            sb.Append("  ExpireTimeDays: ").Append(ExpireTimeDays).Append("\n");
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
            return this.Equals(obj as GenerateMeetingIdRequest);
        }

        /// <summary>
        /// Returns true if GenerateMeetingIdRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateMeetingIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateMeetingIdRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConferenceId == other.ConferenceId ||
                    this.ConferenceId != null &&
                    this.ConferenceId.Equals(other.ConferenceId)
                ) &&
                (
                    this.Ephemeral == other.Ephemeral ||
                    this.Ephemeral != null &&
                    this.Ephemeral.Equals(other.Ephemeral)
                ) &&
                (
                    this.ExpireTimeDays == other.ExpireTimeDays ||
                    this.ExpireTimeDays != null &&
                    this.ExpireTimeDays.Equals(other.ExpireTimeDays)
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
                if (this.ConferenceId != null)
                    hash = hash * 59 + this.ConferenceId.GetHashCode();

                if (this.Ephemeral != null)
                    hash = hash * 59 + this.Ephemeral.GetHashCode();

                if (this.ExpireTimeDays != null)
                    hash = hash * 59 + this.ExpireTimeDays.GetHashCode();

                return hash;
            }
        }
    }

}
