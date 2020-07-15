using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    class Plane : Vehicle
    {

        #region Properties and Fields
        private bool blnLandingGear { get; set; }
        public int numOfEngines { get; set; }
        public int wingSpan { get; set; }
        #endregion

        #region Constructors
        public Plane(bool blnLandingGear, int numOfEngines, int wingSpan,
                    int doors, int seats, string color, int wheels, int yearMade)
            : base(doors, seats, color, wheels, yearMade)
        {
            this.blnLandingGear = blnLandingGear;
            this.numOfEngines = numOfEngines;
            this.wingSpan = wingSpan;
        }

        #endregion

        #region Methods

        public override void Start()
        {
            base.Start();
            Console.WriteLine("The Plane started with switches.");
        }

        public override void GetVehicleDetails()
        {
            base.GetVehicleDetails();

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"{this.GetType().ToString()} blnLandingGear : {blnLandingGear} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} numOfEngines : {numOfEngines} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} wingSpan : {wingSpan} \n");

            // Print summary of vehicle details to console.
            Console.WriteLine(textSummaryBuilder.ToString());
        }

        #endregion

    }
}
