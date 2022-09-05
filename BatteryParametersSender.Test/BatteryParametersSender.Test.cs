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
      Assert.True(BatteryDataSender.printData(1)==1);
      /*if(Assert.True(BatteryDataSender.printData(1)==1))
         Console.WriteLine(1);
       else if(Assert.True(BatteryDataSender.printData(2)==2))
          Console.WriteLine(2);
          */
    }
    
  }
}
