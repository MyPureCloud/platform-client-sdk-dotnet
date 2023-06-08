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
    /// OutcomeAttributionResultsResponse
    /// </summary>
    [DataContract]
    public partial class OutcomeAttributionResultsResponse :  IEquatable<OutcomeAttributionResultsResponse>
    {
        /// <summary>
        /// State of the Outcome Attribution entity.
        /// </summary>
        /// <value>State of the Outcome Attribution entity.</value>
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
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Valid for "Valid"
            /// </summary>
            [EnumMember(Value = "Valid")]
            Valid,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// State of the Outcome Attribution entity.
        /// </summary>
        /// <value>State of the Outcome Attribution entity.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeAttributionResultsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutcomeAttributionResultsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeAttributionResultsResponse" /> class.
        /// </summary>
        /// <param name="OutcomeId">ID of Outcome..</param>
        /// <param name="Index">The index/position of the OutcomeAttribution in the original POST request..</param>
        /// <param name="ExternalContactId">The external contact ID of the customer who achieved the outcome..</param>
        /// <param name="AssociatedValue">The total value associated with the customer's outcome..</param>
        /// <param name="State">State of the Outcome Attribution entity. (required).</param>
        /// <param name="Message">Additional information on the state of the Outcome Attribution entity. (required).</param>
        /// <param name="Touchpoints">List of interactions that led to this outcome being achieved..</param>
        /// <param name="CreatedDate">Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public OutcomeAttributionResultsResponse(string OutcomeId = null, int? Index = null, string ExternalContactId = null, double? AssociatedValue = null, StateEnum? State = null, string Message = null, List<TouchpointResponse> Touchpoints = null, DateTime? CreatedDate = null)
        {
            this.OutcomeId = OutcomeId;
            this.Index = Index;
            this.ExternalContactId = ExternalContactId;
            this.AssociatedValue = AssociatedValue;
            this.State = State;
            this.Message = Message;
            this.Touchpoints = Touchpoints;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// ID of Outcome.
        /// </summary>
        /// <value>ID of Outcome.</value>
        [DataMember(Name="outcomeId", EmitDefaultValue=false)]
        public string OutcomeId { get; set; }



        /// <summary>
        /// The index/position of the OutcomeAttribution in the original POST request.
        /// </summary>
        /// <value>The index/position of the OutcomeAttribution in the original POST request.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }



        /// <summary>
        /// The external contact ID of the customer who achieved the outcome.
        /// </summary>
        /// <value>The external contact ID of the customer who achieved the outcome.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// The total value associated with the customer's outcome.
        /// </summary>
        /// <value>The total value associated with the customer's outcome.</value>
        [DataMember(Name="associatedValue", EmitDefaultValue=false)]
        public double? AssociatedValue { get; set; }





        /// <summary>
        /// Additional information on the state of the Outcome Attribution entity.
        /// </summary>
        /// <value>Additional information on the state of the Outcome Attribution entity.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// List of interactions that led to this outcome being achieved.
        /// </summary>
        /// <value>List of interactions that led to this outcome being achieved.</value>
        [DataMember(Name="touchpoints", EmitDefaultValue=false)]
        public List<TouchpointResponse> Touchpoints { get; set; }



        /// <summary>
        /// Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomeAttributionResultsResponse {\n");

            sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Touchpoints: ").Append(Touchpoints).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(obj as OutcomeAttributionResultsResponse);
        }

        /// <summary>
        /// Returns true if OutcomeAttributionResultsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OutcomeAttributionResultsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeAttributionResultsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OutcomeId == other.OutcomeId ||
                    this.OutcomeId != null &&
                    this.OutcomeId.Equals(other.OutcomeId)
                ) &&
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.AssociatedValue == other.AssociatedValue ||
                    this.AssociatedValue != null &&
                    this.AssociatedValue.Equals(other.AssociatedValue)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Touchpoints == other.Touchpoints ||
                    this.Touchpoints != null &&
                    this.Touchpoints.SequenceEqual(other.Touchpoints)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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
                if (this.OutcomeId != null)
                    hash = hash * 59 + this.OutcomeId.GetHashCode();

                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.AssociatedValue != null)
                    hash = hash * 59 + this.AssociatedValue.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Touchpoints != null)
                    hash = hash * 59 + this.Touchpoints.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
