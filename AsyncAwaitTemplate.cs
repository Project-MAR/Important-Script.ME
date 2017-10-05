public async void asyncExample()
{
    await Task.Run(() =>
    {
        callBeforeThread();
    });

    callAfter();
}

public void callBeforeThread()
{
     // This function is run before in a sperate thread.
     
}

public void callAfter()
{
     // This function is run after a thread callBeforeThread() is done.
     
}
