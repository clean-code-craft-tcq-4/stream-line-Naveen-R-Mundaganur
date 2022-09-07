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
      Assert.True(BatteryDataSender.DisplayDataToConsole()==1);      
    }
    
  }
}
