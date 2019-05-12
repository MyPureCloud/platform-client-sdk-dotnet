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
    /// IntegrationExport
    /// </summary>
    [DataContract]
    public partial class IntegrationExport :  IEquatable<IntegrationExport>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationExport" /> class.
        /// </summary>
        /// <param name="Integration">The aws-s3-recording-bulk-actions-integration that the policy uses for exports..</param>
        /// <param name="ShouldExportScreenRecordings">True if the policy should export screen recordings in addition to the other conversation media. Default = true.</param>
        public IntegrationExport(UriReference Integration = null, bool? ShouldExportScreenRecordings = null)
        {
            this.Integration = Integration;
            this.ShouldExportScreenRecordings = ShouldExportScreenRecordings;
            
        }
        
        
        
        /// <summary>
        /// The aws-s3-recording-bulk-actions-integration that the policy uses for exports.
        /// </summary>
        /// <value>The aws-s3-recording-bulk-actions-integration that the policy uses for exports.</value>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public UriReference Integration { get; set; }
        
        
        
        /// <summary>
        /// True if the policy should export screen recordings in addition to the other conversation media. Default = true
        /// </summary>
        /// <value>True if the policy should export screen recordings in addition to the other conversation media. Default = true</value>
        [DataMember(Name="shouldExportScreenRecordings", EmitDefaultValue=false)]
        public bool? ShouldExportScreenRecordings { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationExport {\n");
            
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  ShouldExportScreenRecordings: ").Append(ShouldExportScreenRecordings).Append("\n");
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
            return this.Equals(obj as IntegrationExport);
        }

        /// <summary>
        /// Returns true if IntegrationExport instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationExport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationExport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Integration == other.Integration ||
                    this.Integration != null &&
                    this.Integration.Equals(other.Integration)
                ) &&
                (
                    this.ShouldExportScreenRecordings == other.ShouldExportScreenRecordings ||
                    this.ShouldExportScreenRecordings != null &&
                    this.ShouldExportScreenRecordings.Equals(other.ShouldExportScreenRecordings)
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
                
                if (this.Integration != null)
                    hash = hash * 59 + this.Integration.GetHashCode();
                
                if (this.ShouldExportScreenRecordings != null)
                    hash = hash * 59 + this.ShouldExportScreenRecordings.GetHashCode();
                
                return hash;
            }
        }
    }

}
