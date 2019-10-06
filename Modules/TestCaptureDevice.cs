using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ArpRouter.Modules
{
    public class TestCaptureDevice : ICaptureDevice, IDisposable
    {
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string LastError => throw new NotImplementedException();

        public string Filter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICaptureStatistics Statistics => throw new NotImplementedException();

        public PhysicalAddress MacAddress => throw new NotImplementedException();

        public bool Started => throw new NotImplementedException();

        public TimeSpan StopCaptureTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public LinkLayers LinkType => throw new NotImplementedException();

        public event PacketArrivalEventHandler OnPacketArrival;
        public event CaptureStoppedEventHandler OnCaptureStopped;

        public void Capture()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public RawCapture GetNextPacket()
        {
            throw new NotImplementedException();
        }

        public int GetNextPacketPointers(ref IntPtr header, ref IntPtr data)
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Open(DeviceMode mode)
        {
            throw new NotImplementedException();
        }

        public void Open(DeviceMode mode, int read_timeout)
        {
            throw new NotImplementedException();
        }

        public void Open(DeviceMode mode, int read_timeout, MonitorMode monitor_mode)
        {
            throw new NotImplementedException();
        }

        public void SendPacket(Packet p)
        {
            throw new NotImplementedException();
        }

        public void SendPacket(Packet p, int size)
        {
            throw new NotImplementedException();
        }

        public void SendPacket(byte[] p)
        {
            throw new NotImplementedException();
        }

        public void SendPacket(byte[] p, int size)
        {
            throw new NotImplementedException();
        }

        public void StartCapture()
        {
            RawCapture capturedPacket = new RawCapture(LinkLayers.Ethernet, new PosixTimeval(), new byte[]
            {
                0x00, 0x1f, 0xb5, 0x27, 0x99, 0xb3, 0x40, 0x84,
                0x93, 0x13, 0x2b, 0x2f, 0x08, 0x00, 0x45, 0x00,
                0x00, 0x44, 0xc6, 0x48, 0x00, 0x00, 0xff, 0x06,
                0x25, 0xea, 0x3e, 0xb5, 0xc2, 0xce, 0xc0, 0xa8,
                0x0d, 0x55, 0x00, 0x15, 0xfb, 0xb3, 0xdc, 0xec,
                0xb1, 0x07, 0xda, 0x93, 0x92, 0x84, 0x50, 0x18,
                0x80, 0x00, 0xfd, 0xe1, 0x00, 0x00, 0x32, 0x32,
                0x30, 0x20, 0x42, 0x75, 0x6c, 0x6c, 0x65, 0x74,
                0x50, 0x72, 0x6f, 0x6f, 0x66, 0x20, 0x46, 0x54,
                0x50, 0x20, 0x53, 0x65, 0x72, 0x76, 0x65, 0x72
            });
            CaptureEventArgs args = new CaptureEventArgs(capturedPacket, this);
            OnPacketArrival(this, args);
        }

        public void StopCapture()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }
    }
}
