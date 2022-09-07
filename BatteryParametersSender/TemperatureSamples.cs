using System;
using System.Collections.Generic;

namespace BatteryParametersSender
{
  public class TemperatureData
  {
      public static List<int> GenerateTemperatures(int temperature_readings_length, int temperature_minimum, int temperature_maximum)
        {
            List<int> temperature_data = new List<int>();
            for (int temp_index = 0; temp_index < temperature_readings_length; temp_index++)
                temperature_data.Add(BatteryDataSender.RandomNumber(temperature_minimum, temperature_maximum));
            return temperature_data;
        }
  }
}
