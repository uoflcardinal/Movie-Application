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
        private string Title;
        private string Category;
        #endregion

        #region Properties
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
        public Movie()
        {
            Title = "Shawshank Redemption";
            Category = "Drama";
        }

        public Movie(string TitleInput, string CategoryInput)
        {
            Title = TitleInput;
            Category = CategoryInput;
        }
        #endregion
    }
}
