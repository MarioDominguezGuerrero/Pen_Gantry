//Mario A. Dominguez Guerrero 
//November 21th - 2023

#region System Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
#endregion

#region Project Libraries

#endregion

namespace Software
{
    public partial class HMI : Form
    {
        #region Variables
        //Rebooting Application State
        bool stsRebooting = false;
        static int partSelected;
        public int PartSelected
        {
            get
            {
                return partSelected;
            }

            set
            {
                partSelected = value;
            }
        }
        #endregion

        #region Callbacks

        #endregion

        #region Objects
        //HMI
        public static HMI OForm;
        //TwinCAT 3 SDK communication
        CTwinCAT3 OTwinCAT3;
        //Cycle
        Cycle OCycle;
        //Gantry System
        CGantry OGantry;
        #endregion

        public HMI()
        {
            InitializeComponent();
            //HMI Page
            OForm = this;

            OGantry = new CGantry();
            OCycle = new Cycle();
            OTwinCAT3 = new CTwinCAT3();

            //Start up gantry
            bool bSucc = StartUp_Gantry();
            //Everything is OK and connected?
            stsRebooting = bSucc;
            //Scan timeout for Register Mapping enable
            MachineStatus.Enabled = bSucc;
            //Visualize the Start and Abort buttons
            btn_Start.Visible = bSucc;
            btn_Stop.Visible = bSucc;
            btn_Home.Visible = bSucc;

        }

        #region Controls
        
        //When the application has been closing, this event is executed
        private void HMI_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShutDown_Gantry();
        }
        //Scan timeout for Register Mapping
        private void MachineStatus_Tick(object sender, EventArgs e)
        {
            #region Gantry Status

            //Map the status of the Axis X (Controller)
            switch (OGantry.OAxisX.StsController)
            {
                case (int)eControllerStatus.Running:
                    lb_AxisX_Status.Text = "Running";
                    break;
                case (int)eControllerStatus.Stopped:
                    lb_AxisX_Status.Text = "Stopped";
                    break;
                case (int)eControllerStatus.pause:
                    lb_AxisX_Status.Text = "Pause";
                    break;
                case (int)eControllerStatus.faulted:
                    lb_AxisX_Status.Text = "Faulted";
                    break;
                default:
                    break;
            }
            //Map the status of the Axis Y (Controller)
            switch (OGantry.OAxisY.StsController)
            {
                case (int)eControllerStatus.Running:
                    lb_AxisY_Status.Text = "Running";
                    break;
                case (int)eControllerStatus.Stopped:
                    lb_AxisY_Status.Text = "Stopped";
                    break;
                case (int)eControllerStatus.pause:
                    lb_AxisY_Status.Text = "Pause";
                    break;
                case (int)eControllerStatus.faulted:
                    lb_AxisY_Status.Text = "Faulted";
                    break;
                default:
                    break;
            }
            //Map the status of the Axis Z (Tooling)
            switch (OGantry.OAxisZ.StsTooling)
            {
                case (int)eToolingStatus.Home:
                    lb_AxisZ_Status.Text = "Home";
                    break;
                case (int)eToolingStatus.Drawing:
                    lb_AxisZ_Status.Text = "Drawing";
                    break;
                default:
                    break;
            }
            #endregion

            #region Cycle and Part Status
            //Cycle State
            switch (OCycle.StsState)
            {
                case (int)eCyceState.Reset:
                    lb_CycleState.Text = "Reseting";
                    break;
                case (int)eCyceState.Finish:
                    lb_CycleState.Text = "Ready";
                    break;
                case (int)eCyceState.Home:
                    lb_CycleState.Text = "Homing";
                    break;
                case (int)eCyceState.Part1:
                case (int)eCyceState.Part2:
                case (int)eCyceState.Part3:
                case (int)eCyceState.Part4:
                    lb_CycleState.Text = "Running";
                    break;
                default:
                    break;
            }

            //Cycle Status
            switch (OCycle.CycleControl)
            {
                case (int)eCycleControl.Started:
                    lb_CycleStatus.Text = "Started";
                    break;
                case (int)eCycleControl.Aborted:
                    lb_CycleStatus.Text = "Aborted";
                    break;
                default:
                    break;
            }

            //Part Selected
            lb_PartSelected.Text = $"{OCycle.PartSelected}";
            
            #endregion

        }

