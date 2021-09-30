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
    /// BenefitAssessment
    /// </summary>
    [DataContract]
    public partial class BenefitAssessment :  IEquatable<BenefitAssessment>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// State of the benefit assessment.
        /// </summary>
        /// <value>State of the benefit assessment.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// State of the benefit assessment.
        /// </summary>
        /// <value>State of the benefit assessment.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BenefitAssessment" /> class.
        /// </summary>
        public BenefitAssessment()
        {
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The list of queues that are assessed for Predictive Routing benefit.
        /// </summary>
        /// <value>The list of queues that are assessed for Predictive Routing benefit.</value>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Queues { get; private set; }
        
        
        
        /// <summary>
        /// A set of key performance indicators applied on the queue to determine suitability of Predictive Routing.
        /// </summary>
        /// <value>A set of key performance indicators applied on the queue to determine suitability of Predictive Routing.</value>
        [DataMember(Name="kpiAssessments", EmitDefaultValue=false)]
        public List<KeyPerformanceIndicatorAssessment> KpiAssessments { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Creation Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Modified Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Modified Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BenefitAssessment {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  KpiAssessments: ").Append(KpiAssessments).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as BenefitAssessment);
        }

        /// <summary>
        /// Returns true if BenefitAssessment instances are equal
        /// </summary>
        /// <param name="other">Instance of BenefitAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BenefitAssessment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
                ) &&
                (
                    this.KpiAssessments == other.KpiAssessments ||
                    this.KpiAssessments != null &&
                    this.KpiAssessments.SequenceEqual(other.KpiAssessments)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();
                
                if (this.KpiAssessments != null)
                    hash = hash * 59 + this.KpiAssessments.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
