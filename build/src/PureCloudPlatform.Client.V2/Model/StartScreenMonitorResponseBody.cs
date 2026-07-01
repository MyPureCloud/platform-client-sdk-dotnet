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
    /// StartScreenMonitorResponseBody
    /// </summary>
    [DataContract]
    public partial class StartScreenMonitorResponseBody :  IEquatable<StartScreenMonitorResponseBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartScreenMonitorResponseBody" /> class.
        /// </summary>
        /// <param name="ScreenMonitoringId">ScreenMonitoringId.</param>
        public StartScreenMonitorResponseBody(string ScreenMonitoringId = null)
        {
            this.ScreenMonitoringId = ScreenMonitoringId;
            
        }
        


        /// <summary>
        /// Gets or Sets ScreenMonitoringId
        /// </summary>
        [DataMember(Name="screenMonitoringId", EmitDefaultValue=false)]
        public string ScreenMonitoringId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartScreenMonitorResponseBody {\n");

            sb.Append("  ScreenMonitoringId: ").Append(ScreenMonitoringId).Append("\n");
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
            return this.Equals(obj as StartScreenMonitorResponseBody);
        }

        /// <summary>
        /// Returns true if StartScreenMonitorResponseBody instances are equal
        /// </summary>
        /// <param name="other">Instance of StartScreenMonitorResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartScreenMonitorResponseBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScreenMonitoringId == other.ScreenMonitoringId ||
                    this.ScreenMonitoringId != null &&
                    this.ScreenMonitoringId.Equals(other.ScreenMonitoringId)
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
                if (this.ScreenMonitoringId != null)
                    hash = hash * 59 + this.ScreenMonitoringId.GetHashCode();

                return hash;
            }
        }
    }

}
