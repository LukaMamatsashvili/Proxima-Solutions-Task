using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTask
{
    public class School : IEnumerable<string>
    {
        public School() { }

        private HashSet<string> teachers = new HashSet<string>();
        private HashSet<string> UniqueSubjects = new HashSet<string>();

        private HashSet<(string teacher, string subject)> subjects = new HashSet<(string, string)>();
        private HashSet<(string pupil, string subject)> pupils = new HashSet<(string, string)>();

        private HashSet<string> returnedTeachers = new HashSet<string>();
        private HashSet<string> returnedPupils = new HashSet<string>();

        public void addTeacher(String teacher)
        {
            teachers.Add(teacher);
        }

        public void addSubject(String teacher, String subject)
        {
            if (teachers.Contains(teacher))
            {
                subjects.Add((teacher, subject));
                UniqueSubjects.Add(subject);
            }
        }

        public void addPupil(String pupil, String subject)
        {
            if (UniqueSubjects.Contains(subject)) pupils.Add((pupil, subject));
        }

        public IEnumerable getTeachers(String pupil)
        {
            foreach (var p in pupils)
                if (pupil == p.pupil)
                    foreach (var s in subjects)
                        if (p.subject == s.subject) returnedTeachers.Add(s.teacher);
            return returnedTeachers;
        }

        public IEnumerable getPupils(String teacher)
        {
            foreach (var s in subjects)
                if (teacher == s.teacher)
                    foreach (var p in pupils)
                        if (s.subject == p.subject) returnedPupils.Add(p.pupil);
            return returnedPupils;
        }

        public void removeTeacher(String teacher)
        {
            teachers.RemoveWhere(item => item.Contains(teacher));
            subjects.RemoveWhere(item => item.teacher.Contains(teacher));
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}