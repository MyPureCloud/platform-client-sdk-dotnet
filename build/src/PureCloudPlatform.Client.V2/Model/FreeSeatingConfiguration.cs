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
    /// FreeSeatingConfiguration
    /// </summary>
    [DataContract]
    public partial class FreeSeatingConfiguration :  IEquatable<FreeSeatingConfiguration>
    {
        
        
        /// <summary>
        /// The FreeSeatingState for FreeSeatingConfiguration. Can be ON, OFF, or PARTIAL. ON meaning disassociate the user after the ttl expires, OFF meaning never disassociate the user, and PARTIAL meaning only disassociate when a user explicitly clicks log out.
        /// </summary>
        /// <value>The FreeSeatingState for FreeSeatingConfiguration. Can be ON, OFF, or PARTIAL. ON meaning disassociate the user after the ttl expires, OFF meaning never disassociate the user, and PARTIAL meaning only disassociate when a user explicitly clicks log out.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FreeSeatingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "ON"
            /// </summary>
            [EnumMember(Value = "ON")]
            On,
            
            /// <summary>
            /// Enum Off for "OFF"
            /// </summary>
            [EnumMember(Value = "OFF")]
            Off,
            
            /// <summary>
            /// Enum Partial for "PARTIAL"
            /// </summary>
            [EnumMember(Value = "PARTIAL")]
            Partial
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The FreeSeatingState for FreeSeatingConfiguration. Can be ON, OFF, or PARTIAL. ON meaning disassociate the user after the ttl expires, OFF meaning never disassociate the user, and PARTIAL meaning only disassociate when a user explicitly clicks log out.
        /// </summary>
        /// <value>The FreeSeatingState for FreeSeatingConfiguration. Can be ON, OFF, or PARTIAL. ON meaning disassociate the user after the ttl expires, OFF meaning never disassociate the user, and PARTIAL meaning only disassociate when a user explicitly clicks log out.</value>
        [DataMember(Name="freeSeatingState", EmitDefaultValue=false)]
        public FreeSeatingStateEnum? FreeSeatingState { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeSeatingConfiguration" /> class.
        /// </summary>
        /// <param name="FreeSeatingState">The FreeSeatingState for FreeSeatingConfiguration. Can be ON, OFF, or PARTIAL. ON meaning disassociate the user after the ttl expires, OFF meaning never disassociate the user, and PARTIAL meaning only disassociate when a user explicitly clicks log out..</param>
        /// <param name="TtlMinutes">The amount of time in minutes until an offline user is disassociated from their station.</param>
        public FreeSeatingConfiguration(FreeSeatingStateEnum? FreeSeatingState = null, int? TtlMinutes = null)
        {
            this.FreeSeatingState = FreeSeatingState;
            this.TtlMinutes = TtlMinutes;
            
        }
        
        
        
        
        
        /// <summary>
        /// The amount of time in minutes until an offline user is disassociated from their station
        /// </summary>
        /// <value>The amount of time in minutes until an offline user is disassociated from their station</value>
        [DataMember(Name="ttlMinutes", EmitDefaultValue=false)]
        public int? TtlMinutes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeSeatingConfiguration {\n");
            
            sb.Append("  FreeSeatingState: ").Append(FreeSeatingState).Append("\n");
            sb.Append("  TtlMinutes: ").Append(TtlMinutes).Append("\n");
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
            return this.Equals(obj as FreeSeatingConfiguration);
        }

        /// <summary>
        /// Returns true if FreeSeatingConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of FreeSeatingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FreeSeatingConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FreeSeatingState == other.FreeSeatingState ||
                    this.FreeSeatingState != null &&
                    this.FreeSeatingState.Equals(other.FreeSeatingState)
                ) &&
                (
                    this.TtlMinutes == other.TtlMinutes ||
                    this.TtlMinutes != null &&
                    this.TtlMinutes.Equals(other.TtlMinutes)
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
                
                if (this.FreeSeatingState != null)
                    hash = hash * 59 + this.FreeSeatingState.GetHashCode();
                
                if (this.TtlMinutes != null)
                    hash = hash * 59 + this.TtlMinutes.GetHashCode();
                
                return hash;
            }
        }
    }

}
