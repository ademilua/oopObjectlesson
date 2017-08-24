using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OOPClassObjectLesson1
{
    public partial class Default : System.Web.UI.Page
    {
       // Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Car MyNewCar = new Car();
            
           // string[] Cars = new string[] { MyNewCar.carColor(), MyNewCar.carColor(), MyNewCar.carColor() };
            
        }
        private void displayImage(string[] carColors)
        {
            Image1.ImageUrl = "/Images/" + carColors[0] + ".jpg";
            Image2.ImageUrl = "/Images/" + carColors[1] + ".jpg";
            Image3.ImageUrl = "/Images/" + carColors[2] + ".jpg";
        }
       public void Button1_Click(object sender, EventArgs e)
        {
            Car MyNewCar = new Car();
            MyNewCar.Make = "oldschool";
            MyNewCar.Model = "mercedez";
            MyNewCar.Year = 1867;
            MyNewCar.color = "White";
            string[] Cars = new string[] { MyNewCar.carColor(), MyNewCar.carColor(), MyNewCar.carColor() };
            displayImage(Cars);
            resultLabel.Text = String.Format("The price of this Car is:{0:C},and the colors is:{1}-Make:{2}-Model:{3}-Year:{4}", evaluateCarPrice(Cars),
                  typeColor(Cars, MyNewCar), MyNewCar.Make, MyNewCar.Model, MyNewCar.Year);


        }
        // determine how many white cars
        private int determineWhiteCars(string[] Cars)
        {
            int whiteCount = 0;
            if (Cars[0] == "White") whiteCount++;
            if (Cars[1] == "White") whiteCount++;
            if (Cars[2] == "White") whiteCount++;
            return whiteCount;
        }
        // if there are 3 whites cars in the spin return the price to get the cars with bonus
        private int CarsPriceBonus(string[] cars)
        {
            int whiteCount = determineWhiteCars(cars);
            if (whiteCount == 1) return 2000;
            if (whiteCount == 2) return 4000;
            if (whiteCount == 3) return 1000;
            return 0;
        }
        private int evaluateCarPrice(string[] cars)
        {
            if (isOtherColors(cars))return 0;
            int amount = 0;
            if (iswhitecars(cars, out amount)) return amount;
            return 0;
        }

        private bool isOtherColors(string[] cars)
        {
            if (cars[0] != "White" || cars[1] != "White" || cars[2] != "White") return true;
            return false;
        }

        private bool iswhitecars(string[] cars, out int amount)
        {
            
            amount = CarsPriceBonus(cars);
            if (amount > 0)
                return true;
            return false;
        }
        private string typeColor(string[] cars, Car Mycar)
        {
            if(cars[0]=="White" || cars[1] == "White" || cars[2] == "White")
            return Mycar.color; 
           return  "We are dealing with White Cars";
        }
    }

    class Car
        {
            Random random = new Random();
            public string Make { get; set; } // is just like any variable I have work with thus far; 
            public string Model { get; set; } //but it is meant to describe the attributes that are common to object's class. 
            public int Year { get; set; }
            public string color { get; set; }

            
          public string carColor()
            {
                string[] carColor = new string[] {"White"};
                return carColor[random.Next(0)];
            }

        }

        
}
