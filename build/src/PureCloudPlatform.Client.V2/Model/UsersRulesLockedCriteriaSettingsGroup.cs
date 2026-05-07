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
    /// UsersRulesLockedCriteriaSettingsGroup
    /// </summary>
    [DataContract]
    public partial class UsersRulesLockedCriteriaSettingsGroup :  IEquatable<UsersRulesLockedCriteriaSettingsGroup>
    {
        /// <summary>
        /// Gets or Sets Operators
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "And"
            /// </summary>
            [EnumMember(Value = "And")]
            And,
            
            /// <summary>
            /// Enum Not for "Not"
            /// </summary>
            [EnumMember(Value = "Not")]
            Not
        }
        /// <summary>
        /// The container that the ids belong to
        /// </summary>
        /// <value>The container that the ids belong to</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ContainerEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Acdskill for "AcdSkill"
            /// </summary>
            [EnumMember(Value = "AcdSkill")]
            Acdskill,
            
            /// <summary>
            /// Enum Businessunit for "BusinessUnit"
            /// </summary>
            [EnumMember(Value = "BusinessUnit")]
            Businessunit,
            
            /// <summary>
            /// Enum Directorygroup for "DirectoryGroup"
            /// </summary>
            [EnumMember(Value = "DirectoryGroup")]
            Directorygroup,
            
            /// <summary>
            /// Enum Division for "Division"
            /// </summary>
            [EnumMember(Value = "Division")]
            Division,
            
            /// <summary>
            /// Enum Language for "Language"
            /// </summary>
            [EnumMember(Value = "Language")]
            Language,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Managementunit for "ManagementUnit"
            /// </summary>
            [EnumMember(Value = "ManagementUnit")]
            Managementunit,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Reportsto for "ReportsTo"
            /// </summary>
            [EnumMember(Value = "ReportsTo")]
            Reportsto,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User
        }
        /// <summary>
        /// The container that the ids belong to
        /// </summary>
        /// <value>The container that the ids belong to</value>
        [DataMember(Name="container", EmitDefaultValue=false)]
        public ContainerEnum? Container { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesLockedCriteriaSettingsGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsersRulesLockedCriteriaSettingsGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesLockedCriteriaSettingsGroup" /> class.
        /// </summary>
        /// <param name="Operators">The allowed operators for this criteria (required).</param>
        /// <param name="Container">The container that the ids belong to (required).</param>
        /// <param name="MaxIdCount">Maximum number of ids that can be specified in this container.</param>
        public UsersRulesLockedCriteriaSettingsGroup(List<OperatorsEnum> Operators = null, ContainerEnum? Container = null, long? MaxIdCount = null)
        {
            this.Operators = Operators;
            this.Container = Container;
            this.MaxIdCount = MaxIdCount;
            
        }
        


        /// <summary>
        /// The allowed operators for this criteria
        /// </summary>
        /// <value>The allowed operators for this criteria</value>
        [DataMember(Name="operators", EmitDefaultValue=false)]
        public List<OperatorsEnum> Operators { get; set; }





        /// <summary>
        /// Maximum number of ids that can be specified in this container
        /// </summary>
        /// <value>Maximum number of ids that can be specified in this container</value>
        [DataMember(Name="maxIdCount", EmitDefaultValue=false)]
        public long? MaxIdCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersRulesLockedCriteriaSettingsGroup {\n");

            sb.Append("  Operators: ").Append(Operators).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  MaxIdCount: ").Append(MaxIdCount).Append("\n");
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
            return this.Equals(obj as UsersRulesLockedCriteriaSettingsGroup);
        }

        /// <summary>
        /// Returns true if UsersRulesLockedCriteriaSettingsGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersRulesLockedCriteriaSettingsGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersRulesLockedCriteriaSettingsGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operators == other.Operators ||
                    this.Operators != null &&
                    this.Operators.SequenceEqual(other.Operators)
                ) &&
                (
                    this.Container == other.Container ||
                    this.Container != null &&
                    this.Container.Equals(other.Container)
                ) &&
                (
                    this.MaxIdCount == other.MaxIdCount ||
                    this.MaxIdCount != null &&
                    this.MaxIdCount.Equals(other.MaxIdCount)
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
                if (this.Operators != null)
                    hash = hash * 59 + this.Operators.GetHashCode();

                if (this.Container != null)
                    hash = hash * 59 + this.Container.GetHashCode();

                if (this.MaxIdCount != null)
                    hash = hash * 59 + this.MaxIdCount.GetHashCode();

                return hash;
            }
        }
    }

}
