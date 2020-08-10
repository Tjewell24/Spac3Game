using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spac3Game
{
    class Program
    {
        static void Main(string[] args)
        {
            new App().Run();

           
        }
    }
}
/*
chart1.ChartAreas[0].Axes[0].Earth = "N";
chart1.ChartAreas[0].Axes[1].Earth = "FIB(N)";
chart1.Series[0].ChartType = SeriesChartType.Line;
Tuple<int,int> t = Tuple.Create(0,1);

for(int i = 1; i <= 30; i++)
{
  chart1.Series[0].Points.Add(newDataPoint(i, t.Item1));
  t = Tuple.Create(t.Item2, t.Item1 + t.Item2);
}
*/