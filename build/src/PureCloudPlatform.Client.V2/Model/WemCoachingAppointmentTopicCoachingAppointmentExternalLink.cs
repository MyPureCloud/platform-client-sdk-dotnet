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
    /// WemCoachingAppointmentTopicCoachingAppointmentExternalLink
    /// </summary>
    [DataContract]
    public partial class WemCoachingAppointmentTopicCoachingAppointmentExternalLink :  IEquatable<WemCoachingAppointmentTopicCoachingAppointmentExternalLink>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Add for "Add"
            /// </summary>
            [EnumMember(Value = "Add")]
            Add,
            
            /// <summary>
            /// Enum Remove for "Remove"
            /// </summary>
            [EnumMember(Value = "Remove")]
            Remove,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WemCoachingAppointmentTopicCoachingAppointmentExternalLink" /> class.
        /// </summary>
        /// <param name="ExternalLink">ExternalLink.</param>
        /// <param name="Action">Action.</param>
        public WemCoachingAppointmentTopicCoachingAppointmentExternalLink(string ExternalLink = null, ActionEnum? Action = null)
        {
            this.ExternalLink = ExternalLink;
            this.Action = Action;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalLink
        /// </summary>
        [DataMember(Name="externalLink", EmitDefaultValue=false)]
        public string ExternalLink { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WemCoachingAppointmentTopicCoachingAppointmentExternalLink {\n");
            
            sb.Append("  ExternalLink: ").Append(ExternalLink).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as WemCoachingAppointmentTopicCoachingAppointmentExternalLink);
        }

        /// <summary>
        /// Returns true if WemCoachingAppointmentTopicCoachingAppointmentExternalLink instances are equal
        /// </summary>
        /// <param name="other">Instance of WemCoachingAppointmentTopicCoachingAppointmentExternalLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WemCoachingAppointmentTopicCoachingAppointmentExternalLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalLink == other.ExternalLink ||
                    this.ExternalLink != null &&
                    this.ExternalLink.Equals(other.ExternalLink)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                
                if (this.ExternalLink != null)
                    hash = hash * 59 + this.ExternalLink.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                return hash;
            }
        }
    }

}
