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
    /// SplittingInformation
    /// </summary>
    [DataContract]
    public partial class SplittingInformation :  IEquatable<SplittingInformation>
    {
        /// <summary>
        /// The splitting criteria type
        /// </summary>
        /// <value>The splitting criteria type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CriteriaEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Percentage for "Percentage"
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage,
            
            /// <summary>
            /// Enum Quantity for "Quantity"
            /// </summary>
            [EnumMember(Value = "Quantity")]
            Quantity,
            
            /// <summary>
            /// Enum Column for "Column"
            /// </summary>
            [EnumMember(Value = "Column")]
            Column,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom
        }
        /// <summary>
        /// The splitting criteria type
        /// </summary>
        /// <value>The splitting criteria type</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public CriteriaEnum? Criteria { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplittingInformation" /> class.
        /// </summary>
        /// <param name="Criteria">The splitting criteria type.</param>
        /// <param name="CriteriaValue">The criteria value for the specified criteria type.</param>
        /// <param name="CreateRemainderContactList">Whether to create remainder contact list.</param>
        /// <param name="UseWaterfallRule">Whether to use waterfall rule.</param>
        public SplittingInformation(CriteriaEnum? Criteria = null, string CriteriaValue = null, bool? CreateRemainderContactList = null, bool? UseWaterfallRule = null)
        {
            this.Criteria = Criteria;
            this.CriteriaValue = CriteriaValue;
            this.CreateRemainderContactList = CreateRemainderContactList;
            this.UseWaterfallRule = UseWaterfallRule;
            
        }
        




        /// <summary>
        /// The criteria value for the specified criteria type
        /// </summary>
        /// <value>The criteria value for the specified criteria type</value>
        [DataMember(Name="criteriaValue", EmitDefaultValue=false)]
        public string CriteriaValue { get; set; }



        /// <summary>
        /// Whether to create remainder contact list
        /// </summary>
        /// <value>Whether to create remainder contact list</value>
        [DataMember(Name="createRemainderContactList", EmitDefaultValue=false)]
        public bool? CreateRemainderContactList { get; set; }



        /// <summary>
        /// Whether to use waterfall rule
        /// </summary>
        /// <value>Whether to use waterfall rule</value>
        [DataMember(Name="useWaterfallRule", EmitDefaultValue=false)]
        public bool? UseWaterfallRule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplittingInformation {\n");

            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  CriteriaValue: ").Append(CriteriaValue).Append("\n");
            sb.Append("  CreateRemainderContactList: ").Append(CreateRemainderContactList).Append("\n");
            sb.Append("  UseWaterfallRule: ").Append(UseWaterfallRule).Append("\n");
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
            return this.Equals(obj as SplittingInformation);
        }

        /// <summary>
        /// Returns true if SplittingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of SplittingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplittingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.Equals(other.Criteria)
                ) &&
                (
                    this.CriteriaValue == other.CriteriaValue ||
                    this.CriteriaValue != null &&
                    this.CriteriaValue.Equals(other.CriteriaValue)
                ) &&
                (
                    this.CreateRemainderContactList == other.CreateRemainderContactList ||
                    this.CreateRemainderContactList != null &&
                    this.CreateRemainderContactList.Equals(other.CreateRemainderContactList)
                ) &&
                (
                    this.UseWaterfallRule == other.UseWaterfallRule ||
                    this.UseWaterfallRule != null &&
                    this.UseWaterfallRule.Equals(other.UseWaterfallRule)
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
                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                if (this.CriteriaValue != null)
                    hash = hash * 59 + this.CriteriaValue.GetHashCode();

                if (this.CreateRemainderContactList != null)
                    hash = hash * 59 + this.CreateRemainderContactList.GetHashCode();

                if (this.UseWaterfallRule != null)
                    hash = hash * 59 + this.UseWaterfallRule.GetHashCode();

                return hash;
            }
        }
    }

}
