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
    class machcomm
    {

    }

    #region PLC, IPC, & Safety PLC Parameters

    /// PLC Communicacion parameters[#]
    /// 0 = Communication Status (Disconnected = 0, Connected = 1)
    /// 1 = Read / Write Coils, (Read = 0, Write = 1)
    /// 2 = Control (Disable = 0 / Enable = 1)
    enum PLC_Comm
    {
        CommStatus,
        RW_Coils,
        Control
    }


    #endregion

    #region External Devices

    #region Servo Motor

    //Axis X, Y, Z

    #endregion

    #region Actuator

    #endregion

    #endregion
}
