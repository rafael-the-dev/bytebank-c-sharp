using System;

using ByteBank.Repositories;

namespace ByteBank.Entities {
	enum TYPE: sbyte { 
		IN = 1,
		OUT = -1
	}

	class Movement {
		public int Id { get; private set; }
		public string AccountId { get; private set; }
		public double Amount { get; private set; }
		public TYPE Type { get; private set; }
		public DateTime Date { get; private set; }

		public Movement(int id, string accountId, double amount, DateTime date, TYPE type) {
			AccountId = accountId;
			Id = id;
			Amount = amount;
			Type = type;
			Date = date;
		}


	}
}