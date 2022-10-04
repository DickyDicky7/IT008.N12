using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IT008.N12_015.src.Util
{
    public class Watcher
    {
        public Watcher()
        {

        }

        public void Start()
        {
            if (Task != null)
                Task.Start();
        }

        public void Stop()
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource.Dispose();
                cancellationTokenSource = null;
            }

            if (Task != null)
            {
                Task.Dispose();
                Task = null;
            }
        }

        private CancellationTokenSource cancellationTokenSource;
        public CancellationTokenSource CancellationTokenSource
        {
            get => cancellationTokenSource;
            set
            {
                if (cancellationTokenSource != null)
                {
                    cancellationTokenSource.Cancel();
                    cancellationTokenSource.Dispose();
                }
                cancellationTokenSource = value;
            }
        }

        private Task Task;

        public TimeSpan Interval { get; set; } =
               TimeSpan.FromSeconds(3);

        public Action Action
        {
            set
            {
                CancellationTokenSource = new
                CancellationTokenSource();
                if (Task != null)
                    Task.Dispose();
                Task = new Task(Prototype(value), CancellationTokenSource.Token);
            }
        }

        private Action Prototype(Action Value)
        {
            return () =>
            {
                while (true)
                {
                    if (CancellationTokenSource.Token.IsCancellationRequested)
                        break;
                    Task.Delay(Interval).Wait();
                    Value();
                }
            };
        }
    }
}
