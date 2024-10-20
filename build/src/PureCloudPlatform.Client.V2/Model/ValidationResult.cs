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
    /// ValidationResult
    /// </summary>
    [DataContract]
    public partial class ValidationResult :  IEquatable<ValidationResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        /// <param name="SeparatorValid">Separator valid in the upload (required).</param>
        /// <param name="FileEncodingValid">File encoding valid for the upload (required).</param>
        /// <param name="Errors">List of errors for the upload (required).</param>
        public ValidationResult(bool? SeparatorValid = null, bool? FileEncodingValid = null, List<ValidationError> Errors = null)
        {
            this.SeparatorValid = SeparatorValid;
            this.FileEncodingValid = FileEncodingValid;
            this.Errors = Errors;
            
        }
        


        /// <summary>
        /// Separator valid in the upload
        /// </summary>
        /// <value>Separator valid in the upload</value>
        [DataMember(Name="separatorValid", EmitDefaultValue=false)]
        public bool? SeparatorValid { get; set; }



        /// <summary>
        /// File encoding valid for the upload
        /// </summary>
        /// <value>File encoding valid for the upload</value>
        [DataMember(Name="fileEncodingValid", EmitDefaultValue=false)]
        public bool? FileEncodingValid { get; set; }



        /// <summary>
        /// List of errors for the upload
        /// </summary>
        /// <value>List of errors for the upload</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ValidationError> Errors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationResult {\n");

            sb.Append("  SeparatorValid: ").Append(SeparatorValid).Append("\n");
            sb.Append("  FileEncodingValid: ").Append(FileEncodingValid).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as ValidationResult);
        }

        /// <summary>
        /// Returns true if ValidationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SeparatorValid == other.SeparatorValid ||
                    this.SeparatorValid != null &&
                    this.SeparatorValid.Equals(other.SeparatorValid)
                ) &&
                (
                    this.FileEncodingValid == other.FileEncodingValid ||
                    this.FileEncodingValid != null &&
                    this.FileEncodingValid.Equals(other.FileEncodingValid)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.SeparatorValid != null)
                    hash = hash * 59 + this.SeparatorValid.GetHashCode();

                if (this.FileEncodingValid != null)
                    hash = hash * 59 + this.FileEncodingValid.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                return hash;
            }
        }
    }

}
