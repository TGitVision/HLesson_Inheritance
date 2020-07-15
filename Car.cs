using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    class Car : Vehicle
    {

        #region Properties and Fields
        private bool blnHasRims { get; set; }
        private bool blnIsConvertable { get; set; }
        #endregion

        #region Constructors
        public Car(bool blnHasRims, bool blnIsConvertable, 
                    int doors, int seats, string color, int wheels, int yearMade) 
            : base (doors, seats, color, wheels, yearMade) 
        {
            this.blnHasRims = blnHasRims;
            this.blnIsConvertable = blnIsConvertable;
        }

        #endregion

        #region Methods

        public override void Start() 
        {
            base.Start();
            Console.WriteLine("The Car started with a Key.");
        }

        public override void GetVehicleDetails()
        {
            base.GetVehicleDetails();

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"{this.GetType().ToString()} blnHasRims : {blnHasRims} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} blnIsConvertable : {blnIsConvertable} \n");

            // Print summary of vehicle details to console.
            Console.WriteLine(textSummaryBuilder.ToString());
        }

        #endregion

    }
}
