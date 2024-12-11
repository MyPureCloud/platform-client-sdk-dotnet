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
    /// MaskingRuleValidateResponse
    /// </summary>
    [DataContract]
    public partial class MaskingRuleValidateResponse :  IEquatable<MaskingRuleValidateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRuleValidateResponse" /> class.
        /// </summary>
        public MaskingRuleValidateResponse()
        {
            
        }
        


        /// <summary>
        /// is masking rule definition valid?
        /// </summary>
        /// <value>is masking rule definition valid?</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; private set; }



        /// <summary>
        /// Validation message.
        /// </summary>
        /// <value>Validation message.</value>
        [DataMember(Name="validationMessage", EmitDefaultValue=false)]
        public string ValidationMessage { get; private set; }



        /// <summary>
        /// Masked text.
        /// </summary>
        /// <value>Masked text.</value>
        [DataMember(Name="maskedText", EmitDefaultValue=false)]
        public string MaskedText { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskingRuleValidateResponse {\n");

            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  ValidationMessage: ").Append(ValidationMessage).Append("\n");
            sb.Append("  MaskedText: ").Append(MaskedText).Append("\n");
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
            return this.Equals(obj as MaskingRuleValidateResponse);
        }

        /// <summary>
        /// Returns true if MaskingRuleValidateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MaskingRuleValidateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaskingRuleValidateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) &&
                (
                    this.ValidationMessage == other.ValidationMessage ||
                    this.ValidationMessage != null &&
                    this.ValidationMessage.Equals(other.ValidationMessage)
                ) &&
                (
                    this.MaskedText == other.MaskedText ||
                    this.MaskedText != null &&
                    this.MaskedText.Equals(other.MaskedText)
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
                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();

                if (this.ValidationMessage != null)
                    hash = hash * 59 + this.ValidationMessage.GetHashCode();

                if (this.MaskedText != null)
                    hash = hash * 59 + this.MaskedText.GetHashCode();

                return hash;
            }
        }
    }

}
