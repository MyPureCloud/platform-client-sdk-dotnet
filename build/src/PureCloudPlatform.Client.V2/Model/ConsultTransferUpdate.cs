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
    /// ConsultTransferUpdate
    /// </summary>
    [DataContract]
    public partial class ConsultTransferUpdate :  IEquatable<ConsultTransferUpdate>
    {
        
        
        /// <summary>
        /// Determines to whom the initiating participant is speaking.
        /// </summary>
        /// <value>Determines to whom the initiating participant is speaking.</value>
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
        /// Determines to whom the initiating participant is speaking.
        /// </summary>
        /// <value>Determines to whom the initiating participant is speaking.</value>
        [DataMember(Name="speakTo", EmitDefaultValue=false)]
        public SpeakToEnum? SpeakTo { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransferUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsultTransferUpdate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransferUpdate" /> class.
        /// </summary>
        /// <param name="SpeakTo">Determines to whom the initiating participant is speaking. (required).</param>
        public ConsultTransferUpdate(SpeakToEnum? SpeakTo = null)
        {
            
        }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultTransferUpdate {\n");
            
            sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
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
            return this.Equals(obj as ConsultTransferUpdate);
        }

        /// <summary>
        /// Returns true if ConsultTransferUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultTransferUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultTransferUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SpeakTo == other.SpeakTo ||
                    this.SpeakTo != null &&
                    this.SpeakTo.Equals(other.SpeakTo)
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
                
                return hash;
            }
        }
    }

}
