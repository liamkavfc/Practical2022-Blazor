using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Practical2022_Blazor.Models
{
    public class ContactModel
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required, StringLength(50)]
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(100)]
        [JsonPropertyName("school")]
        public string School { get; set; }

        [StringLength(50)]
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    }
}