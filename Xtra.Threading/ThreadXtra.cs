using System.Threading;

namespace Xtra.Threading
{
  public static class ThreadXtra
  {
    public static Thread RunInNewThread(ParameterizedThreadStart start)
    {
      var thread = new Thread(start);
      thread.Start();
      return thread;
    }

    public static Thread RunInNewThread(ParameterizedThreadStart start, int maxStackSize)
    {
      var thread = new Thread(start, maxStackSize);
      thread.Start();
      return thread;
    }

    public static Thread RunInNewThread(ThreadStart start)
    {
      var thread = new Thread(start);
      thread.Start();
      return thread;
    }

    public static Thread RunInNewThread(ThreadStart start, int maxStackSize)
    {
      var thread = new Thread(start, maxStackSize);
      thread.Start();
      return thread;
    }
  }
}