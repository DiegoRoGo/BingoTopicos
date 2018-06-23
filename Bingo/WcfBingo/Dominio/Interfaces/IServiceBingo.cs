using WcfBingo.Dominio.Modelos;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfBingo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBingo
    {
        // TODO: Add your service operations here
        [OperationContract]
        void MarkBoards(ref List<Board> Players, int number);

        [OperationContract]
        List<Board> GetWinningBoards(List<Board> players, Board winningPattern);

        [OperationContract]
        List<Board> GenerateBoards(int amount);

        [OperationContract]
        Board GenerateWinningPattern();
    }
}
