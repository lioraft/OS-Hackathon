using System;
using System.Windows.Forms;
using static Hackathon.Program;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace Hackathon
{
    public partial class Form1 : Form
    {
        string button1Text; // text of button1
        int button1Len = 0; // length of button1 text
        int curTicket = 0; // current ticket - counter for serial number of current ticket
        Mutex mutex = new Mutex(); // mutex for next available ticket
        MonitorForBuffer monitor; // monitor for buffer
        int numberOfStudents; // number of students
        int numberOfTickets; // number of tickets
        int sizeOfBuffer = 10; // size of buffer
        int studentRate; // number of students allowed to enter simultaneously
        int ticketRate; // number of tickets allowed to be sold simultaneously
        public Form1()
        {
            InitializeComponent();
            hallTickets1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hallTickets1.Visible = true;
            // check if input is valid
            if (!int.TryParse(textBox1.Text, out numberOfTickets) || !int.TryParse(textBox2.Text, out studentRate) || !int.TryParse(textBox3.Text, out ticketRate) || !int.TryParse(textBox4.Text, out numberOfStudents) || numberOfStudents < 1 || numberOfTickets < 1 || ticketRate < 1 || studentRate < 1)
            {
                // if invalid, show error message
                hallTickets1.Visible = false;
                errorProvider1.SetError(textBox1, "Please enter a valid number!");
            }
            else // if input is valid
            {
                errorProvider1.Clear();
                // get number of students waiting
                int waiting = numberOfStudents - 1;
                // initialize monitor
                monitor = new MonitorForBuffer(sizeOfBuffer, studentRate, ticketRate);
                // start managing sales:
                // create producer and consumer threads
                Thread producer = new Thread(() =>
                {
                    for (int i = 0; i < numberOfStudents; i++)
                    {
                        if (curTicket == numberOfTickets + 1) // check if all tickets are sold
                        {
                            break;
                        }
                        mutex.WaitOne();
                        int ticket = curTicket;
                        curTicket++;
                        monitor.Produce(curTicket); // produce ticket numbers and add them to the buffer
                        mutex.ReleaseMutex();
                        Thread.Sleep(300); // simulate the production time
                    }
                });

                Thread consumer = new Thread(() =>
                {
                    // in order to calculate average waiting time
                    DateTime startTime = DateTime.Now;
                    for (int i = 1; i < numberOfStudents + 1; i++)
                    {
                        if (curTicket == numberOfTickets + 1) // check if all tickets are sold
                        {
                            break;
                        }
                        int ticketNumber = monitor.Consume(); // consume ticket numbers from the buffer
                        hallTickets1.Invoke((MethodInvoker)(() => hallTickets1.setTicketNumber(ticketNumber.ToString()))); // update ticket number
                        hallTickets1.Invoke((MethodInvoker)(() => hallTickets1.setWaitingNumber(waiting.ToString()))); // update waiting people number
                        waiting--;
                        TimeSpan timePassed = DateTime.Now - startTime;
                        hallTickets1.Invoke((MethodInvoker)(() => hallTickets1.setAverageTime(((int)timePassed.TotalMilliseconds / i).ToString()))); // update average time
                        hallTickets1.Invoke((MethodInvoker)(() => hallTickets1.setPercentageOfCapacity((Math.Ceiling(((double)i / numberOfTickets) * 100)).ToString()))); // update percentage of capacity taken
                        Thread.Sleep(300); // simulate the consuming time
                    }
                });

                // start the threads
                producer.Start();
                consumer.Start();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // animation of start button text
            button1Text = button1.Text;
            button1.Text = "";
            timer1.Start();
            // animation of gif
            timer2.Start();
        }

        // timer for start button
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1Len < button1Text.Length)
            {
                button1.Text += button1Text.ElementAt(button1Len);
                button1Len++;
            }
            else
            {
                button1.Text = "";
                button1Len = 0;
            }
        }

        // timer for gif
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if (hallTickets1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hallTickets1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}