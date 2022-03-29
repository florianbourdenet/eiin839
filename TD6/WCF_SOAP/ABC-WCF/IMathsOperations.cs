using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace MathsLibrary
{
    [ServiceContract]
    public interface IMathsOperations
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        int Substract(int a, int b);

        [OperationContract]
        double Divide(int a, int b);
    }
}
