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
    /// PredictedAnswer
    /// </summary>
    [DataContract]
    public partial class PredictedAnswer :  IEquatable<PredictedAnswer>
    {
        /// <summary>
        /// Describes the type of error associated with the predicted answer.
        /// </summary>
        /// <value>Describes the type of error associated with the predicted answer.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FailureTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Lowconfidenceerror for "LowConfidenceError"
            /// </summary>
            [EnumMember(Value = "LowConfidenceError")]
            Lowconfidenceerror,
            
            /// <summary>
            /// Enum Parsingerror for "ParsingError"
            /// </summary>
            [EnumMember(Value = "ParsingError")]
            Parsingerror,
            
            /// <summary>
            /// Enum Serviceerror for "ServiceError"
            /// </summary>
            [EnumMember(Value = "ServiceError")]
            Serviceerror
        }
        /// <summary>
        /// Describes the type of error associated with the predicted answer.
        /// </summary>
        /// <value>Describes the type of error associated with the predicted answer.</value>
        [DataMember(Name="failureType", EmitDefaultValue=false)]
        public FailureTypeEnum? FailureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictedAnswer" /> class.
        /// </summary>
        /// <param name="AnswerId">The unique identifier of the suggested predicted answer..</param>
        /// <param name="Explanation">An explanation providing the reasoning behind the suggested answer..</param>
        /// <param name="FailureType">Describes the type of error associated with the predicted answer..</param>
        public PredictedAnswer(string AnswerId = null, string Explanation = null, FailureTypeEnum? FailureType = null)
        {
            this.AnswerId = AnswerId;
            this.Explanation = Explanation;
            this.FailureType = FailureType;
            
        }
        


        /// <summary>
        /// The unique identifier of the suggested predicted answer.
        /// </summary>
        /// <value>The unique identifier of the suggested predicted answer.</value>
        [DataMember(Name="answerId", EmitDefaultValue=false)]
        public string AnswerId { get; set; }



        /// <summary>
        /// An explanation providing the reasoning behind the suggested answer.
        /// </summary>
        /// <value>An explanation providing the reasoning behind the suggested answer.</value>
        [DataMember(Name="explanation", EmitDefaultValue=false)]
        public string Explanation { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictedAnswer {\n");

            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
            sb.Append("  FailureType: ").Append(FailureType).Append("\n");
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
            return this.Equals(obj as PredictedAnswer);
        }

        /// <summary>
        /// Returns true if PredictedAnswer instances are equal
        /// </summary>
        /// <param name="other">Instance of PredictedAnswer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictedAnswer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AnswerId == other.AnswerId ||
                    this.AnswerId != null &&
                    this.AnswerId.Equals(other.AnswerId)
                ) &&
                (
                    this.Explanation == other.Explanation ||
                    this.Explanation != null &&
                    this.Explanation.Equals(other.Explanation)
                ) &&
                (
                    this.FailureType == other.FailureType ||
                    this.FailureType != null &&
                    this.FailureType.Equals(other.FailureType)
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
                if (this.AnswerId != null)
                    hash = hash * 59 + this.AnswerId.GetHashCode();

                if (this.Explanation != null)
                    hash = hash * 59 + this.Explanation.GetHashCode();

                if (this.FailureType != null)
                    hash = hash * 59 + this.FailureType.GetHashCode();

                return hash;
            }
        }
    }

}
