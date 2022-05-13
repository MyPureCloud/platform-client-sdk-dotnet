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
    /// JourneyAggregateQueryPredicate
    /// </summary>
    [DataContract]
    public partial class JourneyAggregateQueryPredicate :  IEquatable<JourneyAggregateQueryPredicate>
    {
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
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
            /// Enum Dimension for "dimension"
            /// </summary>
            [EnumMember(Value = "dimension")]
            Dimension,
            
            /// <summary>
            /// Enum Property for "property"
            /// </summary>
            [EnumMember(Value = "property")]
            Property,
            
            /// <summary>
            /// Enum Metric for "metric"
            /// </summary>
            [EnumMember(Value = "metric")]
            Metric
        }
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Containsallcondition for "containsAllCondition"
            /// </summary>
            [EnumMember(Value = "containsAllCondition")]
            Containsallcondition,
            
            /// <summary>
            /// Enum Containsanycondition for "containsAnyCondition"
            /// </summary>
            [EnumMember(Value = "containsAnyCondition")]
            Containsanycondition,
            
            /// <summary>
            /// Enum Endswithcondition for "endsWithCondition"
            /// </summary>
            [EnumMember(Value = "endsWithCondition")]
            Endswithcondition,
            
            /// <summary>
            /// Enum Equalcondition for "equalCondition"
            /// </summary>
            [EnumMember(Value = "equalCondition")]
            Equalcondition,
            
            /// <summary>
            /// Enum Journeyactionid for "journeyActionId"
            /// </summary>
            [EnumMember(Value = "journeyActionId")]
            Journeyactionid,
            
            /// <summary>
            /// Enum Journeyactionmapid for "journeyActionMapId"
            /// </summary>
            [EnumMember(Value = "journeyActionMapId")]
            Journeyactionmapid,
            
            /// <summary>
            /// Enum Journeyactionmapversion for "journeyActionMapVersion"
            /// </summary>
            [EnumMember(Value = "journeyActionMapVersion")]
            Journeyactionmapversion,
            
            /// <summary>
            /// Enum Journeyactionmediatype for "journeyActionMediaType"
            /// </summary>
            [EnumMember(Value = "journeyActionMediaType")]
            Journeyactionmediatype,
            
            /// <summary>
            /// Enum Journeyactiontargetid for "journeyActionTargetId"
            /// </summary>
            [EnumMember(Value = "journeyActionTargetId")]
            Journeyactiontargetid,
            
            /// <summary>
            /// Enum Journeyactiontemplateid for "journeyActionTemplateId"
            /// </summary>
            [EnumMember(Value = "journeyActionTemplateId")]
            Journeyactiontemplateid,
            
            /// <summary>
            /// Enum Journeyblockingactionmapid for "journeyBlockingActionMapId"
            /// </summary>
            [EnumMember(Value = "journeyBlockingActionMapId")]
            Journeyblockingactionmapid,
            
            /// <summary>
            /// Enum Journeyblockingemergencyschedulegroupid for "journeyBlockingEmergencyScheduleGroupId"
            /// </summary>
            [EnumMember(Value = "journeyBlockingEmergencyScheduleGroupId")]
            Journeyblockingemergencyschedulegroupid,
            
            /// <summary>
            /// Enum Journeyblockingreason for "journeyBlockingReason"
            /// </summary>
            [EnumMember(Value = "journeyBlockingReason")]
            Journeyblockingreason,
            
            /// <summary>
            /// Enum Journeyblockingschedulegroupid for "journeyBlockingScheduleGroupId"
            /// </summary>
            [EnumMember(Value = "journeyBlockingScheduleGroupId")]
            Journeyblockingschedulegroupid,
            
            /// <summary>
            /// Enum Journeycustomerid for "journeyCustomerId"
            /// </summary>
            [EnumMember(Value = "journeyCustomerId")]
            Journeycustomerid,
            
            /// <summary>
            /// Enum Journeycustomeridtype for "journeyCustomerIdType"
            /// </summary>
            [EnumMember(Value = "journeyCustomerIdType")]
            Journeycustomeridtype,
            
            /// <summary>
            /// Enum Journeydevicecategory for "journeyDeviceCategory"
            /// </summary>
            [EnumMember(Value = "journeyDeviceCategory")]
            Journeydevicecategory,
            
            /// <summary>
            /// Enum Journeydevicetype for "journeyDeviceType"
            /// </summary>
            [EnumMember(Value = "journeyDeviceType")]
            Journeydevicetype,
            
            /// <summary>
            /// Enum Journeyfrequencycapreason for "journeyFrequencyCapReason"
            /// </summary>
            [EnumMember(Value = "journeyFrequencyCapReason")]
            Journeyfrequencycapreason,
            
            /// <summary>
            /// Enum Journeyoutcomeid for "journeyOutcomeId"
            /// </summary>
            [EnumMember(Value = "journeyOutcomeId")]
            Journeyoutcomeid,
            
            /// <summary>
            /// Enum Journeysegmentid for "journeySegmentId"
            /// </summary>
            [EnumMember(Value = "journeySegmentId")]
            Journeysegmentid,
            
            /// <summary>
            /// Enum Journeysegmentscope for "journeySegmentScope"
            /// </summary>
            [EnumMember(Value = "journeySegmentScope")]
            Journeysegmentscope,
            
            /// <summary>
            /// Enum Journeysessionid for "journeySessionId"
            /// </summary>
            [EnumMember(Value = "journeySessionId")]
            Journeysessionid,
            
            /// <summary>
            /// Enum Journeysessionsegmentid for "journeySessionSegmentId"
            /// </summary>
            [EnumMember(Value = "journeySessionSegmentId")]
            Journeysessionsegmentid,
            
            /// <summary>
            /// Enum Journeysessiontype for "journeySessionType"
            /// </summary>
            [EnumMember(Value = "journeySessionType")]
            Journeysessiontype,
            
            /// <summary>
            /// Enum Notcontainsallcondition for "notContainsAllCondition"
            /// </summary>
            [EnumMember(Value = "notContainsAllCondition")]
            Notcontainsallcondition,
            
            /// <summary>
            /// Enum Notcontainsanycondition for "notContainsAnyCondition"
            /// </summary>
            [EnumMember(Value = "notContainsAnyCondition")]
            Notcontainsanycondition,
            
            /// <summary>
            /// Enum Notequalcondition for "notEqualCondition"
            /// </summary>
            [EnumMember(Value = "notEqualCondition")]
            Notequalcondition,
            
            /// <summary>
            /// Enum Startswithcondition for "startsWithCondition"
            /// </summary>
            [EnumMember(Value = "startsWithCondition")]
            Startswithcondition,
            
            /// <summary>
            /// Enum Touchpointactionmapid for "touchpointActionMapId"
            /// </summary>
            [EnumMember(Value = "touchpointActionMapId")]
            Touchpointactionmapid
        }
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
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
            /// Enum Matches for "matches"
            /// </summary>
            [EnumMember(Value = "matches")]
            Matches,
            
            /// <summary>
            /// Enum Exists for "exists"
            /// </summary>
            [EnumMember(Value = "exists")]
            Exists,
            
            /// <summary>
            /// Enum Notexists for "notExists"
            /// </summary>
            [EnumMember(Value = "notExists")]
            Notexists
        }
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAggregateQueryPredicate" /> class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">Left hand side for dimension predicates.</param>
        /// <param name="Operator">Optional operator, default is matches.</param>
        /// <param name="Value">Right hand side for dimension predicates.</param>
        /// <param name="Range">Right hand side for dimension predicates.</param>
        public JourneyAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this.Operator = Operator;
            this.Value = Value;
            this.Range = Range;
            
        }
        








        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public NumericRange Range { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAggregateQueryPredicate {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as JourneyAggregateQueryPredicate);
        }

        /// <summary>
        /// Returns true if JourneyAggregateQueryPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyAggregateQueryPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAggregateQueryPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                return hash;
            }
        }
    }

}
