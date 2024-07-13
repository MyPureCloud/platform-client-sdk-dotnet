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
    /// UserSearchRulePart
    /// </summary>
    [DataContract]
    public partial class UserSearchRulePart :  IEquatable<UserSearchRulePart>
    {
        /// <summary>
        /// The operation for this part
        /// </summary>
        /// <value>The operation for this part</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Include for "Include"
            /// </summary>
            [EnumMember(Value = "Include")]
            Include,
            
            /// <summary>
            /// Enum Exclude for "Exclude"
            /// </summary>
            [EnumMember(Value = "Exclude")]
            Exclude
        }
        /// <summary>
        /// The type of item being selected by this part
        /// </summary>
        /// <value>The type of item being selected by this part</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SelectorEnum
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
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Division for "Division"
            /// </summary>
            [EnumMember(Value = "Division")]
            Division,
            
            /// <summary>
            /// Enum Managementunit for "ManagementUnit"
            /// </summary>
            [EnumMember(Value = "ManagementUnit")]
            Managementunit
        }
        /// <summary>
        /// The operation for this part
        /// </summary>
        /// <value>The operation for this part</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// The type of item being selected by this part
        /// </summary>
        /// <value>The type of item being selected by this part</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public SelectorEnum? Selector { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchRulePart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSearchRulePart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchRulePart" /> class.
        /// </summary>
        /// <param name="Operation">The operation for this part (required).</param>
        /// <param name="Selector">The type of item being selected by this part (required).</param>
        /// <param name="Ids">The ids for the selector; the results of these are ORed together (required).</param>
        public UserSearchRulePart(OperationEnum? Operation = null, SelectorEnum? Selector = null, List<string> Ids = null)
        {
            this.Operation = Operation;
            this.Selector = Selector;
            this.Ids = Ids;
            
        }
        






        /// <summary>
        /// The ids for the selector; the results of these are ORed together
        /// </summary>
        /// <value>The ids for the selector; the results of these are ORed together</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchRulePart {\n");

            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(obj as UserSearchRulePart);
        }

        /// <summary>
        /// Returns true if UserSearchRulePart instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSearchRulePart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchRulePart other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) &&
                (
                    this.Selector == other.Selector ||
                    this.Selector != null &&
                    this.Selector.Equals(other.Selector)
                ) &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
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
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();

                if (this.Selector != null)
                    hash = hash * 59 + this.Selector.GetHashCode();

                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();

                return hash;
            }
        }
    }

}
