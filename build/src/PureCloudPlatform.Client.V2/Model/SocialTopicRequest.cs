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
    /// SocialTopicRequest
    /// </summary>
    [DataContract]
    public partial class SocialTopicRequest :  IEquatable<SocialTopicRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialTopicRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SocialTopicRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialTopicRequest" /> class.
        /// </summary>
        /// <param name="Name">Name of the social topic. (required).</param>
        /// <param name="Description">A description of the social topic..</param>
        /// <param name="DivisionId">The ID of the division the social topic belongs to. (required).</param>
        public SocialTopicRequest(string Name = null, string Description = null, string DivisionId = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.DivisionId = DivisionId;
            
        }
        


        /// <summary>
        /// Name of the social topic.
        /// </summary>
        /// <value>Name of the social topic.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A description of the social topic.
        /// </summary>
        /// <value>A description of the social topic.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The ID of the division the social topic belongs to.
        /// </summary>
        /// <value>The ID of the division the social topic belongs to.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialTopicRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
            return this.Equals(obj as SocialTopicRequest);
        }

        /// <summary>
        /// Returns true if SocialTopicRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialTopicRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialTopicRequest other)
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
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
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

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                return hash;
            }
        }
    }

}
