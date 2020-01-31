using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class WordRecordings1
    {
        private String Anagram;
        private String Solution;
        private String hint;

        public string Anagram1 { get => Anagram; set => Anagram = value; }
        public string Solution1 { get => Solution; set => Solution = value; }
        public string Hint { get => hint; set => hint = value; }

        

       
        
        

       
        
        public WordRecordings1(String Anagram, String Solution, String hint)
        {
            this.Anagram = Anagram;
            this.Solution = Solution;
            this.hint = hint;

           


        }
    }

     

}
