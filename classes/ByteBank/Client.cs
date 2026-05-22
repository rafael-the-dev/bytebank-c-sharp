using System;

namespace ByteBank.Entities
{
    public class Client
    {
        private string _name;

        public Client(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return this._name;  }
            set
            {
                if(value != null && value.Length > 1)
                {
                    this._name = value;
                }
            }
        }

        public override string ToString() {
            return "Nome: " + this.Name;
        }
    }
}
