﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using ECAClientFramework;
using ShadowSys118.Adapters;
using ShadowSys118.VcControlDevice;
using ShadowSys118.VcSubRoutines;

namespace ShadowSys118.VcControlDevice
{
    [Serializable()]
    public class VoltVarController
    {
        #region [ Private Members ]
        private Dictionary<string, object> m_rawKeyValuePairs;
        private List<VcTransformer> m_controlTransformers;
        private List<VcCapacitorBank> m_controlCapacitorBanks; 
        private VcSubstationInfomation m_substationInformation;
        private VcSubstationAlarmDevice m_substationAlarmDevice;
        private VcLtcStatus m_ltcStatus;
        #endregion

        #region [ Property ]
        [XmlIgnore()]
        public Dictionary<string, object> RawkeyValuePairs
        {
            get
            {
                return m_rawKeyValuePairs;
            }
            set
            {
                m_rawKeyValuePairs = value;
            }
        }

        [XmlArray("ControlTransformers")]
        public List<VcTransformer> ControlTransformers
        {
            get
            {
                return m_controlTransformers;
            }
            set
            {
                m_controlTransformers = value;
            }
        }

        [XmlArray("ControlCapacitorBanks")]
        public List<VcCapacitorBank> ControlCapacitorBanks
        {
            get
            {
                return m_controlCapacitorBanks;
            }
            set
            {
                m_controlCapacitorBanks = value;
            }
        }
        
        public VcSubstationInfomation SubstationInformation
        {
            get
            {
                return m_substationInformation;
            }
            set
            {
                m_substationInformation = value;
            }
        }

        //[XmlArray("SubstationAlarmDevice")]
        public VcSubstationAlarmDevice SubstationAlarmDevice
        {
            get
            {
                return m_substationAlarmDevice;
            }
            set
            {
                m_substationAlarmDevice = value;
            }
        }

        public VcLtcStatus LtcStatus
        {
            get
            {
                return m_ltcStatus;
            }
            set
            {
                m_ltcStatus = value;
            }
        }

        #endregion

        #region [ Initialize the Objects Outside the Scope of Constructor ]
        private void Initialize()
        {
            m_controlTransformers = new List<VcTransformer>(); // need to initialize it 

            m_controlCapacitorBanks = new List<VcCapacitorBank>();

            m_substationInformation = new VcSubstationInfomation();

            m_substationAlarmDevice = new VcSubstationAlarmDevice();

            m_ltcStatus = new VcLtcStatus();

            m_rawKeyValuePairs = new Dictionary<string, object>();
        }

        #endregion

        #region [ Constructors ]
        public VoltVarController() // this is construction
        {
            Initialize();

        }
        #endregion

        #region [ Private Methods ]
        
        #endregion


        #region[ Public Method ] 
        public void LinkNetworkComponents(int numberofTX,int numberofCP) // this is construction
        {
            for(int i = 0; i < numberofTX; i++ )
            {
                VcTransformer TX = new VcTransformer();
                ControlTransformers.Add(TX);
            }

            for (int i = 0; i < numberofCP; i++)
            {
                VcCapacitorBank CP = new VcCapacitorBank();
                ControlCapacitorBanks.Add(CP);
            }
        }

        public void OnNewMeasurements()
        {

            InsertVcTransformer();

            InsertVcCapacitors();

            InsertGenerator();



        }

        public void ReadPreviousRun(VoltVarController previousFrame)
        {

            InsertPreviousRun(previousFrame);
        }

