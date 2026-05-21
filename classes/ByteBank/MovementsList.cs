using System;
using System.Collections.Generic;

namespace ByteBank.Entities { 
    class MovementsList {
        private List<Movement> Movements;

        public MovementsList(Movement[] movements) {
            this.Movements = new List<Movement>(movements.AsEnumerable());
        }

        public List<Movement> GetByAccountId(string  accountId) {
            return this.Movements.FindAll(mv => mv.AccountId == accountId);
        }
    }
}