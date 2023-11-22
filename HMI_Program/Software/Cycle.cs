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
    class Cycle
    {
        #region Variables
        //Cycle State
        private static int stsState = 1;
        public int StsState
        {
            get
            {
                return stsState;
            }

            set
            {
                stsState = value;
            }
        }
        //Cycle control
        static int cycleControl = 0;
        public int CycleControl
        {
            get
            {
                return cycleControl;
            }

            set
            {
                cycleControl = value;
            }
        }
        //Part Selected
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
        private static int partSelected = 0;

        //Parts Limits
        public class CPart
        {
            public double[] XYmin = { 0.0f, 0.0f };
            public double[] XYmax = { 0.0f, 0.0f };

            //Initialization of the part with coordinates
            public CPart(double Xmin, double Ymin, double Xmax,double Ymax)
            {
                XYmin[(int)eXYLimts.Xmin] = Xmin;
                XYmin[(int)eXYLimts.Ymin] = Ymin;
                XYmax[(int)eXYLimts.Xmax] = Xmax;
                XYmax[(int)eXYLimts.Ymax] = Ymax;
            }
        }
        #endregion

        #region Objects
        //Gantry System
        CGantry OGantry;
        //Part Selected
        public CPart OPart1, OPart2, OPart3, OPart4;
        #endregion

        //Initialization
        public Cycle()
        {
            //Gantry System
            OGantry = new CGantry();
            //Define the Part preset
            /* Tesla
            OPart1 = new CPart(30, 700, 180, 850);
            OPart2 = new CPart(650, 750, 750, 870);
            OPart3 = new CPart(50, 20, 250, 120);
            OPart4 = new CPart(500, 500, 700, 550);
            */
            OPart1 = new CPart(612, 364, 682, 444);
            OPart2 = new CPart(822, 360, 870, 386);
            OPart3 = new CPart(634, 530, 718, 576);
            OPart4 = new CPart(762, 457, 837, 474);
        }

        #region Functions
        public bool Draw(int Part)
        {
            bool bSucc = false;
            double[] pPoint = new double[] {0f,0f};
            switch (Part)
            {
                case 0:
                    pPoint[(int)eXYZ.X] = OPart1.XYmin[(int)eXYLimts.Xmin];
                    pPoint[(int)eXYZ.Y] = OPart1.XYmin[(int)eXYLimts.Ymin];
                    break;
                case 1:
                    pPoint[(int)eXYZ.X] = OPart2.XYmin[(int)eXYLimts.Xmin];
                    pPoint[(int)eXYZ.Y] = OPart2.XYmin[(int)eXYLimts.Ymin];
                    break;
                case 2:
                    pPoint[(int)eXYZ.X] = OPart3.XYmin[(int)eXYLimts.Xmin];
                    pPoint[(int)eXYZ.Y] = OPart3.XYmin[(int)eXYLimts.Ymin];
                    break;
                case 3:
                    pPoint[(int)eXYZ.X] = OPart4.XYmin[(int)eXYLimts.Xmin];
                    pPoint[(int)eXYZ.Y] = OPart4.XYmin[(int)eXYLimts.Ymin];
                    break;
                default:
                    break;
            }
            //Move Gantry to work position
            OGantry.MoveAxis(pPoint);

            return bSucc;
        }
        public bool Home()
        {
            bool bSucc = false;

            stsState = (int)eCyceState.Home;
            OGantry.HomePosition();

            return bSucc;
        }
        public bool Reset()
        {
            bool bSucc = false;

            stsState = (int)eCyceState.Reset;

            return bSucc;
        }
        #endregion

        #region Threads
        //Start the Cycle
        public void InitProcess()
        {
            cycleControl = (int)eCycleControl.Started;
            //Active the process
            Thread Tick = new Thread(new ThreadStart(() => Process()));
            Tick.Start();
        }
        //State machine of the Cycle
        public void Process()
        {
            //Part Selected
            stsState = HMI.OForm.PartSelected + 2;
            bool Alarm = false;
            //Cycle
            while (cycleControl == (int)eCycleControl.Started)
            {
                switch (stsState)
                {
                    case (int)eCyceState.Reset:
                        stsState = (int)eCyceState.Home;
                        Thread.Sleep(1000);
                        break;
                    case (int)eCyceState.Finish:
                        OGantry.Stop();
                        cycleControl = (int)eCycleControl.Aborted;
                        break;
                    case (int)eCyceState.Home:
                        //Go to Home Position
                        OGantry.HomePosition();
                        Thread.Sleep(1000);
                        //Was fail? please retry
                        if (Alarm)
                        {
                            //Last Part Selected
                            stsState = HMI.OForm.PartSelected + 2;
                            Alarm = false;
                        }
                        else
                            stsState = (int)eCyceState.Finish;
                        break;
                    case (int)eCyceState.Part1:     
                    case (int)eCyceState.Part2:
                    case (int)eCyceState.Part3:
                    case (int)eCyceState.Part4:
                        Draw(HMI.OForm.PartSelected);
                        Thread.Sleep(1000);
                        stsState = (int)eCyceState.Home;
                        break;
                    case (int)eCyceState.Alarmed:
                        Alarm = true;
                        stsState = (int)eCyceState.Reset;
                        break;
                    default:
                        break;
                }
            }
        }
        //Stop the Cycle
        public void StopProcess()
        {
            stsState = (int)eCyceState.Finish;
            cycleControl = (int)eCycleControl.Aborted;
        }
        #endregion

        
    }
    //Cycle Control
    enum eCycleControl
    {
        Started,
        Aborted,
    }
    //Cycle State
    enum eCyceState
    {
        Reset,
        Finish,
        Home,
        Part1,
        Part2,
        Part3,
        Part4,
        Alarmed,
    }
    enum ePartSelected
    {
        Part1,
        Part2,
        Part3,
        Part4
    }
    enum eXYLimts
    {
        Xmin,
        Ymin,
        Xmax = 0,
        Ymax = 1
    }
}
