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
    /// Activity Code
    /// </summary>
    [DataContract]
    public partial class CreateActivityCodeRequest :  IEquatable<CreateActivityCodeRequest>
    {
        
        
        
        
        
        /// <summary>
        /// The activity code's category
        /// </summary>
        /// <value>The activity code's category</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The activity code's category
        /// </summary>
        /// <value>The activity code's category</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateActivityCodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateActivityCodeRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateActivityCodeRequest" /> class.
        /// </summary>
        
        
        /// <param name="Name">The name of the activity code (required).</param>
        
        
        
        /// <param name="Category">The activity code&#39;s category (required).</param>
        
        
        
        /// <param name="LengthInMinutes">The default length of the activity in minutes (required).</param>
        
        
        
        /// <param name="CountsAsPaidTime">Whether an agent is paid while performing this activity (required).</param>
        
        
        
        /// <param name="CountsAsWorkTime">Indicates whether or not the activity should be counted as work time (required).</param>
        
        
        
        /// <param name="AgentTimeOffSelectable">Whether an agent can select this activity code when creating or editing a time off request.</param>
        
        
        public CreateActivityCodeRequest(string Name = null, CategoryEnum? Category = null, int? LengthInMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsWorkTime = null, bool? AgentTimeOffSelectable = null)
        {
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateActivityCodeRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for CreateActivityCodeRequest and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            
            
            
            
            
            // to ensure "LengthInMinutes" is required (not null)
            if (LengthInMinutes == null)
            {
                throw new InvalidDataException("LengthInMinutes is a required property for CreateActivityCodeRequest and cannot be null");
            }
            else
            {
                this.LengthInMinutes = LengthInMinutes;
            }
            
            
            
            
            
            // to ensure "CountsAsPaidTime" is required (not null)
            if (CountsAsPaidTime == null)
            {
                throw new InvalidDataException("CountsAsPaidTime is a required property for CreateActivityCodeRequest and cannot be null");
            }
            else
            {
                this.CountsAsPaidTime = CountsAsPaidTime;
            }
            
            
            
            
            
            // to ensure "CountsAsWorkTime" is required (not null)
            if (CountsAsWorkTime == null)
            {
                throw new InvalidDataException("CountsAsWorkTime is a required property for CreateActivityCodeRequest and cannot be null");
            }
            else
            {
                this.CountsAsWorkTime = CountsAsWorkTime;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.AgentTimeOffSelectable = AgentTimeOffSelectable;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The name of the activity code
        /// </summary>
        /// <value>The name of the activity code</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        
        
        /// <summary>
        /// The default length of the activity in minutes
        /// </summary>
        /// <value>The default length of the activity in minutes</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }
        
        
        
        /// <summary>
        /// Whether an agent is paid while performing this activity
        /// </summary>
        /// <value>Whether an agent is paid while performing this activity</value>
        [DataMember(Name="countsAsPaidTime", EmitDefaultValue=false)]
        public bool? CountsAsPaidTime { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether or not the activity should be counted as work time
        /// </summary>
        /// <value>Indicates whether or not the activity should be counted as work time</value>
        [DataMember(Name="countsAsWorkTime", EmitDefaultValue=false)]
        public bool? CountsAsWorkTime { get; set; }
        
        
        
        /// <summary>
        /// Whether an agent can select this activity code when creating or editing a time off request
        /// </summary>
        /// <value>Whether an agent can select this activity code when creating or editing a time off request</value>
        [DataMember(Name="agentTimeOffSelectable", EmitDefaultValue=false)]
        public bool? AgentTimeOffSelectable { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateActivityCodeRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Category: ").Append(Category).Append("\n");
            
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            
            sb.Append("  CountsAsWorkTime: ").Append(CountsAsWorkTime).Append("\n");
            
            sb.Append("  AgentTimeOffSelectable: ").Append(AgentTimeOffSelectable).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateActivityCodeRequest);
        }

        /// <summary>
        /// Returns true if CreateActivityCodeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateActivityCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateActivityCodeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.CountsAsPaidTime == other.CountsAsPaidTime ||
                    this.CountsAsPaidTime != null &&
                    this.CountsAsPaidTime.Equals(other.CountsAsPaidTime)
                ) &&
                (
                    this.CountsAsWorkTime == other.CountsAsWorkTime ||
                    this.CountsAsWorkTime != null &&
                    this.CountsAsWorkTime.Equals(other.CountsAsWorkTime)
                ) &&
                (
                    this.AgentTimeOffSelectable == other.AgentTimeOffSelectable ||
                    this.AgentTimeOffSelectable != null &&
                    this.AgentTimeOffSelectable.Equals(other.AgentTimeOffSelectable)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();
                
                if (this.CountsAsPaidTime != null)
                    hash = hash * 59 + this.CountsAsPaidTime.GetHashCode();
                
                if (this.CountsAsWorkTime != null)
                    hash = hash * 59 + this.CountsAsWorkTime.GetHashCode();
                
                if (this.AgentTimeOffSelectable != null)
                    hash = hash * 59 + this.AgentTimeOffSelectable.GetHashCode();
                
                return hash;
            }
        }
    }

}
