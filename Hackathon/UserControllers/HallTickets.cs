using static Hackathon.Program;

namespace Hackathon
{
    public partial class HallTickets : UserControl
    {
        private DateTime start; // starting time
        private System.Windows.Forms.Timer timer; // timer to count time that had passed
        public HallTickets()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer(); // initialize a timer
            timer.Interval = 500; // update every half second (which is 500 milliseconds)
            timer.Tick += addSecondToTimer;
        }
        private void HallTickets_Load(object sender, EventArgs e)
        {

            start = DateTime.Now; // save start time 
            timer.Start(); // Start the timer
        }

        private void addSecondToTimer(object sender, EventArgs e)
        {
            // get the time that has passed since the start time
            TimeSpan passedTime = DateTime.Now - start;

            // update time in the textbox
            textBox2.Text = passedTime.ToString(@"hh\:mm\:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
        }

        public void setTicketNumber(String ticket)
        {
            textBox1.Text = ticket;
        }

        public void setWaitingNumber(String waiting)
        {
            textBox4.Text = waiting;
        }

        public void setAverageTime(String time)
        {
            textBox5.Text = time;
        }

        public void setPercentageOfCapacity(String percentage)
        {
            textBox3.Text = percentage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
