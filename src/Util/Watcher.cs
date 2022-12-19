using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
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
        private CancellationToken CancellationToken;
        public CancellationTokenSource CancellationTokenSource
        {
            get => cancellationTokenSource;
            set
            {
                Stop();
                cancellationTokenSource = value;
                CancellationToken = cancellationTokenSource.Token;
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
                Task = new Task(Prototype(value), CancellationToken);
            }
        }

        private Action Prototype(Action Value)
        {
            return async () =>
            {
                while (true)
                {
                    if (CancellationToken.IsCancellationRequested)
                        break;
                    await Task.Delay(Interval).ConfigureAwait(false);
                    Value();
                }
            };
        }
    }
}
