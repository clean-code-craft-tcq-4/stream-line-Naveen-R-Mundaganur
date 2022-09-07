using System;
using System.Collections.Generic;
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
    
      private List<int> temperature_data=null;
      private List<int> soc_data = null;
      private bool isDataPrintable = false;
      
      
      public static bool DisplayDataToConsole()
      {            
            temperature_data = new List<int>();
            soc_data = new List<int>();
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
      //This method generates the Random Number for specified Minimum and Maximum range
      public static int RandomNumber(int min, int max)
      {
            return _random.Next(min, max);
      }
  }  
}
