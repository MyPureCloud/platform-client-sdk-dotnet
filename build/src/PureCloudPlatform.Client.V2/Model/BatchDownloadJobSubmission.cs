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
    /// BatchDownloadJobSubmission
    /// </summary>
    [DataContract]
    public partial class BatchDownloadJobSubmission :  IEquatable<BatchDownloadJobSubmission>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDownloadJobSubmission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchDownloadJobSubmission() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDownloadJobSubmission" /> class.
        /// </summary>
        
        
        /// <param name="BatchDownloadRequestList">List of up to 100 items requested (required).</param>
        
        
        public BatchDownloadJobSubmission(List<BatchDownloadRequest> BatchDownloadRequestList = null)
        {
            
            
            
            // to ensure "BatchDownloadRequestList" is required (not null)
            if (BatchDownloadRequestList == null)
            {
                throw new InvalidDataException("BatchDownloadRequestList is a required property for BatchDownloadJobSubmission and cannot be null");
            }
            else
            {
                this.BatchDownloadRequestList = BatchDownloadRequestList;
            }
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// List of up to 100 items requested
        /// </summary>
        /// <value>List of up to 100 items requested</value>
        [DataMember(Name="batchDownloadRequestList", EmitDefaultValue=false)]
        public List<BatchDownloadRequest> BatchDownloadRequestList { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDownloadJobSubmission {\n");
            
            sb.Append("  BatchDownloadRequestList: ").Append(BatchDownloadRequestList).Append("\n");
            
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
            return this.Equals(obj as BatchDownloadJobSubmission);
        }

        /// <summary>
        /// Returns true if BatchDownloadJobSubmission instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchDownloadJobSubmission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchDownloadJobSubmission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BatchDownloadRequestList == other.BatchDownloadRequestList ||
                    this.BatchDownloadRequestList != null &&
                    this.BatchDownloadRequestList.SequenceEqual(other.BatchDownloadRequestList)
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
                
                if (this.BatchDownloadRequestList != null)
                    hash = hash * 59 + this.BatchDownloadRequestList.GetHashCode();
                
                return hash;
            }
        }
    }

}
