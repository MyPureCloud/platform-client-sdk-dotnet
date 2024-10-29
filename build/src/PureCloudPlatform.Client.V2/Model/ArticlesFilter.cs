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
    /// ArticlesFilter
    /// </summary>
    [DataContract]
    public partial class ArticlesFilter :  IEquatable<ArticlesFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticlesFilter" /> class.
        /// </summary>
        /// <param name="Labels">The labels filter..</param>
        /// <param name="Categories">The categories filter..</param>
        public ArticlesFilter(LabelsFilter Labels = null, CategoriesFilter Categories = null)
        {
            this.Labels = Labels;
            this.Categories = Categories;
            
        }
        


        /// <summary>
        /// The labels filter.
        /// </summary>
        /// <value>The labels filter.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public LabelsFilter Labels { get; set; }



        /// <summary>
        /// The categories filter.
        /// </summary>
        /// <value>The categories filter.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public CategoriesFilter Categories { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArticlesFilter {\n");

            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(obj as ArticlesFilter);
        }

        /// <summary>
        /// Returns true if ArticlesFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ArticlesFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticlesFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.Equals(other.Labels)
                ) &&
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.Equals(other.Categories)
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
                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();

                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();

                return hash;
            }
        }
    }

}
