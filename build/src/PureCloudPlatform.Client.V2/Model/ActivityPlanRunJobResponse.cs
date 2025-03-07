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
    /// ActivityPlanRunJobResponse
    /// </summary>
    [DataContract]
    public partial class ActivityPlanRunJobResponse :  IEquatable<ActivityPlanRunJobResponse>
    {
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
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
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanRunJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanRunJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanRunJobResponse" /> class.
        /// </summary>
        /// <param name="ActivityPlan">The activity plan associated with this job (required).</param>
        /// <param name="Status">The status of the job (required).</param>
        /// <param name="Exceptions">The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing (required).</param>
        /// <param name="Error">Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete.</param>
        public ActivityPlanRunJobResponse(ActivityPlanReference ActivityPlan = null, StatusEnum? Status = null, List<ActivityPlanJobException> Exceptions = null, ErrorBody Error = null)
        {
            this.ActivityPlan = ActivityPlan;
            this.Status = Status;
            this.Exceptions = Exceptions;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The activity plan associated with this job
        /// </summary>
        /// <value>The activity plan associated with this job</value>
        [DataMember(Name="activityPlan", EmitDefaultValue=false)]
        public ActivityPlanReference ActivityPlan { get; set; }





        /// <summary>
        /// The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing
        /// </summary>
        /// <value>The list of exceptions that occurred while running this activity plan job. These are exceptions that affect individual occurrences but didn&#39;t prevent the job from completing</value>
        [DataMember(Name="exceptions", EmitDefaultValue=false)]
        public List<ActivityPlanJobException> Exceptions { get; set; }



        /// <summary>
        /// Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete
        /// </summary>
        /// <value>Error details if status &#x3D;&#x3D; &#39;Error&#39;. These are errors that caused the job to fail to complete</value>
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
            sb.Append("class ActivityPlanRunJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActivityPlan: ").Append(ActivityPlan).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
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
            return this.Equals(obj as ActivityPlanRunJobResponse);
        }

        /// <summary>
        /// Returns true if ActivityPlanRunJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanRunJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanRunJobResponse other)
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
                    this.ActivityPlan == other.ActivityPlan ||
                    this.ActivityPlan != null &&
                    this.ActivityPlan.Equals(other.ActivityPlan)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Exceptions == other.Exceptions ||
                    this.Exceptions != null &&
                    this.Exceptions.SequenceEqual(other.Exceptions)
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

                if (this.ActivityPlan != null)
                    hash = hash * 59 + this.ActivityPlan.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Exceptions != null)
                    hash = hash * 59 + this.Exceptions.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
