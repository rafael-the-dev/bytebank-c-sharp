

namespace ByteBank.Menus {
	public abstract class BaseMenu<T> {
        protected string GetColumn(string value, byte maxLength) {
            string column = value;
            
            while(column.Length <= maxLength) {
                column += " ";
            }

            return column;
        }

		public abstract void Print(T[] list);
	}
}