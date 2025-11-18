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
    /// ShiftTradeExternalActivityRule
    /// </summary>
    [DataContract]
    public partial class ShiftTradeExternalActivityRule :  IEquatable<ShiftTradeExternalActivityRule>
    {
        /// <summary>
        /// The external activity type to which to apply this rule
        /// </summary>
        /// <value>The external activity type to which to apply this rule</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExternalActivityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activityplan for "ActivityPlan"
            /// </summary>
            [EnumMember(Value = "ActivityPlan")]
            Activityplan,
            
            /// <summary>
            /// Enum Coaching for "Coaching"
            /// </summary>
            [EnumMember(Value = "Coaching")]
            Coaching,
            
            /// <summary>
            /// Enum Learning for "Learning"
            /// </summary>
            [EnumMember(Value = "Learning")]
            Learning,
            
            /// <summary>
            /// Enum Opportunity for "Opportunity"
            /// </summary>
            [EnumMember(Value = "Opportunity")]
            Opportunity
        }
        /// <summary>
        /// The action this rule invokes
        /// </summary>
        /// <value>The action this rule invokes</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Donotallowtrade for "DoNotAllowTrade"
            /// </summary>
            [EnumMember(Value = "DoNotAllowTrade")]
            Donotallowtrade,
            
            /// <summary>
            /// Enum Keepwithagent for "KeepWithAgent"
            /// </summary>
            [EnumMember(Value = "KeepWithAgent")]
            Keepwithagent
        }
        /// <summary>
        /// The external activity type to which to apply this rule
        /// </summary>
        /// <value>The external activity type to which to apply this rule</value>
        [DataMember(Name="externalActivityType", EmitDefaultValue=false)]
        public ExternalActivityTypeEnum? ExternalActivityType { get; set; }
        /// <summary>
        /// The action this rule invokes
        /// </summary>
        /// <value>The action this rule invokes</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeExternalActivityRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeExternalActivityRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeExternalActivityRule" /> class.
        /// </summary>
        /// <param name="ExternalActivityType">The external activity type to which to apply this rule (required).</param>
        /// <param name="Action">The action this rule invokes (required).</param>
        /// <param name="ActivityCodeIdReplacement">The ID of the activity code with which to replace to replace external activities (required if action &#x3D;&#x3D; KeepWithAgent, must be a default activity code ID).</param>
        public ShiftTradeExternalActivityRule(ExternalActivityTypeEnum? ExternalActivityType = null, ActionEnum? Action = null, string ActivityCodeIdReplacement = null)
        {
            this.ExternalActivityType = ExternalActivityType;
            this.Action = Action;
            this.ActivityCodeIdReplacement = ActivityCodeIdReplacement;
            
        }
        






        /// <summary>
        /// The ID of the activity code with which to replace to replace external activities (required if action &#x3D;&#x3D; KeepWithAgent, must be a default activity code ID)
        /// </summary>
        /// <value>The ID of the activity code with which to replace to replace external activities (required if action &#x3D;&#x3D; KeepWithAgent, must be a default activity code ID)</value>
        [DataMember(Name="activityCodeIdReplacement", EmitDefaultValue=false)]
        public string ActivityCodeIdReplacement { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeExternalActivityRule {\n");

            sb.Append("  ExternalActivityType: ").Append(ExternalActivityType).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActivityCodeIdReplacement: ").Append(ActivityCodeIdReplacement).Append("\n");
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
            return this.Equals(obj as ShiftTradeExternalActivityRule);
        }

        /// <summary>
        /// Returns true if ShiftTradeExternalActivityRule instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeExternalActivityRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeExternalActivityRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalActivityType == other.ExternalActivityType ||
                    this.ExternalActivityType != null &&
                    this.ExternalActivityType.Equals(other.ExternalActivityType)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.ActivityCodeIdReplacement == other.ActivityCodeIdReplacement ||
                    this.ActivityCodeIdReplacement != null &&
                    this.ActivityCodeIdReplacement.Equals(other.ActivityCodeIdReplacement)
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
                if (this.ExternalActivityType != null)
                    hash = hash * 59 + this.ExternalActivityType.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.ActivityCodeIdReplacement != null)
                    hash = hash * 59 + this.ActivityCodeIdReplacement.GetHashCode();

                return hash;
            }
        }
    }

}
