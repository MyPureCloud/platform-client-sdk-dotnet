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
    /// EdgeLogsJobUploadRequest
    /// </summary>
    [DataContract]
    public partial class EdgeLogsJobUploadRequest :  IEquatable<EdgeLogsJobUploadRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeLogsJobUploadRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobUploadRequest" /> class.
        /// </summary>
        
        
        /// <param name="FileIds">A list of file ids to upload. (required).</param>
        
        
        public EdgeLogsJobUploadRequest(List<string> FileIds = null)
        {
            
            
            
            // to ensure "FileIds" is required (not null)
            if (FileIds == null)
            {
                throw new InvalidDataException("FileIds is a required property for EdgeLogsJobUploadRequest and cannot be null");
            }
            else
            {
                this.FileIds = FileIds;
            }
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// A list of file ids to upload.
        /// </summary>
        /// <value>A list of file ids to upload.</value>
        [DataMember(Name="fileIds", EmitDefaultValue=false)]
        public List<string> FileIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeLogsJobUploadRequest {\n");
            
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            
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
            return this.Equals(obj as EdgeLogsJobUploadRequest);
        }

        /// <summary>
        /// Returns true if EdgeLogsJobUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeLogsJobUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeLogsJobUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileIds == other.FileIds ||
                    this.FileIds != null &&
                    this.FileIds.SequenceEqual(other.FileIds)
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
                
                if (this.FileIds != null)
                    hash = hash * 59 + this.FileIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
