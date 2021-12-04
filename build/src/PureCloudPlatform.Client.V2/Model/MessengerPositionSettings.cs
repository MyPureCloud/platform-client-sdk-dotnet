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
    /// Position settings for messenger
    /// </summary>
    [DataContract]
    public partial class MessengerPositionSettings :  IEquatable<MessengerPositionSettings>
    {
        
        
        /// <summary>
        /// The alignment for messenger position
        /// </summary>
        /// <value>The alignment for messenger position</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlignmentEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            [EnumMember(Value = "Left")]
            Left,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            [EnumMember(Value = "Right")]
            Right
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The alignment for messenger position
        /// </summary>
        /// <value>The alignment for messenger position</value>
        [DataMember(Name="alignment", EmitDefaultValue=false)]
        public AlignmentEnum? Alignment { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessengerPositionSettings" /> class.
        /// </summary>
        /// <param name="Alignment">The alignment for messenger position.</param>
        /// <param name="SideSpace">The sidespace value for messenger position.</param>
        /// <param name="BottomSpace">The bottomspace value for messenger position.</param>
        public MessengerPositionSettings(AlignmentEnum? Alignment = null, int? SideSpace = null, int? BottomSpace = null)
        {
            this.Alignment = Alignment;
            this.SideSpace = SideSpace;
            this.BottomSpace = BottomSpace;
            
        }
        
        
        
        
        
        /// <summary>
        /// The sidespace value for messenger position
        /// </summary>
        /// <value>The sidespace value for messenger position</value>
        [DataMember(Name="sideSpace", EmitDefaultValue=false)]
        public int? SideSpace { get; set; }
        
        
        
        /// <summary>
        /// The bottomspace value for messenger position
        /// </summary>
        /// <value>The bottomspace value for messenger position</value>
        [DataMember(Name="bottomSpace", EmitDefaultValue=false)]
        public int? BottomSpace { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessengerPositionSettings {\n");
            
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  SideSpace: ").Append(SideSpace).Append("\n");
            sb.Append("  BottomSpace: ").Append(BottomSpace).Append("\n");
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
            return this.Equals(obj as MessengerPositionSettings);
        }

        /// <summary>
        /// Returns true if MessengerPositionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of MessengerPositionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessengerPositionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Alignment == other.Alignment ||
                    this.Alignment != null &&
                    this.Alignment.Equals(other.Alignment)
                ) &&
                (
                    this.SideSpace == other.SideSpace ||
                    this.SideSpace != null &&
                    this.SideSpace.Equals(other.SideSpace)
                ) &&
                (
                    this.BottomSpace == other.BottomSpace ||
                    this.BottomSpace != null &&
                    this.BottomSpace.Equals(other.BottomSpace)
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
                
                if (this.Alignment != null)
                    hash = hash * 59 + this.Alignment.GetHashCode();
                
                if (this.SideSpace != null)
                    hash = hash * 59 + this.SideSpace.GetHashCode();
                
                if (this.BottomSpace != null)
                    hash = hash * 59 + this.BottomSpace.GetHashCode();
                
                return hash;
            }
        }
    }

}
