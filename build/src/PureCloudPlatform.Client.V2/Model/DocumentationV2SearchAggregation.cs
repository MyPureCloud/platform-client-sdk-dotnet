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
    /// DocumentationV2SearchAggregation
    /// </summary>
    [DataContract]
    public partial class DocumentationV2SearchAggregation :  IEquatable<DocumentationV2SearchAggregation>
    {
        /// <summary>
        /// The type of aggregation to perform
        /// </summary>
        /// <value>The type of aggregation to perform</value>
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
            /// Enum Term for "TERM"
            /// </summary>
            [EnumMember(Value = "TERM")]
            Term,
            
            /// <summary>
            /// Enum Count for "COUNT"
            /// </summary>
            [EnumMember(Value = "COUNT")]
            Count
        }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum ValueDesc for "VALUE_DESC"
            /// </summary>
            [EnumMember(Value = "VALUE_DESC")]
            ValueDesc,
            
            /// <summary>
            /// Enum ValueAsc for "VALUE_ASC"
            /// </summary>
            [EnumMember(Value = "VALUE_ASC")]
            ValueAsc,
            
            /// <summary>
            /// Enum CountDesc for "COUNT_DESC"
            /// </summary>
            [EnumMember(Value = "COUNT_DESC")]
            CountDesc,
            
            /// <summary>
            /// Enum CountAsc for "COUNT_ASC"
            /// </summary>
            [EnumMember(Value = "COUNT_ASC")]
            CountAsc
        }
        /// <summary>
        /// The type of aggregation to perform
        /// </summary>
        /// <value>The type of aggregation to perform</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationV2SearchAggregation" /> class.
        /// </summary>
        /// <param name="Field">The field used for aggregation.</param>
        /// <param name="Name">The name of the aggregation. The response aggregation uses this name..</param>
        /// <param name="Type">The type of aggregation to perform.</param>
        /// <param name="Value">A value to use for aggregation.</param>
        /// <param name="Size">The number aggregations results to return out of the entire result set.</param>
        /// <param name="Order">The order in which aggregation results are sorted.</param>
        public DocumentationV2SearchAggregation(string Field = null, string Name = null, TypeEnum? Type = null, string Value = null, int? Size = null, List<OrderEnum> Order = null)
        {
            this.Field = Field;
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
            this.Size = Size;
            this.Order = Order;
            
        }
        


        /// <summary>
        /// The field used for aggregation
        /// </summary>
        /// <value>The field used for aggregation</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }



        /// <summary>
        /// The name of the aggregation. The response aggregation uses this name.
        /// </summary>
        /// <value>The name of the aggregation. The response aggregation uses this name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// A value to use for aggregation
        /// </summary>
        /// <value>A value to use for aggregation</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// The number aggregations results to return out of the entire result set
        /// </summary>
        /// <value>The number aggregations results to return out of the entire result set</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }



        /// <summary>
        /// The order in which aggregation results are sorted
        /// </summary>
        /// <value>The order in which aggregation results are sorted</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public List<OrderEnum> Order { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentationV2SearchAggregation {\n");

            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as DocumentationV2SearchAggregation);
        }

        /// <summary>
        /// Returns true if DocumentationV2SearchAggregation instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentationV2SearchAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentationV2SearchAggregation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.SequenceEqual(other.Order)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();

                return hash;
            }
        }
    }

}
