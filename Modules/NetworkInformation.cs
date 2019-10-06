using ArpRouter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArpRouter.Modules
{
    public class NetworkInformation : INetworkInformation
    {
        private readonly List<string> messageBuffer;

        public NetworkInformation()
        {
            messageBuffer = new List<string>();
        }

        public void AddNetworkMessage(string networkData)
        {
            messageBuffer.Add(networkData);
        }

        public int BufferCount => messageBuffer.Count;
        public string GetNextMessage()
        {
            if (messageBuffer.Any())
            {
                string nextMesage = messageBuffer.First();
                messageBuffer.RemoveAt(0);
                return nextMesage;
            }
            else return string.Empty;
        }
    }

    public class NetworkEventArgs : EventArgs
    {
        public string DestinationIpAddress { get; set; }
        public string SourceIpAddress { get; set; }
        public string DestinationPort { get; set; }
        public string SourcePort { get; set; }

        public NetworkEventArgs(string destIpAddress, string destPort, string srcIpAddress, string srcPort)
        {
            DestinationIpAddress = destIpAddress;
            SourceIpAddress = srcIpAddress;
            DestinationPort = destPort;
            SourcePort = srcPort;
        }
    }
}
