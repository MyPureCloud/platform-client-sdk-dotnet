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
    /// OutboundDomain
    /// </summary>
    [DataContract]
    public partial class OutboundDomain :  IEquatable<OutboundDomain>
    {
        /// <summary>
        /// Sender Type
        /// </summary>
        /// <value>Sender Type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SenderTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Emaildomain for "EmailDomain"
            /// </summary>
            [EnumMember(Value = "EmailDomain")]
            Emaildomain,
            
            /// <summary>
            /// Enum Mockemaildomain for "MockEmailDomain"
            /// </summary>
            [EnumMember(Value = "MockEmailDomain")]
            Mockemaildomain,
            
            /// <summary>
            /// Enum Emailsmtpdomain for "EmailSmtpDomain"
            /// </summary>
            [EnumMember(Value = "EmailSmtpDomain")]
            Emailsmtpdomain
        }
        /// <summary>
        /// Sender Type
        /// </summary>
        /// <value>Sender Type</value>
        [DataMember(Name="senderType", EmitDefaultValue=false)]
        public SenderTypeEnum? SenderType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundDomain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutboundDomain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundDomain" /> class.
        /// </summary>
        /// <param name="Id">Unique Id of the domain such as: example.com (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="CnameVerificationResult">CNAME registration Status.</param>
        /// <param name="DkimVerificationResult">DKIM registration Status.</param>
        /// <param name="SenderType">Sender Type.</param>
        public OutboundDomain(string Id = null, string Name = null, VerificationResult CnameVerificationResult = null, VerificationResult DkimVerificationResult = null, SenderTypeEnum? SenderType = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.CnameVerificationResult = CnameVerificationResult;
            this.DkimVerificationResult = DkimVerificationResult;
            this.SenderType = SenderType;
            
        }
        


        /// <summary>
        /// Unique Id of the domain such as: example.com
        /// </summary>
        /// <value>Unique Id of the domain such as: example.com</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// CNAME registration Status
        /// </summary>
        /// <value>CNAME registration Status</value>
        [DataMember(Name="cnameVerificationResult", EmitDefaultValue=false)]
        public VerificationResult CnameVerificationResult { get; set; }



        /// <summary>
        /// DKIM registration Status
        /// </summary>
        /// <value>DKIM registration Status</value>
        [DataMember(Name="dkimVerificationResult", EmitDefaultValue=false)]
        public VerificationResult DkimVerificationResult { get; set; }





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
            sb.Append("class OutboundDomain {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CnameVerificationResult: ").Append(CnameVerificationResult).Append("\n");
            sb.Append("  DkimVerificationResult: ").Append(DkimVerificationResult).Append("\n");
            sb.Append("  SenderType: ").Append(SenderType).Append("\n");
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
            return this.Equals(obj as OutboundDomain);
        }

        /// <summary>
        /// Returns true if OutboundDomain instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundDomain other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.CnameVerificationResult == other.CnameVerificationResult ||
                    this.CnameVerificationResult != null &&
                    this.CnameVerificationResult.Equals(other.CnameVerificationResult)
                ) &&
                (
                    this.DkimVerificationResult == other.DkimVerificationResult ||
                    this.DkimVerificationResult != null &&
                    this.DkimVerificationResult.Equals(other.DkimVerificationResult)
                ) &&
                (
                    this.SenderType == other.SenderType ||
                    this.SenderType != null &&
                    this.SenderType.Equals(other.SenderType)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.CnameVerificationResult != null)
                    hash = hash * 59 + this.CnameVerificationResult.GetHashCode();

                if (this.DkimVerificationResult != null)
                    hash = hash * 59 + this.DkimVerificationResult.GetHashCode();

                if (this.SenderType != null)
                    hash = hash * 59 + this.SenderType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