        public void ExecuteControl(ActionsAdapter act)
        {
            if ((act.ActTxRaise == 1) | (act.ActTxLower == 1))
            {
                #region [ check if LTC Taps are too far apart to continue]
                if (this.LtcStatus.DifTap > this.SubstationAlarmDevice.ZDIFTAP)
                {
                    //set clear alarm
                    MainWindow.WriteMessage($"Control Aborted: LTCs are too far apart [{this.LtcStatus.DifTap}/{this.SubstationAlarmDevice.ZDIFTAP}]");

                }
                #endregion

                #region [ Check for ZCONS consecutive delay steps ]

                if (this.SubstationInformation.ConsecTap < this.SubstationAlarmDevice.ZTCONS)
                {
                    MainWindow.WriteMessage($"Control Delayed: Not enough delays for LTC - [{this.SubstationInformation.ConsecTap}<{this.SubstationAlarmDevice.ZTCONS}]");
                }
                else
                {

                    m_substationInformation.Ntdel = 0;
                    m_substationInformation.ConsecTap = 0;

                    switch (act.ActTxRaise)
                    {
                        case 1:
                            if (this.ControlTransformers[0].TapV < this.SubstationAlarmDevice.ZHITAP)
                            {
                                this.ControlTransformers[0].TapV += 1;
                            }
                            break;
                        default:
                            break;
                    }

                    switch (act.ActTxLower)
                    {
                        case 1:
                            if (this.ControlTransformers[0].TapV > this.SubstationAlarmDevice.ZLOTAP)
                            {
                                this.ControlTransformers[0].TapV += -1;
                            }
                            break;
                        default:
                            break;
                    }
                    
                }

                #endregion

            }

            if ((act.ActSn1Close == 1) | (act.ActSn1Trip == 1) | (act.ActSn2Close == 1) | (act.ActSn2Trip == 1))
            {
                if (this.SubstationInformation.ConsecCap < this.SubstationInformation.Zccons || this.SubstationInformation.Ncdel < this.SubstationInformation.Zcdel || this.SubstationInformation.Ntdel < this.SubstationInformation.Zdel)
                {
                    MainWindow.WriteMessage($"Control Delayed: Not enough delays for CapBank - {this.SubstationInformation.ConsecCap} < {this.SubstationInformation.Zccons} {this.SubstationInformation.Ncdel} < {this.SubstationInformation.Zcdel}  {this.SubstationInformation.Ntdel} < {this.SubstationInformation.Zdel}");                    
                }
                else
                {
                    m_substationInformation.Ncdel = 0;
                    m_substationInformation.ConsecCap = 0;

                    switch (act.ActSn1Close)
                    {
                        case 1:
                            this.ControlCapacitorBanks[0].CapBkrV = 1;
                            break;
                        default:
                            break;
                    }

                    switch (act.ActSn1Trip)
                    {
                        case 1:
                            this.ControlCapacitorBanks[0].CapBkrV = 0;
                            break;
                        default:
                            break;
                    }

                    switch (act.ActSn2Close)
                    {
                        case 1:
                            this.ControlCapacitorBanks[1].CapBkrV = 1;
                            break;
                        default:
                            break;
                    }

                    switch (act.ActSn2Trip)
                    {
                        case 1:
                            this.ControlCapacitorBanks[1].CapBkrV = 0;
                            break;
                        default:
                            break;
                    }

                }

            }


        }


        #endregion

