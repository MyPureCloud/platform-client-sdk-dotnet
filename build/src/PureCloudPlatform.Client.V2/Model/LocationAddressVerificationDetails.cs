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
    /// LocationAddressVerificationDetails
    /// </summary>
    [DataContract]
    public partial class LocationAddressVerificationDetails :  IEquatable<LocationAddressVerificationDetails>
    {
        /// <summary>
        /// Status of address verification process
        /// </summary>
        /// <value>Status of address verification process</value>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Retry for "Retry"
            /// </summary>
            [EnumMember(Value = "Retry")]
            Retry,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// Status of address verification process
        /// </summary>
        /// <value>Status of address verification process</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAddressVerificationDetails" /> class.
        /// </summary>
        /// <param name="Status">Status of address verification process.</param>
        /// <param name="DateFinished">Finished time of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateStarted">Time started of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Service">Third party service used for address verification.</param>
        public LocationAddressVerificationDetails(StatusEnum? Status = null, DateTime? DateFinished = null, DateTime? DateStarted = null, string Service = null)
        {
            this.Status = Status;
            this.DateFinished = DateFinished;
            this.DateStarted = DateStarted;
            this.Service = Service;
            
        }
        




        /// <summary>
        /// Finished time of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Finished time of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateFinished", EmitDefaultValue=false)]
        public DateTime? DateFinished { get; set; }



        /// <summary>
        /// Time started of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Time started of address verification process. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStarted", EmitDefaultValue=false)]
        public DateTime? DateStarted { get; set; }



        /// <summary>
        /// Third party service used for address verification
        /// </summary>
        /// <value>Third party service used for address verification</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationAddressVerificationDetails {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateFinished: ").Append(DateFinished).Append("\n");
            sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
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
            return this.Equals(obj as LocationAddressVerificationDetails);
        }

        /// <summary>
        /// Returns true if LocationAddressVerificationDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationAddressVerificationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationAddressVerificationDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DateFinished == other.DateFinished ||
                    this.DateFinished != null &&
                    this.DateFinished.Equals(other.DateFinished)
                ) &&
                (
                    this.DateStarted == other.DateStarted ||
                    this.DateStarted != null &&
                    this.DateStarted.Equals(other.DateStarted)
                ) &&
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.DateFinished != null)
                    hash = hash * 59 + this.DateFinished.GetHashCode();

                if (this.DateStarted != null)
                    hash = hash * 59 + this.DateStarted.GetHashCode();

                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();

                return hash;
            }
        }
    }

}
