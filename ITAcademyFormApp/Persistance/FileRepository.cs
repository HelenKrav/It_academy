using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace ITAcademyFormApp
{
    internal class FileRepository : IRepository<Question>

    {
        private const string FileName = "Questions";
        
        public void Add(Question item)
        {
            var list = new List<Question>(GetAll());
            list.Add(item);

            var str =  JsonSerializer.Serialize(list);

                    using (var fw = new StreamWriter(FileName, false))
                    {
                        fw.Write(str);
                    }
             
            
            File.WriteAllText(FileName, str);
        }


        public void Update(Question item)
        {
           var list = new List<Question>(GetAll());
           var oldQuestion =  list.Find(x=>x.Equals(item));

            oldQuestion.Text = item.Text;
            oldQuestion.Answers = item.Answers;

            var str = JsonSerializer.Serialize(list);
            File.WriteAllText(FileName, str);
        }




        public IEnumerable<Question> GetAll()
        {
            if(!File.Exists(FileName))
            {
                return Enumerable.Empty<Question>();
            }
            var str = File.ReadAllText(FileName);
            var res =  JsonSerializer.Deserialize<IEnumerable<Question>>(str);
            return res;
        }

        public void Remove(Question item)
        {
            var list = new List<Question>(GetAll());
            list.Remove(item);

            var str = JsonSerializer.Serialize(list);
            File.WriteAllText(FileName, str);
        }
    }
}
