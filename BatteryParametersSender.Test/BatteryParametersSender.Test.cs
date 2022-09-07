using System;
using Xunit;

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
    }
    
  }
}
