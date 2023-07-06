namespace Censor
{
    public partial class Form1 : Form
    {
        public string[] banWords = { "bastard", "tits", "Fuck" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {

            controlBanWord(textInput.Text);

        }

        // For the future, control all possibilities of variation words, uppercase and lowercase
        // Control if a word is a prefix or a suffix
        public void controlBanWord(string text)
        {
            foreach (string word in banWords)
            {
                if (text.Contains(word))
                {
                    textOutput.Text = "Text contains obscene words: " + word;
                    return;
                }
            }
            textOutput.Text = "Text does not contain obscene words";
            return;
        }
    }
}