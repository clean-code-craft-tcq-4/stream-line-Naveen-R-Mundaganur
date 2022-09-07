using System;
using System.Collections.Generic;

namespace BatteryParametersSender
{
  public class StateOfCharge
  {
    public static List<int> GenerateStateOfCharge(int state_of_charge_readings_length, int soc_minimum, int soc_maximum)
    {
            List<int> soc_data = new List<int>();
            for (int temp_index = 0; temp_index < state_of_charge_readings_length; temp_index++)
                soc_data.Add(BatteryDataSender.RandomNumber(soc_minimum, soc_maximum));
            return soc_data;
    }
  }
}
