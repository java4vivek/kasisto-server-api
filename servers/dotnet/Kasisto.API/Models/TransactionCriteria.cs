using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kasisto.API.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TransactionCriteria :  IEquatable<TransactionCriteria>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCriteria" /> class.
        /// </summary>
        public TransactionCriteria()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        public string UserId { get; set; }

        
        /// <summary>
        /// Gets or Sets AccountIds
        /// </summary>
        public List<string> AccountIds { get; set; }

        
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        public int? Limit { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionCriteria {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountIds: ").Append(AccountIds).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            
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
            if (obj.GetType() != GetType()) return false;
            return Equals((TransactionCriteria)obj);
        }

        /// <summary>
        /// Returns true if TransactionCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCriteria other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.AccountIds == other.AccountIds ||
                    this.AccountIds != null &&
                    this.AccountIds.SequenceEqual(other.AccountIds)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                
                    if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                    if (this.AccountIds != null)
                    hash = hash * 59 + this.AccountIds.GetHashCode();
                
                    if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(TransactionCriteria left, TransactionCriteria right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TransactionCriteria left, TransactionCriteria right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
