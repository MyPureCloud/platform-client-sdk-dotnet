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
    /// CsvExportErrorDetails
    /// </summary>
    [DataContract]
    public partial class CsvExportErrorDetails :  IEquatable<CsvExportErrorDetails>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvExportErrorDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CsvExportErrorDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvExportErrorDetails" /> class.
        /// </summary>
        /// <param name="ErrorCode">The error code of a failed export (required).</param>
        /// <param name="ErrorMessage">The error message of a failed export (required).</param>
        public CsvExportErrorDetails(string ErrorCode = null, string ErrorMessage = null)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            
        }
        


        /// <summary>
        /// The error code of a failed export
        /// </summary>
        /// <value>The error code of a failed export</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// The error message of a failed export
        /// </summary>
        /// <value>The error message of a failed export</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsvExportErrorDetails {\n");

            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(obj as CsvExportErrorDetails);
        }

        /// <summary>
        /// Returns true if CsvExportErrorDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of CsvExportErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvExportErrorDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                return hash;
            }
        }
    }

}
