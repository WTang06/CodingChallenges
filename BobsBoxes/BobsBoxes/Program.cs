using System;
using System.IO;

namespace BobsBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("boxdata.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            double totalCost = 0;

            double plastic = Convert.ToDouble(reader.ReadLine());

            writer.WriteLine("BOB'S BOXES COST CALCULAIONS");
            
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split(',');

                string boxColour = parts[0];

                writer.WriteLine("Box colour:{0}", boxColour);
                writer.WriteLine("-----------------------------------------");

                double innerLength = Convert.ToDouble(parts[1]);
                double innerWidth = Convert.ToDouble(parts[2]);
                double innerHeight = Convert.ToDouble(parts[3]);
                
                double innerVolume = innerLength * innerWidth * innerHeight;

                double thicknessInMm = Convert.ToDouble(parts[4]);
                double thickness = thicknessInMm/10;

                double outerLength = (thickness * 2) + innerLength;
                double outerWidth = (thickness * 2) + innerWidth;
                double outerHeight = (thickness * 2) + innerHeight;

                double outerVolume = outerLength * outerWidth * outerHeight;

                double plasticVolume = outerVolume - innerVolume;

                double boxCost = plasticVolume * plastic;
                string bCost = string.Format("{0:C}", Convert.ToDouble(boxCost));

                writer.WriteLine("Cost per box:{0}", bCost);

                double boxAmount = Convert.ToDouble(parts[5]);

                double cost = boxCost * boxAmount;
                string totalBoxCost = string.Format("{0:C}", Convert.ToDouble(cost));

                writer.WriteLine("Cost for {0} boxes:{1}", boxAmount, totalBoxCost);
                writer.WriteLine("-----------------------------------------");

                totalCost = totalCost + cost;
   
            }

            string currencyTotalCost  = string.Format("{0:C}", Convert.ToDouble(totalCost));
            writer.WriteLine("Total Cost:{0}", currencyTotalCost);

            reader.Close();
            writer.Close();

        }
    }
}
