﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAP.Config.HardwareManager
{
    //为所有的Instrument提供配置
    public class InstrumentCfg
    {
        public bool Enabled { get; set; }
        public string InstrumentName { get; set; }
        public string ConnectMode { get; set; }
        public string PortName { get; set; }
    }

    //为所有的运动控制卡提供配置
    public class MotionCardCfg
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool NeedInit { get; set; }
        public int MinAxisNo { get; set; }
        public int MaxAxisNo { get; set; }
        public string RealAxisNo { get; set; }
        public string SN { get; set; }
        public string ConnectMode { get; set; }
        public string PortName { get; set; }
    }

    //位IO卡提供配置
    public class IOCardCfg
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool NeedInit { get; set; }
        public string ConnectMode { get; set; }
        public string IOName_Input { get; set; }
        public string IOName_Output { get; set; }
        public string PortName { get; set; }

    }

    public class CameraCfg
    {
        public string Name { get; set; }            //UserName:IP
        public string NameForVision { get; set; }   //Vision use
        public int LightPortChannel { get; set; }   //光源端口
        public int LightValue { get; set; }
        public string ConnectType { get; set; }
    }

    public class LightCfg
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool NeedInit { get; set; }
        public int MinChannelNo { get; set; }
        public int MaxChannelNo { get; set; }
        public string ConnectMode { get; set; }
        public string PortName { get; set; }
    }


    public interface ICommunicationPortCfg
    {
        string PortName { get; set; }
        EnumConnectType GetTypeString();
    }
    public enum EnumConnectType
    {
        Comport,
        Ethernet,
        GPIB,
        NIVisa
    }
    public class ComportCfg : ICommunicationPortCfg
    {
        public string PortName { get; set; }
        public string Port { get; set; }
        public int BaudRate { get; set; }
        public string Parity { get; set; }
        public int DataBits { get; set; }
        public int StopBits { get; set; }
        public int TimeOut { get; set; }

        public EnumConnectType GetTypeString()
        {
            return EnumConnectType.Comport;
        }
    }
 
    public class EthernetCfg : ICommunicationPortCfg
    {
        public string PortName { get; set; }
        public string Mode { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string EOL { get; set; }
        public int TimeOut { get; set; }
        public EnumConnectType GetTypeString()
        {
            return EnumConnectType.Ethernet;
        }
    }
    public class GpibCfg : ICommunicationPortCfg
    {
        public string PortName { get; set; }
        public int BoardAddress { get; set; }
        public int Address { get; set; }
        public EnumConnectType GetTypeString()
        {
            return EnumConnectType.GPIB;
        }
    }
    public class VisaCfg : ICommunicationPortCfg
    {
        public string PortName { get; set; }
        public string KeyWord1 { get; set; }
        public string KeyWord2 { get; set; }
        public EnumConnectType GetTypeString()
        {
            return EnumConnectType.NIVisa;
        }
    }

}
