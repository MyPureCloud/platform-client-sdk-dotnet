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
    /// A journey element attribute to group by within the chart
    /// </summary>
    [DataContract]
    public partial class JourneyViewChartGroupByAttribute :  IEquatable<JourneyViewChartGroupByAttribute>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartGroupByAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyViewChartGroupByAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewChartGroupByAttribute" /> class.
        /// </summary>
        /// <param name="ElementId">The element in the list of elements which is being grouped by (required).</param>
        /// <param name="Attribute">The attribute of the element being grouped by (required).</param>
        public JourneyViewChartGroupByAttribute(string ElementId = null, string Attribute = null)
        {
            this.ElementId = ElementId;
            this.Attribute = Attribute;
            
        }
        


        /// <summary>
        /// The element in the list of elements which is being grouped by
        /// </summary>
        /// <value>The element in the list of elements which is being grouped by</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }



        /// <summary>
        /// The attribute of the element being grouped by
        /// </summary>
        /// <value>The attribute of the element being grouped by</value>
        [DataMember(Name="attribute", EmitDefaultValue=false)]
        public string Attribute { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewChartGroupByAttribute {\n");

            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
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
            return this.Equals(obj as JourneyViewChartGroupByAttribute);
        }

        /// <summary>
        /// Returns true if JourneyViewChartGroupByAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewChartGroupByAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewChartGroupByAttribute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ElementId == other.ElementId ||
                    this.ElementId != null &&
                    this.ElementId.Equals(other.ElementId)
                ) &&
                (
                    this.Attribute == other.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.Equals(other.Attribute)
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
                if (this.ElementId != null)
                    hash = hash * 59 + this.ElementId.GetHashCode();

                if (this.Attribute != null)
                    hash = hash * 59 + this.Attribute.GetHashCode();

                return hash;
            }
        }
    }

}
