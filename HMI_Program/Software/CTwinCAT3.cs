//Mario A. Dominguez Guerrero 
//November 21th - 2023

#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
#endregion

#region Project Libraries
using TwinCAT.Ads;
using System.IO;
#endregion

namespace Software
{
    public class CTwinCAT3
    {
        #region Variables

        #region Communicacion Parameters[#]
        /// 0 = Communication Status (Disconnected = 0, Connected = 1)
        /// 1 = Read / Write Coils, (Read = 0, Write = 1)
        /// 2 = Control (Disable = 0 / Enable = 1)
        private static bool[] parameters = new bool[4] { false, false, false, false };
        public bool[] Parameters
        {
            get
            {
                return parameters;
            }

            set
            {
                parameters = value;
            }
        }
        #endregion

        #region TCP/IP Client Settings
        /*
        private static string iP;
        public string IP
        {
            get
            {
                return iP;
            }

            set
            {
                iP = value;
            }
        }
        private static int port;
        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }
        public static Socket PC_Client;
        */
        //Message
        public const int MAX_COMMAND_SIZE = 3000;
        #endregion

        #region TwinCAT 3
        int hVar;
        byte[] bVar;
        #endregion

        #endregion

        #region Callbacks

        #endregion

        #region Objects
        private TcAdsClient tcClient;
        #endregion

        public CTwinCAT3()
        {
            // Create instance of class TcAdsClient
            tcClient = new TcAdsClient();
        }

        #region Control

        #endregion

        #region Functions
        //Connect 
        private bool Connect()
        {
            try
            {
                // Connect to local PLC - Runtime 1 TwinCAT 3 Port=851
                tcClient.Connect(AmsNetId.Local, 851);

                //Creat Variable Handles
                CreateVariableHandlers(tcClient);

                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)PLC_Comm.CommStatus] = true;
                return true;
            }
            catch (Exception)
            {
                //Message
                //HMI.OForm.SystemMessages("Connection Error\n", "Error");

                return false;
            }
        }
        //Disconnect 
        private bool Disconnect()
        {
            try
            {
                //Close the connection   
                tcClient.Disconnect();
                tcClient.Dispose();
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)PLC_Comm.CommStatus] = false;
                return true;
            }
            catch (Exception)
            {
                //Message
                //HMI.OForm.SystemMessages("Disconnection Error\n", "Error");
                return false;
            }
        }

        bool CreateVariableHandlers(TcAdsClient OClient)
        {
            bool bSucc = true;

            try
            {
                hVar = OClient.CreateVariableHandle("Main_GVLs.PLCInputs");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                bSucc = false;
            }

            return bSucc;
        }

        //Communication: Read from registers
        void StatusRegisters()
        {
            // AdsStream which gets the data
            AdsStream dataStream = new AdsStream(15);
            //read comlpete Array 
            tcClient.Read(hVar, dataStream);
            //get value
            bVar = dataStream.ToArray();
        }
        //Communication: Write to registers
        void ControlRegisters()
        {
            // AdsStream which gets the data
            AdsStream dataStream = new AdsStream(15);
            //read comlpete Array 
            tcClient.Write(hVar, dataStream);
            //get value
            bVar = dataStream.ToArray();
        }

        #endregion

        #region Threads
        //Open the communication
        public bool Open_Communication()
        {
            if (!parameters[(int)PLC_Comm.Control])
            {
                if (Connect())
                {
                    parameters[(int)PLC_Comm.Control] = true;
                    //Active the communication process
                    Thread Tick = new Thread(new ThreadStart(() => Communication()));
                    Tick.Start();
                    return true;
                }
                else
                {
                    parameters[(int)PLC_Comm.Control] = false;
                    return false;
                }

            }
            else
                return false;
        }
        //Mapping Registers from TwinCAT 3
        private void Communication()
        {
            while (parameters[(int)PLC_Comm.Control])
            {
                //ReadRegisters();
            }
        }
        //Close the communication
        public bool Close_Communication()
        {
            if (parameters[(int)PLC_Comm.Control])
            {
                parameters[(int)PLC_Comm.Control] = false;
                Disconnect();
                return true;
            }
            else
            {
                parameters[(int)PLC_Comm.Control] = false;
                return false;
            }
        }
        #endregion
    }


}
