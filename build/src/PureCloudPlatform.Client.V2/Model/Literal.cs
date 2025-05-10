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
    /// Literal
    /// </summary>
    [DataContract]
    public partial class Literal :  IEquatable<Literal>
    {
        /// <summary>
        /// A special value enum, such as Wildcard, Null, etc
        /// </summary>
        /// <value>A special value enum, such as Wildcard, Null, etc</value>
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
        /// A special value enum, such as Wildcard, Null, etc
        /// </summary>
        /// <value>A special value enum, such as Wildcard, Null, etc</value>
        [DataMember(Name="special", EmitDefaultValue=false)]
        public SpecialEnum? Special { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Literal" /> class.
        /// </summary>
        /// <param name="String">A string value.</param>
        /// <param name="Integer">An integer value.</param>
        /// <param name="Number">A decimal value.</param>
        /// <param name="Date">A date value, must be in the format of yyyy-MM-dd, e.g. 2024-09-23. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Datetime">A date time value, must be in the format of yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ, e.g. 2024-10-02T01:01:01.111Z. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Special">A special value enum, such as Wildcard, Null, etc.</param>
        /// <param name="Boolean">A boolean value.</param>
        public Literal(string String = null, int? Integer = null, double? Number = null, String Date = null, DateTime? Datetime = null, SpecialEnum? Special = null, bool? Boolean = null)
        {
            this.String = String;
            this.Integer = Integer;
            this.Number = Number;
            this.Date = Date;
            this.Datetime = Datetime;
            this.Special = Special;
            this.Boolean = Boolean;
            
        }
        


        /// <summary>
        /// A string value
        /// </summary>
        /// <value>A string value</value>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string String { get; set; }



        /// <summary>
        /// An integer value
        /// </summary>
        /// <value>An integer value</value>
        [DataMember(Name="integer", EmitDefaultValue=false)]
        public int? Integer { get; set; }



        /// <summary>
        /// A decimal value
        /// </summary>
        /// <value>A decimal value</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public double? Number { get; set; }



        /// <summary>
        /// A date value, must be in the format of yyyy-MM-dd, e.g. 2024-09-23. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>A date value, must be in the format of yyyy-MM-dd, e.g. 2024-09-23. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public String Date { get; set; }



        /// <summary>
        /// A date time value, must be in the format of yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ, e.g. 2024-10-02T01:01:01.111Z. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>A date time value, must be in the format of yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ, e.g. 2024-10-02T01:01:01.111Z. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datetime", EmitDefaultValue=false)]
        public DateTime? Datetime { get; set; }





        /// <summary>
        /// A boolean value
        /// </summary>
        /// <value>A boolean value</value>
        [DataMember(Name="boolean", EmitDefaultValue=false)]
        public bool? Boolean { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Literal {\n");

            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
            sb.Append("  Boolean: ").Append(Boolean).Append("\n");
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
            return this.Equals(obj as Literal);
        }

        /// <summary>
        /// Returns true if Literal instances are equal
        /// </summary>
        /// <param name="other">Instance of Literal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Literal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.String == other.String ||
                    this.String != null &&
                    this.String.Equals(other.String)
                ) &&
                (
                    this.Integer == other.Integer ||
                    this.Integer != null &&
                    this.Integer.Equals(other.Integer)
                ) &&
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.Datetime == other.Datetime ||
                    this.Datetime != null &&
                    this.Datetime.Equals(other.Datetime)
                ) &&
                (
                    this.Special == other.Special ||
                    this.Special != null &&
                    this.Special.Equals(other.Special)
                ) &&
                (
                    this.Boolean == other.Boolean ||
                    this.Boolean != null &&
                    this.Boolean.Equals(other.Boolean)
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
                if (this.String != null)
                    hash = hash * 59 + this.String.GetHashCode();

                if (this.Integer != null)
                    hash = hash * 59 + this.Integer.GetHashCode();

                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();

                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                if (this.Datetime != null)
                    hash = hash * 59 + this.Datetime.GetHashCode();

                if (this.Special != null)
                    hash = hash * 59 + this.Special.GetHashCode();

                if (this.Boolean != null)
                    hash = hash * 59 + this.Boolean.GetHashCode();

                return hash;
            }
        }
    }

}
