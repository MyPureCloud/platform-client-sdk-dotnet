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
    /// OrganizationsExportFilter
    /// </summary>
    [DataContract]
    public partial class OrganizationsExportFilter :  IEquatable<OrganizationsExportFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsExportFilter" /> class.
        /// </summary>
        /// <param name="Eq">Filtered field should have the same value.</param>
        /// <param name="In">Filtered field should match one of the listed values.</param>
        /// <param name="Lte">Filtered field should be less than or equal to the value.</param>
        /// <param name="Gte">Filtered field should be greater than or equal to the value.</param>
        /// <param name="And">Boolean AND combination of filters.</param>
        /// <param name="Or">Boolean OR combination of filters.</param>
        /// <param name="Not">Boolean negation of filters.</param>
        public OrganizationsExportFilter(OrganizationsExportFieldFilter Eq = null, OrganizationsExportFieldListFilter In = null, OrganizationsExportComparisonFieldFilter Lte = null, OrganizationsExportComparisonFieldFilter Gte = null, List<OrganizationsExportFilter> And = null, List<OrganizationsExportFilter> Or = null, OrganizationsExportFilter Not = null)
        {
            this.Eq = Eq;
            this.In = In;
            this.Lte = Lte;
            this.Gte = Gte;
            this.And = And;
            this.Or = Or;
            this.Not = Not;
            
        }
        


        /// <summary>
        /// Filtered field should have the same value
        /// </summary>
        /// <value>Filtered field should have the same value</value>
        [DataMember(Name="eq", EmitDefaultValue=false)]
        public OrganizationsExportFieldFilter Eq { get; set; }



        /// <summary>
        /// Filtered field should match one of the listed values
        /// </summary>
        /// <value>Filtered field should match one of the listed values</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public OrganizationsExportFieldListFilter In { get; set; }



        /// <summary>
        /// Filtered field should be less than or equal to the value
        /// </summary>
        /// <value>Filtered field should be less than or equal to the value</value>
        [DataMember(Name="lte", EmitDefaultValue=false)]
        public OrganizationsExportComparisonFieldFilter Lte { get; set; }



        /// <summary>
        /// Filtered field should be greater than or equal to the value
        /// </summary>
        /// <value>Filtered field should be greater than or equal to the value</value>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public OrganizationsExportComparisonFieldFilter Gte { get; set; }



        /// <summary>
        /// Boolean AND combination of filters
        /// </summary>
        /// <value>Boolean AND combination of filters</value>
        [DataMember(Name="and", EmitDefaultValue=false)]
        public List<OrganizationsExportFilter> And { get; set; }



        /// <summary>
        /// Boolean OR combination of filters
        /// </summary>
        /// <value>Boolean OR combination of filters</value>
        [DataMember(Name="or", EmitDefaultValue=false)]
        public List<OrganizationsExportFilter> Or { get; set; }



        /// <summary>
        /// Boolean negation of filters
        /// </summary>
        /// <value>Boolean negation of filters</value>
        [DataMember(Name="not", EmitDefaultValue=false)]
        public OrganizationsExportFilter Not { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationsExportFilter {\n");

            sb.Append("  Eq: ").Append(Eq).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  Lte: ").Append(Lte).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  And: ").Append(And).Append("\n");
            sb.Append("  Or: ").Append(Or).Append("\n");
            sb.Append("  Not: ").Append(Not).Append("\n");
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
            return this.Equals(obj as OrganizationsExportFilter);
        }

        /// <summary>
        /// Returns true if OrganizationsExportFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationsExportFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationsExportFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Eq == other.Eq ||
                    this.Eq != null &&
                    this.Eq.Equals(other.Eq)
                ) &&
                (
                    this.In == other.In ||
                    this.In != null &&
                    this.In.Equals(other.In)
                ) &&
                (
                    this.Lte == other.Lte ||
                    this.Lte != null &&
                    this.Lte.Equals(other.Lte)
                ) &&
                (
                    this.Gte == other.Gte ||
                    this.Gte != null &&
                    this.Gte.Equals(other.Gte)
                ) &&
                (
                    this.And == other.And ||
                    this.And != null &&
                    this.And.SequenceEqual(other.And)
                ) &&
                (
                    this.Or == other.Or ||
                    this.Or != null &&
                    this.Or.SequenceEqual(other.Or)
                ) &&
                (
                    this.Not == other.Not ||
                    this.Not != null &&
                    this.Not.Equals(other.Not)
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
                if (this.Eq != null)
                    hash = hash * 59 + this.Eq.GetHashCode();

                if (this.In != null)
                    hash = hash * 59 + this.In.GetHashCode();

                if (this.Lte != null)
                    hash = hash * 59 + this.Lte.GetHashCode();

                if (this.Gte != null)
                    hash = hash * 59 + this.Gte.GetHashCode();

                if (this.And != null)
                    hash = hash * 59 + this.And.GetHashCode();

                if (this.Or != null)
                    hash = hash * 59 + this.Or.GetHashCode();

                if (this.Not != null)
                    hash = hash * 59 + this.Not.GetHashCode();

                return hash;
            }
        }
    }

}
