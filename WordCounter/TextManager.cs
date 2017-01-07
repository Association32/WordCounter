using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class TextManager
    {
        private string _textInput ="";
        private bool _toLower;
        private WordForm[] _exceptionWords = new WordForm[0];
        private char[] _removables = {'.', ',', '?', '\'', '*','-', ':', ';', '%', '"',
        '#', '¤', '&', '/', '(', ')', '=', '+', '@', '£','$', '{', '[', ']', '}', '\\', '<', '>', '|',
        '_', '½', '§', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        private WordForm[] excpetionsWithRemovables = new WordForm[0];
        private WordForm[] _allWords = new WordForm[0];
        private WordForm[] uniqueWords =  new WordForm[0];
        private int _nrUniques;
        private int _nrTotal;


        public int NrTotal
        {
            get { return _nrTotal; }
            set
            {
                if (value < 0)
                {
                    _nrTotal = 0;
                }
                else
                {
                    _nrTotal = value;
                }
            }
        }

        public int NrUniques
        {
            get { return _nrUniques; }
            set
            {
                if(value<0)
                {
                    _nrUniques = 0;
                }
                else
                {
                    _nrUniques = value;
                }
            }
        }

        public WordForm[] AllWords
        {
            get { return _allWords; }
            set { _allWords = value; }
        }

        public WordForm[] UniqueWords
        {
            get { return uniqueWords; }
            set { uniqueWords = value; }
        }

        public char[] Removables
        {
            get { return _removables; }
            set { _removables = value; }
        }

        public bool ToLower
        {
            get { return _toLower; }
            set
            {
                _toLower = value;
            }
        }

        public WordForm[] ExceptionWords
        {
            get { return _exceptionWords; }
            set { _exceptionWords = value; }
        }

        public string TextInput
        {
            get { return _textInput; }
            set
            {
                if (value.Length>0)
                {
                    _textInput = value;
                }
                else
                {
                    _textInput = "";
                }
            }
        }

        public TextManager(string textInput)
        {
            this.TextInput = TextInput;
            this.AllWords = AllWords;
            this.UniqueWords = UniqueWords;
            this.NrTotal = NrTotal;
            this.NrUniques = NrUniques;

        }

        /// <summary>
        /// Nollställer från tidigare uträkningar
        /// </summary>
        private void Reset()
        {
            AllWords = new WordForm[0];
            UniqueWords = new WordForm[0];
            NrTotal = 0;
            NrUniques = 0;
        }

        /// <summary>
        /// Gör alla uträkningar här.
        /// </summary>

        public void Calculate()
        {
            Reset();
            CheckToLower();
            SetExpetionsWithRemovables();
            SplitInput();
            CollectUniques();
            SortUniques();
            CalculateFrequenzy();
            
            NrTotal = CalcNrTotal();
            NrUniques = CalcNrUniques();
        }

        /// <summary>
        /// Om användaren har markerat det ska hela input konverteras till tolower
        /// Gör om alla undantag till små bokstäver också
        /// </summary>
        private void CheckToLower()
        {
            if(ToLower)
            {
                TextInput = TextInput.ToLower();
            }

            for(int i =0; i<ExceptionWords.Length; i++)
            {
                if(ExceptionWords[i]!=null)
                {
                    ExceptionWords[i].Word = ExceptionWords[i].Word.ToLower();
                }
            }
        }

        /// <summary>
        /// Kontrollerar om ett ord kan finns i ExceptionWords, men med extra Removables.
        /// Returnerar ordet från ExceptionWords
        /// </summary>
        private string ReturnOriginalException(string word)
        {
            string exception = "";
            for(int i = 0; i<ExceptionWords.Length; i++)
            {
                if(ExceptionWords[i]!=null)
                {
                    if (word.Contains(ExceptionWords[i].Word))
                    {
                        exception = ExceptionWords[i].Word;
                    }
                }                
            }
            return exception;
        }


        /// <summary>
        /// Sorterar i UniqueWords så att inga ord ligger dubbelt.
        /// </summary>
        private void SortUniques()
        {
            string[] controlArray = new string[uniqueWords.Length];

            int counter = 0;
            for (int i = 0; i < uniqueWords.Length; i++)
            {
                if (!controlArray.Contains(uniqueWords[i].Word))
                {
                    controlArray[counter] = uniqueWords[i].Word;
                    counter++;
                }
            }
            WordForm[] newArray = new WordForm[counter];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = new WordForm(controlArray[i]);
            }

            UniqueWords = newArray;
        }


        /// <summary>
        /// Samlar en lista av unika ord.
        /// </summary>

        private void CollectUniques()
        {
            for (int i = 0; i<AllWords.Length; i++)
            {
                if (CheckIfInExceptionsWithRemovasbles(AllWords[i].Word))
                {
                    if(CheckIfInExceptions(AllWords[i].Word))
                    {
                        if (!CheckIfInUniques(AllWords[i].Word))
                        {
                            AddToUniques(AllWords[i].Word);
                        }
                    }
                    else
                    {
                        string word = ReturnOriginalException(AllWords[i].Word);
                        if ((!CheckIfInUniques(word))&&(word!=""))
                        {
                            AddToUniques(word);
                        }
                    }
                }
                else
                {
                    string word = TrimmedWord(AllWords[i]);
                    if (!CheckIfInUniques(word))
                    {
                        AddToUniques(word);
                    }
                }
            }
        }

        /// <summary>
        /// Räknar ut vilka varianter av exceptionWords som kan förekomma
        /// </summary>
        private void SetExpetionsWithRemovables()
        {
            int length = ExceptionWords.Length * Removables.Length * Removables.Length;
            length += ExceptionWords.Length;
            excpetionsWithRemovables = new WordForm[length];
            int counter = 0;
            for(int i = 0; i<ExceptionWords.Length; i++)
            {
                try
                {
                    string word = ExceptionWords[i].Word;
                    excpetionsWithRemovables[counter] = new WordForm(word);
                    counter++;

                    if (!string.IsNullOrEmpty(ExceptionWords[i].Word))
                    {
                        for (int ii = 0; ii < Removables.Length; i++)
                        {
                            word = Removables[ii] + ExceptionWords[i].Word;
                            excpetionsWithRemovables[counter] = new WordForm(word);
                            counter++;
                            for (int iii = 0; iii < Removables.Length; iii++)
                            {
                                word = ExceptionWords[i].Word + Removables[iii];
                                excpetionsWithRemovables[counter] = new WordForm(word);
                                counter++;

                                word = Removables[ii] + ExceptionWords[i].Word + Removables[iii];
                                excpetionsWithRemovables[counter] = new WordForm(word);
                                counter++;
                            }
                        }
                    }
                }
                catch
                {}
            }
        }


        /// <summary>
        /// Returnerar en sträng utan removables
        /// </summary>
        private string TrimmedWord(WordForm word)
        {
            string trimmedWord;
            trimmedWord = word.Word;

            for(int i  = 0; i<Removables.Length;i++)
            {
                trimmedWord = trimmedWord.Trim(Removables[i]);
            }

            return trimmedWord;
        }

        /// <summary>
        /// Lägger till ett ord _uniqueWords.
        /// </summary>
        private void AddToUniques(string word)
        {
            WordForm[] thisWordFormArray;
            if (UniqueWords.Length==0)
            {
                thisWordFormArray = new WordForm[1];
            }
            else
            {
                thisWordFormArray = new WordForm[UniqueWords.Length + 1];
            }
            
            for (int i = 0; i < UniqueWords.Length; i++)
            {
                thisWordFormArray[i] = UniqueWords[i];
            }
            thisWordFormArray[UniqueWords.Length] = new WordForm(word);
            UniqueWords = new WordForm[thisWordFormArray.Length];
            for (int i = 0; i < UniqueWords.Length; i++)
            {
                UniqueWords[i] = new WordForm(thisWordFormArray[i].Word);                         
            }                     
        }

        /// <summary>
        /// Kontrollerar om ordet finns i undantagen, inkluderat removables runt det.
        /// </summary>
        private bool CheckIfInExceptionsWithRemovasbles(string word)
        {
            bool isInExceptions = false;
            for(int i =0; i< excpetionsWithRemovables.Length; i++)
            {
                if(excpetionsWithRemovables[i]!=null)
                {
                    if (excpetionsWithRemovables[i].Word == word)
                    {
                        isInExceptions = true;
                    }
                }
            }
            return isInExceptions;
        }

        /// <summary>
        /// Kontrolelrar om ett ord finns med i listan med undantag
        /// </summary>
        private bool CheckIfInExceptions(string word)
        {
            bool isInExceptions = false;
            for (int i = 0; i < ExceptionWords.Length; i++)
            {
                if (ExceptionWords[i] != null)
                {
                    if (ExceptionWords[i].Word == word)
                    {
                        isInExceptions = true;
                    }
                }
            }
            return isInExceptions;
        }
        /// <summary>
        /// Kontrollerar om ett ord redan är representerat i _uniqueWords
        /// </summary>
        private bool CheckIfInUniques(string  word)
        {
            bool isInUniques = true;
            word = word.Trim();

            if((TrimmedWord(new WordForm(word)).Length>0)||(CheckIfInExceptions(word)))
            {
                if(UniqueWords.Length>0)
                {
                    for (int i = 0; i < UniqueWords.Length; i++)
                    {
                        if (UniqueWords[i].Word == word)
                        {
                            isInUniques = true;
                        }
                        else
                        {
                            isInUniques = false;
                        }
                    }
                }
                else
                {
                    isInUniques = false;
                }
                
            }
            else
            {
                isInUniques = true;
            }

            return isInUniques;
        }


        /// <summary>
        /// Delar upp inmatad text i separata ord.
        /// </summary>
        private void SplitInput()
        {
            TextInput = TextInput.Trim();
            string[] thisStringArray = TextInput.Split(' ');
            AllWords = new WordForm[thisStringArray.Length];
            
            for (int i  = 0; i<thisStringArray.Length; i++)
            {
                AllWords[i] = new WordForm(thisStringArray[i]);                
            } 
        }
        
        /// <summary>
        /// Skriver om till text som kan visas i .txt eller .xls filer
        /// </summary>
        public string SaveString()
        {
            string saveString = "";
            for(int i = 0; i<UniqueWords.Length; i++)
            {
                if ((UniqueWords[i] != null)&& (UniqueWords[i].Word != ""))
                {
                    saveString += UniqueWords[i].Word;
                    saveString += "\t";
                    saveString += UniqueWords[i].frequency;
                    saveString += Environment.NewLine;
                }
            }
            return saveString;
        }

        /// <summary>
        /// Räknar ut antalet ord i texten
        /// Sorterar bort om några orde enbart består av removables
        /// </summary>
        private int CalcNrTotal()
        {
            int nrInArray = 0;
            for (int i = 0; i < AllWords.Length; i++)
            {
                if ((!string.IsNullOrEmpty(AllWords[i].Word))&&(TrimmedWord(AllWords[i]).Length>0))
                {
                    nrInArray++;
                }
            }
            return nrInArray;
        }

        /// <summary>
        /// Räknar ut antalet unika ord i texten.
        /// </summary>
        private int CalcNrUniques()
        {
            int nrInArray = 0;
            for (int i = 0; i < UniqueWords.Length; i++)
            {
                if (!string.IsNullOrEmpty(UniqueWords[i].Word))
                {
                    nrInArray++;
                }
            }
            return nrInArray;
        }

        /// <summary>
        /// Räknar ut hur ofta varje unikt ord förekommer i texten
        /// </summary>
        private void CalculateFrequenzy()
        {
            for (int i =0; i<UniqueWords.Length; i++)
            {
                for (int ii =0; ii<AllWords.Length; ii++)
                {
                    if(UniqueWords[i].Word==AllWords[ii].Word)
                    {
                        UniqueWords[i].frequency++;
                    }
                    else if(AllWords[ii].Word.Contains(UniqueWords[i].Word))
                    {
                        UniqueWords[i].frequency++;
                    }
                }
            }
        }
        /// <summary>
        /// Kontrollerar inmatad data, så att det inte till exempel 
        /// bara står tcken som ska raderas
        /// </summary>
        public bool CheckInput(string words)
        {
            bool isOk = true;
            
            for (int i=0; i<Removables.Length; i++)
            {
                words = words.Trim(Removables[i]);
                words = words.Trim();
            }
            if(words.Trim().Length>0)
            {
                isOk = true;
            }
            else
            {
                isOk = false;
                for (int i = 0; i < ExceptionWords.Length; i++)
                {
                    if (words.Contains(ExceptionWords[i].Word))
                    {
                        isOk = true;
                    }
                }
            }
            return isOk;
        }

        /// <summary>
        /// Lägger till nya undantag
        /// </summary>
        public void AddException(string word)
        {
            WordForm[] newArray = new WordForm[ExceptionWords.Length + 1];

            for(int i  = 0; i < ExceptionWords.Length; i++)
            {
                newArray[i] = ExceptionWords[i];
            }
            newArray[ExceptionWords.Length] = new WordForm(word);

            ExceptionWords = newArray;
        }


        /// <summary>
        /// Raderar objekt ur exceptions
        /// </summary>
        public void DeleteException(int indexer)
        {
            
            try
            {
                for (int i = indexer; i < ExceptionWords.Length - 1; i++)
                {
                    ExceptionWords[i] = ExceptionWords[i + 1];
                }
                ExceptionWords[ExceptionWords.Length - 1] = null;
            }
            catch { }
        }
    }
}
