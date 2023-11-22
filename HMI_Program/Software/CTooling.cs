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
    class CTooling
    {
        #region Variables
        private static int stsTooling = 0;
        public int StsTooling
        {
            get
            {
                return stsTooling;
            }

            set
            {
                stsTooling = value;
            }
        }
        //Up = 0.0mm, Down = 15mm
        public double Position = 15.0;
        #endregion

        #region Objects
        //TwinCAT 3 SDK communication
        CTwinCAT3 OTwinCAT3 = new CTwinCAT3();
        #endregion

        //Initialization
        public CTooling()
        {

        }

        #region Funtions
        //Connect to Tooling
        public bool Connect()
        {
            bool bSucc = true;

            return bSucc;
        }
        //Disconnetc from Tooling
        public bool Disconnect()
        {
            bool bSucc = true;

            return bSucc;
        }

        //Move Up
        public bool MoveUp()
        {
            bool bSucc = true;
            stsTooling = (int)eToolingStatus.Home;
            return bSucc;
        }
        //Move Down
        public bool MoveDown()
        {
            bool bSucc = true;
            stsTooling = (int)eToolingStatus.Drawing;
            return bSucc;
        }
        #endregion

        #region Threads

        #endregion
    }
    //Tootling Status and Control definition
    enum eToolingStatus
    {
        Home, //Up
        Drawing  //Down
    }
    enum eToolingControl
    {
        MoveUp,
        MoveDown
    }
}
