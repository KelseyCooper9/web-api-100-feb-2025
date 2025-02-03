using Alba;

namespace SoftwareCatalog.Tests.Status;
// Have to be public classes.  And they have to extend* ControllerBase
public class CanGetTheSTatus
{
    [Fact]
    public async Task GetsA200WhenGettingTheStatus()
    {
        var host = await AlbaHost.For<Program>();
        await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });
    }


}
