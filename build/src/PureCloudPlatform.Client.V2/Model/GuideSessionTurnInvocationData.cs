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
    /// GuideSessionTurnInvocationData
    /// </summary>
    [DataContract]
    public partial class GuideSessionTurnInvocationData :  IEquatable<GuideSessionTurnInvocationData>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnInvocationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuideSessionTurnInvocationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnInvocationData" /> class.
        /// </summary>
        /// <param name="Group">The action group of the invocation data. (required).</param>
        /// <param name="ActionName">The action name of the invocation data. (required).</param>
        /// <param name="Output">The output of the invocation data. (required).</param>
        public GuideSessionTurnInvocationData(string Group = null, string ActionName = null, string Output = null)
        {
            this.Group = Group;
            this.ActionName = ActionName;
            this.Output = Output;
            
        }
        


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
        /// The output of the invocation data.
        /// </summary>
        /// <value>The output of the invocation data.</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public string Output { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionTurnInvocationData {\n");

            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
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
            return this.Equals(obj as GuideSessionTurnInvocationData);
        }

        /// <summary>
        /// Returns true if GuideSessionTurnInvocationData instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionTurnInvocationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionTurnInvocationData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.Equals(other.Output)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.ActionName != null)
                    hash = hash * 59 + this.ActionName.GetHashCode();

                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();

                return hash;
            }
        }
    }

}
