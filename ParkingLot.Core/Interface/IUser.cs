using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ParkingLot.Core.Interface
{
    public interface IUser
    {

        string GetUser(string user);

        void SaveUser(string user);
        
    }
}
