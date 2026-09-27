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
    /// DomainEdgeSoftwareVersionDto
    /// </summary>
    [DataContract]
    public partial class DomainEdgeSoftwareVersionDto :  IEquatable<DomainEdgeSoftwareVersionDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainEdgeSoftwareVersionDto" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="EdgeVersion">EdgeVersion.</param>
        /// <param name="PublishDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EdgeUri">EdgeUri.</param>
        /// <param name="LatestRelease">LatestRelease.</param>
        /// <param name="Current">Current.</param>
        public DomainEdgeSoftwareVersionDto(string Name = null, string EdgeVersion = null, DateTime? PublishDate = null, string EdgeUri = null, bool? LatestRelease = null, bool? Current = null)
        {
            this.Name = Name;
            this.EdgeVersion = EdgeVersion;
            this.PublishDate = PublishDate;
            this.EdgeUri = EdgeUri;
            this.LatestRelease = LatestRelease;
            this.Current = Current;
            
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
        /// Gets or Sets EdgeVersion
        /// </summary>
        [DataMember(Name="edgeVersion", EmitDefaultValue=false)]
        public string EdgeVersion { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="publishDate", EmitDefaultValue=false)]
        public DateTime? PublishDate { get; set; }



        /// <summary>
        /// Gets or Sets EdgeUri
        /// </summary>
        [DataMember(Name="edgeUri", EmitDefaultValue=false)]
        public string EdgeUri { get; set; }



        /// <summary>
        /// Gets or Sets LatestRelease
        /// </summary>
        [DataMember(Name="latestRelease", EmitDefaultValue=false)]
        public bool? LatestRelease { get; set; }



        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public bool? Current { get; set; }



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
            sb.Append("class DomainEdgeSoftwareVersionDto {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EdgeVersion: ").Append(EdgeVersion).Append("\n");
            sb.Append("  PublishDate: ").Append(PublishDate).Append("\n");
            sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
            sb.Append("  LatestRelease: ").Append(LatestRelease).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
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
            return this.Equals(obj as DomainEdgeSoftwareVersionDto);
        }

        /// <summary>
        /// Returns true if DomainEdgeSoftwareVersionDto instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainEdgeSoftwareVersionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainEdgeSoftwareVersionDto other)
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
                    this.EdgeVersion == other.EdgeVersion ||
                    this.EdgeVersion != null &&
                    this.EdgeVersion.Equals(other.EdgeVersion)
                ) &&
                (
                    this.PublishDate == other.PublishDate ||
                    this.PublishDate != null &&
                    this.PublishDate.Equals(other.PublishDate)
                ) &&
                (
                    this.EdgeUri == other.EdgeUri ||
                    this.EdgeUri != null &&
                    this.EdgeUri.Equals(other.EdgeUri)
                ) &&
                (
                    this.LatestRelease == other.LatestRelease ||
                    this.LatestRelease != null &&
                    this.LatestRelease.Equals(other.LatestRelease)
                ) &&
                (
                    this.Current == other.Current ||
                    this.Current != null &&
                    this.Current.Equals(other.Current)
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

                if (this.EdgeVersion != null)
                    hash = hash * 59 + this.EdgeVersion.GetHashCode();

                if (this.PublishDate != null)
                    hash = hash * 59 + this.PublishDate.GetHashCode();

                if (this.EdgeUri != null)
                    hash = hash * 59 + this.EdgeUri.GetHashCode();

                if (this.LatestRelease != null)
                    hash = hash * 59 + this.LatestRelease.GetHashCode();

                if (this.Current != null)
                    hash = hash * 59 + this.Current.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
