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
    /// the range of attribute values to filter on. At least one comparator must be defined
    /// </summary>
    [DataContract]
    public partial class JourneyViewElementFilterRange :  IEquatable<JourneyViewElementFilterRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElementFilterRange" /> class.
        /// </summary>
        /// <param name="Lt">comparator: less than.</param>
        /// <param name="Lte">comparator: less than or equal.</param>
        /// <param name="Gt">comparator: greater than.</param>
        /// <param name="Gte">comparator: greater than or equal.</param>
        /// <param name="Eq">comparator: is equal to.</param>
        /// <param name="Neq">comparator: is not equal to.</param>
        public JourneyViewElementFilterRange(JourneyViewElementFilterRangeData Lt = null, JourneyViewElementFilterRangeData Lte = null, JourneyViewElementFilterRangeData Gt = null, JourneyViewElementFilterRangeData Gte = null, JourneyViewElementFilterRangeData Eq = null, JourneyViewElementFilterRangeData Neq = null)
        {
            this.Lt = Lt;
            this.Lte = Lte;
            this.Gt = Gt;
            this.Gte = Gte;
            this.Eq = Eq;
            this.Neq = Neq;
            
        }
        


        /// <summary>
        /// comparator: less than
        /// </summary>
        /// <value>comparator: less than</value>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public JourneyViewElementFilterRangeData Lt { get; set; }



        /// <summary>
        /// comparator: less than or equal
        /// </summary>
        /// <value>comparator: less than or equal</value>
        [DataMember(Name="lte", EmitDefaultValue=false)]
        public JourneyViewElementFilterRangeData Lte { get; set; }



        /// <summary>
        /// comparator: greater than
        /// </summary>
        /// <value>comparator: greater than</value>
        [DataMember(Name="gt", EmitDefaultValue=false)]
        public JourneyViewElementFilterRangeData Gt { get; set; }



        /// <summary>
        /// comparator: greater than or equal
        /// </summary>
        /// <value>comparator: greater than or equal</value>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public JourneyViewElementFilterRangeData Gte { get; set; }



        /// <summary>
        /// comparator: is equal to
        /// </summary>
        /// <value>comparator: is equal to</value>
        [DataMember(Name="eq", EmitDefaultValue=false)]
        public JourneyViewElementFilterRangeData Eq { get; set; }



        /// <summary>
        /// comparator: is not equal to
        /// </summary>
        /// <value>comparator: is not equal to</value>
        [DataMember(Name="neq", EmitDefaultValue=false)]
        public JourneyViewElementFilterRangeData Neq { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewElementFilterRange {\n");

            sb.Append("  Lt: ").Append(Lt).Append("\n");
            sb.Append("  Lte: ").Append(Lte).Append("\n");
            sb.Append("  Gt: ").Append(Gt).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Eq: ").Append(Eq).Append("\n");
            sb.Append("  Neq: ").Append(Neq).Append("\n");
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
            return this.Equals(obj as JourneyViewElementFilterRange);
        }

        /// <summary>
        /// Returns true if JourneyViewElementFilterRange instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewElementFilterRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewElementFilterRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Lt == other.Lt ||
                    this.Lt != null &&
                    this.Lt.Equals(other.Lt)
                ) &&
                (
                    this.Lte == other.Lte ||
                    this.Lte != null &&
                    this.Lte.Equals(other.Lte)
                ) &&
                (
                    this.Gt == other.Gt ||
                    this.Gt != null &&
                    this.Gt.Equals(other.Gt)
                ) &&
                (
                    this.Gte == other.Gte ||
                    this.Gte != null &&
                    this.Gte.Equals(other.Gte)
                ) &&
                (
                    this.Eq == other.Eq ||
                    this.Eq != null &&
                    this.Eq.Equals(other.Eq)
                ) &&
                (
                    this.Neq == other.Neq ||
                    this.Neq != null &&
                    this.Neq.Equals(other.Neq)
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
                if (this.Lt != null)
                    hash = hash * 59 + this.Lt.GetHashCode();

                if (this.Lte != null)
                    hash = hash * 59 + this.Lte.GetHashCode();

                if (this.Gt != null)
                    hash = hash * 59 + this.Gt.GetHashCode();

                if (this.Gte != null)
                    hash = hash * 59 + this.Gte.GetHashCode();

                if (this.Eq != null)
                    hash = hash * 59 + this.Eq.GetHashCode();

                if (this.Neq != null)
                    hash = hash * 59 + this.Neq.GetHashCode();

                return hash;
            }
        }
    }

}
