namespace Hackathon
{
    internal static class Program
    {
        public class MonitorForBuffer
        {

            public int[] buffer_tickets;
            Mutex mutexForBuffer;
            int count;
            Mutex mutexForConsumers;
            Mutex mutexForProducers;
            int bufferSize;
            int maxStudents;
            int maxTickets;
            public MonitorForBuffer(int sizeOfBuffer, int studentsRate, int ticketsRate)
            {
                maxStudents = studentsRate; // initialize max number of students
                maxTickets = ticketsRate; // initialize max number of tickets
                bufferSize = sizeOfBuffer; // initialize buffer size
                buffer_tickets = new int[sizeOfBuffer]; // initialize buffer
                mutexForConsumers = new Mutex(); // mutex for consumers - number 1
                mutexForProducers = new Mutex(); // mutex for producers - number 2
                mutexForBuffer = new Mutex(); // mutex for buffer - number 3
                count = 0; // initialize count of current available tickets
                for (int i = 0; i < sizeOfBuffer; i++) // initialize buffer with 0
                {
                    buffer_tickets[i] = 0;
                }

            }

            public void Produce(int ticket)
            {
                mutexForProducers.WaitOne(); // acquire producer mutex
                mutexForBuffer.WaitOne(); // acquire buffer mutex

                if (count < bufferSize && count < maxTickets) // check if buffer is not full and can accept more tickets
                {
                    for (int i = 0; i < buffer_tickets.Length; i++)
                    {
                        if (buffer_tickets[i] == 0) // search for empty slot
                        {
                            buffer_tickets[i] = ticket; // insert ticket
                            count++;
                            break;
                        }
                    }
                }

                mutexForBuffer.ReleaseMutex(); // release buffer mutex
                mutexForProducers.ReleaseMutex(); // release producer mutex
            }

            public int Consume()
            {
                mutexForConsumers.WaitOne(); // acquire consumer mutex
                mutexForBuffer.WaitOne(); // acquire buffer mutex

                int ticket = 0;
                if (count > 0 && count < maxStudents) // check if there are tickets available and can let students in
                {
                    for (int i = 0; i < buffer_tickets.Length; i++)
                    {
                        if (buffer_tickets[i] != 0) // search for full slot
                        {
                            ticket = buffer_tickets[i]; // get ticket
                            buffer_tickets[i] = 0; // remove ticket
                            count--;
                            break;
                        }
                    }
                }

                mutexForBuffer.ReleaseMutex(); // release buffer mutex
                mutexForConsumers.ReleaseMutex(); // release consumer mutex

                return ticket;
            }


        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }


    }
}