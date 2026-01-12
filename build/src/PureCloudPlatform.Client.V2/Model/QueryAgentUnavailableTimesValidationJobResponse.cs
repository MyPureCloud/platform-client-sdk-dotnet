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
    /// QueryAgentUnavailableTimesValidationJobResponse
    /// </summary>
    [DataContract]
    public partial class QueryAgentUnavailableTimesValidationJobResponse :  IEquatable<QueryAgentUnavailableTimesValidationJobResponse>
    {
        /// <summary>
        /// Status of the job
        /// </summary>
        /// <value>Status of the job</value>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Status of the job
        /// </summary>
        /// <value>Status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentUnavailableTimesValidationJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryAgentUnavailableTimesValidationJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentUnavailableTimesValidationJobResponse" /> class.
        /// </summary>
        /// <param name="Agent">The agent who started the job (required).</param>
        /// <param name="Status">Status of the job (required).</param>
        /// <param name="Result">Validation results if status &#x3D;&#x3D; &#39;Complete&#39;.</param>
        /// <param name="Error">Error details if status &#x3D;&#x3D; &#39;Error&#39;. The error occurs if the validation job has failed.</param>
        public QueryAgentUnavailableTimesValidationJobResponse(UserReference Agent = null, StatusEnum? Status = null, UnavailableTimesValidationResult Result = null, ErrorBody Error = null)
        {
            this.Agent = Agent;
            this.Status = Status;
            this.Result = Result;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The agent who started the job
        /// </summary>
        /// <value>The agent who started the job</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public UserReference Agent { get; set; }





        /// <summary>
        /// Validation results if status &#x3D;&#x3D; &#39;Complete&#39;
        /// </summary>
        /// <value>Validation results if status &#x3D;&#x3D; &#39;Complete&#39;</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public UnavailableTimesValidationResult Result { get; set; }



        /// <summary>
        /// Error details if status &#x3D;&#x3D; &#39;Error&#39;. The error occurs if the validation job has failed
        /// </summary>
        /// <value>Error details if status &#x3D;&#x3D; &#39;Error&#39;. The error occurs if the validation job has failed</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }



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
            sb.Append("class QueryAgentUnavailableTimesValidationJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as QueryAgentUnavailableTimesValidationJobResponse);
        }

        /// <summary>
        /// Returns true if QueryAgentUnavailableTimesValidationJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryAgentUnavailableTimesValidationJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAgentUnavailableTimesValidationJobResponse other)
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
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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

                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
