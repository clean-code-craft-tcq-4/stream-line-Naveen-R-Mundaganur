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
      int result=BatteryDataSender.GatherBatteryTelemetryDetails();
      Assert.Equal(true,result);
      
      int result=BatteryDataSender.GenerateRandomNumber(1,1);
      Assert.Equal(1,result);
    }
    
  }
}
