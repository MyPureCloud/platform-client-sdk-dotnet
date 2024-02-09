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
    /// TaskManagementAggregationView
    /// </summary>
    [DataContract]
    public partial class TaskManagementAggregationView :  IEquatable<TaskManagementAggregationView>
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
            /// Enum Nworkitemsacdcancelled for "nWorkitemsAcdCancelled"
            /// </summary>
            [EnumMember(Value = "nWorkitemsAcdCancelled")]
            Nworkitemsacdcancelled,
            
            /// <summary>
            /// Enum Nworkitemsacdexpired for "nWorkitemsAcdExpired"
            /// </summary>
            [EnumMember(Value = "nWorkitemsAcdExpired")]
            Nworkitemsacdexpired,
            
            /// <summary>
            /// Enum Nworkitemsacdstarted for "nWorkitemsAcdStarted"
            /// </summary>
            [EnumMember(Value = "nWorkitemsAcdStarted")]
            Nworkitemsacdstarted,
            
            /// <summary>
            /// Enum Nworkitemsagenttransferred for "nWorkitemsAgentTransferred"
            /// </summary>
            [EnumMember(Value = "nWorkitemsAgentTransferred")]
            Nworkitemsagenttransferred,
            
            /// <summary>
            /// Enum Nworkitemscreated for "nWorkitemsCreated"
            /// </summary>
            [EnumMember(Value = "nWorkitemsCreated")]
            Nworkitemscreated,
            
            /// <summary>
            /// Enum Nworkitemsdeclined for "nWorkitemsDeclined"
            /// </summary>
            [EnumMember(Value = "nWorkitemsDeclined")]
            Nworkitemsdeclined,
            
            /// <summary>
            /// Enum Nworkitemsdeleted for "nWorkitemsDeleted"
            /// </summary>
            [EnumMember(Value = "nWorkitemsDeleted")]
            Nworkitemsdeleted,
            
            /// <summary>
            /// Enum Nworkitemsdisconnected for "nWorkitemsDisconnected"
            /// </summary>
            [EnumMember(Value = "nWorkitemsDisconnected")]
            Nworkitemsdisconnected,
            
            /// <summary>
            /// Enum Nworkitemsoversla for "nWorkitemsOverSla"
            /// </summary>
            [EnumMember(Value = "nWorkitemsOverSla")]
            Nworkitemsoversla,
            
            /// <summary>
            /// Enum Nworkitemspurged for "nWorkitemsPurged"
            /// </summary>
            [EnumMember(Value = "nWorkitemsPurged")]
            Nworkitemspurged,
            
            /// <summary>
            /// Enum Nworkitemsqueuetransferred for "nWorkitemsQueueTransferred"
            /// </summary>
            [EnumMember(Value = "nWorkitemsQueueTransferred")]
            Nworkitemsqueuetransferred,
            
            /// <summary>
            /// Enum Nworkitemsstatuschanged for "nWorkitemsStatusChanged"
            /// </summary>
            [EnumMember(Value = "nWorkitemsStatusChanged")]
            Nworkitemsstatuschanged,
            
            /// <summary>
            /// Enum Nworkitemsterminated for "nWorkitemsTerminated"
            /// </summary>
            [EnumMember(Value = "nWorkitemsTerminated")]
            Nworkitemsterminated,
            
            /// <summary>
            /// Enum Nworkitemstimedout for "nWorkitemsTimedout"
            /// </summary>
            [EnumMember(Value = "nWorkitemsTimedout")]
            Nworkitemstimedout,
            
            /// <summary>
            /// Enum Nworkitemstransferred for "nWorkitemsTransferred"
            /// </summary>
            [EnumMember(Value = "nWorkitemsTransferred")]
            Nworkitemstransferred,
            
            /// <summary>
            /// Enum Nworkitemswrapupadded for "nWorkitemsWrapupAdded"
            /// </summary>
            [EnumMember(Value = "nWorkitemsWrapupAdded")]
            Nworkitemswrapupadded,
            
            /// <summary>
            /// Enum Nworkitemswrapupremoved for "nWorkitemsWrapupRemoved"
            /// </summary>
            [EnumMember(Value = "nWorkitemsWrapupRemoved")]
            Nworkitemswrapupremoved,
            
            /// <summary>
            /// Enum Oworkitemsservicelevel for "oWorkitemsServiceLevel"
            /// </summary>
            [EnumMember(Value = "oWorkitemsServiceLevel")]
            Oworkitemsservicelevel,
            
            /// <summary>
            /// Enum Tworkitemsalert for "tWorkitemsAlert"
            /// </summary>
            [EnumMember(Value = "tWorkitemsAlert")]
            Tworkitemsalert,
            
            /// <summary>
            /// Enum Tworkitemsanswered for "tWorkitemsAnswered"
            /// </summary>
            [EnumMember(Value = "tWorkitemsAnswered")]
            Tworkitemsanswered,
            
            /// <summary>
            /// Enum Tworkitemsdirectanswered for "tWorkitemsDirectAnswered"
            /// </summary>
            [EnumMember(Value = "tWorkitemsDirectAnswered")]
            Tworkitemsdirectanswered,
            
            /// <summary>
            /// Enum Tworkitemsfocus for "tWorkitemsFocus"
            /// </summary>
            [EnumMember(Value = "tWorkitemsFocus")]
            Tworkitemsfocus,
            
            /// <summary>
            /// Enum Tworkitemsfocuscomplete for "tWorkitemsFocusComplete"
            /// </summary>
            [EnumMember(Value = "tWorkitemsFocusComplete")]
            Tworkitemsfocuscomplete,
            
            /// <summary>
            /// Enum Tworkitemshandled for "tWorkitemsHandled"
            /// </summary>
            [EnumMember(Value = "tWorkitemsHandled")]
            Tworkitemshandled,
            
            /// <summary>
            /// Enum Tworkitemsheld for "tWorkitemsHeld"
            /// </summary>
            [EnumMember(Value = "tWorkitemsHeld")]
            Tworkitemsheld,
            
            /// <summary>
            /// Enum Tworkitemsheldcomplete for "tWorkitemsHeldComplete"
            /// </summary>
            [EnumMember(Value = "tWorkitemsHeldComplete")]
            Tworkitemsheldcomplete,
            
            /// <summary>
            /// Enum Tworkitemsnotresponding for "tWorkitemsNotResponding"
            /// </summary>
            [EnumMember(Value = "tWorkitemsNotResponding")]
            Tworkitemsnotresponding,
            
            /// <summary>
            /// Enum Tworkitemsparked for "tWorkitemsParked"
            /// </summary>
            [EnumMember(Value = "tWorkitemsParked")]
            Tworkitemsparked,
            
            /// <summary>
            /// Enum Tworkitemsqueueanswered for "tWorkitemsQueueAnswered"
            /// </summary>
            [EnumMember(Value = "tWorkitemsQueueAnswered")]
            Tworkitemsqueueanswered,
            
            /// <summary>
            /// Enum Tworkitemsstatus for "tWorkitemsStatus"
            /// </summary>
            [EnumMember(Value = "tWorkitemsStatus")]
            Tworkitemsstatus
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
        /// Initializes a new instance of the <see cref="TaskManagementAggregationView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskManagementAggregationView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementAggregationView" /> class.
        /// </summary>
        /// <param name="Target">Target metric name (required).</param>
        /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
        /// <param name="Function">Type of view you wish to create (required).</param>
        /// <param name="Range">Range of numbers for slicing up data.</param>
        public TaskManagementAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
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
            sb.Append("class TaskManagementAggregationView {\n");

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
            return this.Equals(obj as TaskManagementAggregationView);
        }

        /// <summary>
        /// Returns true if TaskManagementAggregationView instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementAggregationView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementAggregationView other)
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
