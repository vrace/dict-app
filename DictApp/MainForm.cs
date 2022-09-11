using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Media;

namespace DictApp
{
    public partial class MainForm : Form
    {
        private MainFormModel model = new MainFormModel();

        public MainForm()
        {
            InitializeComponent();
            LoadWords();
            UpdateCurrentWord();
            UpdateDisplayingWord();
        }

        private void LoadWords()
        {
            List<string> words = new List<string>();
            words.Add("hello");
            words.Add("world");
            words.Add("example");
            words.Add("education");
            words.Add("estimation");

            model.SetWords(words);
        }

        private void UpdateCurrentWord()
        {
            buttonPrev.Enabled = model.HasPrev();
            buttonNext.Enabled = model.HasNext();
            UpdateDisplayingWord();
            PlayCurrentWord();
        }

        private void UpdateDisplayingWord()
        {
            bool revealText = checkBoxRevealWord.Checked;
            if (!revealText)
            {
                labelWord.Text = "******";
            }
            else
            {
                labelWord.Text = model.GetCurrentWord();
            }
        }

        private void PlayCurrentWord()
        {
            axMediaPlayer.URL = "";
            Task.Factory.StartNew(() => PlaySoundAsync());
        }

        private void PlaySoundAsync()
        {
            string filename = string.Format("{0}.mp3", model.GetCurrentWord());
            if (!File.Exists(filename))
            {
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(filename)))
                {
                    WebRequest request = WebRequest.Create(model.GetCurrentWordAudioUrl());
                    var res = request.GetResponse();
                    Stream s = res.GetResponseStream();
                    using (BinaryReader reader = new BinaryReader(s))
                    {
                        while (true)
                        {
                            byte[] bytes = reader.ReadBytes(4096);
                            if (bytes == null || bytes.Length == 0)
                            {
                                break;
                            }

                            writer.Write(bytes);
                        }
                    }
                }
            }

            axMediaPlayer.URL = filename;
        }

        private void checkBoxRevealWord_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplayingWord();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            model.MovePrev();
            UpdateCurrentWord();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            model.MoveNext();
            UpdateCurrentWord();
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            PlayCurrentWord();
        }
    }
}
