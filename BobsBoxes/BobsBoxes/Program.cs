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

            double TotalCost = 0;

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split(',');

                string boxcolour = (parts[0]);

                writer.WriteLine("Box colour:{0}", boxcolour);
                writer.WriteLine("");

                double innerlength = Convert.ToDouble(parts[1]);
                double innerwidth = Convert.ToDouble(parts[2]);
                double innerheight = Convert.ToDouble(parts[3]);
                
                double innervolume = innerlength * innerwidth * innerheight;

                double thicknessinmm = Convert.ToDouble(parts[4]);
                double thickness = thicknessinmm/10;

                double outerlength = (thickness * 2) + innerlength;
                double outerwidth = (thickness * 2) + innerwidth;
                double outerheight = (thickness * 2) + innerheight;

                double outervolume = outerlength * outerwidth * outerheight;

                double plasticvolume = outervolume - innervolume;

                double boxcost = plasticvolume * 0.00025;
                string bcost = string.Format("{0:C}", Convert.ToDouble(boxcost));

                writer.WriteLine("Cost per box:{0}", bcost);

                double boxamount = Convert.ToDouble(parts[5]);

                double cost = boxcost * boxamount;
                string TotalBoxCost = string.Format("{0:C}", Convert.ToDouble(cost));

                writer.WriteLine("Cost for {0} boxes:{1}", boxamount, TotalBoxCost);
                writer.WriteLine("");

                TotalCost = TotalCost + cost;
   
            }

            string CurrencyTotalCost  = string.Format("{0:C}", Convert.ToDouble(TotalCost));
            writer.WriteLine("Total Cost:{0}", CurrencyTotalCost);

            reader.Close();
            writer.Close();

        }
    }
}
