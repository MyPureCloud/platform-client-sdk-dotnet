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
    /// Disposition
    /// </summary>
    [DataContract]
    public partial class Disposition :  IEquatable<Disposition>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Disposition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Disposition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Disposition" /> class.
        /// </summary>
        /// <param name="Name">Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table.. (required).</param>
        /// <param name="Analyzer">The final media analyzer result that triggered the disposition result, if any..</param>
        /// <param name="DispositionParameters">Contains various parameters related to call analysis..</param>
        public Disposition(string Name = null, string Analyzer = null, DispositionParameters DispositionParameters = null)
        {
            this.Name = Name;
            this.Analyzer = Analyzer;
            this.DispositionParameters = DispositionParameters;
            
        }
        


        /// <summary>
        /// Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..
        /// </summary>
        /// <value>Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The final media analyzer result that triggered the disposition result, if any.
        /// </summary>
        /// <value>The final media analyzer result that triggered the disposition result, if any.</value>
        [DataMember(Name="analyzer", EmitDefaultValue=false)]
        public string Analyzer { get; set; }



        /// <summary>
        /// Contains various parameters related to call analysis.
        /// </summary>
        /// <value>Contains various parameters related to call analysis.</value>
        [DataMember(Name="dispositionParameters", EmitDefaultValue=false)]
        public DispositionParameters DispositionParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Disposition {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Analyzer: ").Append(Analyzer).Append("\n");
            sb.Append("  DispositionParameters: ").Append(DispositionParameters).Append("\n");
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
            return this.Equals(obj as Disposition);
        }

        /// <summary>
        /// Returns true if Disposition instances are equal
        /// </summary>
        /// <param name="other">Instance of Disposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Disposition other)
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
                    this.Analyzer == other.Analyzer ||
                    this.Analyzer != null &&
                    this.Analyzer.Equals(other.Analyzer)
                ) &&
                (
                    this.DispositionParameters == other.DispositionParameters ||
                    this.DispositionParameters != null &&
                    this.DispositionParameters.Equals(other.DispositionParameters)
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

                if (this.Analyzer != null)
                    hash = hash * 59 + this.Analyzer.GetHashCode();

                if (this.DispositionParameters != null)
                    hash = hash * 59 + this.DispositionParameters.GetHashCode();

                return hash;
            }
        }
    }

}
