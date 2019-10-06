using System;
using System.Collections.Generic;
using System.Text;

namespace ArpRouter.Interfaces
{
    public interface INetworkInformation
    {
        void AddNetworkMessage(string hello);
        int BufferCount { get; }
        string GetNextMessage();
    }
}
