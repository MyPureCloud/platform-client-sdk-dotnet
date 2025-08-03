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
    /// CreateReprocessJobRequest
    /// </summary>
    [DataContract]
    public partial class CreateReprocessJobRequest :  IEquatable<CreateReprocessJobRequest>
    {
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReprocessJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateReprocessJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReprocessJobRequest" /> class.
        /// </summary>
        /// <param name="Name">The name given for the job. (required).</param>
        /// <param name="Description">The description of the job..</param>
        /// <param name="DateStart">The start date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateEnd">The end date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Programs">A list of program IDs to filter conversations by. (required).</param>
        /// <param name="MediaTypes">The types of conversations to reprocess. (required).</param>
        /// <param name="Dialects">The dialects to filter by the conversations..</param>
        public CreateReprocessJobRequest(string Name = null, string Description = null, DateTime? DateStart = null, DateTime? DateEnd = null, List<string> Programs = null, List<MediaTypesEnum> MediaTypes = null, List<string> Dialects = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Programs = Programs;
            this.MediaTypes = MediaTypes;
            this.Dialects = Dialects;
            
        }
        


        /// <summary>
        /// The name given for the job.
        /// </summary>
        /// <value>The name given for the job.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the job.
        /// </summary>
        /// <value>The description of the job.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The start date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// The end date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end date for the search criteria. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }



        /// <summary>
        /// A list of program IDs to filter conversations by.
        /// </summary>
        /// <value>A list of program IDs to filter conversations by.</value>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public List<string> Programs { get; set; }



        /// <summary>
        /// The types of conversations to reprocess.
        /// </summary>
        /// <value>The types of conversations to reprocess.</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }



        /// <summary>
        /// The dialects to filter by the conversations.
        /// </summary>
        /// <value>The dialects to filter by the conversations.</value>
        [DataMember(Name="dialects", EmitDefaultValue=false)]
        public List<string> Dialects { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReprocessJobRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  Dialects: ").Append(Dialects).Append("\n");
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
            return this.Equals(obj as CreateReprocessJobRequest);
        }

        /// <summary>
        /// Returns true if CreateReprocessJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateReprocessJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReprocessJobRequest other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.Programs == other.Programs ||
                    this.Programs != null &&
                    this.Programs.SequenceEqual(other.Programs)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.Dialects == other.Dialects ||
                    this.Dialects != null &&
                    this.Dialects.SequenceEqual(other.Dialects)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.Programs != null)
                    hash = hash * 59 + this.Programs.GetHashCode();

                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                if (this.Dialects != null)
                    hash = hash * 59 + this.Dialects.GetHashCode();

                return hash;
            }
        }
    }

}
