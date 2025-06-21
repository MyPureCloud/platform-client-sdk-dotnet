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
    /// SendMessagingTemplateRequest
    /// </summary>
    [DataContract]
    public partial class SendMessagingTemplateRequest :  IEquatable<SendMessagingTemplateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessagingTemplateRequest" /> class.
        /// </summary>
        /// <param name="ResponseId">Unique identifier for a Response Management response to fetch and apply pre-configured message content when sending outbound responses..</param>
        /// <param name="Parameters">A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead..</param>
        /// <param name="HeaderParameters">A list of Response Management header parameter substitutions for the response&#39;s messaging template.</param>
        /// <param name="BodyParameters">A list of Response Management body parameter substitutions for the response&#39;s messaging template.</param>
        /// <param name="ButtonUrlParameters">A list of Response Management button url parameter substitutions for the response&#39;s messaging template.</param>
        public SendMessagingTemplateRequest(string ResponseId = null, List<TemplateParameter> Parameters = null, List<TemplateParameter> HeaderParameters = null, List<TemplateParameter> BodyParameters = null, List<TemplateParameter> ButtonUrlParameters = null)
        {
            this.ResponseId = ResponseId;
            this.Parameters = Parameters;
            this.HeaderParameters = HeaderParameters;
            this.BodyParameters = BodyParameters;
            this.ButtonUrlParameters = ButtonUrlParameters;
            
        }
        


        /// <summary>
        /// Unique identifier for a Response Management response to fetch and apply pre-configured message content when sending outbound responses.
        /// </summary>
        /// <value>Unique identifier for a Response Management response to fetch and apply pre-configured message content when sending outbound responses.</value>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }



        /// <summary>
        /// A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead.
        /// </summary>
        /// <value>A list of Response Management response substitutions for the response&#39;s messaging template. (Deprecated) use bodyParameters instead.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<TemplateParameter> Parameters { get; set; }



        /// <summary>
        /// A list of Response Management header parameter substitutions for the response&#39;s messaging template
        /// </summary>
        /// <value>A list of Response Management header parameter substitutions for the response&#39;s messaging template</value>
        [DataMember(Name="headerParameters", EmitDefaultValue=false)]
        public List<TemplateParameter> HeaderParameters { get; set; }



        /// <summary>
        /// A list of Response Management body parameter substitutions for the response&#39;s messaging template
        /// </summary>
        /// <value>A list of Response Management body parameter substitutions for the response&#39;s messaging template</value>
        [DataMember(Name="bodyParameters", EmitDefaultValue=false)]
        public List<TemplateParameter> BodyParameters { get; set; }



        /// <summary>
        /// A list of Response Management button url parameter substitutions for the response&#39;s messaging template
        /// </summary>
        /// <value>A list of Response Management button url parameter substitutions for the response&#39;s messaging template</value>
        [DataMember(Name="buttonUrlParameters", EmitDefaultValue=false)]
        public List<TemplateParameter> ButtonUrlParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessagingTemplateRequest {\n");

            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  HeaderParameters: ").Append(HeaderParameters).Append("\n");
            sb.Append("  BodyParameters: ").Append(BodyParameters).Append("\n");
            sb.Append("  ButtonUrlParameters: ").Append(ButtonUrlParameters).Append("\n");
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
            return this.Equals(obj as SendMessagingTemplateRequest);
        }

        /// <summary>
        /// Returns true if SendMessagingTemplateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SendMessagingTemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMessagingTemplateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ResponseId == other.ResponseId ||
                    this.ResponseId != null &&
                    this.ResponseId.Equals(other.ResponseId)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) &&
                (
                    this.HeaderParameters == other.HeaderParameters ||
                    this.HeaderParameters != null &&
                    this.HeaderParameters.SequenceEqual(other.HeaderParameters)
                ) &&
                (
                    this.BodyParameters == other.BodyParameters ||
                    this.BodyParameters != null &&
                    this.BodyParameters.SequenceEqual(other.BodyParameters)
                ) &&
                (
                    this.ButtonUrlParameters == other.ButtonUrlParameters ||
                    this.ButtonUrlParameters != null &&
                    this.ButtonUrlParameters.SequenceEqual(other.ButtonUrlParameters)
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
                if (this.ResponseId != null)
                    hash = hash * 59 + this.ResponseId.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                if (this.HeaderParameters != null)
                    hash = hash * 59 + this.HeaderParameters.GetHashCode();

                if (this.BodyParameters != null)
                    hash = hash * 59 + this.BodyParameters.GetHashCode();

                if (this.ButtonUrlParameters != null)
                    hash = hash * 59 + this.ButtonUrlParameters.GetHashCode();

                return hash;
            }
        }
    }

}
