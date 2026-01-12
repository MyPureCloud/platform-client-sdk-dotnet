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
    /// AssistantQueueUsersJobsRequest
    /// </summary>
    [DataContract]
    public partial class AssistantQueueUsersJobsRequest :  IEquatable<AssistantQueueUsersJobsRequest>
    {
        /// <summary>
        /// Action to perform by the job.
        /// </summary>
        /// <value>Action to perform by the job.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Autoassignment for "AutoAssignment"
            /// </summary>
            [EnumMember(Value = "AutoAssignment")]
            Autoassignment,
            
            /// <summary>
            /// Enum Manualassignment for "ManualAssignment"
            /// </summary>
            [EnumMember(Value = "ManualAssignment")]
            Manualassignment
        }
        /// <summary>
        /// Action to perform by the job.
        /// </summary>
        /// <value>Action to perform by the job.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantQueueUsersJobsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssistantQueueUsersJobsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantQueueUsersJobsRequest" /> class.
        /// </summary>
        /// <param name="Action">Action to perform by the job. (required).</param>
        public AssistantQueueUsersJobsRequest(ActionEnum? Action = null)
        {
            this.Action = Action;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistantQueueUsersJobsRequest {\n");

            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as AssistantQueueUsersJobsRequest);
        }

        /// <summary>
        /// Returns true if AssistantQueueUsersJobsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AssistantQueueUsersJobsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssistantQueueUsersJobsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                return hash;
            }
        }
    }

}
