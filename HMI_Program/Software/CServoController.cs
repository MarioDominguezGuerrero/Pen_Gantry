//Mario A. Dominguez Guerrero 
//November 21th - 2023

#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Software
{
    class CServoController
    {
        #region Variables
        private static int stsController = 1;
        public int StsController
        {
            get
            {
                return stsController;
            }

            set
            {
                stsController = value;
            }
        }
        public double Position = 0.0f;
        #endregion

        #region Objects
        //TwinCAT 3 SDK communication
        CTwinCAT3 OTwinCAT3 = new CTwinCAT3();
        #endregion

        //Initialization
        public CServoController()
        {

        }

        #region Funtions
        //Connect to ServoController
        public bool Connect()
        {
            bool bSucc = true;

            return bSucc;
        }
        //Disconnetc from ServoController
        public bool Disconnect()
        {
            bool bSucc = true;

            return bSucc;
        }
        //Start
        public bool Start()
        {
            bool bSucc = true;

            stsController = (int)eControllerStatus.Running;
            return bSucc;
        }
        //Stop
        public bool Stop()
        {
            bool bSucc = true;

            stsController = (int)eControllerStatus.Stopped;
            return bSucc;
        }
        //Pause
        public bool Pause()
        {
            bool bSucc = true;

            stsController = (int)eControllerStatus.pause;
            return bSucc;
        }
        #endregion

        #region Threads

        #endregion

    }
    //Controller status and definition
    enum eControllerStatus 
    {
        Running,
        Stopped,
        pause,
        faulted,
    }
    enum eControllerControl
    {
        Start,
        Stop,
        Pause,
        Reset
    }
}
