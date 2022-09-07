using System;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersSender
{
  public class BatteryDataSender
  {    
      private static readonly Random _random = new Random();
      private const int SOC_MIN = 0;
      private const int SOC_MAX = 80;
      private const int TEMP_MIN = -50;
      private const int TEMP_MAX = 200;
      private const int READING_MAX = 50;                
                
      public static bool GatherBatteryTelemetryDetails()
      {           
            bool isDataPrintable = false;
            List<int> temperature_data = new List<int>();
            List<int> soc_data = new List<int>();
            temperature_data = GenerateTemperatures(READING_MAX, TEMP_MIN, TEMP_MAX);
            soc_data = GenerateStateOfCharge(READING_MAX, SOC_MIN, SOC_MAX);
            if(IsBatteryParametersEmpty)              
            {
              isDataPrintable=DisplayBatteryTelemetryDetails(temperature_data, soc_data);  
            }
            return isDataPrintable;
      }
      
      public static bool IsBatteryParametersEmpty(List<int> temperature_data, List<int> soc_data)
      {
          bool isbatteryDataAvailable=false
          if(temperature_data!=null && soc_data!=null)
          {
            isbatteryDataAvailable=true;
          }          
            return isbatteryDataAvailable;
      }
    
      public static bool DisplayBatteryTelemetryDetails(List<int> temperature_data, List<int> soc_data)
      {
        bool isPrintable = false;
            if (temperature_data.Count == READING_MAX && soc_data.Count == READING_MAX)
            {
                Console.WriteLine($"Temperature Reading, State Of Charge Reading");
                for (int index = 0; index < READING_MAX; index++)
                {
                    Console.WriteLine($"{temperature_data[index].ToString()}, {soc_data[index].ToString()}");
                }
                isPrintable = true;
            }
            return isPrintable;
      }
    
      //This method generates the Random Number for specified Minimum and Maximum range
      public static int GenerateRandomNumber(int minimum_value, int maximum_value)
      {
            if (minimum_value >= int.MinValue && maximum_value <= int.MaxValue)
                return _random.Next(minimum_value, maximum_value);
            else
                return 0;
      }
      
      public static List<int> GenerateTemperatures(int temperature_readings_length, int temperature_minimum, int temperature_maximum)
      {
            if (temperature_readings_length>0)
            {
              List<int> temperature_samples = new List<int>();
              for(int temp_index=0;temp_index< temperature_readings_length; temp_index++)
              {
                  temperature_samples.Add(GenerateRandomNumber(temperature_minimum, temperature_maximum));
              }        
              return temperature_samples;
            }
            else
            {
              return temperature_samples=null;
            }
            
      }
      public static List<int> GenerateStateOfCharge(int state_of_charge_readings_length, int soc_minimum, int soc_maximum)
      {
             if (state_of_charge_readings_length>0)
            {
              List<int> soc_samples = new List<int>();
              for (int temp_index = 0; temp_index < state_of_charge_readings_length; temp_index++)
                  soc_samples.Add(GenerateRandomNumber(soc_minimum, soc_maximum));
              return soc_samples;
             }
             else
             {
                return soc_samples=null;
             }  
      }
  }  
}
