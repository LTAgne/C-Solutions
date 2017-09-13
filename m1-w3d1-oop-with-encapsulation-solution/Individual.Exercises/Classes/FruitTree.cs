using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        private string typeOfFruit;
        private int piecesOfFruitLeft;

        /// <summary>
        /// Type of fruit on the tree
        /// </summary>
        public string TypeOfFruit
        {
            get { return typeOfFruit; }            
        }
        
        /// <summary>
        /// Number of fruit pieces remaining
        /// </summary>
        public int PiecesOfFruitLeft
        {
            get { return piecesOfFruitLeft; }            
        }

        /// <summary>
        /// Creates a new fruit tree.
        /// </summary>
        /// <param name="typeOfFruit">type of fruit the tree holds</param>
        /// <param name="startingPiecesOfFruit">number of fruit pieces to start on the tree</param>
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.piecesOfFruitLeft = startingPiecesOfFruit;
            this.typeOfFruit = typeOfFruit;
        }

        /// <summary>
        /// Picks fruit off of the tree and reduces the number of remaining pieces.
        /// </summary>
        /// <param name="numberOfPiecesToRemove">number of fruit pieces to remove</param>
        /// <returns>True if there is enough fruit to pick, false if not.</returns>
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (piecesOfFruitLeft-numberOfPiecesToRemove >= 0)
            {
                piecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }

            return false;            
        }
    }
}
