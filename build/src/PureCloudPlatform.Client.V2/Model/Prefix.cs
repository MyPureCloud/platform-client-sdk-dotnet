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
    /// Prefix
    /// </summary>
    [DataContract]
    public partial class Prefix :  IEquatable<Prefix>
    {
        /// <summary>
        /// Prefix type: allow or block
        /// </summary>
        /// <value>Prefix type: allow or block</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Allow for "Allow"
            /// </summary>
            [EnumMember(Value = "Allow")]
            Allow,
            
            /// <summary>
            /// Enum Block for "Block"
            /// </summary>
            [EnumMember(Value = "Block")]
            Block
        }
        /// <summary>
        /// The action to perform: ADD or DELETE
        /// </summary>
        /// <value>The action to perform: ADD or DELETE</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Add for "Add"
            /// </summary>
            [EnumMember(Value = "Add")]
            Add,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete
        }
        /// <summary>
        /// Prefix type: allow or block
        /// </summary>
        /// <value>Prefix type: allow or block</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The action to perform: ADD or DELETE
        /// </summary>
        /// <value>The action to perform: ADD or DELETE</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Prefix() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix" /> class.
        /// </summary>
        /// <param name="CountryCode">The ITU-T E.164 country code (numeric, max 4 digits, required) (required).</param>
        /// <param name="Number">The DID (Direct Inward Dialing) number (numeric, max 20 digits).</param>
        /// <param name="Type">Prefix type: allow or block.</param>
        /// <param name="Action">The action to perform: ADD or DELETE.</param>
        public Prefix(string CountryCode = null, string Number = null, TypeEnum? Type = null, ActionEnum? Action = null)
        {
            this.CountryCode = CountryCode;
            this.Number = Number;
            this.Type = Type;
            this.Action = Action;
            
        }
        


        /// <summary>
        /// The ITU-T E.164 country code (numeric, max 4 digits, required)
        /// </summary>
        /// <value>The ITU-T E.164 country code (numeric, max 4 digits, required)</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }



        /// <summary>
        /// The DID (Direct Inward Dialing) number (numeric, max 20 digits)
        /// </summary>
        /// <value>The DID (Direct Inward Dialing) number (numeric, max 20 digits)</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Prefix {\n");

            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as Prefix);
        }

        /// <summary>
        /// Returns true if Prefix instances are equal
        /// </summary>
        /// <param name="other">Instance of Prefix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Prefix other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();

                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                return hash;
            }
        }
    }

}
