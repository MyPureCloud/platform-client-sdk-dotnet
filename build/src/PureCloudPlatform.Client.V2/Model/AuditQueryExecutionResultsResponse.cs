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
    /// AuditQueryExecutionResultsResponse
    /// </summary>
    [DataContract]
    public partial class AuditQueryExecutionResultsResponse :  IEquatable<AuditQueryExecutionResultsResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditQueryExecutionResultsResponse" /> class.
        /// </summary>
        /// <param name="Id">Id of the audit query execution request..</param>
        /// <param name="PageSize">Number of results in a page..</param>
        /// <param name="Cursor">Optional cursor to indicate where to resume the results..</param>
        /// <param name="Entities">List of audit messages..</param>
        public AuditQueryExecutionResultsResponse(string Id = null, int? PageSize = null, string Cursor = null, List<AuditLogMessage> Entities = null)
        {
            this.Id = Id;
            this.PageSize = PageSize;
            this.Cursor = Cursor;
            this.Entities = Entities;
            
        }
        
        
        
        /// <summary>
        /// Id of the audit query execution request.
        /// </summary>
        /// <value>Id of the audit query execution request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Number of results in a page.
        /// </summary>
        /// <value>Number of results in a page.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// Optional cursor to indicate where to resume the results.
        /// </summary>
        /// <value>Optional cursor to indicate where to resume the results.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        
        
        
        /// <summary>
        /// List of audit messages.
        /// </summary>
        /// <value>List of audit messages.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<AuditLogMessage> Entities { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditQueryExecutionResultsResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as AuditQueryExecutionResultsResponse);
        }

        /// <summary>
        /// Returns true if AuditQueryExecutionResultsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditQueryExecutionResultsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditQueryExecutionResultsResponse other)
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
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                
                return hash;
            }
        }
    }

}
