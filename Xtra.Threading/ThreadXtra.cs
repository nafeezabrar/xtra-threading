using System;
using System.Threading;

namespace Xtra.Threading
{
  public static class ThreadXtra
  {
    public static void RunInNewThread(Action action)
    {
      var thread = new Thread(() => action());
      thread.Start();
    }
  }
}