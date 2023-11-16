using WatchStuff;


public class Tests
{
    public Watch _watch;

    [SetUp]
    public void Setup()
    {
        _watch = new Watch();
        Watch.Main();
    }

    [Test]
    public void TestStartButton()
    {
        Watch.StartButton();
        Assert.IsTrue(Watch.isRunning);
    }

    [Test]
    public void TestPauseButton(){
        Watch.PauseButton();
        Assert.IsFalse(Watch.isRunning);
    }

    [Test]
    public void TestResumeButton(){
        Watch.ResumeButton();
        Assert.IsTrue(Watch.isRunning);
    }

    [Test]
    public void TestResetButton(){
        Watch.ResetButton();
        Assert.IsFalse(Watch.isRunning);
    }


}