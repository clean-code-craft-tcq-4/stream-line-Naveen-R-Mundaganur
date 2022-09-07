using System;
using Xunit;
using System.Collections.Generic;

namespace BatteryParametersSender.Test
{
  public class BatteryDataSenderTest
  {
    [Fact]
    public void TestBatteryParams()
    {
      bool result=BatteryDataSender.GatherBatteryTelemetryDetails();
      Assert.True(result);                        
    }
    
    [Fact]
    public void ValidateConsoleOutput()
    {
      List<int> temp_range=new List<int>(){1,2,3,4,5};
      List<int> soc_range=new List<int>(){2,4,6,8};
      bool result=BatteryDataSender.DisplayBatteryTelemetryDetails(temp_range,soc_range);
      Assert.False(result);
    }
    
    [Fact]
    public void RandomNumberMethod()
    {
      int result=BatteryDataSender.GenerateRandomNumber(1,1);
      Assert.Equal(1,result);
    }

    [Fact]
    public void CheckEmptyData()
    {
      List<int> temp_range=null;
      List<int> soc_range=new List<int>(){2,4,6,8};
      bool result=BatteryDataSender.IsBatteryParametersEmpty(temp_range,soc_range);
      Assert.False(result); 
    }
    
    [Fact]
    public void ValidateBatteryParameters()
    {
      List<int> temp_range=new List<int>{1,2,3,4,5};
      List<int> soc_range=new List<int>(){2,4,6,8};
      bool result=BatteryDataSender.IsBatteryParametersEmpty(temp_range,soc_range);
      Assert.True(result); 
    }
    
    [Fact]
    public void ValidateTemperatureSampleParametersforZeroLength()
    {
      List<int> sample_info=new List<int>();
      sample_info=BatteryDataSender.GenerateTemperatures(0,-20,250);
      Assert.Null(sample_info);
    }
    
    [Fact]
    public void ValidateStateOfChargeSampleParametersforZeroLength()
    {
      List<int> sample_info=new List<int>();
      sample_info=BatteryDataSender.GenerateStateOfCharge(0,10,95);      
      Assert.Null(sample_info);
    }        
  }
}
