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
    /// BulkErrorDetail
    /// </summary>
    [DataContract]
    public partial class BulkErrorDetail :  IEquatable<BulkErrorDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkErrorDetail" /> class.
        /// </summary>
        /// <param name="FieldName">The name of the field which experienced an error..</param>
        /// <param name="Value">The field value from the request which caused the error..</param>
        /// <param name="Message">A field-specific error message describing why this operation was rejected..</param>
        public BulkErrorDetail(string FieldName = null, string Value = null, string Message = null)
        {
            this.FieldName = FieldName;
            this.Value = Value;
            this.Message = Message;
            
        }
        


        /// <summary>
        /// The name of the field which experienced an error.
        /// </summary>
        /// <value>The name of the field which experienced an error.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }



        /// <summary>
        /// The field value from the request which caused the error.
        /// </summary>
        /// <value>The field value from the request which caused the error.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// A field-specific error message describing why this operation was rejected.
        /// </summary>
        /// <value>A field-specific error message describing why this operation was rejected.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkErrorDetail {\n");

            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as BulkErrorDetail);
        }

        /// <summary>
        /// Returns true if BulkErrorDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkErrorDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                return hash;
            }
        }
    }

}
