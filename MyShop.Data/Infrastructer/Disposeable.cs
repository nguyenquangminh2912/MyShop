using System;

namespace MyShop.Data.Infrastructer
{
    public class Disposable : IDisposable
    {
        //Phương thức Disposed này dùng để giải phóng bộ nhớ, có trong c#
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        // Ovveride this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
}


