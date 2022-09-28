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
    /// PredictorModel
    /// </summary>
    [DataContract]
    public partial class PredictorModel :  IEquatable<PredictorModel>
    {
        /// <summary>
        /// The media type of the model.
        /// </summary>
        /// <value>The media type of the model.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        /// <summary>
        /// The media type of the model.
        /// </summary>
        /// <value>The media type of the model.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictorModel" /> class.
        /// </summary>
        /// <param name="Features">Features.</param>
        public PredictorModel(List<PredictorModelFeature> Features = null)
        {
            this.Features = Features;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The key performance indicator used in the model.
        /// </summary>
        /// <value>The key performance indicator used in the model.</value>
        [DataMember(Name="kpi", EmitDefaultValue=false)]
        public string Kpi { get; private set; }



        /// <summary>
        /// The List of Queues that are assessed for Predictive Routing.
        /// </summary>
        /// <value>The List of Queues that are assessed for Predictive Routing.</value>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Queues { get; private set; }



        /// <summary>
        /// DateTime indicating when the model was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>DateTime indicating when the model was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// DateTime indicating when the model was last trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>DateTime indicating when the model was last trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateTrained", EmitDefaultValue=false)]
        public DateTime? DateTrained { get; private set; }





        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<PredictorModelFeature> Features { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictorModel {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Kpi: ").Append(Kpi).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateTrained: ").Append(DateTrained).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(obj as PredictorModel);
        }

        /// <summary>
        /// Returns true if PredictorModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PredictorModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictorModel other)
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
                    this.Kpi == other.Kpi ||
                    this.Kpi != null &&
                    this.Kpi.Equals(other.Kpi)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateTrained == other.DateTrained ||
                    this.DateTrained != null &&
                    this.DateTrained.Equals(other.DateTrained)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
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

                if (this.Kpi != null)
                    hash = hash * 59 + this.Kpi.GetHashCode();

                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateTrained != null)
                    hash = hash * 59 + this.DateTrained.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();

                return hash;
            }
        }
    }

}
