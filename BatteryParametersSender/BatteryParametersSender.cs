using System;
using System.Linq;

namespace BatteryParametersSender
{
  public class BatteryDataSender
  {    
      private static readonly Random _random = new Random();
      public const int SOC_MIN = 0;
      public const int SOC_MAX = 100;
      public const int TEMP_MIN = -50;
      public const int TEMP_MAX = 150;
      public const int READING_MAX = 50;
    
      public static bool DisplayDataToConsole()
        {
            bool isDataPrintable = false;
            List<int> temperature_data = new List<int>();
            List<int> soc_data = new List<int>();
            temperature_data = TemperatureData.GenerateTemperatures(READING_MAX, TEMP_MIN, TEMP_MAX);
            soc_data = StateOfCharge.GenerateStateOfCharge(READING_MAX, SOC_MIN, SOC_MAX);
            if(temperature_data.Count== READING_MAX && soc_data.Count== READING_MAX)
            {
                for(int index=0;index< READING_MAX;index++)
                    Console.WriteLine($"{ temperature_data[index].ToString()},{soc_data[index].ToString()}");
                isDataPrintable = true;
            }
            return isDataPrintable;
        }
  }  
}
