using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Heroic.AutoMapper;
using HeroicCRM.Web.Core;

namespace HeroicCRM.Web.Models
{
	public class EditCustomerForm : IMapTo<Customer>
	{
		[HiddenInput]
		public int Id { get; set; }

		[Required, Display(Name = "Full Name", Prompt = "Full Name (ex: John Doe)...")]
		public string Name { get; set; }

		[Required, DataType(DataType.EmailAddress)]
		public string WorkEmail { get; set; }

		[DataType(DataType.EmailAddress)]
		public string HomeEmail { get; set; }

		[Required, DataType(DataType.PhoneNumber)]
		public string WorkPhone { get; set; }

		[DataType(DataType.PhoneNumber)]
		public string HomePhone { get; set; }

		[Required, DataType(DataType.MultilineText)]
		public string WorkAddress { get; set; }

		[DataType(DataType.MultilineText)]
		public string HomeAddress { get; set; }
	}
}