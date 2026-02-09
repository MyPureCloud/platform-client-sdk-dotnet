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
    /// TaskManagementQueryMetric
    /// </summary>
    [DataContract]
    public partial class TaskManagementQueryMetric :  IEquatable<TaskManagementQueryMetric>
    {
        /// <summary>
        /// The requested metric name
        /// </summary>
        /// <value>The requested metric name</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oworkitemsunassigned for "oWorkitemsUnassigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemsUnassigned")]
            Oworkitemsunassigned,
            
            /// <summary>
            /// Enum Oworkitemsassigned for "oWorkitemsAssigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemsAssigned")]
            Oworkitemsassigned,
            
            /// <summary>
            /// Enum Oworkitemsconnected for "oWorkitemsConnected"
            /// </summary>
            [EnumMember(Value = "oWorkitemsConnected")]
            Oworkitemsconnected,
            
            /// <summary>
            /// Enum Oworkitemsparked for "oWorkitemsParked"
            /// </summary>
            [EnumMember(Value = "oWorkitemsParked")]
            Oworkitemsparked,
            
            /// <summary>
            /// Enum Oworkitemsheld for "oWorkitemsHeld"
            /// </summary>
            [EnumMember(Value = "oWorkitemsHeld")]
            Oworkitemsheld,
            
            /// <summary>
            /// Enum Oworkitemsacdstarted for "oWorkitemsAcdStarted"
            /// </summary>
            [EnumMember(Value = "oWorkitemsAcdStarted")]
            Oworkitemsacdstarted,
            
            /// <summary>
            /// Enum Oworkitemsdeclined for "oWorkitemsDeclined"
            /// </summary>
            [EnumMember(Value = "oWorkitemsDeclined")]
            Oworkitemsdeclined,
            
            /// <summary>
            /// Enum Oworkitemsidle for "oWorkitemsIdle"
            /// </summary>
            [EnumMember(Value = "oWorkitemsIdle")]
            Oworkitemsidle,
            
            /// <summary>
            /// Enum Oworkitemsdisconnected for "oWorkitemsDisconnected"
            /// </summary>
            [EnumMember(Value = "oWorkitemsDisconnected")]
            Oworkitemsdisconnected,
            
            /// <summary>
            /// Enum Oworkitemsacdexpired for "oWorkitemsAcdExpired"
            /// </summary>
            [EnumMember(Value = "oWorkitemsAcdExpired")]
            Oworkitemsacdexpired,
            
            /// <summary>
            /// Enum Oworkitemsdue for "oWorkitemsDue"
            /// </summary>
            [EnumMember(Value = "oWorkitemsDue")]
            Oworkitemsdue,
            
            /// <summary>
            /// Enum Oworkitemsoverdue for "oWorkitemsOverDue"
            /// </summary>
            [EnumMember(Value = "oWorkitemsOverDue")]
            Oworkitemsoverdue,
            
            /// <summary>
            /// Enum Oworkitemoldestunassigned for "oWorkitemOldestUnassigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemOldestUnassigned")]
            Oworkitemoldestunassigned,
            
            /// <summary>
            /// Enum Oworkitemoldestassigned for "oWorkitemOldestAssigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemOldestAssigned")]
            Oworkitemoldestassigned
        }
        /// <summary>
        /// Qualifier for duration based metrics. Required when requesting oWorkitemsDue
        /// </summary>
        /// <value>Qualifier for duration based metrics. Required when requesting oWorkitemsDue</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QualifierEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hours24 for "Hours24"
            /// </summary>
            [EnumMember(Value = "Hours24")]
            Hours24,
            
            /// <summary>
            /// Enum Hours72 for "Hours72"
            /// </summary>
            [EnumMember(Value = "Hours72")]
            Hours72
        }
        /// <summary>
        /// The requested metric name
        /// </summary>
        /// <value>The requested metric name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Qualifier for duration based metrics. Required when requesting oWorkitemsDue
        /// </summary>
        /// <value>Qualifier for duration based metrics. Required when requesting oWorkitemsDue</value>
        [DataMember(Name="qualifier", EmitDefaultValue=false)]
        public QualifierEnum? Qualifier { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementQueryMetric" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskManagementQueryMetric() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementQueryMetric" /> class.
        /// </summary>
        /// <param name="Name">The requested metric name (required).</param>
        /// <param name="Qualifier">Qualifier for duration based metrics. Required when requesting oWorkitemsDue.</param>
        public TaskManagementQueryMetric(NameEnum? Name = null, QualifierEnum? Qualifier = null)
        {
            this.Name = Name;
            this.Qualifier = Qualifier;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementQueryMetric {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
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
            return this.Equals(obj as TaskManagementQueryMetric);
        }

        /// <summary>
        /// Returns true if TaskManagementQueryMetric instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementQueryMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementQueryMetric other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Qualifier == other.Qualifier ||
                    this.Qualifier != null &&
                    this.Qualifier.Equals(other.Qualifier)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Qualifier != null)
                    hash = hash * 59 + this.Qualifier.GetHashCode();

                return hash;
            }
        }
    }

}
