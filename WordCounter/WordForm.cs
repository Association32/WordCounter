using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class WordForm
    {
        private string _word;
        private int _frequency = 0;

        public string Word
        {
            get { return _word; }
            set
            {
                if(value.Length>0)
                {
                    _word = value;
                }
                else
                {
                    _word = "";
                }
            }
        }

        public int frequency
        {
            get { return _frequency; }
            set
            {
                if (value>=0)
                {
                    _frequency = value;
                }
                else
                {
                    _frequency = 0;
                }
            }
        }

        public WordForm()
        {
            
        }
        public WordForm(string word)
        {
            this.Word = word;
        }
    }
}
