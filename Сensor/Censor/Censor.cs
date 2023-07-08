namespace Censor
{
    public partial class Censor : Form
    {
        public string[] banSwearWords = { "cumbubble", "shit", "piss", "asshole", "dickweed", "cunt", "bastard", "tits", "fuck", "bitch", "damn", "bollocks", "bugger", "cocknose", "bloody hell", "knobhead", "choad", "crikey", "rubbish", "pissflaps", "shag", "wanker", "twat", "arsebadger", "cumdumpster", "shitmagnet", "scrote", "twatwaffle", "thundercunt", "dickhead", "shitpouch", "jizzstain", "nonce", "pisskidney", "wazzock", "cumwipe", "fanny", "bellend", "pisswizard", "knobjockey", "cuntpuddle", "dickweasel", "quim", "bawbag", "fuckwit", "tosspot", "cockwomble", "twat face", "cack", "flange", "clunge", "dickfucker", "fannyflaps", "wankface", "shithouse", "gobshite", "jizzbreath", "todger", "nutsack", };
        public string[] banViolentWords = { "kill", "assault", "hack", "chop", "rip", "smash", "break", "grab", "slash", "bash", "punch", "behead", "grip", "pummel", "terrorism", "homicide", "suicide", "war" };

        public Censor()
        {
            InitializeComponent();
        }


        // I wanted create a border-radius, but after this message: 
        // As far as I know, No, it is not possible in WinForms with standart TextBox control. Take a look at WPF, instead. FROM: https://stackoverflow.com/questions/21250993/how-to-set-border-radius-for-textbox
        // I decided to leave this idea
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnControl_Click(object sender, EventArgs e)
        {

            textOutput.Text = "";
            if (cbObscene.Checked)
            {
                controlBanWord(textInput.Text, banSwearWords);
            }

            if (cbViolent.Checked)
            {
                controlBanWord(textInput.Text, banViolentWords);
            }

        }


        public void controlBanWord(string text, string[] banControlList)
        {
            int banWordsCounter = 0;
            text = text.ToLower();
            foreach (string word in banControlList)
            {
                if (text.Contains(word))
                {
                    textOutput.Text += "Text contains word: " + word;
                    textOutput.Text += "\r\n";
                    banWordsCounter++;
                }
            }
            textOutput.Text += "From: banList, number of banWords = " + banWordsCounter;
            textOutput.Text += "\r\n";
            textOutput.Text += "\r\n";
            return;
        }
    }
}