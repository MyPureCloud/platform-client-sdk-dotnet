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
    /// SipSearchResult
    /// </summary>
    [DataContract]
    public partial class SipSearchResult :  IEquatable<SipSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SipSearchResult" /> class.
        /// </summary>
        /// <param name="Status">Status of the search request.</param>
        /// <param name="Sid">Session id associated to the search request.</param>
        /// <param name="Auth">Auth token used for this search request.</param>
        /// <param name="Message">Any messages returned from homer as part of the response.</param>
        /// <param name="Data">Homer search data that is returned.</param>
        /// <param name="Count">Number of records returned.</param>
        public SipSearchResult(int? Status = null, string Sid = null, string Auth = null, string Message = null, List<HomerRecord> Data = null, int? Count = null)
        {
            this.Status = Status;
            this.Sid = Sid;
            this.Auth = Auth;
            this.Message = Message;
            this.Data = Data;
            this.Count = Count;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Status of the search request
        /// </summary>
        /// <value>Status of the search request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }



        /// <summary>
        /// Session id associated to the search request
        /// </summary>
        /// <value>Session id associated to the search request</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }



        /// <summary>
        /// Auth token used for this search request
        /// </summary>
        /// <value>Auth token used for this search request</value>
        [DataMember(Name="auth", EmitDefaultValue=false)]
        public string Auth { get; set; }



        /// <summary>
        /// Any messages returned from homer as part of the response
        /// </summary>
        /// <value>Any messages returned from homer as part of the response</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Homer search data that is returned
        /// </summary>
        /// <value>Homer search data that is returned</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<HomerRecord> Data { get; set; }



        /// <summary>
        /// Number of records returned
        /// </summary>
        /// <value>Number of records returned</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }



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
            sb.Append("class SipSearchResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as SipSearchResult);
        }

        /// <summary>
        /// Returns true if SipSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SipSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SipSearchResult other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Sid == other.Sid ||
                    this.Sid != null &&
                    this.Sid.Equals(other.Sid)
                ) &&
                (
                    this.Auth == other.Auth ||
                    this.Auth != null &&
                    this.Auth.Equals(other.Auth)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Sid != null)
                    hash = hash * 59 + this.Sid.GetHashCode();

                if (this.Auth != null)
                    hash = hash * 59 + this.Auth.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
