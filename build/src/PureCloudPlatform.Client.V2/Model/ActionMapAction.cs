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
            Webchat,
            
            /// <summary>
            /// Enum Webmessagingoffer for "webMessagingOffer"
            /// </summary>
            [EnumMember(Value = "webMessagingOffer")]
            Webmessagingoffer,
            
            /// <summary>
            /// Enum Contentoffer for "contentOffer"
            /// </summary>
            [EnumMember(Value = "contentOffer")]
            Contentoffer,
            
            /// <summary>
            /// Enum Integrationaction for "integrationAction"
            /// </summary>
            [EnumMember(Value = "integrationAction")]
            Integrationaction,
            
            /// <summary>
            /// Enum Architectflow for "architectFlow"
            /// </summary>
            [EnumMember(Value = "architectFlow")]
            Architectflow,
            
            /// <summary>
            /// Enum Openaction for "openAction"
            /// </summary>
            [EnumMember(Value = "openAction")]
            Openaction
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
        /// <param name="ActionTemplate">Action template associated with the action map..</param>
        /// <param name="MediaType">Media type of action..</param>
        /// <param name="ActionTargetId">Action target ID..</param>
        /// <param name="IsPacingEnabled">Whether this action should be throttled..</param>
        /// <param name="Props">Additional properties..</param>
        /// <param name="ArchitectFlowFields">Architect Flow Id and input contract..</param>
        /// <param name="WebMessagingOfferFields">Admin-configurable fields of a web messaging offer action..</param>
        /// <param name="OpenActionFields">Admin-configurable fields of an open action..</param>
        public ActionMapAction(ActionMapActionTemplate ActionTemplate = null, MediaTypeEnum? MediaType = null, string ActionTargetId = null, bool? IsPacingEnabled = null, ActionProperties Props = null, ArchitectFlowFields ArchitectFlowFields = null, WebMessagingOfferFields WebMessagingOfferFields = null, OpenActionFields OpenActionFields = null)
        {
            this.ActionTemplate = ActionTemplate;
            this.MediaType = MediaType;
            this.ActionTargetId = ActionTargetId;
            this.IsPacingEnabled = IsPacingEnabled;
            this.Props = Props;
            this.ArchitectFlowFields = ArchitectFlowFields;
            this.WebMessagingOfferFields = WebMessagingOfferFields;
            this.OpenActionFields = OpenActionFields;
            
        }
        


        /// <summary>
        /// Action template associated with the action map.
        /// </summary>
        /// <value>Action template associated with the action map.</value>
        [DataMember(Name="actionTemplate", EmitDefaultValue=false)]
        public ActionMapActionTemplate ActionTemplate { get; set; }





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
        /// Architect Flow Id and input contract.
        /// </summary>
        /// <value>Architect Flow Id and input contract.</value>
        [DataMember(Name="architectFlowFields", EmitDefaultValue=false)]
        public ArchitectFlowFields ArchitectFlowFields { get; set; }



        /// <summary>
        /// Admin-configurable fields of a web messaging offer action.
        /// </summary>
        /// <value>Admin-configurable fields of a web messaging offer action.</value>
        [DataMember(Name="webMessagingOfferFields", EmitDefaultValue=false)]
        public WebMessagingOfferFields WebMessagingOfferFields { get; set; }



        /// <summary>
        /// Admin-configurable fields of an open action.
        /// </summary>
        /// <value>Admin-configurable fields of an open action.</value>
        [DataMember(Name="openActionFields", EmitDefaultValue=false)]
        public OpenActionFields OpenActionFields { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionMapAction {\n");

            sb.Append("  ActionTemplate: ").Append(ActionTemplate).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ActionTargetId: ").Append(ActionTargetId).Append("\n");
            sb.Append("  IsPacingEnabled: ").Append(IsPacingEnabled).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("  ArchitectFlowFields: ").Append(ArchitectFlowFields).Append("\n");
            sb.Append("  WebMessagingOfferFields: ").Append(WebMessagingOfferFields).Append("\n");
            sb.Append("  OpenActionFields: ").Append(OpenActionFields).Append("\n");
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
                    this.ActionTemplate == other.ActionTemplate ||
                    this.ActionTemplate != null &&
                    this.ActionTemplate.Equals(other.ActionTemplate)
                ) &&
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
                ) &&
                (
                    this.ArchitectFlowFields == other.ArchitectFlowFields ||
                    this.ArchitectFlowFields != null &&
                    this.ArchitectFlowFields.Equals(other.ArchitectFlowFields)
                ) &&
                (
                    this.WebMessagingOfferFields == other.WebMessagingOfferFields ||
                    this.WebMessagingOfferFields != null &&
                    this.WebMessagingOfferFields.Equals(other.WebMessagingOfferFields)
                ) &&
                (
                    this.OpenActionFields == other.OpenActionFields ||
                    this.OpenActionFields != null &&
                    this.OpenActionFields.Equals(other.OpenActionFields)
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
                if (this.ActionTemplate != null)
                    hash = hash * 59 + this.ActionTemplate.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.ActionTargetId != null)
                    hash = hash * 59 + this.ActionTargetId.GetHashCode();

                if (this.IsPacingEnabled != null)
                    hash = hash * 59 + this.IsPacingEnabled.GetHashCode();

                if (this.Props != null)
                    hash = hash * 59 + this.Props.GetHashCode();

                if (this.ArchitectFlowFields != null)
                    hash = hash * 59 + this.ArchitectFlowFields.GetHashCode();

                if (this.WebMessagingOfferFields != null)
                    hash = hash * 59 + this.WebMessagingOfferFields.GetHashCode();

                if (this.OpenActionFields != null)
                    hash = hash * 59 + this.OpenActionFields.GetHashCode();

                return hash;
            }
        }
    }

}
