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
    /// IntentFeedback
    /// </summary>
    [DataContract]
    public partial class IntentFeedback :  IEquatable<IntentFeedback>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The assessment on the detection for feedback text.
        /// </summary>
        /// <value>The assessment on the detection for feedback text.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssessmentEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Incorrect for "Incorrect"
            /// </summary>
            [EnumMember(Value = "Incorrect")]
            Incorrect,
            
            /// <summary>
            /// Enum Correct for "Correct"
            /// </summary>
            [EnumMember(Value = "Correct")]
            Correct,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Disabled for "Disabled"
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The assessment on the detection for feedback text.
        /// </summary>
        /// <value>The assessment on the detection for feedback text.</value>
        [DataMember(Name="assessment", EmitDefaultValue=false)]
        public AssessmentEnum? Assessment { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntentFeedback" /> class.
        /// </summary>
        /// <param name="Entities">The collection of named entities detected..</param>
        /// <param name="Assessment">The assessment on the detection for feedback text..</param>
        public IntentFeedback(List<DetectedNamedEntity> Entities = null, AssessmentEnum? Assessment = null)
        {
            this.Entities = Entities;
            this.Assessment = Assessment;
            
        }
        
        
        
        /// <summary>
        /// The name of the detected intent.
        /// </summary>
        /// <value>The name of the detected intent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// The probability of the detected intent.
        /// </summary>
        /// <value>The probability of the detected intent.</value>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public double? Probability { get; private set; }
        
        
        
        /// <summary>
        /// The collection of named entities detected.
        /// </summary>
        /// <value>The collection of named entities detected.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<DetectedNamedEntity> Entities { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntentFeedback {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Assessment: ").Append(Assessment).Append("\n");
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
            return this.Equals(obj as IntentFeedback);
        }

        /// <summary>
        /// Returns true if IntentFeedback instances are equal
        /// </summary>
        /// <param name="other">Instance of IntentFeedback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntentFeedback other)
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
                    this.Probability == other.Probability ||
                    this.Probability != null &&
                    this.Probability.Equals(other.Probability)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.Assessment == other.Assessment ||
                    this.Assessment != null &&
                    this.Assessment.Equals(other.Assessment)
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
                
                if (this.Probability != null)
                    hash = hash * 59 + this.Probability.GetHashCode();
                
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                
                if (this.Assessment != null)
                    hash = hash * 59 + this.Assessment.GetHashCode();
                
                return hash;
            }
        }
    }

}
