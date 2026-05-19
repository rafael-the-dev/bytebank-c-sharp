using System;
using System.Collections.Generic;

using ByteBank.Interfaces;

namespace ByteBank.Entities { 
    public class Invoker {
        private List<ICommand> history;

        public Invoker() {
           history = new List<ICommand>();
        }

        public void Run(ICommand command) {
            command.Execute();

            history.Add(command);
        }

        public void Rollback() {
            sbyte length = (sbyte)history.Count();


            while (length > 0) {
                ICommand command = history.ElementAt(length - 1);

                history.RemoveAt(length - 1);

                command.Undo();

                length--;
            }
        }

        public void RunBatch(ICommand[] commands) { 
            try { 
                foreach(ICommand command in commands) {
                    Run(command);
                }
            } catch(Exception e) {
                Console.WriteLine("Erro encontrado, executando rollback...");
                Console.WriteLine(e);

                Rollback();
            }
        }
    }
}