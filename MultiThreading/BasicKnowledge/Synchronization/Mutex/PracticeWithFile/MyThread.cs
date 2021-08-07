using System;
using System.IO;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        private int _countTry;
        private StreamWriter _streamWriter;

        public Thread Thrd { get; private set; }

        public MyThread(string nameThread, int count)
        {
            _countTry = count;
            Thrd = new Thread(Run);
            Thrd.Name = nameThread;
            Thrd.Start();
        }

        private void Run()
        {
            MainProgram.myMutex.WaitOne();
            Console.WriteLine("Work thread: " + Thrd.Name);
            _streamWriter = new StreamWriter(new FileStream(MainProgram.nameOfFile, FileMode.Append));
            do
            { 
                Console.Write(_countTry + " ");
                _streamWriter.WriteLine(Thrd.Name);
                _countTry--;
            } while (_countTry > 0);
            _streamWriter.Close();
            MainProgram.myMutex.ReleaseMutex();
        }
    }
}
