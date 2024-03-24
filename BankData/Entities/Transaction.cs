using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData.Entities;

public class Transaction
{
    public int Id { get; set; }
	public decimal Amount { get; set; }
	public DateTime Date { get; set; } = DateTime.UtcNow;
	public string Sender { get; set; } 
	public string Recipient { get; set; }
    public int TagId { get; set; }
    public Tag? Tag { get; set; }
	public bool IsIncome { get; set; } // Приход (true) или уход (false) средств

}
