using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace SQA07ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR PROCEDURAL PROGRAMMING

            ProceduralProgramming proceduralProgramming = new ProceduralProgramming();

            #region VARIABLES-BASICS
            proceduralProgramming.DataTypes();    
            #endregion

            #region 
            proceduralProgramming.Basics(); //for understanding basics of C# Commands/Builtin Functions
            #endregion

            #region CONDITIONS
            proceduralProgramming.ConditionsIfElse();
            proceduralProgramming.ConditionsSwitchCase();
            #endregion

            #region LOOPS
            proceduralProgramming.LoopsGetTable();
            proceduralProgramming.LoopsPrintPatterns();
            #endregion
            
            #region ARRAY
            proceduralProgramming.ArraysRemoveDuplicates();
            #endregion

            #region LISTS
            proceduralProgramming.Lists();
            #endregion

            Console.ReadLine();

            #endregion


            #region FOR OOPS PROGRAMMING

            #region POLYMORPHISM
            #endregion

            #region ENCAPSTULATION
            #endregion

            #region INHERITENCE
            #endregion

            #region ABSTRACTION
            #endregion

            #endregion

            Console.ReadLine();

        }
    }
}
