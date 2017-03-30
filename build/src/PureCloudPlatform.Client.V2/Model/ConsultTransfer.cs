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
    /// ConsultTransfer
    /// </summary>
    [DataContract]
    public partial class ConsultTransfer :  IEquatable<ConsultTransfer>
    {
        /// <summary>
        /// Determines to whom the initiating participant is speaking. Defaults to DESTINATION
        /// </summary>
        /// <value>Determines to whom the initiating participant is speaking. Defaults to DESTINATION</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SpeakToEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Destination for "DESTINATION"
            /// </summary>
            [EnumMember(Value = "DESTINATION")]
            Destination,
            
            /// <summary>
            /// Enum Object for "OBJECT"
            /// </summary>
            [EnumMember(Value = "OBJECT")]
            Object,
            
            /// <summary>
            /// Enum Both for "BOTH"
            /// </summary>
            [EnumMember(Value = "BOTH")]
            Both
        }
        /// <summary>
        /// Determines to whom the initiating participant is speaking. Defaults to DESTINATION
        /// </summary>
        /// <value>Determines to whom the initiating participant is speaking. Defaults to DESTINATION</value>
        [DataMember(Name="speakTo", EmitDefaultValue=false)]
        public SpeakToEnum? SpeakTo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransfer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsultTransfer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransfer" /> class.
        /// </summary>
        /// <param name="SpeakTo">Determines to whom the initiating participant is speaking. Defaults to DESTINATION.</param>
        /// <param name="Destination">Destination phone number and name. (required).</param>
        public ConsultTransfer(SpeakToEnum? SpeakTo = null, Destination Destination = null)
        {
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for ConsultTransfer and cannot be null");
            }
            else
            {
                this.Destination = Destination;
            }
            this.SpeakTo = SpeakTo;
        }
        
        /// <summary>
        /// Destination phone number and name.
        /// </summary>
        /// <value>Destination phone number and name.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public Destination Destination { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultTransfer {\n");
            sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(obj as ConsultTransfer);
        }

        /// <summary>
        /// Returns true if ConsultTransfer instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultTransfer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SpeakTo == other.SpeakTo ||
                    this.SpeakTo != null &&
                    this.SpeakTo.Equals(other.SpeakTo)
                ) &&
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
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
                if (this.SpeakTo != null)
                    hash = hash * 59 + this.SpeakTo.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                return hash;
            }
        }
    }

}
