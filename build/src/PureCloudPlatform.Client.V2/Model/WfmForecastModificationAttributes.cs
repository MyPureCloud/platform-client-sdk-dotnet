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
    /// WfmForecastModificationAttributes
    /// </summary>
    [DataContract]
    public partial class WfmForecastModificationAttributes :  IEquatable<WfmForecastModificationAttributes>
    {
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmForecastModificationAttributes" /> class.
        /// </summary>
        /// <param name="Queues">The queues to which to apply a modification.</param>
        /// <param name="MediaTypes">The media types to which to apply a modification.</param>
        /// <param name="Languages">The languages to which to apply a modification.</param>
        /// <param name="SkillSets">The skill sets to which to apply a modification.</param>
        public WfmForecastModificationAttributes(List<QueueReference> Queues = null, List<MediaTypesEnum> MediaTypes = null, List<LanguageReference> Languages = null, List<List<RoutingSkillReference>> SkillSets = null)
        {
            this.Queues = Queues;
            this.MediaTypes = MediaTypes;
            this.Languages = Languages;
            this.SkillSets = SkillSets;
            
        }
        
        
        
        /// <summary>
        /// The queues to which to apply a modification
        /// </summary>
        /// <value>The queues to which to apply a modification</value>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<QueueReference> Queues { get; set; }
        
        
        
        /// <summary>
        /// The media types to which to apply a modification
        /// </summary>
        /// <value>The media types to which to apply a modification</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }
        
        
        
        /// <summary>
        /// The languages to which to apply a modification
        /// </summary>
        /// <value>The languages to which to apply a modification</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageReference> Languages { get; set; }
        
        
        
        /// <summary>
        /// The skill sets to which to apply a modification
        /// </summary>
        /// <value>The skill sets to which to apply a modification</value>
        [DataMember(Name="skillSets", EmitDefaultValue=false)]
        public List<List<RoutingSkillReference>> SkillSets { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmForecastModificationAttributes {\n");
            
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  SkillSets: ").Append(SkillSets).Append("\n");
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
            return this.Equals(obj as WfmForecastModificationAttributes);
        }

        /// <summary>
        /// Returns true if WfmForecastModificationAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmForecastModificationAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmForecastModificationAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
                ) &&
                (
                    this.SkillSets == other.SkillSets ||
                    this.SkillSets != null &&
                    this.SkillSets.SequenceEqual(other.SkillSets)
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
                
                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();
                
                if (this.SkillSets != null)
                    hash = hash * 59 + this.SkillSets.GetHashCode();
                
                return hash;
            }
        }
    }

}
