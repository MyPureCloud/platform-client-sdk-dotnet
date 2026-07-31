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
    /// RatingFilter
    /// </summary>
    [DataContract]
    public partial class RatingFilter :  IEquatable<RatingFilter>
    {
        /// <summary>
        /// The comparison operator for review rating filtering.
        /// </summary>
        /// <value>The comparison operator for review rating filtering.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Equalto for "EqualTo"
            /// </summary>
            [EnumMember(Value = "EqualTo")]
            Equalto
        }
        /// <summary>
        /// The comparison operator for review rating filtering.
        /// </summary>
        /// <value>The comparison operator for review rating filtering.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatingFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RatingFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingFilter" /> class.
        /// </summary>
        /// <param name="Operator">The comparison operator for review rating filtering. (required).</param>
        /// <param name="Values">One or more rating values to filter by.</param>
        public RatingFilter(OperatorEnum? Operator = null, List<int?> Values = null)
        {
            this.Operator = Operator;
            this.Values = Values;
            
        }
        




        /// <summary>
        /// One or more rating values to filter by
        /// </summary>
        /// <value>One or more rating values to filter by</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<int?> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RatingFilter {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as RatingFilter);
        }

        /// <summary>
        /// Returns true if RatingFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of RatingFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RatingFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
