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
    public class Constructor : IEquatable<Constructor>
    {
        /// <summary>
        /// Gets or Sets ConstructorId
        /// </summary>

        [DataMember(Name = "constructorId")]
        public string ConstructorId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>

        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>

        [DataMember(Name = "nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Constructor {\n");
            sb.Append("  ConstructorId: ").Append(ConstructorId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Constructor)obj);
        }

        /// <summary>
        /// Returns true if Constructor instances are equal
        /// </summary>
        /// <param name="other">Instance of Constructor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Constructor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ConstructorId == other.ConstructorId ||
                    ConstructorId != null &&
                    ConstructorId.Equals(other.ConstructorId)
                ) &&
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Nationality == other.Nationality ||
                    Nationality != null &&
                    Nationality.Equals(other.Nationality)
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
                if (ConstructorId != null)
                    hashCode = hashCode * 59 + ConstructorId.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Nationality != null)
                    hashCode = hashCode * 59 + Nationality.GetHashCode();
                return hashCode;
            }
        }
    }
}
