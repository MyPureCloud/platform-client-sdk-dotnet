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
    /// ImportReport
    /// </summary>
    [DataContract]
    public partial class ImportReport :  IEquatable<ImportReport>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportReport" /> class.
        /// </summary>
        /// <param name="Errors">Errors.</param>
        /// <param name="Validated">Validated.</param>
        /// <param name="Imported">Imported.</param>
        /// <param name="TotalDocuments">TotalDocuments.</param>
        public ImportReport(List<ImportError> Errors = null, ResultCounters Validated = null, ResultCounters Imported = null, int? TotalDocuments = null)
        {
            this.Errors = Errors;
            this.Validated = Validated;
            this.Imported = Imported;
            this.TotalDocuments = TotalDocuments;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ImportError> Errors { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Validated
        /// </summary>
        [DataMember(Name="validated", EmitDefaultValue=false)]
        public ResultCounters Validated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Imported
        /// </summary>
        [DataMember(Name="imported", EmitDefaultValue=false)]
        public ResultCounters Imported { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TotalDocuments
        /// </summary>
        [DataMember(Name="totalDocuments", EmitDefaultValue=false)]
        public int? TotalDocuments { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportReport {\n");
            
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Validated: ").Append(Validated).Append("\n");
            sb.Append("  Imported: ").Append(Imported).Append("\n");
            sb.Append("  TotalDocuments: ").Append(TotalDocuments).Append("\n");
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
            return this.Equals(obj as ImportReport);
        }

        /// <summary>
        /// Returns true if ImportReport instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.Validated == other.Validated ||
                    this.Validated != null &&
                    this.Validated.Equals(other.Validated)
                ) &&
                (
                    this.Imported == other.Imported ||
                    this.Imported != null &&
                    this.Imported.Equals(other.Imported)
                ) &&
                (
                    this.TotalDocuments == other.TotalDocuments ||
                    this.TotalDocuments != null &&
                    this.TotalDocuments.Equals(other.TotalDocuments)
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
                
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                
                if (this.Validated != null)
                    hash = hash * 59 + this.Validated.GetHashCode();
                
                if (this.Imported != null)
                    hash = hash * 59 + this.Imported.GetHashCode();
                
                if (this.TotalDocuments != null)
                    hash = hash * 59 + this.TotalDocuments.GetHashCode();
                
                return hash;
            }
        }
    }

}
