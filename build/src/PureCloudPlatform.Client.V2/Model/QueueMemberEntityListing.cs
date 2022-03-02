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
    /// QueueMemberEntityListing
    /// </summary>
    [DataContract]
    public partial class QueueMemberEntityListing :  IEquatable<QueueMemberEntityListing>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMemberEntityListing" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="FirstUri">FirstUri.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="NextUri">NextUri.</param>
        /// <param name="PreviousUri">PreviousUri.</param>
        public QueueMemberEntityListing(List<QueueMember> Entities = null, int? PageNumber = null, int? PageSize = null, string FirstUri = null, string SelfUri = null, string NextUri = null, string PreviousUri = null)
        {
            this.Entities = Entities;
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.FirstUri = FirstUri;
            this.SelfUri = SelfUri;
            this.NextUri = NextUri;
            this.PreviousUri = PreviousUri;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<QueueMember> Entities { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FirstUri
        /// </summary>
        [DataMember(Name="firstUri", EmitDefaultValue=false)]
        public string FirstUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NextUri
        /// </summary>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PreviousUri
        /// </summary>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueMemberEntityListing {\n");
            
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  FirstUri: ").Append(FirstUri).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
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
            return this.Equals(obj as QueueMemberEntityListing);
        }

        /// <summary>
        /// Returns true if QueueMemberEntityListing instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueMemberEntityListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueMemberEntityListing other)
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
                    this.FirstUri == other.FirstUri ||
                    this.FirstUri != null &&
                    this.FirstUri.Equals(other.FirstUri)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) &&
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
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
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.FirstUri != null)
                    hash = hash * 59 + this.FirstUri.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();
                
                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
