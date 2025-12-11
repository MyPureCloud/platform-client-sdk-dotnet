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
    /// CreateKpiRequest
    /// </summary>
    [DataContract]
    public partial class CreateKpiRequest :  IEquatable<CreateKpiRequest>
    {
        /// <summary>
        /// The type of the Key Performance Indicator.
        /// </summary>
        /// <value>The type of the Key Performance Indicator.</value>
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
            Salesvalue
        }
        /// <summary>
        /// The source of the Key Performance Indicator.
        /// </summary>
        /// <value>The source of the Key Performance Indicator.</value>
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
        /// The type of the Key Performance Indicator.
        /// </summary>
        /// <value>The type of the Key Performance Indicator.</value>
        [DataMember(Name="kpiType", EmitDefaultValue=false)]
        public KpiTypeEnum? KpiType { get; set; }
        /// <summary>
        /// The source of the Key Performance Indicator.
        /// </summary>
        /// <value>The source of the Key Performance Indicator.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKpiRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateKpiRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKpiRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Key Performance Indicator. (required).</param>
        /// <param name="Description">The description of the Key Performance Indicator..</param>
        /// <param name="KpiType">The type of the Key Performance Indicator. (required).</param>
        /// <param name="WrapUpCodeConfig">Defines what wrap up codes are mapped to Key Performance Indicator..</param>
        /// <param name="Source">The source of the Key Performance Indicator. (required).</param>
        public CreateKpiRequest(string Name = null, string Description = null, KpiTypeEnum? KpiType = null, WrapUpCodeConfig WrapUpCodeConfig = null, SourceEnum? Source = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.KpiType = KpiType;
            this.WrapUpCodeConfig = WrapUpCodeConfig;
            this.Source = Source;
            
        }
        


        /// <summary>
        /// The name of the Key Performance Indicator.
        /// </summary>
        /// <value>The name of the Key Performance Indicator.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the Key Performance Indicator.
        /// </summary>
        /// <value>The description of the Key Performance Indicator.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// Defines what wrap up codes are mapped to Key Performance Indicator.
        /// </summary>
        /// <value>Defines what wrap up codes are mapped to Key Performance Indicator.</value>
        [DataMember(Name="wrapUpCodeConfig", EmitDefaultValue=false)]
        public WrapUpCodeConfig WrapUpCodeConfig { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKpiRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  KpiType: ").Append(KpiType).Append("\n");
            sb.Append("  WrapUpCodeConfig: ").Append(WrapUpCodeConfig).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as CreateKpiRequest);
        }

        /// <summary>
        /// Returns true if CreateKpiRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateKpiRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateKpiRequest other)
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
                    this.WrapUpCodeConfig == other.WrapUpCodeConfig ||
                    this.WrapUpCodeConfig != null &&
                    this.WrapUpCodeConfig.Equals(other.WrapUpCodeConfig)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.KpiType != null)
                    hash = hash * 59 + this.KpiType.GetHashCode();

                if (this.WrapUpCodeConfig != null)
                    hash = hash * 59 + this.WrapUpCodeConfig.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                return hash;
            }
        }
    }

}
