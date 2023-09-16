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
    /// AlertSummary
    /// </summary>
    [DataContract]
    public partial class AlertSummary :  IEquatable<AlertSummary>
    {
        /// <summary>
        /// The metric type that is monitored.
        /// </summary>
        /// <value>The metric type that is monitored.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Interval for "Interval"
            /// </summary>
            [EnumMember(Value = "Interval")]
            Interval,
            
            /// <summary>
            /// Enum Instance for "Instance"
            /// </summary>
            [EnumMember(Value = "Instance")]
            Instance
        }
        /// <summary>
        /// The metric type that is monitored.
        /// </summary>
        /// <value>The metric type that is monitored.</value>
        [DataMember(Name="metricType", EmitDefaultValue=false)]
        public MetricTypeEnum? MetricType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlertSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertSummary" /> class.
        /// </summary>
        /// <param name="Entities">The entities who violated the rule condition over the duration of the alert. (required).</param>
        /// <param name="Conversation">The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics..</param>
        /// <param name="MetricType">The metric type that is monitored. (required).</param>
        /// <param name="EntitiesAreTeamMembers">Flag that indicated whether or not the alert is for a rule with a condition for all members of a team. (required).</param>
        public AlertSummary(List<AlertSummaryEntity> Entities = null, AddressableEntityRef Conversation = null, MetricTypeEnum? MetricType = null, bool? EntitiesAreTeamMembers = null)
        {
            this.Entities = Entities;
            this.Conversation = Conversation;
            this.MetricType = MetricType;
            this.EntitiesAreTeamMembers = EntitiesAreTeamMembers;
            
        }
        


        /// <summary>
        /// The entities who violated the rule condition over the duration of the alert.
        /// </summary>
        /// <value>The entities who violated the rule condition over the duration of the alert.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<AlertSummaryEntity> Entities { get; set; }



        /// <summary>
        /// The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics.
        /// </summary>
        /// <value>The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; set; }





        /// <summary>
        /// Flag that indicated whether or not the alert is for a rule with a condition for all members of a team.
        /// </summary>
        /// <value>Flag that indicated whether or not the alert is for a rule with a condition for all members of a team.</value>
        [DataMember(Name="entitiesAreTeamMembers", EmitDefaultValue=false)]
        public bool? EntitiesAreTeamMembers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertSummary {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  MetricType: ").Append(MetricType).Append("\n");
            sb.Append("  EntitiesAreTeamMembers: ").Append(EntitiesAreTeamMembers).Append("\n");
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
            return this.Equals(obj as AlertSummary);
        }

        /// <summary>
        /// Returns true if AlertSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of AlertSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.MetricType == other.MetricType ||
                    this.MetricType != null &&
                    this.MetricType.Equals(other.MetricType)
                ) &&
                (
                    this.EntitiesAreTeamMembers == other.EntitiesAreTeamMembers ||
                    this.EntitiesAreTeamMembers != null &&
                    this.EntitiesAreTeamMembers.Equals(other.EntitiesAreTeamMembers)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.MetricType != null)
                    hash = hash * 59 + this.MetricType.GetHashCode();

                if (this.EntitiesAreTeamMembers != null)
                    hash = hash * 59 + this.EntitiesAreTeamMembers.GetHashCode();

                return hash;
            }
        }
    }

}
