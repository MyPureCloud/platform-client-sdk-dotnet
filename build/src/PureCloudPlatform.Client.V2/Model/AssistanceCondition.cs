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
    /// AssistanceCondition
    /// </summary>
    [DataContract]
    public partial class AssistanceCondition :  IEquatable<AssistanceCondition>
    {
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
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
            /// Enum Exists for "EXISTS"
            /// </summary>
            [EnumMember(Value = "EXISTS")]
            Exists,
            
            /// <summary>
            /// Enum Notexists for "NOTEXISTS"
            /// </summary>
            [EnumMember(Value = "NOTEXISTS")]
            Notexists
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistanceCondition" /> class.
        /// </summary>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="TopicIds">TopicIds.</param>
        public AssistanceCondition(OperatorEnum? _Operator = null, List<string> TopicIds = null)
        {
            this._Operator = _Operator;
            this.TopicIds = TopicIds;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets TopicIds
        /// </summary>
        [DataMember(Name="topicIds", EmitDefaultValue=false)]
        public List<string> TopicIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistanceCondition {\n");
            
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  TopicIds: ").Append(TopicIds).Append("\n");
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
            return this.Equals(obj as AssistanceCondition);
        }

        /// <summary>
        /// Returns true if AssistanceCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of AssistanceCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssistanceCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.TopicIds == other.TopicIds ||
                    this.TopicIds != null &&
                    this.TopicIds.SequenceEqual(other.TopicIds)
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
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.TopicIds != null)
                    hash = hash * 59 + this.TopicIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
