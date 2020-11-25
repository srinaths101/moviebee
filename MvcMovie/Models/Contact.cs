using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
  public class Contact
  {
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 1)]
    [Required]
    public string Name { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [Required]
    [StringLength(100)]
    public string EmailId { get; set; }

    [Required]
    [StringLength(1000)]
    public string Message { get; set; }
  }
}