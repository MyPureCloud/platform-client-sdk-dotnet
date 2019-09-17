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
    /// RuleSetDiagnostic
    /// </summary>
    [DataContract]
    public partial class RuleSetDiagnostic :  IEquatable<RuleSetDiagnostic>
    {
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WarningsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum WrapupCodeNotInQueue for "WRAPUP_CODE_NOT_IN_QUEUE"
            /// </summary>
            [EnumMember(Value = "WRAPUP_CODE_NOT_IN_QUEUE")]
            WrapupCodeNotInQueue,
            
            /// <summary>
            /// Enum ContactAttributeNotInContactList for "CONTACT_ATTRIBUTE_NOT_IN_CONTACT_LIST"
            /// </summary>
            [EnumMember(Value = "CONTACT_ATTRIBUTE_NOT_IN_CONTACT_LIST")]
            ContactAttributeNotInContactList,
            
            /// <summary>
            /// Enum NoDncListForAppend for "NO_DNC_LIST_FOR_APPEND"
            /// </summary>
            [EnumMember(Value = "NO_DNC_LIST_FOR_APPEND")]
            NoDncListForAppend,
            
            /// <summary>
            /// Enum PhoneConditionsWithMulticolumnPreview for "PHONE_CONDITIONS_WITH_MULTICOLUMN_PREVIEW"
            /// </summary>
            [EnumMember(Value = "PHONE_CONDITIONS_WITH_MULTICOLUMN_PREVIEW")]
            PhoneConditionsWithMulticolumnPreview
        }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSetDiagnostic" /> class.
        /// </summary>
        /// <param name="RuleSet">A campaign rule set.</param>
        /// <param name="Warnings">Diagnostic warnings for the rule set.</param>
        public RuleSetDiagnostic(DomainEntityRef RuleSet = null, List<WarningsEnum> Warnings = null)
        {
            this.RuleSet = RuleSet;
            this.Warnings = Warnings;
            
        }
        
        
        
        /// <summary>
        /// A campaign rule set
        /// </summary>
        /// <value>A campaign rule set</value>
        [DataMember(Name="ruleSet", EmitDefaultValue=false)]
        public DomainEntityRef RuleSet { get; set; }
        
        
        
        /// <summary>
        /// Diagnostic warnings for the rule set
        /// </summary>
        /// <value>Diagnostic warnings for the rule set</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<WarningsEnum> Warnings { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleSetDiagnostic {\n");
            
            sb.Append("  RuleSet: ").Append(RuleSet).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(obj as RuleSetDiagnostic);
        }

        /// <summary>
        /// Returns true if RuleSetDiagnostic instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleSetDiagnostic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleSetDiagnostic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RuleSet == other.RuleSet ||
                    this.RuleSet != null &&
                    this.RuleSet.Equals(other.RuleSet)
                ) &&
                (
                    this.Warnings == other.Warnings ||
                    this.Warnings != null &&
                    this.Warnings.SequenceEqual(other.Warnings)
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
                
                if (this.RuleSet != null)
                    hash = hash * 59 + this.RuleSet.GetHashCode();
                
                if (this.Warnings != null)
                    hash = hash * 59 + this.Warnings.GetHashCode();
                
                return hash;
            }
        }
    }

}
