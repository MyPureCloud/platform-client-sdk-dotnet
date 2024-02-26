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
    /// An element within a journey view
    /// </summary>
    [DataContract]
    public partial class JourneyViewElement :  IEquatable<JourneyViewElement>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyViewElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElement" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier of the element within the elements list (required).</param>
        /// <param name="Name">The unique name of the element within the view (required).</param>
        /// <param name="Attributes">Required attributes of the element (required).</param>
        /// <param name="Filter">Any filters applied to this element.</param>
        /// <param name="FollowedBy">A list of JourneyViewLink objects, listing the elements downstream of this element.</param>
        public JourneyViewElement(string Id = null, string Name = null, JourneyViewElementAttributes Attributes = null, JourneyViewElementFilter Filter = null, List<JourneyViewLink> FollowedBy = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Attributes = Attributes;
            this.Filter = Filter;
            this.FollowedBy = FollowedBy;
            
        }
        


        /// <summary>
        /// The unique identifier of the element within the elements list
        /// </summary>
        /// <value>The unique identifier of the element within the elements list</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The unique name of the element within the view
        /// </summary>
        /// <value>The unique name of the element within the view</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Required attributes of the element
        /// </summary>
        /// <value>Required attributes of the element</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public JourneyViewElementAttributes Attributes { get; set; }



        /// <summary>
        /// Any filters applied to this element
        /// </summary>
        /// <value>Any filters applied to this element</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public JourneyViewElementFilter Filter { get; set; }



        /// <summary>
        /// A list of JourneyViewLink objects, listing the elements downstream of this element
        /// </summary>
        /// <value>A list of JourneyViewLink objects, listing the elements downstream of this element</value>
        [DataMember(Name="followedBy", EmitDefaultValue=false)]
        public List<JourneyViewLink> FollowedBy { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewElement {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  FollowedBy: ").Append(FollowedBy).Append("\n");
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
            return this.Equals(obj as JourneyViewElement);
        }

        /// <summary>
        /// Returns true if JourneyViewElement instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewElement other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.FollowedBy == other.FollowedBy ||
                    this.FollowedBy != null &&
                    this.FollowedBy.SequenceEqual(other.FollowedBy)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.FollowedBy != null)
                    hash = hash * 59 + this.FollowedBy.GetHashCode();

                return hash;
            }
        }
    }

}
