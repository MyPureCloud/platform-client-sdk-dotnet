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
    /// Check
    /// </summary>
    [DataContract]
    public partial class Check :  IEquatable<Check>
    {
        
        
        /// <summary>
        /// The result of a check executed. This indicates if the check was successful or not.
        /// </summary>
        /// <value>The result of a check executed. This indicates if the check was successful or not.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Passed for "Passed"
            /// </summary>
            [EnumMember(Value = "Passed")]
            Passed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Skipped for "Skipped"
            /// </summary>
            [EnumMember(Value = "Skipped")]
            Skipped,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        
        
        
        
        /// <summary>
        /// The type of check executed.
        /// </summary>
        /// <value>The type of check executed.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Handletimevalue for "HandleTimeValue"
            /// </summary>
            [EnumMember(Value = "HandleTimeValue")]
            Handletimevalue,
            
            /// <summary>
            /// Enum Transferratevalue for "TransferRateValue"
            /// </summary>
            [EnumMember(Value = "TransferRateValue")]
            Transferratevalue,
            
            /// <summary>
            /// Enum Interactionvolume for "InteractionVolume"
            /// </summary>
            [EnumMember(Value = "InteractionVolume")]
            Interactionvolume,
            
            /// <summary>
            /// Enum Uservariance for "UserVariance"
            /// </summary>
            [EnumMember(Value = "UserVariance")]
            Uservariance,
            
            /// <summary>
            /// Enum Datacoverage for "DataCoverage"
            /// </summary>
            [EnumMember(Value = "DataCoverage")]
            Datacoverage,
            
            /// <summary>
            /// Enum Modelquality for "ModelQuality"
            /// </summary>
            [EnumMember(Value = "ModelQuality")]
            Modelquality
        }
        
        
        
        
        
        /// <summary>
        /// The result of a check executed. This indicates if the check was successful or not.
        /// </summary>
        /// <value>The result of a check executed. This indicates if the check was successful or not.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ResultEnum? Result { get; set; }
        
        
        
        /// <summary>
        /// The type of check executed.
        /// </summary>
        /// <value>The type of check executed.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        public Check()
        {
            
        }
        
        
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Check {\n");
            
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Check);
        }

        /// <summary>
        /// Returns true if Check instances are equal
        /// </summary>
        /// <param name="other">Instance of Check to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Check other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }
    }

}
