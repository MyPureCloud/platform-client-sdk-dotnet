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
    /// CustomAttributesBulkUpdateResponse
    /// </summary>
    [DataContract]
    public partial class CustomAttributesBulkUpdateResponse :  IEquatable<CustomAttributesBulkUpdateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributesBulkUpdateResponse" /> class.
        /// </summary>
        /// <param name="Attributes">The Custom Attributes record..</param>
        /// <param name="StatusCode">The status code result of updating the Custom Attributes record..</param>
        /// <param name="ErrorMessage">The error message if an error occurs while updating the record, otherwise null..</param>
        public CustomAttributesBulkUpdateResponse(CustomAttributes Attributes = null, int? StatusCode = null, string ErrorMessage = null)
        {
            this.Attributes = Attributes;
            this.StatusCode = StatusCode;
            this.ErrorMessage = ErrorMessage;
            
        }
        


        /// <summary>
        /// The Custom Attributes record.
        /// </summary>
        /// <value>The Custom Attributes record.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public CustomAttributes Attributes { get; set; }



        /// <summary>
        /// The status code result of updating the Custom Attributes record.
        /// </summary>
        /// <value>The status code result of updating the Custom Attributes record.</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }



        /// <summary>
        /// The error message if an error occurs while updating the record, otherwise null.
        /// </summary>
        /// <value>The error message if an error occurs while updating the record, otherwise null.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomAttributesBulkUpdateResponse {\n");

            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(obj as CustomAttributesBulkUpdateResponse);
        }

        /// <summary>
        /// Returns true if CustomAttributesBulkUpdateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomAttributesBulkUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributesBulkUpdateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
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
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                return hash;
            }
        }
    }

}
