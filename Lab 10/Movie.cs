using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Movie
    {
        #region Variables
        //Declaration of variables.
        private string Title;
        private string Category;
        #endregion

        #region Properties
        //Declaration of Properties.
        public string MovieTitle
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public string MovieCategory
        {
            get
            {
                return Category;
            }
            set
            {
                Category = value;
            }
        }
        #endregion

        #region Constructors
        //Declaration of Constructors.
        //Default Constructor.
        public Movie()
        {
            Title = "Shawshank Redemption";
            Category = "Drama";
        }
        //Constructor with Parameters to Pass Arguments.
        public Movie(string TitleInput, string CategoryInput)
        {
            Title = TitleInput;
            Category = CategoryInput;
        }
        #endregion
    }
}
