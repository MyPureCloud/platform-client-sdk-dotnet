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
    /// KeyPerformanceIndicator
    /// </summary>
    [DataContract]
    public partial class KeyPerformanceIndicator :  IEquatable<KeyPerformanceIndicator>
    {
        /// <summary>
        /// The optimization type of the Key Performance Indicator.
        /// </summary>
        /// <value>The optimization type of the Key Performance Indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OptimizationTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Maximization for "Maximization"
            /// </summary>
            [EnumMember(Value = "Maximization")]
            Maximization,
            
            /// <summary>
            /// Enum Minimization for "Minimization"
            /// </summary>
            [EnumMember(Value = "Minimization")]
            Minimization
        }
        /// <summary>
        /// The problem type of the Key Performance Indicator.
        /// </summary>
        /// <value>The problem type of the Key Performance Indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ProblemTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Classification for "Classification"
            /// </summary>
            [EnumMember(Value = "Classification")]
            Classification,
            
            /// <summary>
            /// Enum Regression for "Regression"
            /// </summary>
            [EnumMember(Value = "Regression")]
            Regression
        }
        /// <summary>
        /// The type of Key Performance Indicator.
        /// </summary>
        /// <value>The type of Key Performance Indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KpiTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Salesconversion for "SalesConversion"
            /// </summary>
            [EnumMember(Value = "SalesConversion")]
            Salesconversion,
            
            /// <summary>
            /// Enum Churn for "Churn"
            /// </summary>
            [EnumMember(Value = "Churn")]
            Churn,
            
            /// <summary>
            /// Enum Retention for "Retention"
            /// </summary>
            [EnumMember(Value = "Retention")]
            Retention,
            
            /// <summary>
            /// Enum Salesvalue for "SalesValue"
            /// </summary>
            [EnumMember(Value = "SalesValue")]
            Salesvalue,
            
            /// <summary>
            /// Enum Handletime for "HandleTime"
            /// </summary>
            [EnumMember(Value = "HandleTime")]
            Handletime,
            
            /// <summary>
            /// Enum Numberoftransfers for "NumberOfTransfers"
            /// </summary>
            [EnumMember(Value = "NumberOfTransfers")]
            Numberoftransfers
        }
        /// <summary>
        /// Source of values for Key Performance Indicator.
        /// </summary>
        /// <value>Source of values for Key Performance Indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapUpCode"
            /// </summary>
            [EnumMember(Value = "WrapUpCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        /// <summary>
        /// The status of the Key Performance Indicator.
        /// </summary>
        /// <value>The status of the Key Performance Indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enabled for "Enabled"
            /// </summary>
            [EnumMember(Value = "Enabled")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "Disabled"
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled
        }
        /// <summary>
        /// The group the Key Performance Indicator belongs to.
        /// </summary>
        /// <value>The group the Key Performance Indicator belongs to.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KpiGroupEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom
        }
        /// <summary>
        /// The optimization type of the Key Performance Indicator.
        /// </summary>
        /// <value>The optimization type of the Key Performance Indicator.</value>
        [DataMember(Name="optimizationType", EmitDefaultValue=false)]
        public OptimizationTypeEnum? OptimizationType { get; private set; }
        /// <summary>
        /// The problem type of the Key Performance Indicator.
        /// </summary>
        /// <value>The problem type of the Key Performance Indicator.</value>
        [DataMember(Name="problemType", EmitDefaultValue=false)]
        public ProblemTypeEnum? ProblemType { get; private set; }
        /// <summary>
        /// The type of Key Performance Indicator.
        /// </summary>
        /// <value>The type of Key Performance Indicator.</value>
        [DataMember(Name="kpiType", EmitDefaultValue=false)]
        public KpiTypeEnum? KpiType { get; private set; }
        /// <summary>
        /// Source of values for Key Performance Indicator.
        /// </summary>
        /// <value>Source of values for Key Performance Indicator.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; private set; }
        /// <summary>
        /// The status of the Key Performance Indicator.
        /// </summary>
        /// <value>The status of the Key Performance Indicator.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// The group the Key Performance Indicator belongs to.
        /// </summary>
        /// <value>The group the Key Performance Indicator belongs to.</value>
        [DataMember(Name="kpiGroup", EmitDefaultValue=false)]
        public KpiGroupEnum? KpiGroup { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPerformanceIndicator" /> class.
        /// </summary>
        public KeyPerformanceIndicator()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Key Performance Indicator.
        /// </summary>
        /// <value>The name of the Key Performance Indicator.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }







        /// <summary>
        /// DateTime indicating when the Key Performance Indicator was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>DateTime indicating when the Key Performance Indicator was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// DateTime indicating when the Key Performance Indicator was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>DateTime indicating when the Key Performance Indicator was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The description of the Key Performance Indicator.
        /// </summary>
        /// <value>The description of the Key Performance Indicator.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }







        /// <summary>
        /// Defines what wrap up codes are mapped to Key Performance Indicator.
        /// </summary>
        /// <value>Defines what wrap up codes are mapped to Key Performance Indicator.</value>
        [DataMember(Name="wrapUpCodeConfig", EmitDefaultValue=false)]
        public WrapUpCodeConfig WrapUpCodeConfig { get; private set; }



        /// <summary>
        /// Defines what outcome ids are mapped to Key Performance Indicator.
        /// </summary>
        /// <value>Defines what outcome ids are mapped to Key Performance Indicator.</value>
        [DataMember(Name="outcomeConfig", EmitDefaultValue=false)]
        public OutcomeConfig OutcomeConfig { get; private set; }







        /// <summary>
        /// Queue IDs on which KPI specification is used.
        /// </summary>
        /// <value>Queue IDs on which KPI specification is used.</value>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<string> Queues { get; private set; }



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
            sb.Append("class KeyPerformanceIndicator {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OptimizationType: ").Append(OptimizationType).Append("\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  KpiType: ").Append(KpiType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  WrapUpCodeConfig: ").Append(WrapUpCodeConfig).Append("\n");
            sb.Append("  OutcomeConfig: ").Append(OutcomeConfig).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  KpiGroup: ").Append(KpiGroup).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
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
            return this.Equals(obj as KeyPerformanceIndicator);
        }

        /// <summary>
        /// Returns true if KeyPerformanceIndicator instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyPerformanceIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyPerformanceIndicator other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.OptimizationType == other.OptimizationType ||
                    this.OptimizationType != null &&
                    this.OptimizationType.Equals(other.OptimizationType)
                ) &&
                (
                    this.ProblemType == other.ProblemType ||
                    this.ProblemType != null &&
                    this.ProblemType.Equals(other.ProblemType)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.KpiType == other.KpiType ||
                    this.KpiType != null &&
                    this.KpiType.Equals(other.KpiType)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.WrapUpCodeConfig == other.WrapUpCodeConfig ||
                    this.WrapUpCodeConfig != null &&
                    this.WrapUpCodeConfig.Equals(other.WrapUpCodeConfig)
                ) &&
                (
                    this.OutcomeConfig == other.OutcomeConfig ||
                    this.OutcomeConfig != null &&
                    this.OutcomeConfig.Equals(other.OutcomeConfig)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.KpiGroup == other.KpiGroup ||
                    this.KpiGroup != null &&
                    this.KpiGroup.Equals(other.KpiGroup)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.OptimizationType != null)
                    hash = hash * 59 + this.OptimizationType.GetHashCode();

                if (this.ProblemType != null)
                    hash = hash * 59 + this.ProblemType.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.KpiType != null)
                    hash = hash * 59 + this.KpiType.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.WrapUpCodeConfig != null)
                    hash = hash * 59 + this.WrapUpCodeConfig.GetHashCode();

                if (this.OutcomeConfig != null)
                    hash = hash * 59 + this.OutcomeConfig.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.KpiGroup != null)
                    hash = hash * 59 + this.KpiGroup.GetHashCode();

                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
