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
    /// WorkitemOnAttributeChangeMatch
    /// </summary>
    [DataContract]
    public partial class WorkitemOnAttributeChangeMatch :  IEquatable<WorkitemOnAttributeChangeMatch>
    {
        /// <summary>
        /// How the results of the groups are combined. The conditions within each group are combined separately, by that group's own operator.
        /// </summary>
        /// <value>How the results of the groups are combined. The conditions within each group are combined separately, by that group's own operator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
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
            /// Enum Or for "Or"
            /// </summary>
            [EnumMember(Value = "Or")]
            Or
        }
        /// <summary>
        /// How the results of the groups are combined. The conditions within each group are combined separately, by that group's own operator.
        /// </summary>
        /// <value>How the results of the groups are combined. The conditions within each group are combined separately, by that group's own operator.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeMatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemOnAttributeChangeMatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeMatch" /> class.
        /// </summary>
        /// <param name="Operator">How the results of the groups are combined. The conditions within each group are combined separately, by that group&#39;s own operator. (required).</param>
        /// <param name="Groups">The groups to evaluate. Between 1 and 5 groups are permitted. (required).</param>
        public WorkitemOnAttributeChangeMatch(OperatorEnum? Operator = null, List<WorkitemOnAttributeChangeConditionGroup> Groups = null)
        {
            this.Operator = Operator;
            this.Groups = Groups;
            
        }
        




        /// <summary>
        /// The groups to evaluate. Between 1 and 5 groups are permitted.
        /// </summary>
        /// <value>The groups to evaluate. Between 1 and 5 groups are permitted.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<WorkitemOnAttributeChangeConditionGroup> Groups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemOnAttributeChangeMatch {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(obj as WorkitemOnAttributeChangeMatch);
        }

        /// <summary>
        /// Returns true if WorkitemOnAttributeChangeMatch instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemOnAttributeChangeMatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemOnAttributeChangeMatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();

                return hash;
            }
        }
    }

}
