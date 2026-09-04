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
    /// StageplanCreate
    /// </summary>
    [DataContract]
    public partial class StageplanCreate :  IEquatable<StageplanCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StageplanCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StageplanCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StageplanCreate" /> class.
        /// </summary>
        /// <param name="Name">The name of the Stageplan. Valid length between 3 and 256 characters. (required).</param>
        /// <param name="Description">The description of the Stageplan. Maximum length of 512 characters..</param>
        /// <param name="After">The ID of the Stageplan to place the new Stageplan after. Omit or null to place at the front..</param>
        public StageplanCreate(string Name = null, string Description = null, string After = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.After = After;
            
        }
        


        /// <summary>
        /// The name of the Stageplan. Valid length between 3 and 256 characters.
        /// </summary>
        /// <value>The name of the Stageplan. Valid length between 3 and 256 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the Stageplan. Maximum length of 512 characters.
        /// </summary>
        /// <value>The description of the Stageplan. Maximum length of 512 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The ID of the Stageplan to place the new Stageplan after. Omit or null to place at the front.
        /// </summary>
        /// <value>The ID of the Stageplan to place the new Stageplan after. Omit or null to place at the front.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StageplanCreate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
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
            return this.Equals(obj as StageplanCreate);
        }

        /// <summary>
        /// Returns true if StageplanCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of StageplanCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StageplanCreate other)
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
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
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

                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();

                return hash;
            }
        }
    }

}
