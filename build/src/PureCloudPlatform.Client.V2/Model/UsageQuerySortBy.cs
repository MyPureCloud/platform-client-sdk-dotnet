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
    /// UsageQuerySortBy
    /// </summary>
    [DataContract]
    public partial class UsageQuerySortBy :  IEquatable<UsageQuerySortBy>
    {
        /// <summary>
        /// The order to sort by.
        /// </summary>
        /// <value>The order to sort by.</value>
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
            /// Enum Asc for "Asc"
            /// </summary>
            [EnumMember(Value = "Asc")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "Desc"
            /// </summary>
            [EnumMember(Value = "Desc")]
            Desc
        }
        /// <summary>
        /// The order to sort by.
        /// </summary>
        /// <value>The order to sort by.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageQuerySortBy" /> class.
        /// </summary>
        /// <param name="FieldName">The name of the field you want to specify to sort by..</param>
        /// <param name="Order">The order to sort by..</param>
        public UsageQuerySortBy(string FieldName = null, OrderEnum? Order = null)
        {
            this.FieldName = FieldName;
            this.Order = Order;
            
        }
        


        /// <summary>
        /// The name of the field you want to specify to sort by.
        /// </summary>
        /// <value>The name of the field you want to specify to sort by.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageQuerySortBy {\n");

            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
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
            return this.Equals(obj as UsageQuerySortBy);
        }

        /// <summary>
        /// Returns true if UsageQuerySortBy instances are equal
        /// </summary>
        /// <param name="other">Instance of UsageQuerySortBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageQuerySortBy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();

                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();

                return hash;
            }
        }
    }

}
