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
    /// CreateAdherenceAdjustmentsReasonCodeRequest
    /// </summary>
    [DataContract]
    public partial class CreateAdherenceAdjustmentsReasonCodeRequest :  IEquatable<CreateAdherenceAdjustmentsReasonCodeRequest>
    {
        /// <summary>
        /// The state of the reason code
        /// </summary>
        /// <value>The state of the reason code</value>
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
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive
        }
        /// <summary>
        /// The state of the reason code
        /// </summary>
        /// <value>The state of the reason code</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdherenceAdjustmentsReasonCodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAdherenceAdjustmentsReasonCodeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdherenceAdjustmentsReasonCodeRequest" /> class.
        /// </summary>
        /// <param name="Name">The display name of the reason code (required).</param>
        /// <param name="State">The state of the reason code (required).</param>
        public CreateAdherenceAdjustmentsReasonCodeRequest(string Name = null, StateEnum? State = null)
        {
            this.Name = Name;
            this.State = State;
            
        }
        


        /// <summary>
        /// The display name of the reason code
        /// </summary>
        /// <value>The display name of the reason code</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAdherenceAdjustmentsReasonCodeRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as CreateAdherenceAdjustmentsReasonCodeRequest);
        }

        /// <summary>
        /// Returns true if CreateAdherenceAdjustmentsReasonCodeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateAdherenceAdjustmentsReasonCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAdherenceAdjustmentsReasonCodeRequest other)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                return hash;
            }
        }
    }

}
