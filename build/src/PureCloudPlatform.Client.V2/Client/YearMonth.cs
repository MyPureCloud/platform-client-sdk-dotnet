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

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// YearMonth
    /// </summary>
    [DataContract]
    public partial class YearMonth :  IEquatable<YearMonth>
    {
        private int? year;
        private int? month;

        /// <summary>
        /// Initializes a new instance of the <see cref="YearMonth" /> class.
        /// </summary>
        /// <param name="Year">Year.</param>
        /// <param name="Month">Month.</param>
        public YearMonth(int? Year = null, int? Month = null)
        {
            if (Year == null || Year < 0 || Year > 9999)
            {
                throw new ArgumentException("YearMonth Error - Year must be between 0 and 9999");
            }
            if (Month == null || Month < 1 || Month > 12)
            {
                throw new ArgumentException("YearMonth Error - Month must be between 1 and 12");
            }
            this.year = Year;
            this.month = Month;
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearMonth" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        public YearMonth(DateTime Date)
        {
            this.year = Date.Year;
            this.month = Date.Month;
            
        }
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value == null || value < 0 || value > 9999)
                {
                    throw new ArgumentException("YearMonth Error - Year must be between 0 and 9999");
                }
                this.year = value;
            }
        }

        /// <summary>
        /// Gets or Sets MonthValue
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month
        {
            get
            {
                return this.month;
            }
            set
            {
                if (value == null || value < 1 || value > 12)
                {
                    throw new ArgumentException("YearMonth Error - Month must be between 1 and 12");
                }
                this.month = value;
            }
        }

        /// <summary>
        /// Returns the DateTime presentation of the object
        /// </summary>
        /// <returns>DateTime presentation of the object</returns>
        public DateTime? ToDate()
        {
            if (this.Year == null || this.Month == null) return null;
            DateTime date = new DateTime(this.Year ?? 0, this.Month ?? 0, 1);
            return date;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            // JSM Choose
            // return String.Format("{0:0000}", this.Year) + "-" + String.Format("{0:00}", this.Month);
            var sb = new StringBuilder();
            sb.Append("class YearMonth {\n");

            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            // JSM Choose
            // return String.Format("{0:0000}", this.Year) + "-" + String.Format("{0:00}", this.Month);
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
            return this.Equals(obj as YearMonth);
        }

        /// <summary>
        /// Returns true if YearMonth instances are equal
        /// </summary>
        /// <param name="other">Instance of YearMonth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YearMonth other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) &&
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
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
                if (this.Year != null)
                    hash = hash * 59 + this.Year.GetHashCode();

                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();

                return hash;
            }
        }
    }

}
