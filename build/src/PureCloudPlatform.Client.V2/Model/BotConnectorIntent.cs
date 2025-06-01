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
    /// A bot intention
    /// </summary>
    [DataContract]
    public partial class BotConnectorIntent :  IEquatable<BotConnectorIntent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotConnectorIntent" /> class.
        /// </summary>
        /// <param name="Name">The name of this intent..</param>
        /// <param name="Entities">A list of entity values that can be associated with this intent.</param>
        public BotConnectorIntent(string Name = null, List<BotEntity> Entities = null)
        {
            this.Name = Name;
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// The name of this intent.
        /// </summary>
        /// <value>The name of this intent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A list of entity values that can be associated with this intent
        /// </summary>
        /// <value>A list of entity values that can be associated with this intent</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<BotEntity> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotConnectorIntent {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as BotConnectorIntent);
        }

        /// <summary>
        /// Returns true if BotConnectorIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of BotConnectorIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotConnectorIntent other)
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
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
