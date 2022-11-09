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
    /// PredictorModelRetrainingError
    /// </summary>
    [DataContract]
    public partial class PredictorModelRetrainingError :  IEquatable<PredictorModelRetrainingError>
    {
        /// <summary>
        /// Error code describing model training failure.
        /// </summary>
        /// <value>Error code describing model training failure.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Notenoughdata for "NotEnoughData"
            /// </summary>
            [EnumMember(Value = "NotEnoughData")]
            Notenoughdata,
            
            /// <summary>
            /// Enum Serviceerror for "ServiceError"
            /// </summary>
            [EnumMember(Value = "ServiceError")]
            Serviceerror,
            
            /// <summary>
            /// Enum Unknownerror for "UnknownError"
            /// </summary>
            [EnumMember(Value = "UnknownError")]
            Unknownerror
        }
        /// <summary>
        /// Error code describing model training failure.
        /// </summary>
        /// <value>Error code describing model training failure.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictorModelRetrainingError" /> class.
        /// </summary>
        public PredictorModelRetrainingError()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// Date when the first retraining failure happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the first retraining failure happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateOfFirstOccurrence", EmitDefaultValue=false)]
        public DateTime? DateOfFirstOccurrence { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictorModelRetrainingError {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  DateOfFirstOccurrence: ").Append(DateOfFirstOccurrence).Append("\n");
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
            return this.Equals(obj as PredictorModelRetrainingError);
        }

        /// <summary>
        /// Returns true if PredictorModelRetrainingError instances are equal
        /// </summary>
        /// <param name="other">Instance of PredictorModelRetrainingError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictorModelRetrainingError other)
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
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.DateOfFirstOccurrence == other.DateOfFirstOccurrence ||
                    this.DateOfFirstOccurrence != null &&
                    this.DateOfFirstOccurrence.Equals(other.DateOfFirstOccurrence)
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

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.DateOfFirstOccurrence != null)
                    hash = hash * 59 + this.DateOfFirstOccurrence.GetHashCode();

                return hash;
            }
        }
    }

}
