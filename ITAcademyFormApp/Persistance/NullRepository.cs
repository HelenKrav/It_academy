using System;
using System.Collections.Generic;
using System.Text;

namespace ITAcademyFormApp.Persistance
{
    internal class NullRepository : IRepository<Question>
    {
        public void Add(Question item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetAll()
        {
            return new[]
            {
                new Question("Are you tired?",
                new[]
                {
                    new Answer("Yes", true),
                    new Answer("No"),
                    new  Answer("Maybe")
                }),
                new Question("Are you Love С#?",
                new[]
                {
                    new Answer("Yes", true),
                    new Answer("No"),
                    new  Answer("Maybe"),
                    new  Answer("not know")
                }),
                new Question("New question?",
                new[]
                {
                    new Answer("1"),
                    new Answer("2"),
                    new  Answer("3",true),
                    new  Answer("4")
                })
        };        
        }

        public void Remove(Question item)
        {
            throw new NotImplementedException();
        }

        public void Update(Question item)
        {
            throw new NotImplementedException();
        }
    }
}
