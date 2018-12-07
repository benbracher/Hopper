using Hopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopper.Contracts
{
    public interface IConnectionService
    {
        bool CreateConnection(ConnectionCreate model);
        ConnectionDetailsItem GetConnectionById(int id);


    }
}
