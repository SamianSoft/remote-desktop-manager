using RemoteDesktopManager.Helpers;
using RemoteDesktopManager.Models;
using Xunit;

namespace RemoteDesktopManagerTest
{
    public class CostsTests
    {
        [Fact]
        public void TestDisplayColorEnum()
        {
            const DisplayColor enumValue = DisplayColor._8bits;
            var color=new RemoteDisplayColor(enumValue);
            Assert.Equal(enumValue.ToLong(),color.Id);
            Assert.Equal("8 bits",color.Title);
            Assert.Equal(8,color.ColorDepth);
        }
        [Fact]
        public void TestScreenSizeEnum()
        {
            const ScreenSize enumValue = ScreenSize.W640_H480;
            var size=new RemoteScreenSize(enumValue);
            Assert.Equal(enumValue.ToLong(),size.Id);
            Assert.Equal("640x480",size.Title);
            Assert.Equal(640,size.Width);
            Assert.Equal(480,size.Height);
        }
    }
}