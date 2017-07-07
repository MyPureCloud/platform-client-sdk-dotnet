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
    /// HistoryListing
    /// </summary>
    [DataContract]
    public partial class HistoryListing :  IEquatable<HistoryListing>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryListing" /> class.
        /// </summary>
        
        
        /// <param name="Entities">Entities.</param>
        
        
        
        /// <param name="PageSize">PageSize.</param>
        
        
        
        /// <param name="PageNumber">PageNumber.</param>
        
        
        
        /// <param name="Total">Total.</param>
        
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="Description">Description.</param>
        
        
        
        /// <param name="System">System.</param>
        
        
        
        /// <param name="PageCount">PageCount.</param>
        
        
        public HistoryListing(List<HistoryEntry> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, string Id = null, string Name = null, string Description = null, bool? System = null, int? PageCount = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Entities = Entities;
            
            
            
            
            
            
            
            
this.PageSize = PageSize;
            
            
            
            
            
            
            
            
this.PageNumber = PageNumber;
            
            
            
            
            
            
            
            
this.Total = Total;
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Description = Description;
            
            
            
            
            
            
            
            
this.System = System;
            
            
            
            
            
            
            
            
this.PageCount = PageCount;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<HistoryEntry> Entities { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public bool? System { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryListing {\n");
            
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            
            sb.Append("  Total: ").Append(Total).Append("\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            
            sb.Append("  System: ").Append(System).Append("\n");
            
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            
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
            return this.Equals(obj as HistoryListing);
        }

        /// <summary>
        /// Returns true if HistoryListing instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoryListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryListing other)
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
                    this.System == other.System ||
                    this.System != null &&
                    this.System.Equals(other.System)
                ) &&
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.System != null)
                    hash = hash * 59 + this.System.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                
                return hash;
            }
        }
    }

}
