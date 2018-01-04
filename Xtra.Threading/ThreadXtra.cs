using System;
using System.Threading;

namespace Xtra.Threading
{
  public static class ThreadXtra
  {
    public static void RunInNewThread(ParameterizedThreadStart start)
    {
      var thread = new Thread(start);
      thread.Start();
    }

    public static void RunInNewThread(ParameterizedThreadStart start, int maxStackSize)
    {
      var thread = new Thread(start, maxStackSize);
      thread.Start();
    }

    public static void RunInNewThread(ThreadStart start)
    {
      var thread = new Thread(start);
      thread.Start();
    }

    public static void RunInNewThread(ThreadStart start, int maxStackSize)
    {
      var thread = new Thread(start, maxStackSize);
      thread.Start();
    }
  }
}