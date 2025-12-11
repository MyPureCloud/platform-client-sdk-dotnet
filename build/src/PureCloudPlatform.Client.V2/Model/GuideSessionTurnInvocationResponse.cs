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
    /// GuideSessionTurnInvocationResponse
    /// </summary>
    [DataContract]
    public partial class GuideSessionTurnInvocationResponse :  IEquatable<GuideSessionTurnInvocationResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnInvocationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuideSessionTurnInvocationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnInvocationResponse" /> class.
        /// </summary>
        /// <param name="Id">The action ID of the invocation data..</param>
        /// <param name="Group">The action group of the invocation data. (required).</param>
        /// <param name="ActionName">The action name of the invocation data. (required).</param>
        /// <param name="Parameters">The parameters of the invocation response..</param>
        public GuideSessionTurnInvocationResponse(string Id = null, string Group = null, string ActionName = null, List<GuideSessionTurnInvocationParameters> Parameters = null)
        {
            this.Id = Id;
            this.Group = Group;
            this.ActionName = ActionName;
            this.Parameters = Parameters;
            
        }
        


        /// <summary>
        /// The action ID of the invocation data.
        /// </summary>
        /// <value>The action ID of the invocation data.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The action group of the invocation data.
        /// </summary>
        /// <value>The action group of the invocation data.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }



        /// <summary>
        /// The action name of the invocation data.
        /// </summary>
        /// <value>The action name of the invocation data.</value>
        [DataMember(Name="actionName", EmitDefaultValue=false)]
        public string ActionName { get; set; }



        /// <summary>
        /// The parameters of the invocation response.
        /// </summary>
        /// <value>The parameters of the invocation response.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<GuideSessionTurnInvocationParameters> Parameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionTurnInvocationResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as GuideSessionTurnInvocationResponse);
        }

        /// <summary>
        /// Returns true if GuideSessionTurnInvocationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionTurnInvocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionTurnInvocationResponse other)
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
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.ActionName == other.ActionName ||
                    this.ActionName != null &&
                    this.ActionName.Equals(other.ActionName)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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

                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.ActionName != null)
                    hash = hash * 59 + this.ActionName.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                return hash;
            }
        }
    }

}
