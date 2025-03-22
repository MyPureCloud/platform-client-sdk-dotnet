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
    /// ContactsExportFilter
    /// </summary>
    [DataContract]
    public partial class ContactsExportFilter :  IEquatable<ContactsExportFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsExportFilter" /> class.
        /// </summary>
        /// <param name="Eq">Filtered field should have the same value.</param>
        /// <param name="In">Filtered field should match one of the listed values.</param>
        /// <param name="And">Boolean AND combination of filters.</param>
        /// <param name="Or">Boolean OR combination of filters.</param>
        /// <param name="Not">Boolean negation of filters.</param>
        public ContactsExportFilter(ContactsExportFieldFilter Eq = null, ContactsExportFieldListFilter In = null, List<ContactsExportFilter> And = null, List<ContactsExportFilter> Or = null, ContactsExportFilter Not = null)
        {
            this.Eq = Eq;
            this.In = In;
            this.And = And;
            this.Or = Or;
            this.Not = Not;
            
        }
        


        /// <summary>
        /// Filtered field should have the same value
        /// </summary>
        /// <value>Filtered field should have the same value</value>
        [DataMember(Name="eq", EmitDefaultValue=false)]
        public ContactsExportFieldFilter Eq { get; set; }



        /// <summary>
        /// Filtered field should match one of the listed values
        /// </summary>
        /// <value>Filtered field should match one of the listed values</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public ContactsExportFieldListFilter In { get; set; }



        /// <summary>
        /// Boolean AND combination of filters
        /// </summary>
        /// <value>Boolean AND combination of filters</value>
        [DataMember(Name="and", EmitDefaultValue=false)]
        public List<ContactsExportFilter> And { get; set; }



        /// <summary>
        /// Boolean OR combination of filters
        /// </summary>
        /// <value>Boolean OR combination of filters</value>
        [DataMember(Name="or", EmitDefaultValue=false)]
        public List<ContactsExportFilter> Or { get; set; }



        /// <summary>
        /// Boolean negation of filters
        /// </summary>
        /// <value>Boolean negation of filters</value>
        [DataMember(Name="not", EmitDefaultValue=false)]
        public ContactsExportFilter Not { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsExportFilter {\n");

            sb.Append("  Eq: ").Append(Eq).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
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
            return this.Equals(obj as ContactsExportFilter);
        }

        /// <summary>
        /// Returns true if ContactsExportFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactsExportFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsExportFilter other)
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
