using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Domain.Models
{
	public class BaseEntry
	{
		[Display(Name = "Id")]
		public Guid Id { get; set; }

		[Display(Name = "Удаление")]
		public bool IsDelete { get; set; }

		[Display(Name = "Комментарий")]
		public string Comment { get; set; }
	}
}