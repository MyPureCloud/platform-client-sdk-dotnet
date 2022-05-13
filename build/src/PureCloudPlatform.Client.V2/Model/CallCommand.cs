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
    /// CallCommand
    /// </summary>
    [DataContract]
    public partial class CallCommand :  IEquatable<CallCommand>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallCommand" /> class.
        /// </summary>
        /// <param name="CallNumber">The phone number to dial for this call. (required).</param>
        /// <param name="PhoneColumn">For a dialer preview or scheduled callback, the phone column associated with the phone number.</param>
        public CallCommand(string CallNumber = null, string PhoneColumn = null)
        {
            this.CallNumber = CallNumber;
            this.PhoneColumn = PhoneColumn;
            
        }
        


        /// <summary>
        /// The phone number to dial for this call.
        /// </summary>
        /// <value>The phone number to dial for this call.</value>
        [DataMember(Name="callNumber", EmitDefaultValue=false)]
        public string CallNumber { get; set; }



        /// <summary>
        /// For a dialer preview or scheduled callback, the phone column associated with the phone number
        /// </summary>
        /// <value>For a dialer preview or scheduled callback, the phone column associated with the phone number</value>
        [DataMember(Name="phoneColumn", EmitDefaultValue=false)]
        public string PhoneColumn { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallCommand {\n");

            sb.Append("  CallNumber: ").Append(CallNumber).Append("\n");
            sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
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
            return this.Equals(obj as CallCommand);
        }

        /// <summary>
        /// Returns true if CallCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of CallCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallNumber == other.CallNumber ||
                    this.CallNumber != null &&
                    this.CallNumber.Equals(other.CallNumber)
                ) &&
                (
                    this.PhoneColumn == other.PhoneColumn ||
                    this.PhoneColumn != null &&
                    this.PhoneColumn.Equals(other.PhoneColumn)
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
                if (this.CallNumber != null)
                    hash = hash * 59 + this.CallNumber.GetHashCode();

                if (this.PhoneColumn != null)
                    hash = hash * 59 + this.PhoneColumn.GetHashCode();

                return hash;
            }
        }
    }

}
