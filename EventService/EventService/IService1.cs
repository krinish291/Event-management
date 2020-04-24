using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Event Show_event(int id);

        [OperationContract]
        int SaveEvent(Event e);

        [OperationContract]
        void UpdateEvent(Event e);

        [OperationContract]
        string DeleteEvent(int id);

        [OperationContract]
        DataSet Events();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EventService.ContractType".
   
}
