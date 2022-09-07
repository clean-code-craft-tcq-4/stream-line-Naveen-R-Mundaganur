using System;
using Xunit;
using System.Collections.Generic;

namespace BatteryParametersSender.Test
{
  public class BatteryDataSenderTest
  {
    //int[] a=new int[2]{1,2};
    
    [Fact]
    public void TestBatteryParams()
    {
      bool result=BatteryDataSender.GatherBatteryTelemetryDetails();
      Assert.True(result);
      
      int result1=BatteryDataSender.GenerateRandomNumber(1,1);
      Assert.Equal(1,result1);
      
      List<int> temp_range=new List<int>(){1,2,3,4,5};
      List<int> soc_range=new List<int>(){2,4,6,8};
      bool result3=BatteryDataSender.DisplayBatteryTelemetryDetails(temp_range,soc_range);
      Assert.True(result3);
    }
    
  }
}
