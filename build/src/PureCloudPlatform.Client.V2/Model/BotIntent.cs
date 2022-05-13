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
    /// A botConnector&#39;s bot intention
    /// </summary>
    [DataContract]
    public partial class BotIntent :  IEquatable<BotIntent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BotIntent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotIntent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotIntent" /> class.
        /// </summary>
        /// <param name="Name">The name of this intent.  This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace (required).</param>
        /// <param name="Slots">Optional returned data values associated with this intent, limit of 50..</param>
        public BotIntent(string Name = null, Dictionary<string, BotSlot> Slots = null)
        {
            this.Name = Name;
            this.Slots = Slots;
            
        }
        


        /// <summary>
        /// The name of this intent.  This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
        /// </summary>
        /// <value>The name of this intent.  This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Optional returned data values associated with this intent, limit of 50.
        /// </summary>
        /// <value>Optional returned data values associated with this intent, limit of 50.</value>
        [DataMember(Name="slots", EmitDefaultValue=false)]
        public Dictionary<string, BotSlot> Slots { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotIntent {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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
            return this.Equals(obj as BotIntent);
        }

        /// <summary>
        /// Returns true if BotIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of BotIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotIntent other)
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
                    this.Slots == other.Slots ||
                    this.Slots != null &&
                    this.Slots.SequenceEqual(other.Slots)
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

                if (this.Slots != null)
                    hash = hash * 59 + this.Slots.GetHashCode();

                return hash;
            }
        }
    }

}
