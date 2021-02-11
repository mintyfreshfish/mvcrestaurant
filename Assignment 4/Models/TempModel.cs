using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public static class TempModel
    {
        private static List<Submission> submissions = new List<Submission>();

        public static IEnumerable<Submission> Submissions => submissions;

        public static void AddSubmission(Submission submission)
        {
            submissions.Add(submission);
        }
    }
}