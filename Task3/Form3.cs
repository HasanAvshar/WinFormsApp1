using Task3.Properties;

namespace Task3
{
    public partial class Form3 : Form
    {
        private System.Windows.Forms.Timer timer;
        private TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

        public Form3()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeButton();
            ShowBakuTime();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeButton()
        {
            button1.Click += button1_Click;
            Controls.Add(button1);
        }

        private void ShowBakuTime()
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ShowLondonTime()
        {
            DateTime londonTime = TimeZoneInfo.ConvertTime(DateTime.Now, londonTimeZone);
            label1.Text = londonTime.ToString("HH:mm:ss");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (button1.Text == "Baku")
            {
                ShowBakuTime();
            }
            else if (button1.Text == "London")
            {
                ShowLondonTime();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Baku")
            {
                button2.BackgroundImage = Resources.london1;
                button1.Text = "London";
            }
            else if (button1.Text == "London")
            {
                button2.BackgroundImage = Resources.az_06;
                button1.Text = "Baku";
            }
        }
    }
}
