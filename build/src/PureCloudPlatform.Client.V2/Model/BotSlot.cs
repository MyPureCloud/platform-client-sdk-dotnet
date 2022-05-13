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
    /// Description of a data value returned from an intent
    /// </summary>
    [DataContract]
    public partial class BotSlot :  IEquatable<BotSlot>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BotSlot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotSlot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotSlot" /> class.
        /// </summary>
        /// <param name="Name">The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace (required).</param>
        /// <param name="Type">The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types (required).</param>
        public BotSlot(string Name = null, string Type = null)
        {
            this.Name = Name;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
        /// </summary>
        /// <value>The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types
        /// </summary>
        /// <value>The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotSlot {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as BotSlot);
        }

        /// <summary>
        /// Returns true if BotSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of BotSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotSlot other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
