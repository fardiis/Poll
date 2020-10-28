using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollDal
{
  public  class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }
        public int id { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
