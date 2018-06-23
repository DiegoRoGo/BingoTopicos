using WcfBingo.Dominio.Modelos;
using WcfBingo.Dominio.Especificaciones;
using System;
using System.Collections.Generic;

namespace WcfBingo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceBingo : IServiceBingo
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Board> GetWinningBoards(List<Board> players, Board winningPattern)
        {
            return new EspecificacionesBingo().GetWinningBoards(players, winningPattern);
        }

        public void MarkBoards(List<Board> Players, int number)
        {
            new EspecificacionesBingo().MarkBoards(Players, number);
        }

        public List<Board> GenerateBoards(int amount)
        {
            return new EspecificacionesBingo().GenerateBoards(amount);
        }

        public Board GenerateWinningPattern()
        {
            return new EspecificacionesBingo().GenerateWinningPattern();
        }
    }
}
