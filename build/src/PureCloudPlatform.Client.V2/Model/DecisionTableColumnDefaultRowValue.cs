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
    /// Must provide a valid value for exactly one of the fields in this class.
    /// </summary>
    [DataContract]
    public partial class DecisionTableColumnDefaultRowValue :  IEquatable<DecisionTableColumnDefaultRowValue>
    {
        /// <summary>
        /// A default special value enum for this column.
        /// </summary>
        /// <value>A default special value enum for this column.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SpecialEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Wildcard for "Wildcard"
            /// </summary>
            [EnumMember(Value = "Wildcard")]
            Wildcard,
            
            /// <summary>
            /// Enum Null for "Null"
            /// </summary>
            [EnumMember(Value = "Null")]
            Null,
            
            /// <summary>
            /// Enum Empty for "Empty"
            /// </summary>
            [EnumMember(Value = "Empty")]
            Empty,
            
            /// <summary>
            /// Enum Currenttime for "CurrentTime"
            /// </summary>
            [EnumMember(Value = "CurrentTime")]
            Currenttime
        }
        /// <summary>
        /// A default special value enum for this column.
        /// </summary>
        /// <value>A default special value enum for this column.</value>
        [DataMember(Name="special", EmitDefaultValue=false)]
        public SpecialEnum? Special { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableColumnDefaultRowValue" /> class.
        /// </summary>
        /// <param name="Value">A default string value for this column, will be cast to appropriate type according to the relevant contract schema property..</param>
        /// <param name="Values">A default list of values for this column, items will be cast to appropriate type according to the relevant contract schema property.</param>
        /// <param name="Special">A default special value enum for this column..</param>
        public DecisionTableColumnDefaultRowValue(string Value = null, List<string> Values = null, SpecialEnum? Special = null)
        {
            this.Value = Value;
            this.Values = Values;
            this.Special = Special;
            
        }
        


        /// <summary>
        /// A default string value for this column, will be cast to appropriate type according to the relevant contract schema property.
        /// </summary>
        /// <value>A default string value for this column, will be cast to appropriate type according to the relevant contract schema property.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// A default list of values for this column, items will be cast to appropriate type according to the relevant contract schema property
        /// </summary>
        /// <value>A default list of values for this column, items will be cast to appropriate type according to the relevant contract schema property</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableColumnDefaultRowValue {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
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
            return this.Equals(obj as DecisionTableColumnDefaultRowValue);
        }

        /// <summary>
        /// Returns true if DecisionTableColumnDefaultRowValue instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableColumnDefaultRowValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableColumnDefaultRowValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.Special == other.Special ||
                    this.Special != null &&
                    this.Special.Equals(other.Special)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.Special != null)
                    hash = hash * 59 + this.Special.GetHashCode();

                return hash;
            }
        }
    }

}
