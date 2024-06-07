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
    /// Library
    /// </summary>
    [DataContract]
    public partial class Library :  IEquatable<Library>
    {
        /// <summary>
        /// This value is deprecated. Responses representing message templates may be added to any library.
        /// </summary>
        /// <value>This value is deprecated. Responses representing message templates may be added to any library.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResponseTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Messagingtemplate for "MessagingTemplate"
            /// </summary>
            [EnumMember(Value = "MessagingTemplate")]
            Messagingtemplate,
            
            /// <summary>
            /// Enum Campaignsmstemplate for "CampaignSmsTemplate"
            /// </summary>
            [EnumMember(Value = "CampaignSmsTemplate")]
            Campaignsmstemplate,
            
            /// <summary>
            /// Enum Campaignemailtemplate for "CampaignEmailTemplate"
            /// </summary>
            [EnumMember(Value = "CampaignEmailTemplate")]
            Campaignemailtemplate,
            
            /// <summary>
            /// Enum Footer for "Footer"
            /// </summary>
            [EnumMember(Value = "Footer")]
            Footer
        }
        /// <summary>
        /// This value is deprecated. Responses representing message templates may be added to any library.
        /// </summary>
        /// <value>This value is deprecated. Responses representing message templates may be added to any library.</value>
        [DataMember(Name="responseType", EmitDefaultValue=false)]
        public ResponseTypeEnum? ResponseType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Library" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Library() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Library" /> class.
        /// </summary>
        /// <param name="Name">The library name. (required).</param>
        /// <param name="Version">Current version for this resource..</param>
        /// <param name="ResponseType">This value is deprecated. Responses representing message templates may be added to any library..</param>
        public Library(string Name = null, int? Version = null, ResponseTypeEnum? ResponseType = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.ResponseType = ResponseType;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The library name.
        /// </summary>
        /// <value>The library name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Current version for this resource.
        /// </summary>
        /// <value>Current version for this resource.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// User that created the library.
        /// </summary>
        /// <value>User that created the library.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; private set; }



        /// <summary>
        /// The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }





        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Library {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Library);
        }

        /// <summary>
        /// Returns true if Library instances are equal
        /// </summary>
        /// <param name="other">Instance of Library to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Library other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ResponseType == other.ResponseType ||
                    this.ResponseType != null &&
                    this.ResponseType.Equals(other.ResponseType)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ResponseType != null)
                    hash = hash * 59 + this.ResponseType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
