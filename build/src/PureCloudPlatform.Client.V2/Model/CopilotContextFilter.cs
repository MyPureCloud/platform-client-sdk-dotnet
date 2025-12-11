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
    /// CopilotContextFilter
    /// </summary>
    [DataContract]
    public partial class CopilotContextFilter :  IEquatable<CopilotContextFilter>
    {
        /// <summary>
        /// Operator to apply for multiple context values, default: MatchAll.
        /// </summary>
        /// <value>Operator to apply for multiple context values, default: MatchAll.</value>
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
            /// Enum Matchall for "MatchAll"
            /// </summary>
            [EnumMember(Value = "MatchAll")]
            Matchall,
            
            /// <summary>
            /// Enum Matchany for "MatchAny"
            /// </summary>
            [EnumMember(Value = "MatchAny")]
            Matchany
        }
        /// <summary>
        /// Operator to apply for multiple context values, default: MatchAll.
        /// </summary>
        /// <value>Operator to apply for multiple context values, default: MatchAll.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotContextFilter" /> class.
        /// </summary>
        /// <param name="Operator">Operator to apply for multiple context values, default: MatchAll..</param>
        /// <param name="Values">Context names to use for filtering..</param>
        public CopilotContextFilter(OperatorEnum? Operator = null, List<string> Values = null)
        {
            this.Operator = Operator;
            this.Values = Values;
            
        }
        




        /// <summary>
        /// Context names to use for filtering.
        /// </summary>
        /// <value>Context names to use for filtering.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopilotContextFilter {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as CopilotContextFilter);
        }

        /// <summary>
        /// Returns true if CopilotContextFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of CopilotContextFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopilotContextFilter other)
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
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
