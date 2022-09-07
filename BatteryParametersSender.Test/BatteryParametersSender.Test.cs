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
      Assert.Equal(1,result);     
    }
    
  }
}
