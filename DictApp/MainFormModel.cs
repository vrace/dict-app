using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictApp
{
    public class MainFormModel
    {
        private List<String> words;
        private int current;

        public MainFormModel()
        {
            words = new List<string>();
            current = 0;
        }

        public void SetWords(List<String> newWords)
        {
            words = newWords;
            current = 0;
        }

        public bool HasPrev()
        {
            return words.Count > 0 && current > 0;
        }

        public bool HasNext()
        {
            return words.Count > 0 && current < words.Count - 1;
        }

        public void MoveNext()
        {
            if (HasNext())
            {
                current++;
            }
        }

        public void MovePrev()
        {
            if (HasPrev())
            {
                current--;
            }
        }

        public string GetCurrentWord()
        {
            if (words.Count == 0)
            {
                return "-";
            }

            return words[current];
        }

        public string GetCurrentWordAudioUrl()
        {
            string words = GetCurrentWord();
            return string.Format("http://dict.youdao.com/speech?audio={0}", words);
        }
    }
}
