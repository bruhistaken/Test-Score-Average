using static System.Formats.Asn1.AsnWriter;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        private int average = 0;
        private int totalScore = 0;
        private int scoreCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int score = Int32.Parse(textBox1.Text);


            totalScore += score;
            scoreCount++;
            double average = (double)totalScore / scoreCount;
            textBox2.Text = totalScore.ToString();
            textBox3.Text = scoreCount.ToString();
            textBox4.Text = average.ToString();
            textBox1.Text = score.ToString();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
