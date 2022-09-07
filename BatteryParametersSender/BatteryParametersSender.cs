using System;
using System.Collections.Generic;
using System.Linq;

namespace BatteryParametersSender
{
  public class BatteryDataSender
  {    
      //Class Fields
      private static readonly Random _random = new Random();
      private const int SOC_MIN = 0;
      private const int SOC_MAX = 80;
      private const int TEMP_MIN = -50;
      private const int TEMP_MAX = 200;
      private const int MAX_READING = 50;                
      
      //Methods collects the battery system parameters and process for Display
      public static bool GatherBatteryTelemetryDetails()
      {           
            bool isDataPrintable = false;
            List<int> temperature_data = new List<int>();
            List<int> soc_data = new List<int>();
            temperature_data = GenerateBatteryParameterSamples(MAX_READING, TEMP_MIN, TEMP_MAX);
            soc_data = GenerateBatteryParameterSamples(MAX_READING, SOC_MIN, SOC_MAX);
            if(IsBatteryParametersEmpty(temperature_data,soc_data))              
            {
              isDataPrintable=DisplayBatteryTelemetryDetails(temperature_data, soc_data);  
            }
            return isDataPrintable;
      }
    
      //Check the battery parameters are null
      public static bool IsBatteryParametersEmpty(List<int> temperature_data, List<int> soc_data)
      {
          bool isbatteryDataAvailable=false;
          if(temperature_data!=null && soc_data!=null)
          {
            isbatteryDataAvailable=true;
          }          
            return isbatteryDataAvailable;
      }
    
      //Display the Battery Parameters to Console Output
      public static bool DisplayBatteryTelemetryDetails(List<int> temperature_data, List<int> soc_data)
      {
        bool isPrintable = false;
            if (temperature_data.Count == MAX_READING && soc_data.Count == MAX_READING)
            {
                Console.WriteLine($"Temperature Reading, State Of Charge Reading");
                for (int index = 0; index < MAX_READING; index++)
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
            return _random.Next(minimum_value, maximum_value);           
      }
    
      //Methods generates the Battery Parameters Samples and process for Display
      public static List<int> GenerateBatteryParameterSamples(int battery_param_readings_length, int battery_param_minimum, int battery_param_maximum)
      {
          List<int> battery_parameter_samples = new List<int>();
            if (battery_param_readings_length>0)
            {
              for(int temp_index=0;temp_index< battery_param_readings_length; temp_index++)
              {
                  battery_parameter_samples.Add(GenerateRandomNumber(battery_param_minimum, battery_param_maximum));
              }        
              return battery_parameter_samples;
            }
            else
            {
              battery_parameter_samples=null;
              return battery_parameter_samples;
            }            
      } 
  }  
}
