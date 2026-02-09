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
    /// InactivityTimeoutGroupBundle
    /// </summary>
    [DataContract]
    public partial class InactivityTimeoutGroupBundle :  IEquatable<InactivityTimeoutGroupBundle>
    {
        /// <summary>
        /// The unit for the timeout (MINUTES or HOURS).
        /// </summary>
        /// <value>The unit for the timeout (MINUTES or HOURS).</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InactivityTimeoutUnitEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Minutes for "Minutes"
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes,
            
            /// <summary>
            /// Enum Hours for "Hours"
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours
        }
        /// <summary>
        /// The unit for the timeout (MINUTES or HOURS).
        /// </summary>
        /// <value>The unit for the timeout (MINUTES or HOURS).</value>
        [DataMember(Name="inactivityTimeoutUnit", EmitDefaultValue=false)]
        public InactivityTimeoutUnitEnum? InactivityTimeoutUnit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InactivityTimeoutGroupBundle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InactivityTimeoutGroupBundle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InactivityTimeoutGroupBundle" /> class.
        /// </summary>
        /// <param name="Priority">The priority of the group bundle (1-5). (required).</param>
        /// <param name="TimeoutSeconds">The timeout value in seconds (300 to 28800, representing 5 to 480 minutes). (required).</param>
        /// <param name="InactivityTimeoutUnit">The unit for the timeout (MINUTES or HOURS)..</param>
        /// <param name="Groups">The list of group IDs to select. (required).</param>
        public InactivityTimeoutGroupBundle(int? Priority = null, int? TimeoutSeconds = null, InactivityTimeoutUnitEnum? InactivityTimeoutUnit = null, List<string> Groups = null)
        {
            this.Priority = Priority;
            this.TimeoutSeconds = TimeoutSeconds;
            this.InactivityTimeoutUnit = InactivityTimeoutUnit;
            this.Groups = Groups;
            
        }
        


        /// <summary>
        /// The priority of the group bundle (1-5).
        /// </summary>
        /// <value>The priority of the group bundle (1-5).</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// The timeout value in seconds (300 to 28800, representing 5 to 480 minutes).
        /// </summary>
        /// <value>The timeout value in seconds (300 to 28800, representing 5 to 480 minutes).</value>
        [DataMember(Name="timeoutSeconds", EmitDefaultValue=false)]
        public int? TimeoutSeconds { get; set; }





        /// <summary>
        /// The list of group IDs to select.
        /// </summary>
        /// <value>The list of group IDs to select.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InactivityTimeoutGroupBundle {\n");

            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  InactivityTimeoutUnit: ").Append(InactivityTimeoutUnit).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(obj as InactivityTimeoutGroupBundle);
        }

        /// <summary>
        /// Returns true if InactivityTimeoutGroupBundle instances are equal
        /// </summary>
        /// <param name="other">Instance of InactivityTimeoutGroupBundle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InactivityTimeoutGroupBundle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.TimeoutSeconds == other.TimeoutSeconds ||
                    this.TimeoutSeconds != null &&
                    this.TimeoutSeconds.Equals(other.TimeoutSeconds)
                ) &&
                (
                    this.InactivityTimeoutUnit == other.InactivityTimeoutUnit ||
                    this.InactivityTimeoutUnit != null &&
                    this.InactivityTimeoutUnit.Equals(other.InactivityTimeoutUnit)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
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
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.TimeoutSeconds != null)
                    hash = hash * 59 + this.TimeoutSeconds.GetHashCode();

                if (this.InactivityTimeoutUnit != null)
                    hash = hash * 59 + this.InactivityTimeoutUnit.GetHashCode();

                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();

                return hash;
            }
        }
    }

}
