namespace Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void GetAnswerDefault(string[] choices)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
        retry:
            if (MessageBox.Show(this, choices[random.Next(0, choices.Length)], "Final Decision", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                goto retry;
        }

        private void YesNo(object sender, EventArgs e)
        {
            GetAnswerDefault(new string[] { "Yes!", "No!" });
        }

        private void GetMultipleAnswer(object sender, EventArgs e)
        {
            using (GetListForm getListForm = new GetListForm())
            {
                if (getListForm.ShowDialog(this) == DialogResult.OK)
                    GetAnswerDefault(getListForm.textBox.Lines);
            }
        }
    }
}