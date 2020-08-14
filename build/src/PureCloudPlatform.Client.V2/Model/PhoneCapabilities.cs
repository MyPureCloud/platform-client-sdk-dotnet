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
    /// PhoneCapabilities
    /// </summary>
    [DataContract]
    public partial class PhoneCapabilities :  IEquatable<PhoneCapabilities>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaCodecs
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaCodecsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Audioopus for "audio/opus"
            /// </summary>
            [EnumMember(Value = "audio/opus")]
            Audioopus,
            
            /// <summary>
            /// Enum Audiopcmu for "audio/pcmu"
            /// </summary>
            [EnumMember(Value = "audio/pcmu")]
            Audiopcmu,
            
            /// <summary>
            /// Enum Audiopcma for "audio/pcma"
            /// </summary>
            [EnumMember(Value = "audio/pcma")]
            Audiopcma,
            
            /// <summary>
            /// Enum Audiog729 for "audio/g729"
            /// </summary>
            [EnumMember(Value = "audio/g729")]
            Audiog729,
            
            /// <summary>
            /// Enum Audiog722 for "audio/g722"
            /// </summary>
            [EnumMember(Value = "audio/g722")]
            Audiog722
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneCapabilities" /> class.
        /// </summary>
        /// <param name="Provisions">Provisions.</param>
        /// <param name="Registers">Registers.</param>
        /// <param name="DualRegisters">DualRegisters.</param>
        /// <param name="HardwareIdType">HardwareIdType.</param>
        /// <param name="AllowReboot">AllowReboot.</param>
        /// <param name="NoRebalance">NoRebalance.</param>
        /// <param name="NoCloudProvisioning">NoCloudProvisioning.</param>
        /// <param name="MediaCodecs">MediaCodecs.</param>
        /// <param name="Cdm">Cdm.</param>
        public PhoneCapabilities(bool? Provisions = null, bool? Registers = null, bool? DualRegisters = null, string HardwareIdType = null, bool? AllowReboot = null, bool? NoRebalance = null, bool? NoCloudProvisioning = null, List<MediaCodecsEnum> MediaCodecs = null, bool? Cdm = null)
        {
            this.Provisions = Provisions;
            this.Registers = Registers;
            this.DualRegisters = DualRegisters;
            this.HardwareIdType = HardwareIdType;
            this.AllowReboot = AllowReboot;
            this.NoRebalance = NoRebalance;
            this.NoCloudProvisioning = NoCloudProvisioning;
            this.MediaCodecs = MediaCodecs;
            this.Cdm = Cdm;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Provisions
        /// </summary>
        [DataMember(Name="provisions", EmitDefaultValue=false)]
        public bool? Provisions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Registers
        /// </summary>
        [DataMember(Name="registers", EmitDefaultValue=false)]
        public bool? Registers { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DualRegisters
        /// </summary>
        [DataMember(Name="dualRegisters", EmitDefaultValue=false)]
        public bool? DualRegisters { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets HardwareIdType
        /// </summary>
        [DataMember(Name="hardwareIdType", EmitDefaultValue=false)]
        public string HardwareIdType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AllowReboot
        /// </summary>
        [DataMember(Name="allowReboot", EmitDefaultValue=false)]
        public bool? AllowReboot { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NoRebalance
        /// </summary>
        [DataMember(Name="noRebalance", EmitDefaultValue=false)]
        public bool? NoRebalance { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NoCloudProvisioning
        /// </summary>
        [DataMember(Name="noCloudProvisioning", EmitDefaultValue=false)]
        public bool? NoCloudProvisioning { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MediaCodecs
        /// </summary>
        [DataMember(Name="mediaCodecs", EmitDefaultValue=false)]
        public List<MediaCodecsEnum> MediaCodecs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Cdm
        /// </summary>
        [DataMember(Name="cdm", EmitDefaultValue=false)]
        public bool? Cdm { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneCapabilities {\n");
            
            sb.Append("  Provisions: ").Append(Provisions).Append("\n");
            sb.Append("  Registers: ").Append(Registers).Append("\n");
            sb.Append("  DualRegisters: ").Append(DualRegisters).Append("\n");
            sb.Append("  HardwareIdType: ").Append(HardwareIdType).Append("\n");
            sb.Append("  AllowReboot: ").Append(AllowReboot).Append("\n");
            sb.Append("  NoRebalance: ").Append(NoRebalance).Append("\n");
            sb.Append("  NoCloudProvisioning: ").Append(NoCloudProvisioning).Append("\n");
            sb.Append("  MediaCodecs: ").Append(MediaCodecs).Append("\n");
            sb.Append("  Cdm: ").Append(Cdm).Append("\n");
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
            return this.Equals(obj as PhoneCapabilities);
        }

        /// <summary>
        /// Returns true if PhoneCapabilities instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneCapabilities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Provisions == other.Provisions ||
                    this.Provisions != null &&
                    this.Provisions.Equals(other.Provisions)
                ) &&
                (
                    this.Registers == other.Registers ||
                    this.Registers != null &&
                    this.Registers.Equals(other.Registers)
                ) &&
                (
                    this.DualRegisters == other.DualRegisters ||
                    this.DualRegisters != null &&
                    this.DualRegisters.Equals(other.DualRegisters)
                ) &&
                (
                    this.HardwareIdType == other.HardwareIdType ||
                    this.HardwareIdType != null &&
                    this.HardwareIdType.Equals(other.HardwareIdType)
                ) &&
                (
                    this.AllowReboot == other.AllowReboot ||
                    this.AllowReboot != null &&
                    this.AllowReboot.Equals(other.AllowReboot)
                ) &&
                (
                    this.NoRebalance == other.NoRebalance ||
                    this.NoRebalance != null &&
                    this.NoRebalance.Equals(other.NoRebalance)
                ) &&
                (
                    this.NoCloudProvisioning == other.NoCloudProvisioning ||
                    this.NoCloudProvisioning != null &&
                    this.NoCloudProvisioning.Equals(other.NoCloudProvisioning)
                ) &&
                (
                    this.MediaCodecs == other.MediaCodecs ||
                    this.MediaCodecs != null &&
                    this.MediaCodecs.SequenceEqual(other.MediaCodecs)
                ) &&
                (
                    this.Cdm == other.Cdm ||
                    this.Cdm != null &&
                    this.Cdm.Equals(other.Cdm)
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
                
                if (this.Provisions != null)
                    hash = hash * 59 + this.Provisions.GetHashCode();
                
                if (this.Registers != null)
                    hash = hash * 59 + this.Registers.GetHashCode();
                
                if (this.DualRegisters != null)
                    hash = hash * 59 + this.DualRegisters.GetHashCode();
                
                if (this.HardwareIdType != null)
                    hash = hash * 59 + this.HardwareIdType.GetHashCode();
                
                if (this.AllowReboot != null)
                    hash = hash * 59 + this.AllowReboot.GetHashCode();
                
                if (this.NoRebalance != null)
                    hash = hash * 59 + this.NoRebalance.GetHashCode();
                
                if (this.NoCloudProvisioning != null)
                    hash = hash * 59 + this.NoCloudProvisioning.GetHashCode();
                
                if (this.MediaCodecs != null)
                    hash = hash * 59 + this.MediaCodecs.GetHashCode();
                
                if (this.Cdm != null)
                    hash = hash * 59 + this.Cdm.GetHashCode();
                
                return hash;
            }
        }
    }

}
