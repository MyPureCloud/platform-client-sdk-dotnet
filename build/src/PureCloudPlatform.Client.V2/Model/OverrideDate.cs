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
    /// OverrideDate
    /// </summary>
    [DataContract]
    public partial class OverrideDate :  IEquatable<OverrideDate>
    {
        /// <summary>
        /// The type of override date
        /// </summary>
        /// <value>The type of override date</value>
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
            /// Enum Blocked for "Blocked"
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked,
            
            /// <summary>
            /// Enum Manualreview for "ManualReview"
            /// </summary>
            [EnumMember(Value = "ManualReview")]
            Manualreview
        }
        /// <summary>
        /// The type of override date
        /// </summary>
        /// <value>The type of override date</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideDate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OverrideDate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideDate" /> class.
        /// </summary>
        /// <param name="Date">The date in yyyy-MM-dd format, interpreted in the business unit’s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Type">The type of override date (required).</param>
        public OverrideDate(String Date = null, TypeEnum? Type = null)
        {
            this.Date = Date;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The date in yyyy-MM-dd format, interpreted in the business unit’s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date in yyyy-MM-dd format, interpreted in the business unit’s time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public String Date { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverrideDate {\n");

            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as OverrideDate);
        }

        /// <summary>
        /// Returns true if OverrideDate instances are equal
        /// </summary>
        /// <param name="other">Instance of OverrideDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverrideDate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
