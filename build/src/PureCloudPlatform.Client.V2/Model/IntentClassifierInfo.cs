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
    /// IntentClassifierInfo
    /// </summary>
    [DataContract]
    public partial class IntentClassifierInfo :  IEquatable<IntentClassifierInfo>
    {
        /// <summary>
        /// The intent classifier state
        /// </summary>
        /// <value>The intent classifier state</value>
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
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Testready for "TestReady"
            /// </summary>
            [EnumMember(Value = "TestReady")]
            Testready,
            
            /// <summary>
            /// Enum Productionready for "ProductionReady"
            /// </summary>
            [EnumMember(Value = "ProductionReady")]
            Productionready
        }
        /// <summary>
        /// The intent classifier state
        /// </summary>
        /// <value>The intent classifier state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntentClassifierInfo" /> class.
        /// </summary>
        /// <param name="ClassifierId">The intent classifier ID.</param>
        /// <param name="Version">The intent classifier version.</param>
        /// <param name="State">The intent classifier state.</param>
        public IntentClassifierInfo(string ClassifierId = null, string Version = null, StateEnum? State = null)
        {
            this.ClassifierId = ClassifierId;
            this.Version = Version;
            this.State = State;
            
        }
        


        /// <summary>
        /// The intent classifier ID
        /// </summary>
        /// <value>The intent classifier ID</value>
        [DataMember(Name="classifierId", EmitDefaultValue=false)]
        public string ClassifierId { get; set; }



        /// <summary>
        /// The intent classifier version
        /// </summary>
        /// <value>The intent classifier version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntentClassifierInfo {\n");

            sb.Append("  ClassifierId: ").Append(ClassifierId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as IntentClassifierInfo);
        }

        /// <summary>
        /// Returns true if IntentClassifierInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of IntentClassifierInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntentClassifierInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ClassifierId == other.ClassifierId ||
                    this.ClassifierId != null &&
                    this.ClassifierId.Equals(other.ClassifierId)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.ClassifierId != null)
                    hash = hash * 59 + this.ClassifierId.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                return hash;
            }
        }
    }

}
