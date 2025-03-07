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
    /// ExternalMetricDataItem
    /// </summary>
    [DataContract]
    public partial class ExternalMetricDataItem :  IEquatable<ExternalMetricDataItem>
    {
        /// <summary>
        /// The type of the metric data. The default value is Total.
        /// </summary>
        /// <value>The type of the metric data. The default value is Total.</value>
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
            /// Enum Total for "Total"
            /// </summary>
            [EnumMember(Value = "Total")]
            Total,
            
            /// <summary>
            /// Enum Cumulative for "Cumulative"
            /// </summary>
            [EnumMember(Value = "Cumulative")]
            Cumulative
        }
        /// <summary>
        /// The type of the metric data. The default value is Total.
        /// </summary>
        /// <value>The type of the metric data. The default value is Total.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalMetricDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalMetricDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalMetricDataItem" /> class.
        /// </summary>
        /// <param name="UserId">The user ID. Must provide either userId or userEmail, but not both..</param>
        /// <param name="UserEmail">The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both..</param>
        /// <param name="MetricId">The ID of the external metric definition (required).</param>
        /// <param name="DateOccurred">The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Value">The value of the metric data. When value is null, the metric data will be deleted. (required).</param>
        /// <param name="Count">The number of data points. The default value is 0 when type is Cumulative and the metric data already exists, otherwise 1. When total count reaches 0, the metric data will be deleted..</param>
        /// <param name="Type">The type of the metric data. The default value is Total..</param>
        public ExternalMetricDataItem(string UserId = null, string UserEmail = null, string MetricId = null, String DateOccurred = null, double? Value = null, int? Count = null, TypeEnum? Type = null)
        {
            this.UserId = UserId;
            this.UserEmail = UserEmail;
            this.MetricId = MetricId;
            this.DateOccurred = DateOccurred;
            this.Value = Value;
            this.Count = Count;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The user ID. Must provide either userId or userEmail, but not both.
        /// </summary>
        /// <value>The user ID. Must provide either userId or userEmail, but not both.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both.
        /// </summary>
        /// <value>The user main email used in user&#39;s GenesysCloud account. Must provide either userId or userEmail, but not both.</value>
        [DataMember(Name="userEmail", EmitDefaultValue=false)]
        public string UserEmail { get; set; }



        /// <summary>
        /// The ID of the external metric definition
        /// </summary>
        /// <value>The ID of the external metric definition</value>
        [DataMember(Name="metricId", EmitDefaultValue=false)]
        public string MetricId { get; set; }



        /// <summary>
        /// The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date of the metric data. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateOccurred", EmitDefaultValue=false)]
        public String DateOccurred { get; set; }



        /// <summary>
        /// The value of the metric data. When value is null, the metric data will be deleted.
        /// </summary>
        /// <value>The value of the metric data. When value is null, the metric data will be deleted.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }



        /// <summary>
        /// The number of data points. The default value is 0 when type is Cumulative and the metric data already exists, otherwise 1. When total count reaches 0, the metric data will be deleted.
        /// </summary>
        /// <value>The number of data points. The default value is 0 when type is Cumulative and the metric data already exists, otherwise 1. When total count reaches 0, the metric data will be deleted.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalMetricDataItem {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  MetricId: ").Append(MetricId).Append("\n");
            sb.Append("  DateOccurred: ").Append(DateOccurred).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as ExternalMetricDataItem);
        }

        /// <summary>
        /// Returns true if ExternalMetricDataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalMetricDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalMetricDataItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.UserEmail == other.UserEmail ||
                    this.UserEmail != null &&
                    this.UserEmail.Equals(other.UserEmail)
                ) &&
                (
                    this.MetricId == other.MetricId ||
                    this.MetricId != null &&
                    this.MetricId.Equals(other.MetricId)
                ) &&
                (
                    this.DateOccurred == other.DateOccurred ||
                    this.DateOccurred != null &&
                    this.DateOccurred.Equals(other.DateOccurred)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.UserEmail != null)
                    hash = hash * 59 + this.UserEmail.GetHashCode();

                if (this.MetricId != null)
                    hash = hash * 59 + this.MetricId.GetHashCode();

                if (this.DateOccurred != null)
                    hash = hash * 59 + this.DateOccurred.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
