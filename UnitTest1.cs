namespace poser_os_shim;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Shim osShim = Shim.Replace(() => OperatingSystem.IsWindows()).With(() => false);

        PoseContext.Isolate(() =>
        {
            Assert.False(OperatingSystem.IsWindows());
        }, osShim);
    }
}