        #region [ Private Methods ]
        private void InsertVcTransformer()
        {
            foreach(VcTransformer vcTransformer in m_controlTransformers)
            {
                object value = 0;

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.HighSideId, out value))
                {
                    vcTransformer.HighSideV = (int)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.LowSideId, out value))
                {
                    vcTransformer.LowSideV = (int)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.LocRemId , out value))
                {
                    vcTransformer.LocRemV = (string)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.MvrId, out value))
                {
                    vcTransformer.MvrV = (double)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.MwId, out value))
                {
                    vcTransformer.MwV = (double)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.ScadaSw, out value)) 
                {
                    vcTransformer.ScadaSwV = (string)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.TapId, out value))
                {
                    vcTransformer.TapV = (int)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcTransformer.VoltsId , out value))
                {
                    vcTransformer.VoltsV = (double)value;
                    value = 0;
                }
            }  
        }

        private void InsertVcCapacitors()
        {
            foreach(VcCapacitorBank vcCapacitorbank in m_controlCapacitorBanks)
            {
                object value = 0;

                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.OpCapId, out value))
                {
                    vcCapacitorbank.OpCapV = (string)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.ScadaSwId, out value))
                {
                    vcCapacitorbank.ScadaSwV = (string)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.MiscId, out value))
                {
                    vcCapacitorbank.MiscV = (string)value;
                    value = 0;
                }


                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.AutoManId, out value))
                {
                    vcCapacitorbank.AutoManV = (string)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.BusBkrId, out value))
                {
                    //
                    vcCapacitorbank.BusBkrV = (short)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.LockvId, out value))
                {
                    vcCapacitorbank.LockvV = (double)value;
                    value = 0;
                }

                if (m_rawKeyValuePairs.TryGetValue(vcCapacitorbank.CapBkrId, out value))
                {
                    //
                    vcCapacitorbank.CapBkrV = (short)value;
                    value = 0;
                }

            }
        }

        private void InsertGenerator()
        {
            object value = 0;

            if (m_rawKeyValuePairs.TryGetValue(SubstationInformation.G1MwId, out value))
            {
                SubstationInformation.G1Mw = (double)value;
                value = 0;
            }

            if (m_rawKeyValuePairs.TryGetValue(SubstationInformation.G1MvrId, out value))
            {
                SubstationInformation.G1Mvr = (double)value;
                value = 0;
            }

            if (m_rawKeyValuePairs.TryGetValue(SubstationInformation.G2MwId, out value))
            {
                SubstationInformation.G2Mw = (double)value;
                value = 0;
            }

            if (m_rawKeyValuePairs.TryGetValue(SubstationInformation.G2MvrId, out value))
            {
                SubstationInformation.G2Mvr = (double)value;
                value = 0;
            }
        }

        private void InsertPreviousRun(VoltVarController previousFrame)
        {
            m_substationInformation.ConsecCap = previousFrame.SubstationInformation.ConsecCap;
            m_substationInformation.ConsecTap = previousFrame.SubstationInformation.ConsecTap;
            m_substationInformation.Ntdel = previousFrame.SubstationInformation.Ntdel;
            m_substationInformation.Ncdel = previousFrame.SubstationInformation.Ncdel;
            m_substationInformation.OldDay = previousFrame.SubstationInformation.OldDay;
            
            for(int i = 0;i < m_substationAlarmDevice.ZNTX;i++)
            {
                m_controlTransformers[i].CtlDone = previousFrame.ControlTransformers[i].CtlDone;
                m_controlTransformers[i].TapV = previousFrame.ControlTransformers[i].TapV;
                m_controlTransformers[i].MvrV = previousFrame.ControlTransformers[i].MvrV;
                m_controlTransformers[i].PrevCtl = previousFrame.ControlTransformers[i].PrevCtl;
            } 

            for(int i = 0; i < m_substationAlarmDevice.ZNCP;i++)
            {
                m_controlCapacitorBanks[i].CtlDone = previousFrame.ControlCapacitorBanks[i].CtlDone;
                m_controlCapacitorBanks[i].PrevCtl = previousFrame.ControlCapacitorBanks[i].PrevCtl;
                m_controlCapacitorBanks[i].NcTrip = previousFrame.ControlCapacitorBanks[i].NcTrip;
                m_controlCapacitorBanks[i].NcClose = previousFrame.ControlCapacitorBanks[i].NcClose;
                m_controlCapacitorBanks[i].TripEx = previousFrame.ControlCapacitorBanks[i].TripEx;
                m_controlCapacitorBanks[i].CloseEx = previousFrame.ControlCapacitorBanks[i].CloseEx;
            }
        }

        //private void InsertVcSubstationAlarmDevice()
        //{
        //    object value = 0;
        //    if (m_rawKeyValuePairs.TryGetValue(m_substationInformation.. , out value))
        //    {
        //        m_substationAlarmDevice. = (int)value;
        //        value = 0;
        //    }
        //}

        #endregion

        #region [ Xml Serialization/Deserialization methods ]
        public void SerializeToXml(string pathName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(VoltVarController));

                TextWriter writer = new StreamWriter(pathName);

                serializer.Serialize(writer, this);

                writer.Close();
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to Serialize");
            }
        }

        public static VoltVarController DeserializeFromXml(string pathName)
        {
            try
            {
                VoltVarController voltVarController = null;

                XmlSerializer deserializer = new XmlSerializer(typeof(VoltVarController));

                StreamReader reader = new StreamReader(pathName);

                voltVarController = (VoltVarController)deserializer.Deserialize(reader);

                reader.Close();

                return voltVarController;
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to Deserialize");
            }
        }

        #endregion

    }
}
