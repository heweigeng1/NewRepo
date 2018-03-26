using FileConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitDemo
{
    public class FileConsoleApp_Test
    {
        [Fact]
        public void SaveToTxtTest()
        {
            var result = SaveFile.SaveToTxt("asdf12313", @"D:\abc.txt");
            Assert.True(result != "error");
        }
        [Theory(DisplayName ="多测试数据")]
        [InlineData("adfasfaf",@"d:\obj.txt","error")]//true
        [InlineData("my love csharp",@"d:efg.txt","error")]//参数2 路径不正确
        [InlineData("love java",@"d:\xyz.txt","afdf")]//返回值异常
        public void SaveToTxtTest2(string data,string path,string result)
        {
            var str = SaveFile.SaveToTxt(data, path);
            Assert.True(str == result);
        }
    }
}
