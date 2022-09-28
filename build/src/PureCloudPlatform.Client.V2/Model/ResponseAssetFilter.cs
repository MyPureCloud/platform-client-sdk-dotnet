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
    /// ResponseAssetFilter
    /// </summary>
    [DataContract]
    public partial class ResponseAssetFilter :  IEquatable<ResponseAssetFilter>
    {
        /// <summary>
        /// How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE]
        /// </summary>
        /// <value>How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE]</value>
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
            /// Enum Terms for "TERMS"
            /// </summary>
            [EnumMember(Value = "TERMS")]
            Terms,
            
            /// <summary>
            /// Enum StartsWith for "STARTS_WITH"
            /// </summary>
            [EnumMember(Value = "STARTS_WITH")]
            StartsWith,
            
            /// <summary>
            /// Enum Range for "RANGE"
            /// </summary>
            [EnumMember(Value = "RANGE")]
            Range,
            
            /// <summary>
            /// Enum GreaterThanEqualTo for "GREATER_THAN_EQUAL_TO"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN_EQUAL_TO")]
            GreaterThanEqualTo,
            
            /// <summary>
            /// Enum LessThanEqualTo for "LESS_THAN_EQUAL_TO"
            /// </summary>
            [EnumMember(Value = "LESS_THAN_EQUAL_TO")]
            LessThanEqualTo,
            
            /// <summary>
            /// Enum DateRange for "DATE_RANGE"
            /// </summary>
            [EnumMember(Value = "DATE_RANGE")]
            DateRange
        }
        /// <summary>
        /// How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE]
        /// </summary>
        /// <value>How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE]</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAssetFilter" /> class.
        /// </summary>
        /// <param name="EndValue">The end value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format.</param>
        /// <param name="Values">A list of values for the search to match against.</param>
        /// <param name="StartValue">The start value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format.</param>
        /// <param name="Fields">Field name to search against. Allowed Values: divisionId, name, contentLength, contentType, dateCreated.</param>
        /// <param name="Value">A value for the search to match against.</param>
        /// <param name="Type">How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE].</param>
        public ResponseAssetFilter(string EndValue = null, List<string> Values = null, string StartValue = null, List<string> Fields = null, string Value = null, TypeEnum? Type = null)
        {
            this.EndValue = EndValue;
            this.Values = Values;
            this.StartValue = StartValue;
            this.Fields = Fields;
            this.Value = Value;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The end value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format
        /// </summary>
        /// <value>The end value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format</value>
        [DataMember(Name="endValue", EmitDefaultValue=false)]
        public string EndValue { get; set; }



        /// <summary>
        /// A list of values for the search to match against
        /// </summary>
        /// <value>A list of values for the search to match against</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }



        /// <summary>
        /// The start value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format
        /// </summary>
        /// <value>The start value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format</value>
        [DataMember(Name="startValue", EmitDefaultValue=false)]
        public string StartValue { get; set; }



        /// <summary>
        /// Field name to search against. Allowed Values: divisionId, name, contentLength, contentType, dateCreated
        /// </summary>
        /// <value>Field name to search against. Allowed Values: divisionId, name, contentLength, contentType, dateCreated</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }



        /// <summary>
        /// A value for the search to match against
        /// </summary>
        /// <value>A value for the search to match against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAssetFilter {\n");

            sb.Append("  EndValue: ").Append(EndValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  StartValue: ").Append(StartValue).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ResponseAssetFilter);
        }

        /// <summary>
        /// Returns true if ResponseAssetFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseAssetFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAssetFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndValue == other.EndValue ||
                    this.EndValue != null &&
                    this.EndValue.Equals(other.EndValue)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.StartValue == other.StartValue ||
                    this.StartValue != null &&
                    this.StartValue.Equals(other.StartValue)
                ) &&
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.EndValue != null)
                    hash = hash * 59 + this.EndValue.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.StartValue != null)
                    hash = hash * 59 + this.StartValue.GetHashCode();

                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
