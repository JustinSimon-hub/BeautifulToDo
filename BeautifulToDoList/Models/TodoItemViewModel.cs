using System;
using System.ComponentModel.DataAnnotations;
namespace BeautifulToDoList.Models
{
	public class TodoItem
	{

		public int Id { get; set; }

		//Validation for the entry
		[Required(ErrorMessage = "Name is required")]
    	[StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
		public string Name { get; set; }


		[Required(ErrorMessage = "Date is required")]
		public DateTime? Date { get; set; }


	}
}

