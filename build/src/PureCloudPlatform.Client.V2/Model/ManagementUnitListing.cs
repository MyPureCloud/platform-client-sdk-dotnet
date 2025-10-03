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
    /// ManagementUnitListing
    /// </summary>
    [DataContract]
    public partial class ManagementUnitListing :  IEquatable<ManagementUnitListing>, IPagedResource<ManagementUnit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnitListing" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="PageSize">Deprecated, paging is not supported.</param>
        /// <param name="PageNumber">Deprecated, paging is not supported.</param>
        /// <param name="Total">Deprecated, paging is not supported.</param>
        /// <param name="FirstUri">Deprecated, paging is not supported.</param>
        /// <param name="LastUri">Deprecated, paging is not supported.</param>
        /// <param name="PageCount">Deprecated, paging is not supported.</param>
        /// <param name="PreviousUri">Deprecated, paging is not supported.</param>
        /// <param name="NextUri">Deprecated, paging is not supported.</param>
        /// <param name="SelfUri">SelfUri.</param>
        public ManagementUnitListing(List<ManagementUnit> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, string FirstUri = null, string LastUri = null, int? PageCount = null, string PreviousUri = null, string NextUri = null, string SelfUri = null)
        {
            this.Entities = Entities;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.Total = Total;
            this.FirstUri = FirstUri;
            this.LastUri = LastUri;
            this.PageCount = PageCount;
            this.PreviousUri = PreviousUri;
            this.NextUri = NextUri;
            this.SelfUri = SelfUri;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<ManagementUnit> Entities { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="firstUri", EmitDefaultValue=false)]
        public string FirstUri { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="lastUri", EmitDefaultValue=false)]
        public string LastUri { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }



        /// <summary>
        /// Deprecated, paging is not supported
        /// </summary>
        /// <value>Deprecated, paging is not supported</value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagementUnitListing {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  FirstUri: ").Append(FirstUri).Append("\n");
            sb.Append("  LastUri: ").Append(LastUri).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
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
            return this.Equals(obj as ManagementUnitListing);
        }

        /// <summary>
        /// Returns true if ManagementUnitListing instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagementUnitListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagementUnitListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) &&
                (
                    this.FirstUri == other.FirstUri ||
                    this.FirstUri != null &&
                    this.FirstUri.Equals(other.FirstUri)
                ) &&
                (
                    this.LastUri == other.LastUri ||
                    this.LastUri != null &&
                    this.LastUri.Equals(other.LastUri)
                ) &&
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) &&
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) &&
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();

                if (this.FirstUri != null)
                    hash = hash * 59 + this.FirstUri.GetHashCode();

                if (this.LastUri != null)
                    hash = hash * 59 + this.LastUri.GetHashCode();

                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();

                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();

                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
