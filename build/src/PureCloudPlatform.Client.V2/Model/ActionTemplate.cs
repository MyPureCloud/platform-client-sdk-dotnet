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
    /// ActionTemplate
    /// </summary>
    [DataContract]
    public partial class ActionTemplate :  IEquatable<ActionTemplate>
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
            Architectflow
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
        /// Initializes a new instance of the <see cref="ActionTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionTemplate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTemplate" /> class.
        /// </summary>
        /// <param name="Name">Name of the action template. (required).</param>
        /// <param name="Description">Description of the action template&#39;s functionality..</param>
        /// <param name="MediaType">Media type of action described by the action template. (required).</param>
        /// <param name="State">Whether the action template is currently active, inactive or deleted. (required).</param>
        /// <param name="ContentOffer">Properties used to configure an action of type content offer.</param>
        public ActionTemplate(string Name = null, string Description = null, MediaTypeEnum? MediaType = null, StateEnum? State = null, ContentOffer ContentOffer = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.MediaType = MediaType;
            this.State = State;
            this.ContentOffer = ContentOffer;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Name of the action template.
        /// </summary>
        /// <value>Name of the action template.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Description of the action template&#39;s functionality.
        /// </summary>
        /// <value>Description of the action template&#39;s functionality.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Properties used to configure an action of type content offer
        /// </summary>
        /// <value>Properties used to configure an action of type content offer</value>
        [DataMember(Name="contentOffer", EmitDefaultValue=false)]
        public ContentOffer ContentOffer { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Date when action template was created in ISO-8601 format.
        /// </summary>
        /// <value>Date when action template was created in ISO-8601 format.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        
        
        
        /// <summary>
        /// Date when action template was last modified in ISO-8601 format.
        /// </summary>
        /// <value>Date when action template was last modified in ISO-8601 format.</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionTemplate {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ContentOffer: ").Append(ContentOffer).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as ActionTemplate);
        }

        /// <summary>
        /// Returns true if ActionTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
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
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
