using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Models
{
  public class Review
  {
    public int Id { get; set; }

    [StringLength(5000, MinimumLength = 1)]
    [Required]
    public string MovieReview { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [Required]
    [StringLength(1000)]
    public string UserId { get; set; }

    [Required]
    [StringLength(1000)]
    public string UserName { get; set; }

    [StringLength(100)]
    [Required]
    public string MovieId { get; set; }

    [Required]
    [HiddenInput]
    public int Rating { get; set; }

  }
}