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
    public partial class ResultTime : IEquatable<ResultTime>
    {
        /// <summary>
        /// Gets or Sets Millis
        /// </summary>

        [DataMember(Name = "millis")]
        public string Millis { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>

        [DataMember(Name = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultTime {\n");
            sb.Append("  Millis: ").Append(Millis).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResultTime)obj);
        }

        /// <summary>
        /// Returns true if ResultTime instances are equal
        /// </summary>
        /// <param name="other">Instance of ResultTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultTime other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Millis == other.Millis ||
                    Millis != null &&
                    Millis.Equals(other.Millis)
                ) &&
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
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
                if (Millis != null)
                    hashCode = hashCode * 59 + Millis.GetHashCode();
                if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                return hashCode;
            }
        }
    }
}

