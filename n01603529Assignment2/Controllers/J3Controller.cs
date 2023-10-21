using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603529Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        ///  This code calculates grades.
        ///  It takes scores for four subjects in sequence, and if the score is 90 or higher, it assigns 'A,' if it's 80 or higher, it assigns 'B,' if it's 70 or higher, it assigns 'C,' if it's 60 or higher, it assigns 'D,' and if it's below 60, it assigns 'F.'
        /// </summary>
        /// <param name="a">1st class score</param>
        /// <param name="b">2nd class score</param>
        /// <param name="c">3rd class score</param>
        /// <param name="d">4th class score</param>
        /// <returns>The code will produce grades for each subject accordingly.</returns>
        [HttpGet]
        [Route("api/J3/Testcore/{a}/{b}/{c}/{d}")]
        public string Testcore(int a, int b, int c, int d)
        {
            List<int> ClassCores = new List<int>();//This is an List for storing scores for each subject.
            ClassCores.Add(a);
            ClassCores.Add(b);
            ClassCores.Add(c);
            ClassCores.Add(d);
            
            List<string> Grades = new List<string>(); //This is an List for storing grades for each subject.

            for (int i = 0; i < ClassCores.Count; i++) //It repeats for the length of 'ClassScores.'
            {
                if (ClassCores[i] >= 90)
                {
                    Grades.Insert(i, "A");
                }
                else if(ClassCores[i] >= 80)
                {
                    Grades.Insert(i, "B");
                }
                else if (ClassCores[i] >= 70)
                {
                    Grades.Insert(i, "C");
                }
                else if (ClassCores[i] >= 60)
                {
                    Grades.Insert(i, "D");
                }
                else
                {
                    Grades.Insert(i, "F");
                }
            };
            return "1st Class:'"+ Grades[0] + "' 2nd Class:'" + Grades[1] + "' 3rd Class:'" + Grades[2] + "' 4th Class:'" + Grades[3]+"'"; //It returns the grades for each subject in string format.
        }
    }
}