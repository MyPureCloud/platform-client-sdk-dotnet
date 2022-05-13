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
    /// PatchActionTemplate
    /// </summary>
    [DataContract]
    public partial class PatchActionTemplate :  IEquatable<PatchActionTemplate>
    {
        /// <summary>
        /// Media type of action described by the action template.
        /// </summary>
        /// <value>Media type of action described by the action template.</value>
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
        /// Whether the action template is currently active, inactive or deleted.
        /// </summary>
        /// <value>Whether the action template is currently active, inactive or deleted.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }
        /// <summary>
        /// Media type of action described by the action template.
        /// </summary>
        /// <value>Media type of action described by the action template.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Whether the action template is currently active, inactive or deleted.
        /// </summary>
        /// <value>Whether the action template is currently active, inactive or deleted.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchActionTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchActionTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchActionTemplate" /> class.
        /// </summary>
        /// <param name="Name">Name of the action template. (required).</param>
        /// <param name="Description">Description of the action template's functionality..</param>
        /// <param name="MediaType">Media type of action described by the action template..</param>
        /// <param name="State">Whether the action template is currently active, inactive or deleted..</param>
        /// <param name="ContentOffer">Properties used to configure an action of type content offer.</param>
        public PatchActionTemplate(string Name = null, string Description = null, MediaTypeEnum? MediaType = null, StateEnum? State = null, PatchContentOffer ContentOffer = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.MediaType = MediaType;
            this.State = State;
            this.ContentOffer = ContentOffer;
            
        }
        


        /// <summary>
        /// Name of the action template.
        /// </summary>
        /// <value>Name of the action template.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description of the action template's functionality.
        /// </summary>
        /// <value>Description of the action template's functionality.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }







        /// <summary>
        /// Properties used to configure an action of type content offer
        /// </summary>
        /// <value>Properties used to configure an action of type content offer</value>
        [DataMember(Name="contentOffer", EmitDefaultValue=false)]
        public PatchContentOffer ContentOffer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchActionTemplate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ContentOffer: ").Append(ContentOffer).Append("\n");
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
            return this.Equals(obj as PatchActionTemplate);
        }

        /// <summary>
        /// Returns true if PatchActionTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchActionTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchActionTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ContentOffer == other.ContentOffer ||
                    this.ContentOffer != null &&
                    this.ContentOffer.Equals(other.ContentOffer)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.ContentOffer != null)
                    hash = hash * 59 + this.ContentOffer.GetHashCode();

                return hash;
            }
        }
    }

}
