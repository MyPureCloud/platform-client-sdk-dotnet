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
    /// AgenticVirtualAgent
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgent :  IEquatable<AgenticVirtualAgent>
    {
        /// <summary>
        /// The status of the virtual agent.
        /// </summary>
        /// <value>The status of the virtual agent.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published
        }
        /// <summary>
        /// The status of the virtual agent.
        /// </summary>
        /// <value>The status of the virtual agent.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgent" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ImageUri">The URI of the image for the virtual agent..</param>
        public AgenticVirtualAgent(string Name = null, string ImageUri = null)
        {
            this.Name = Name;
            this.ImageUri = ImageUri;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The date and time the virtual agent was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the virtual agent was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The date and time the virtual agent was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the virtual agent was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }





        /// <summary>
        /// The latest saved version of the virtual agent.
        /// </summary>
        /// <value>The latest saved version of the virtual agent.</value>
        [DataMember(Name="latestSavedVersion", EmitDefaultValue=false)]
        public AgenticVersionAddressableEntity LatestSavedVersion { get; private set; }



        /// <summary>
        /// The latest production ready version of the virtual agent.
        /// </summary>
        /// <value>The latest production ready version of the virtual agent.</value>
        [DataMember(Name="latestProductionReadyVersion", EmitDefaultValue=false)]
        public AgenticVersionAddressableEntity LatestProductionReadyVersion { get; private set; }



        /// <summary>
        /// The URI of the image for the virtual agent.
        /// </summary>
        /// <value>The URI of the image for the virtual agent.</value>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }



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
            sb.Append("class AgenticVirtualAgent {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LatestSavedVersion: ").Append(LatestSavedVersion).Append("\n");
            sb.Append("  LatestProductionReadyVersion: ").Append(LatestProductionReadyVersion).Append("\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgent);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgent other)
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.LatestSavedVersion == other.LatestSavedVersion ||
                    this.LatestSavedVersion != null &&
                    this.LatestSavedVersion.Equals(other.LatestSavedVersion)
                ) &&
                (
                    this.LatestProductionReadyVersion == other.LatestProductionReadyVersion ||
                    this.LatestProductionReadyVersion != null &&
                    this.LatestProductionReadyVersion.Equals(other.LatestProductionReadyVersion)
                ) &&
                (
                    this.ImageUri == other.ImageUri ||
                    this.ImageUri != null &&
                    this.ImageUri.Equals(other.ImageUri)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.LatestSavedVersion != null)
                    hash = hash * 59 + this.LatestSavedVersion.GetHashCode();

                if (this.LatestProductionReadyVersion != null)
                    hash = hash * 59 + this.LatestProductionReadyVersion.GetHashCode();

                if (this.ImageUri != null)
                    hash = hash * 59 + this.ImageUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
