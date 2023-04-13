using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ToDo.Models
{
	public class ToDo
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Please enter a description.")]

		public string Description { get; set; } = string.Empty;

		public bool Completed { get; set; }

		public string? Title { get; set; }

		
	}
}

