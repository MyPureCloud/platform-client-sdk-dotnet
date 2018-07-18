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
    /// CreateAsgRequest
    /// </summary>
    [DataContract]
    public partial class CreateAsgRequest :  IEquatable<CreateAsgRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Overrides the type of ASG being created.  By default we always create a 'standard' asg.
        /// </summary>
        /// <value>Overrides the type of ASG being created.  By default we always create a 'standard' asg.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AsgTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "standard"
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard,
            
            /// <summary>
            /// Enum Recovery for "recovery"
            /// </summary>
            [EnumMember(Value = "recovery")]
            Recovery
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Overrides the type of ASG being created.  By default we always create a 'standard' asg.
        /// </summary>
        /// <value>Overrides the type of ASG being created.  By default we always create a 'standard' asg.</value>
        [DataMember(Name="asgType", EmitDefaultValue=false)]
        public AsgTypeEnum? AsgType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsgRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAsgRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsgRequest" /> class.
        /// </summary>
        /// <param name="AsgOwnerEmail">Email address of the individual starting the ASG (required).</param>
        /// <param name="EdgeGroupId">Edge group that the user wants the asg edges to be assigned to..</param>
        /// <param name="ExternalTrunkBaseId">Trunk base that the user wants the asg edges to be assigned to.</param>
        /// <param name="AsgLogicalIAMInstanceProfile">Overrides the default logical IAM Instance Profile.</param>
        /// <param name="AsgAmi">Overrides the default EDGE AMI used with the ASG.</param>
        /// <param name="AsgType">Overrides the type of ASG being created.  By default we always create a &#39;standard&#39; asg..</param>
        /// <param name="AsgInstanceCount">Overrides the default number of Edge instances to start in the ASG.</param>
        /// <param name="AsgNetworkSpace">Overrides the network space the ASG will start in.  The default will always be mediaservices.</param>
        /// <param name="AsgChaosExempt">Optional parameter that exempts this ASG from chaos monkey killing one of its instances..</param>
        /// <param name="AsgRecoveryShutdownMinutes">Number of minutes a recovery ASG will stay active before it is torn down.</param>
        public CreateAsgRequest(string AsgOwnerEmail = null, string EdgeGroupId = null, string ExternalTrunkBaseId = null, string AsgLogicalIAMInstanceProfile = null, string AsgAmi = null, AsgTypeEnum? AsgType = null, int? AsgInstanceCount = null, string AsgNetworkSpace = null, bool? AsgChaosExempt = null, int? AsgRecoveryShutdownMinutes = null)
        {
            this.AsgOwnerEmail = AsgOwnerEmail;
            this.EdgeGroupId = EdgeGroupId;
            this.ExternalTrunkBaseId = ExternalTrunkBaseId;
            this.AsgLogicalIAMInstanceProfile = AsgLogicalIAMInstanceProfile;
            this.AsgAmi = AsgAmi;
            this.AsgType = AsgType;
            this.AsgInstanceCount = AsgInstanceCount;
            this.AsgNetworkSpace = AsgNetworkSpace;
            this.AsgChaosExempt = AsgChaosExempt;
            this.AsgRecoveryShutdownMinutes = AsgRecoveryShutdownMinutes;
            
        }
        
        
        
        /// <summary>
        /// Email address of the individual starting the ASG
        /// </summary>
        /// <value>Email address of the individual starting the ASG</value>
        [DataMember(Name="asgOwnerEmail", EmitDefaultValue=false)]
        public string AsgOwnerEmail { get; set; }
        
        
        
        /// <summary>
        /// Edge group that the user wants the asg edges to be assigned to.
        /// </summary>
        /// <value>Edge group that the user wants the asg edges to be assigned to.</value>
        [DataMember(Name="edgeGroupId", EmitDefaultValue=false)]
        public string EdgeGroupId { get; set; }
        
        
        
        /// <summary>
        /// Trunk base that the user wants the asg edges to be assigned to
        /// </summary>
        /// <value>Trunk base that the user wants the asg edges to be assigned to</value>
        [DataMember(Name="externalTrunkBaseId", EmitDefaultValue=false)]
        public string ExternalTrunkBaseId { get; set; }
        
        
        
        /// <summary>
        /// Overrides the default logical IAM Instance Profile
        /// </summary>
        /// <value>Overrides the default logical IAM Instance Profile</value>
        [DataMember(Name="asgLogicalIAMInstanceProfile", EmitDefaultValue=false)]
        public string AsgLogicalIAMInstanceProfile { get; set; }
        
        
        
        /// <summary>
        /// Overrides the default EDGE AMI used with the ASG
        /// </summary>
        /// <value>Overrides the default EDGE AMI used with the ASG</value>
        [DataMember(Name="asgAmi", EmitDefaultValue=false)]
        public string AsgAmi { get; set; }
        
        
        
        
        
        /// <summary>
        /// Overrides the default number of Edge instances to start in the ASG
        /// </summary>
        /// <value>Overrides the default number of Edge instances to start in the ASG</value>
        [DataMember(Name="asgInstanceCount", EmitDefaultValue=false)]
        public int? AsgInstanceCount { get; set; }
        
        
        
        /// <summary>
        /// Overrides the network space the ASG will start in.  The default will always be mediaservices
        /// </summary>
        /// <value>Overrides the network space the ASG will start in.  The default will always be mediaservices</value>
        [DataMember(Name="asgNetworkSpace", EmitDefaultValue=false)]
        public string AsgNetworkSpace { get; set; }
        
        
        
        /// <summary>
        /// Optional parameter that exempts this ASG from chaos monkey killing one of its instances.
        /// </summary>
        /// <value>Optional parameter that exempts this ASG from chaos monkey killing one of its instances.</value>
        [DataMember(Name="asgChaosExempt", EmitDefaultValue=false)]
        public bool? AsgChaosExempt { get; set; }
        
        
        
        /// <summary>
        /// Number of minutes a recovery ASG will stay active before it is torn down
        /// </summary>
        /// <value>Number of minutes a recovery ASG will stay active before it is torn down</value>
        [DataMember(Name="asgRecoveryShutdownMinutes", EmitDefaultValue=false)]
        public int? AsgRecoveryShutdownMinutes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAsgRequest {\n");
            
            sb.Append("  AsgOwnerEmail: ").Append(AsgOwnerEmail).Append("\n");
            sb.Append("  EdgeGroupId: ").Append(EdgeGroupId).Append("\n");
            sb.Append("  ExternalTrunkBaseId: ").Append(ExternalTrunkBaseId).Append("\n");
            sb.Append("  AsgLogicalIAMInstanceProfile: ").Append(AsgLogicalIAMInstanceProfile).Append("\n");
            sb.Append("  AsgAmi: ").Append(AsgAmi).Append("\n");
            sb.Append("  AsgType: ").Append(AsgType).Append("\n");
            sb.Append("  AsgInstanceCount: ").Append(AsgInstanceCount).Append("\n");
            sb.Append("  AsgNetworkSpace: ").Append(AsgNetworkSpace).Append("\n");
            sb.Append("  AsgChaosExempt: ").Append(AsgChaosExempt).Append("\n");
            sb.Append("  AsgRecoveryShutdownMinutes: ").Append(AsgRecoveryShutdownMinutes).Append("\n");
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
            return this.Equals(obj as CreateAsgRequest);
        }

        /// <summary>
        /// Returns true if CreateAsgRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateAsgRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAsgRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AsgOwnerEmail == other.AsgOwnerEmail ||
                    this.AsgOwnerEmail != null &&
                    this.AsgOwnerEmail.Equals(other.AsgOwnerEmail)
                ) &&
                (
                    this.EdgeGroupId == other.EdgeGroupId ||
                    this.EdgeGroupId != null &&
                    this.EdgeGroupId.Equals(other.EdgeGroupId)
                ) &&
                (
                    this.ExternalTrunkBaseId == other.ExternalTrunkBaseId ||
                    this.ExternalTrunkBaseId != null &&
                    this.ExternalTrunkBaseId.Equals(other.ExternalTrunkBaseId)
                ) &&
                (
                    this.AsgLogicalIAMInstanceProfile == other.AsgLogicalIAMInstanceProfile ||
                    this.AsgLogicalIAMInstanceProfile != null &&
                    this.AsgLogicalIAMInstanceProfile.Equals(other.AsgLogicalIAMInstanceProfile)
                ) &&
                (
                    this.AsgAmi == other.AsgAmi ||
                    this.AsgAmi != null &&
                    this.AsgAmi.Equals(other.AsgAmi)
                ) &&
                (
                    this.AsgType == other.AsgType ||
                    this.AsgType != null &&
                    this.AsgType.Equals(other.AsgType)
                ) &&
                (
                    this.AsgInstanceCount == other.AsgInstanceCount ||
                    this.AsgInstanceCount != null &&
                    this.AsgInstanceCount.Equals(other.AsgInstanceCount)
                ) &&
                (
                    this.AsgNetworkSpace == other.AsgNetworkSpace ||
                    this.AsgNetworkSpace != null &&
                    this.AsgNetworkSpace.Equals(other.AsgNetworkSpace)
                ) &&
                (
                    this.AsgChaosExempt == other.AsgChaosExempt ||
                    this.AsgChaosExempt != null &&
                    this.AsgChaosExempt.Equals(other.AsgChaosExempt)
                ) &&
                (
                    this.AsgRecoveryShutdownMinutes == other.AsgRecoveryShutdownMinutes ||
                    this.AsgRecoveryShutdownMinutes != null &&
                    this.AsgRecoveryShutdownMinutes.Equals(other.AsgRecoveryShutdownMinutes)
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
                
                if (this.AsgOwnerEmail != null)
                    hash = hash * 59 + this.AsgOwnerEmail.GetHashCode();
                
                if (this.EdgeGroupId != null)
                    hash = hash * 59 + this.EdgeGroupId.GetHashCode();
                
                if (this.ExternalTrunkBaseId != null)
                    hash = hash * 59 + this.ExternalTrunkBaseId.GetHashCode();
                
                if (this.AsgLogicalIAMInstanceProfile != null)
                    hash = hash * 59 + this.AsgLogicalIAMInstanceProfile.GetHashCode();
                
                if (this.AsgAmi != null)
                    hash = hash * 59 + this.AsgAmi.GetHashCode();
                
                if (this.AsgType != null)
                    hash = hash * 59 + this.AsgType.GetHashCode();
                
                if (this.AsgInstanceCount != null)
                    hash = hash * 59 + this.AsgInstanceCount.GetHashCode();
                
                if (this.AsgNetworkSpace != null)
                    hash = hash * 59 + this.AsgNetworkSpace.GetHashCode();
                
                if (this.AsgChaosExempt != null)
                    hash = hash * 59 + this.AsgChaosExempt.GetHashCode();
                
                if (this.AsgRecoveryShutdownMinutes != null)
                    hash = hash * 59 + this.AsgRecoveryShutdownMinutes.GetHashCode();
                
                return hash;
            }
        }
    }

}
