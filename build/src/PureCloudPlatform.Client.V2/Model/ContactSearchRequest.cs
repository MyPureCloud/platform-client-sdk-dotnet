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
    /// ContactSearchRequest
    /// </summary>
    [DataContract]
    public partial class ContactSearchRequest :  IEquatable<ContactSearchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSearchRequest" /> class.
        /// </summary>
        /// <param name="PageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000).</param>
        /// <param name="PageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000).</param>
        /// <param name="DivisionIds">Which divisions to search, up to 50.</param>
        /// <param name="Expand">Which fields, if any, to expand.</param>
        /// <param name="Operation">Search operation to execute, currently supports {@code simpleSearch} only..</param>
        public ContactSearchRequest(int? PageNumber = null, int? PageSize = null, List<string> DivisionIds = null, List<string> Expand = null, ContactSearchOperation Operation = null)
        {
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.DivisionIds = DivisionIds;
            this.Expand = Expand;
            this.Operation = Operation;
            
        }
        


        /// <summary>
        /// Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000)
        /// </summary>
        /// <value>Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000)</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000)
        /// </summary>
        /// <value>Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000)</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Which divisions to search, up to 50
        /// </summary>
        /// <value>Which divisions to search, up to 50</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }



        /// <summary>
        /// Which fields, if any, to expand
        /// </summary>
        /// <value>Which fields, if any, to expand</value>
        [DataMember(Name="expand", EmitDefaultValue=false)]
        public List<string> Expand { get; set; }



        /// <summary>
        /// Search operation to execute, currently supports {@code simpleSearch} only.
        /// </summary>
        /// <value>Search operation to execute, currently supports {@code simpleSearch} only.</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public ContactSearchOperation Operation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactSearchRequest {\n");

            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
            return this.Equals(obj as ContactSearchRequest);
        }

        /// <summary>
        /// Returns true if ContactSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.Expand == other.Expand ||
                    this.Expand != null &&
                    this.Expand.SequenceEqual(other.Expand)
                ) &&
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
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
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();

                if (this.Expand != null)
                    hash = hash * 59 + this.Expand.GetHashCode();

                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();

                return hash;
            }
        }
    }

}