        #region Cycle
        //Start Cycle
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (OCycle.CycleControl == (int)eCycleControl.Aborted)
                OCycle.InitProcess();
        }
        //Stop Cycle
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            OCycle.StopProcess();
        }
        //Part Selection
        private void img_WorkSpace_MouseClick(object sender, MouseEventArgs e)
        {
            //Get the position of the mouse
            int X = MousePosition.X;
            int Y = MousePosition.Y;
            //Display the mouse coordinates
            lb_MouseX.Text = X.ToString("000");
            lb_MouseY.Text = Y.ToString("000");
            //Check if the coordinates are in range vs WorkArea
            bool bSucc = X > OGantry.WorkingArea_Min[(int)eXYLimts.Xmin] &&
                         X < OGantry.WorkingArea_Max[(int)eXYLimts.Xmax];
            bSucc &= Y > OGantry.WorkingArea_Min[(int)eXYLimts.Ymin] &&
                     Y < OGantry.WorkingArea_Max[(int)eXYLimts.Ymax] ;

            //Check the coordinates vs Part defined
            if (OCycle.OPart1.XYmin[(int)eXYLimts.Xmin] < X && OCycle.OPart1.XYmin[(int)eXYLimts.Ymin] < Y &&
               OCycle.OPart1.XYmax[(int)eXYLimts.Xmax] > X && OCycle.OPart1.XYmax[(int)eXYLimts.Ymax] > Y)
                partSelected = 1;
            if (OCycle.OPart2.XYmin[(int)eXYLimts.Xmin] < X && OCycle.OPart2.XYmin[(int)eXYLimts.Ymin] < Y &&
               OCycle.OPart2.XYmax[(int)eXYLimts.Xmax] > X && OCycle.OPart2.XYmax[(int)eXYLimts.Ymax] > Y)
                partSelected = 2;
            if (OCycle.OPart3.XYmin[(int)eXYLimts.Xmin] < X && OCycle.OPart3.XYmin[(int)eXYLimts.Ymin] < Y &&
               OCycle.OPart3.XYmax[(int)eXYLimts.Xmax] > X && OCycle.OPart3.XYmax[(int)eXYLimts.Ymax] > Y)
                partSelected = 3;
            if (OCycle.OPart4.XYmin[(int)eXYLimts.Xmin] < X && OCycle.OPart4.XYmin[(int)eXYLimts.Ymin] < Y &&
               OCycle.OPart4.XYmax[(int)eXYLimts.Xmax] > X && OCycle.OPart4.XYmax[(int)eXYLimts.Ymax] > Y)
                partSelected = 4;

            OCycle.PartSelected = partSelected;
        }

        //Home Cycle
        private void btn_Home_Click(object sender, EventArgs e)
        {
            OCycle.Home();
        }
        //Reset Cycle
        private void btn_Reset_CheckedChanged(object sender, EventArgs e)
        {
            OCycle.Reset();
        }
        #endregion

        #endregion

        #region Functions
        //Initialize all external devices of the Gantry
        bool StartUp_Gantry()
        {
            bool bSucc = false;

            bSucc = OGantry.OAxisX.Connect();
            bSucc &= OGantry.OAxisY.Connect();
            bSucc &=  OGantry.OAxisZ.Connect();

            return bSucc;
        }
        //Shutdown all external devices of the Gantry
        bool ShutDown_Gantry()
        {
            bool bSucc = false;

            bSucc = OGantry.OAxisX.Disconnect();
            bSucc &= OGantry.OAxisY.Disconnect();
            bSucc &= OGantry.OAxisZ.Disconnect();

            return bSucc;
        }


        #endregion

        #region Threads

        #endregion     
    }
}
