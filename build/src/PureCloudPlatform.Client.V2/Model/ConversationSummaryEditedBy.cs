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
    /// ConversationSummaryEditedBy
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryEditedBy :  IEquatable<ConversationSummaryEditedBy>
    {
        /// <summary>
        /// The participant purpose of the user.
        /// </summary>
        /// <value>The participant purpose of the user.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Acd for "Acd"
            /// </summary>
            [EnumMember(Value = "Acd")]
            Acd,
            
            /// <summary>
            /// Enum Agent for "Agent"
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer,
            
            /// <summary>
            /// Enum Workflow for "Workflow"
            /// </summary>
            [EnumMember(Value = "Workflow")]
            Workflow
        }
        /// <summary>
        /// The participant purpose of the user.
        /// </summary>
        /// <value>The participant purpose of the user.</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum? Purpose { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryEditedBy" /> class.
        /// </summary>
        /// <param name="User">The user that edited the summary..</param>
        /// <param name="Purpose">The participant purpose of the user..</param>
        public ConversationSummaryEditedBy(AddressableEntityRef User = null, PurposeEnum? Purpose = null)
        {
            this.User = User;
            this.Purpose = Purpose;
            
        }
        


        /// <summary>
        /// The user that edited the summary.
        /// </summary>
        /// <value>The user that edited the summary.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryEditedBy {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
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
            return this.Equals(obj as ConversationSummaryEditedBy);
        }

        /// <summary>
        /// Returns true if ConversationSummaryEditedBy instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryEditedBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryEditedBy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                return hash;
            }
        }
    }

}
