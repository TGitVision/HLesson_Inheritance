using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    class Boat : Vehicle
    {

        #region Properties and Fields
        private bool blnHasRutters { get; set; }
        private bool blnHasSails { get; set; }
        private string boatType { get; set; }
        #endregion

        #region Constructors
        public Boat(bool blnHasRutters, bool blnHasSails, string boatType,
                    int doors, int seats, string color, int wheels, int yearMade)
            : base(doors, seats, color, wheels, yearMade)
        {
            this.blnHasRutters = blnHasRutters;
            this.blnHasSails = blnHasSails;
            this.boatType = boatType;
        }

        #endregion

        #region Methods

        public override void Start()
        {
            base.Start();
            Console.WriteLine("The Boat started with a key and button.");
        }

        public override void GetVehicleDetails()
        {
            base.GetVehicleDetails();

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"\n\n ****** START {this.GetType().ToString()} CHILD GetVehicleDetails() VALUES ****** \n\n");

            textSummaryBuilder.Append($"{this.GetType().ToString()} blnHasRims : {blnHasRutters} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} blnIsConvertable : {blnHasSails} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} boatType : {boatType} \n");

            // Print summary of vehicle details to console.
            Console.WriteLine(textSummaryBuilder.ToString());
        }

        public override string ToString()
        {

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append(base.ToString());

            textSummaryBuilder.Append($"\n\n ****** START {this.GetType().ToString()} CHILD ToString() VALUES ****** \n\n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} blnHasRims : {blnHasRutters} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} blnIsConvertable : {blnHasSails} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} boatType : {boatType} \n");

            //// Print summary of vehicle details to console.
            // Console.WriteLine(textSummaryBuilder.ToString());

            return textSummaryBuilder.ToString();

        }

        #endregion

    }
}
