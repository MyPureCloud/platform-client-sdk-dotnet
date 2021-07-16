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
    /// JourneyAggregationView
    /// </summary>
    [DataContract]
    public partial class JourneyAggregationView :  IEquatable<JourneyAggregationView>
    {
        
        
        /// <summary>
        /// Target metric name
        /// </summary>
        /// <value>Target metric name</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TargetEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ndistinctjourneyactions for "nDistinctJourneyActions"
            /// </summary>
            [EnumMember(Value = "nDistinctJourneyActions")]
            Ndistinctjourneyactions,
            
            /// <summary>
            /// Enum Ndistinctjourneysessions for "nDistinctJourneySessions"
            /// </summary>
            [EnumMember(Value = "nDistinctJourneySessions")]
            Ndistinctjourneysessions,
            
            /// <summary>
            /// Enum Njourneyactionsblocked for "nJourneyActionsBlocked"
            /// </summary>
            [EnumMember(Value = "nJourneyActionsBlocked")]
            Njourneyactionsblocked,
            
            /// <summary>
            /// Enum Njourneyoutcomesachieved for "nJourneyOutcomesAchieved"
            /// </summary>
            [EnumMember(Value = "nJourneyOutcomesAchieved")]
            Njourneyoutcomesachieved,
            
            /// <summary>
            /// Enum Njourneyoutcomesattributed for "nJourneyOutcomesAttributed"
            /// </summary>
            [EnumMember(Value = "nJourneyOutcomesAttributed")]
            Njourneyoutcomesattributed,
            
            /// <summary>
            /// Enum Njourneysegmentsassigned for "nJourneySegmentsAssigned"
            /// </summary>
            [EnumMember(Value = "nJourneySegmentsAssigned")]
            Njourneysegmentsassigned,
            
            /// <summary>
            /// Enum Njourneysessions for "nJourneySessions"
            /// </summary>
            [EnumMember(Value = "nJourneySessions")]
            Njourneysessions,
            
            /// <summary>
            /// Enum Nwebactionsabandoned for "nWebActionsAbandoned"
            /// </summary>
            [EnumMember(Value = "nWebActionsAbandoned")]
            Nwebactionsabandoned,
            
            /// <summary>
            /// Enum Nwebactionsaccepted for "nWebActionsAccepted"
            /// </summary>
            [EnumMember(Value = "nWebActionsAccepted")]
            Nwebactionsaccepted,
            
            /// <summary>
            /// Enum Nwebactionsengaged for "nWebActionsEngaged"
            /// </summary>
            [EnumMember(Value = "nWebActionsEngaged")]
            Nwebactionsengaged,
            
            /// <summary>
            /// Enum Nwebactionserrored for "nWebActionsErrored"
            /// </summary>
            [EnumMember(Value = "nWebActionsErrored")]
            Nwebactionserrored,
            
            /// <summary>
            /// Enum Nwebactionsignored for "nWebActionsIgnored"
            /// </summary>
            [EnumMember(Value = "nWebActionsIgnored")]
            Nwebactionsignored,
            
            /// <summary>
            /// Enum Nwebactionsoffered for "nWebActionsOffered"
            /// </summary>
            [EnumMember(Value = "nWebActionsOffered")]
            Nwebactionsoffered,
            
            /// <summary>
            /// Enum Nwebactionsqualified for "nWebActionsQualified"
            /// </summary>
            [EnumMember(Value = "nWebActionsQualified")]
            Nwebactionsqualified,
            
            /// <summary>
            /// Enum Nwebactionsqualifiedoutsideschedule for "nWebActionsQualifiedOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "nWebActionsQualifiedOutsideSchedule")]
            Nwebactionsqualifiedoutsideschedule,
            
            /// <summary>
            /// Enum Nwebactionsrejected for "nWebActionsRejected"
            /// </summary>
            [EnumMember(Value = "nWebActionsRejected")]
            Nwebactionsrejected,
            
            /// <summary>
            /// Enum Nwebactionsstarted for "nWebActionsStarted"
            /// </summary>
            [EnumMember(Value = "nWebActionsStarted")]
            Nwebactionsstarted,
            
            /// <summary>
            /// Enum Nwebactionstimedout for "nWebActionsTimedout"
            /// </summary>
            [EnumMember(Value = "nWebActionsTimedout")]
            Nwebactionstimedout,
            
            /// <summary>
            /// Enum Nwebactionsfrequencycapreached for "nWebActionsFrequencyCapReached"
            /// </summary>
            [EnumMember(Value = "nWebActionsFrequencyCapReached")]
            Nwebactionsfrequencycapreached,
            
            /// <summary>
            /// Enum Nwebactionsofferedoutsideschedule for "nWebActionsOfferedOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "nWebActionsOfferedOutsideSchedule")]
            Nwebactionsofferedoutsideschedule
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Type of view you wish to create
        /// </summary>
        /// <value>Type of view you wish to create</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FunctionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Rangebound for "rangeBound"
            /// </summary>
            [EnumMember(Value = "rangeBound")]
            Rangebound
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// Target metric name
        /// </summary>
        /// <value>Target metric name</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetEnum? Target { get; set; }
        
        
        
        
        
        /// <summary>
        /// Type of view you wish to create
        /// </summary>
        /// <value>Type of view you wish to create</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public FunctionEnum? Function { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAggregationView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyAggregationView() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAggregationView" /> class.
        /// </summary>
        /// <param name="Target">Target metric name (required).</param>
        /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
        /// <param name="Function">Type of view you wish to create (required).</param>
        /// <param name="Range">Range of numbers for slicing up data.</param>
        public JourneyAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
        {
            this.Target = Target;
            this.Name = Name;
            this.Function = Function;
            this.Range = Range;
            
        }
        
        
        
        
        
        /// <summary>
        /// A unique name for this view. Must be distinct from other views and built-in metric names.
        /// </summary>
        /// <value>A unique name for this view. Must be distinct from other views and built-in metric names.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        
        
        /// <summary>
        /// Range of numbers for slicing up data
        /// </summary>
        /// <value>Range of numbers for slicing up data</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public AggregationRange Range { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAggregationView {\n");
            
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
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
            return this.Equals(obj as JourneyAggregationView);
        }

        /// <summary>
        /// Returns true if JourneyAggregationView instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyAggregationView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAggregationView other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
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
                
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();
                
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                
                return hash;
            }
        }
    }

}
