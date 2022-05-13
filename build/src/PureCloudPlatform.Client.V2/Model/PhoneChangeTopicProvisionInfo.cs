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
    /// PhoneChangeTopicProvisionInfo
    /// </summary>
    [DataContract]
    public partial class PhoneChangeTopicProvisionInfo :  IEquatable<PhoneChangeTopicProvisionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneChangeTopicProvisionInfo" /> class.
        /// </summary>
        /// <param name="Time">Time.</param>
        /// <param name="Source">Source.</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        public PhoneChangeTopicProvisionInfo(DateTime? Time = null, string Source = null, string ErrorInfo = null)
        {
            this.Time = Time;
            this.Source = Source;
            this.ErrorInfo = ErrorInfo;
            
        }
        


        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }



        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public string ErrorInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneChangeTopicProvisionInfo {\n");

            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
            return this.Equals(obj as PhoneChangeTopicProvisionInfo);
        }

        /// <summary>
        /// Returns true if PhoneChangeTopicProvisionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneChangeTopicProvisionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneChangeTopicProvisionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
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
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                return hash;
            }
        }
    }

}
