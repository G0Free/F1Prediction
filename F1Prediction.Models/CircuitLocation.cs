using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    [DataContract]
    public class CircuitLocation : IEquatable<CircuitLocation>
    {
        /// <summary>
        /// Gets or Sets Lat
        /// </summary>

        [DataMember(Name = "lat")]
        public string Lat { get; set; }

        /// <summary>
        /// Gets or Sets _Long
        /// </summary>

        [DataMember(Name = "long")]
        public string _Long { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>

        [DataMember(Name = "locality")]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>

        [DataMember(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CircuitLocation {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  _Long: ").Append(_Long).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CircuitLocation)obj);
        }

        /// <summary>
        /// Returns true if CircuitLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of CircuitLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CircuitLocation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Lat == other.Lat ||
                    Lat != null &&
                    Lat.Equals(other.Lat)
                ) &&
                (
                    _Long == other._Long ||
                    _Long != null &&
                    _Long.Equals(other._Long)
                ) &&
                (
                    Locality == other.Locality ||
                    Locality != null &&
                    Locality.Equals(other.Locality)
                ) &&
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Lat != null)
                    hashCode = hashCode * 59 + Lat.GetHashCode();
                if (_Long != null)
                    hashCode = hashCode * 59 + _Long.GetHashCode();
                if (Locality != null)
                    hashCode = hashCode * 59 + Locality.GetHashCode();
                if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                return hashCode;
            }
        }
    }
}
