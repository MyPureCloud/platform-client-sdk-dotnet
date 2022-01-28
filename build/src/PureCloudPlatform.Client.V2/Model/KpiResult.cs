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
    /// KpiResult
    /// </summary>
    [DataContract]
    public partial class KpiResult :  IEquatable<KpiResult>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Media type used for the KPI
        /// </summary>
        /// <value>Media type used for the KPI</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Media type used for the KPI
        /// </summary>
        /// <value>Media type used for the KPI</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KpiResult" /> class.
        /// </summary>
        public KpiResult()
        {
            
        }
        
        
        
        /// <summary>
        /// Absolute metric (in which the KPI is based) total for the interactions handled by predictive routing (GPR was on)
        /// </summary>
        /// <value>Absolute metric (in which the KPI is based) total for the interactions handled by predictive routing (GPR was on)</value>
        [DataMember(Name="kpiTotalOn", EmitDefaultValue=false)]
        public long? KpiTotalOn { get; private set; }
        
        
        
        /// <summary>
        /// Absolute metric (in which the KPI is based) total for the interactions not routed by predictive routing (GPR was off)
        /// </summary>
        /// <value>Absolute metric (in which the KPI is based) total for the interactions not routed by predictive routing (GPR was off)</value>
        [DataMember(Name="kpiTotalOff", EmitDefaultValue=false)]
        public long? KpiTotalOff { get; private set; }
        
        
        
        /// <summary>
        /// Total interactions handled by predictive routing (GPR was on)
        /// </summary>
        /// <value>Total interactions handled by predictive routing (GPR was on)</value>
        [DataMember(Name="interactionCountOn", EmitDefaultValue=false)]
        public long? InteractionCountOn { get; private set; }
        
        
        
        /// <summary>
        /// Total interactions not routed by predictive routing (GPR was off)
        /// </summary>
        /// <value>Total interactions not routed by predictive routing (GPR was off)</value>
        [DataMember(Name="interactionCountOff", EmitDefaultValue=false)]
        public long? InteractionCountOff { get; private set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KpiResult {\n");
            
            sb.Append("  KpiTotalOn: ").Append(KpiTotalOn).Append("\n");
            sb.Append("  KpiTotalOff: ").Append(KpiTotalOff).Append("\n");
            sb.Append("  InteractionCountOn: ").Append(InteractionCountOn).Append("\n");
            sb.Append("  InteractionCountOff: ").Append(InteractionCountOff).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
            return this.Equals(obj as KpiResult);
        }

        /// <summary>
        /// Returns true if KpiResult instances are equal
        /// </summary>
        /// <param name="other">Instance of KpiResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpiResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.KpiTotalOn == other.KpiTotalOn ||
                    this.KpiTotalOn != null &&
                    this.KpiTotalOn.Equals(other.KpiTotalOn)
                ) &&
                (
                    this.KpiTotalOff == other.KpiTotalOff ||
                    this.KpiTotalOff != null &&
                    this.KpiTotalOff.Equals(other.KpiTotalOff)
                ) &&
                (
                    this.InteractionCountOn == other.InteractionCountOn ||
                    this.InteractionCountOn != null &&
                    this.InteractionCountOn.Equals(other.InteractionCountOn)
                ) &&
                (
                    this.InteractionCountOff == other.InteractionCountOff ||
                    this.InteractionCountOff != null &&
                    this.InteractionCountOff.Equals(other.InteractionCountOff)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                
                if (this.KpiTotalOn != null)
                    hash = hash * 59 + this.KpiTotalOn.GetHashCode();
                
                if (this.KpiTotalOff != null)
                    hash = hash * 59 + this.KpiTotalOff.GetHashCode();
                
                if (this.InteractionCountOn != null)
                    hash = hash * 59 + this.InteractionCountOn.GetHashCode();
                
                if (this.InteractionCountOff != null)
                    hash = hash * 59 + this.InteractionCountOff.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                return hash;
            }
        }
    }

}
