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
        Watcher()
        {

        }

        public void Start()
        {
            if (Task != null)
                Task.Start();
        }

        public void Stop()
        {
            if (CancellationTokenSource != null)
            {
                CancellationTokenSource.Cancel();
                CancellationTokenSource.Dispose();
                CancellationTokenSource = null;
            }

            if (Task != null)
            {
                Task.Dispose();
                Task = null;
            }
        }

        public CancellationTokenSource CancellationTokenSource
        {
            get => CancellationTokenSource;
            set
            {
                if (CancellationTokenSource != null)
                {
                    CancellationTokenSource.Cancel();
                    CancellationTokenSource.Dispose();
                }
                CancellationTokenSource = value;
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
