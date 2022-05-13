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
    /// ArchitectJobStateResponse
    /// </summary>
    [DataContract]
    public partial class ArchitectJobStateResponse :  IEquatable<ArchitectJobStateResponse>
    {
        /// <summary>
        /// Status of the Architect Job
        /// </summary>
        /// <value>Status of the Architect Job</value>
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
            /// Enum Registered for "Registered"
            /// </summary>
            [EnumMember(Value = "Registered")]
            Registered,
            
            /// <summary>
            /// Enum Started for "Started"
            /// </summary>
            [EnumMember(Value = "Started")]
            Started,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failure for "Failure"
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure
        }
        /// <summary>
        /// The command executed by the Architect Job
        /// </summary>
        /// <value>The command executed by the Architect Job</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CommandEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Publish for "Publish"
            /// </summary>
            [EnumMember(Value = "Publish")]
            Publish,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update
        }
        /// <summary>
        /// Status of the Architect Job
        /// </summary>
        /// <value>Status of the Architect Job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The command executed by the Architect Job
        /// </summary>
        /// <value>The command executed by the Architect Job</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public CommandEnum? Command { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectJobStateResponse" /> class.
        /// </summary>
        /// <param name="Flow">Flow created from the Architect Job.</param>
        /// <param name="Status">Status of the Architect Job.</param>
        /// <param name="Command">The command executed by the Architect Job.</param>
        /// <param name="Messages">Warnings and Errors messages of the Architect Job.</param>
        public ArchitectJobStateResponse(AddressableEntityRef Flow = null, StatusEnum? Status = null, CommandEnum? Command = null, List<ArchitectJobMessage> Messages = null)
        {
            this.Flow = Flow;
            this.Status = Status;
            this.Command = Command;
            this.Messages = Messages;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Flow created from the Architect Job
        /// </summary>
        /// <value>Flow created from the Architect Job</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public AddressableEntityRef Flow { get; set; }







        /// <summary>
        /// Warnings and Errors messages of the Architect Job
        /// </summary>
        /// <value>Warnings and Errors messages of the Architect Job</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ArchitectJobMessage> Messages { get; set; }



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
            sb.Append("class ArchitectJobStateResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(obj as ArchitectJobStateResponse);
        }

        /// <summary>
        /// Returns true if ArchitectJobStateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectJobStateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectJobStateResponse other)
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
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Command == other.Command ||
                    this.Command != null &&
                    this.Command.Equals(other.Command)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
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

                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Command != null)
                    hash = hash * 59 + this.Command.GetHashCode();

                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
