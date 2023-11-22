#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#endregion

namespace Software
{
    class CGantry
    {
        #region Variables
        //Gantry Limits
        //Workspace are available
        public double[] WorkingArea_Min = new double[] { 0f,0f};
        public double[] WorkingArea_Max = new double[] { 1000f,1000f };
        //Home position coordinates and tooling position
        public double[] HomePos = new double[]{ 10f,10f};

        #endregion

        #region Objects
        //Axis X,Y
        public CServoController OAxisX;
        public CServoController OAxisY;
        //Tooling: Axis Z
        public CTooling OAxisZ;
        #endregion

        public CGantry()
        {
            OAxisX = new CServoController();
            OAxisY = new CServoController();
            OAxisZ = new CTooling();
        }

        #region Functions
        //Servo Controllers: Move to part position
        public bool MoveAxis(double[] Coordinates)
        {
            bool bSucc = false;
            //Set positions
            OAxisX.Position = Coordinates[(int)eXYZ.X];  //Axis X
            OAxisY.Position = Coordinates[(int)eXYZ.Y];  //Axis Y
            Thread.Sleep(1000);
            //Start 
            OAxisX.Start();
            Thread.Sleep(1000);
            OAxisY.Start();
            //Position reached it? PID control
            Thread.Sleep(1000);
            //Stop 
            OAxisX.Stop();
            OAxisY.Stop();
            Thread.Sleep(1000);
            MoveTooling();  //Axis Z

            return bSucc;
        }
        //Tooling: Drawing Task
        public bool MoveTooling()
        {
            bool bSucc = false;
            //Home position (Up)
            OAxisZ.MoveUp();
            Thread.Sleep(1000);
            //Work position (Down)
            OAxisZ.MoveDown();
            Thread.Sleep(1000);
            //Home position (Up)
            OAxisZ.MoveUp();

            return bSucc;
        }
        //Home position: Preset position
        public bool HomePosition()
        {
            bool bSucc = false;
            //Move the axis X, Y 
            MoveAxis(HomePos);
            Thread.Sleep(2000);

            return bSucc;
        }
        //Stop the gantry
        public bool Stop()
        {
            bool bSucc = false;
            //Home position (Up)
            OAxisZ.MoveUp();
            Thread.Sleep(1000);
            //Stop Axis X, Y
            OAxisX.Stop();
            OAxisY.Stop();
            Thread.Sleep(1000);
            return bSucc;
        }
        #endregion

        #region Threads

        #endregion
    }
    //Coordinates definition
    enum eXYZ
    {
        X,
        Y,
        Z
    }
}
