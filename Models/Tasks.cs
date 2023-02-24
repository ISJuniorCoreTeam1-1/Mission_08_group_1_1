using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Mission_08_group_1_1.Models 
{
	public class Tasks
	{
			[Key]
			[Required]
			public int TaskId { get; set; }

			[Required]
			public string Task { get; set; }

			public DateTime DueDate { get; set; }

			[Required]
			public int Quadrant { get; set; }

			public bool Completed { get; set; }

			[Required]
			public int CategoryId { get; set; }
			public Category Category { get; set; }
		}
	}
