using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class ProfessorCourse
    {
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
