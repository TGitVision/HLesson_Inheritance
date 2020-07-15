using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    class Vehicle
    {
        #region  Properties and Fields

        // private string name { get; set; }
        private int doors { get; set; }
        private int seats { get; set; }
        private string color { get; set; }
        private int wheels { get; set; }
        private int yearMade { get; set; }
        private bool isRunning { get; set; }

        #endregion

        #region Constructors

        public Vehicle(int doors, int seats, string color, int wheels, int yearMade)
        {
            // this.name = name;
            this.doors = doors;
            this.seats = seats;
            this.color = color;
            this.wheels = wheels;
            this.yearMade = yearMade;
            this.isRunning = false;
        }

        #endregion

        #region Methods

        public virtual void Start() 
        {
            if (isRunning == true)
            {
                Console.WriteLine($"You got to be kidding. {this.GetType().ToString()} is already running;");                
            }
            else 
            {
                Console.WriteLine($"{this.GetType().ToString()} just started.");
                isRunning = true;
            }

        }
        public void Stop()
        {
            if (isRunning == true)
            {
                Console.WriteLine($"{this.GetType().ToString()} just stopped");
                isRunning = false;
            }
            else
            {
                Console.WriteLine($"You got to be kidding. {this.GetType().ToString()} has already stopped.");
            }
        }

        public virtual void GetVehicleDetails() 
        {
            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"{this.GetType().ToString()} doors : {doors} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} seats : {seats} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} colors : {color} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} wheels : {wheels} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} year made : {yearMade}");

            // Print summary of vehicle details to console.
            Console.WriteLine(textSummaryBuilder.ToString());
        }

        #endregion

    }
}
