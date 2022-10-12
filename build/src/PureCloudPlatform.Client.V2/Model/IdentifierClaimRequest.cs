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
    /// IdentifierClaimRequest
    /// </summary>
    [DataContract]
    public partial class IdentifierClaimRequest :  IEquatable<IdentifierClaimRequest>
    {
        /// <summary>
        /// The operation to perform claim/release
        /// </summary>
        /// <value>The operation to perform claim/release</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Claim for "Claim"
            /// </summary>
            [EnumMember(Value = "Claim")]
            Claim,
            
            /// <summary>
            /// Enum Release for "Release"
            /// </summary>
            [EnumMember(Value = "Release")]
            Release
        }
        /// <summary>
        /// The operation to perform claim/release
        /// </summary>
        /// <value>The operation to perform claim/release</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierClaimRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdentifierClaimRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierClaimRequest" /> class.
        /// </summary>
        /// <param name="Operation">The operation to perform claim/release (required).</param>
        /// <param name="Identifier">The identifier that should be claimed/released from a contact (required).</param>
        public IdentifierClaimRequest(OperationEnum? Operation = null, ContactIdentifier Identifier = null)
        {
            this.Operation = Operation;
            this.Identifier = Identifier;
            
        }
        




        /// <summary>
        /// The identifier that should be claimed/released from a contact
        /// </summary>
        /// <value>The identifier that should be claimed/released from a contact</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public ContactIdentifier Identifier { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentifierClaimRequest {\n");

            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
            return this.Equals(obj as IdentifierClaimRequest);
        }

        /// <summary>
        /// Returns true if IdentifierClaimRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentifierClaimRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentifierClaimRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) &&
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
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
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();

                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();

                return hash;
            }
        }
    }

}
