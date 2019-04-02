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
    /// ActionMapAction
    /// </summary>
    [DataContract]
    public partial class ActionMapAction :  IEquatable<ActionMapAction>
    {
        
        
        /// <summary>
        /// Media type of action.
        /// </summary>
        /// <value>Media type of action.</value>
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
            /// Enum Webchat for "webchat"
            /// </summary>
            [EnumMember(Value = "webchat")]
            Webchat
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Media type of action.
        /// </summary>
        /// <value>Media type of action.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionMapAction() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapAction" /> class.
        /// </summary>
        /// <param name="MediaType">Media type of action. (required).</param>
        /// <param name="ActionTargetId">Action target ID..</param>
        /// <param name="IsPacingEnabled">Whether this action should be throttled..</param>
        /// <param name="Props">Additional properties..</param>
        public ActionMapAction(MediaTypeEnum? MediaType = null, string ActionTargetId = null, bool? IsPacingEnabled = null, ActionProperties Props = null)
        {
            this.MediaType = MediaType;
            this.ActionTargetId = ActionTargetId;
            this.IsPacingEnabled = IsPacingEnabled;
            this.Props = Props;
            
        }
        
        
        
        
        
        /// <summary>
        /// Action target ID.
        /// </summary>
        /// <value>Action target ID.</value>
        [DataMember(Name="actionTargetId", EmitDefaultValue=false)]
        public string ActionTargetId { get; set; }
        
        
        
        /// <summary>
        /// Whether this action should be throttled.
        /// </summary>
        /// <value>Whether this action should be throttled.</value>
        [DataMember(Name="isPacingEnabled", EmitDefaultValue=false)]
        public bool? IsPacingEnabled { get; set; }
        
        
        
        /// <summary>
        /// Additional properties.
        /// </summary>
        /// <value>Additional properties.</value>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public ActionProperties Props { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionMapAction {\n");
            
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ActionTargetId: ").Append(ActionTargetId).Append("\n");
            sb.Append("  IsPacingEnabled: ").Append(IsPacingEnabled).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
            return this.Equals(obj as ActionMapAction);
        }

        /// <summary>
        /// Returns true if ActionMapAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionMapAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionMapAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.ActionTargetId == other.ActionTargetId ||
                    this.ActionTargetId != null &&
                    this.ActionTargetId.Equals(other.ActionTargetId)
                ) &&
                (
                    this.IsPacingEnabled == other.IsPacingEnabled ||
                    this.IsPacingEnabled != null &&
                    this.IsPacingEnabled.Equals(other.IsPacingEnabled)
                ) &&
                (
                    this.Props == other.Props ||
                    this.Props != null &&
                    this.Props.Equals(other.Props)
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
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.ActionTargetId != null)
                    hash = hash * 59 + this.ActionTargetId.GetHashCode();
                
                if (this.IsPacingEnabled != null)
                    hash = hash * 59 + this.IsPacingEnabled.GetHashCode();
                
                if (this.Props != null)
                    hash = hash * 59 + this.Props.GetHashCode();
                
                return hash;
            }
        }
    }

}
