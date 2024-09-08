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
    /// CopilotAction
    /// </summary>
    [DataContract]
    public partial class CopilotAction :  IEquatable<CopilotAction>
    {
        /// <summary>
        /// Type of action.
        /// </summary>
        /// <value>Type of action.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Knowledgearticle for "KnowledgeArticle"
            /// </summary>
            [EnumMember(Value = "KnowledgeArticle")]
            Knowledgearticle,
            
            /// <summary>
            /// Enum Cannedresponse for "CannedResponse"
            /// </summary>
            [EnumMember(Value = "CannedResponse")]
            Cannedresponse,
            
            /// <summary>
            /// Enum Script for "Script"
            /// </summary>
            [EnumMember(Value = "Script")]
            Script
        }
        /// <summary>
        /// Type of action.
        /// </summary>
        /// <value>Type of action.</value>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopilotAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAction" /> class.
        /// </summary>
        /// <param name="ActionType">Type of action. (required).</param>
        /// <param name="Attributes">Action specific attributes, if any. Maximum 100 of string key-value pair allowed..</param>
        public CopilotAction(ActionTypeEnum? ActionType = null, Dictionary<string, string> Attributes = null)
        {
            this.ActionType = ActionType;
            this.Attributes = Attributes;
            
        }
        




        /// <summary>
        /// Action specific attributes, if any. Maximum 100 of string key-value pair allowed.
        /// </summary>
        /// <value>Action specific attributes, if any. Maximum 100 of string key-value pair allowed.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopilotAction {\n");

            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as CopilotAction);
        }

        /// <summary>
        /// Returns true if CopilotAction instances are equal
        /// </summary>
        /// <param name="other">Instance of CopilotAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopilotAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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
                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                return hash;
            }
        }
    }

}
