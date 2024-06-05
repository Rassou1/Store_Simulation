using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Form.Classes
{
    internal class Storage<T>
    {
        T[] storageBuffer;

        int producedPosition;
        int consumedPosition;

        int componentsInBuffer;
        const int bufferSize = 15;

        Mutex bufferMutex = new Mutex();
        Semaphore occupiedSlots = new Semaphore(0, bufferSize);
        Semaphore emptySlots = new Semaphore(bufferSize, bufferSize);

        public int ComponentsInBuffer { get { return componentsInBuffer; } }

        public Storage()
        {
            producedPosition = -1;
            consumedPosition = -1;
            componentsInBuffer = 0;
            storageBuffer = new T[bufferSize];
        }

        public T Consume()
        {
            try
            {
                occupiedSlots.WaitOne();
                bufferMutex.WaitOne();
                consumedPosition = (consumedPosition + 1) % bufferSize;
                componentsInBuffer--;
                return storageBuffer[consumedPosition];
            }
            finally
            {
                bufferMutex.ReleaseMutex();
                emptySlots.Release();
            }
        }

        public void Produce(T product)
        {
            try
            {
                emptySlots.WaitOne();
                bufferMutex.WaitOne();
                producedPosition = (producedPosition + 1) % bufferSize;
                storageBuffer[producedPosition] = product;
                componentsInBuffer++;
            }
            finally
            {
                bufferMutex.ReleaseMutex();
                occupiedSlots.Release();
            }
        }

        
    }
}
