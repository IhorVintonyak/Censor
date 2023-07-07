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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            controlBanWord(textInput.Text, banSwearWords);

        }

        // For the future, control all possibilities of variation words, uppercase and lowercase
        public void controlBanWord(string text, string[] banControlList)
        {
            int banWordsCounter = 0;
            foreach (string word in banSwearWords)
            {
                if (text.Contains(word))
                {
                    //textOutput.Text += "Text contains obscene words: " + word;
                    banWordsCounter++;
                }
            }
            textOutput.Text += "banWordsCounter = " + banWordsCounter + "\n";
            textOutput.Text += "END";
            return;
        }
    }
}