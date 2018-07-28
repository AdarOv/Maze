using ATP2016Project.Model.Algorithms.MazeGenerators;
using ATP2016Project.Model.Algorithms.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP2016Project.Model
{
    /// <summary>
    /// An Interface represents a model
    /// </summary>
    interface IModel
    {
        string[] getDir(string path);
        void generate3dMaze(string mazeName, int columns, int rows, int levels);
        int[,,] getMaze(string mazeName);        
        bool saveMaze(string mazeName, string path);
        void loadMaze(string path, string mazeName);
        int mazeSize(string mazeName);
        long fileSize(string path);
        void solveMaze(string mazeName, string algorithm);
        Solution displaySolution(string mazeName);
        bool mazeExists(string mazeName);
        void exit();
    }
}
