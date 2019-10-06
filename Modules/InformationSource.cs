using ArpRouter.Modules;
using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArpRouter.Modules
{
    public class InformationSource : NetworkInformation
    {
        private readonly ICaptureDevice captureDevice;

        public event EventHandler NetworkAlert;

        public InformationSource(TestCaptureDevice device)
        {
            captureDevice = device;
            captureDevice.OnPacketArrival += CaptureDevice_OnPacketArrival;
        }

        private void CaptureDevice_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            AddNetworkMessage(e.Packet.Data.ToString());
            NetworkEventArgs netArgs = ExtractNetworkInformation(e.Packet);

            NetworkAlert(this, netArgs);
        }

        private NetworkEventArgs ExtractNetworkInformation(RawCapture packet)
        {
            EthernetPacket ethernetPacket = PacketDotNet.Packet.ParsePacket(LinkLayers.Ethernet, packet.Data) as EthernetPacket;
            IPPacket ipPacket = ethernetPacket.Extract<IPPacket>();
            TcpPacket tcpPacket = ethernetPacket.Extract<TcpPacket>();

            return new NetworkEventArgs(ipPacket.DestinationAddress.ToString(), tcpPacket.DestinationPort.ToString(), ipPacket.SourceAddress.ToString(), tcpPacket.SourcePort.ToString());
        }

        public void StartListening()
        {
            captureDevice.StartCapture();
        }

    }
}
