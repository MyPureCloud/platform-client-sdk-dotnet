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
    /// ActionEventActionMap
    /// </summary>
    [DataContract]
    public partial class ActionEventActionMap :  IEquatable<ActionEventActionMap>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionEventActionMap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionEventActionMap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionEventActionMap" /> class.
        /// </summary>
        /// <param name="Id">The ID of the action map. (required).</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="Version">The version of the action map. (required).</param>
        /// <param name="DisplayName">Display name of the action map. (required).</param>
        public ActionEventActionMap(string Id = null, string SelfUri = null, int? Version = null, string DisplayName = null)
        {
            this.Id = Id;
            this.SelfUri = SelfUri;
            this.Version = Version;
            this.DisplayName = DisplayName;
            
        }
        


        /// <summary>
        /// The ID of the action map.
        /// </summary>
        /// <value>The ID of the action map.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// The version of the action map.
        /// </summary>
        /// <value>The version of the action map.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// Display name of the action map.
        /// </summary>
        /// <value>Display name of the action map.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionEventActionMap {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(obj as ActionEventActionMap);
        }

        /// <summary>
        /// Returns true if ActionEventActionMap instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionEventActionMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionEventActionMap other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                return hash;
            }
        }
    }

}
