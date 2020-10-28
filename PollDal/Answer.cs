using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollDal
{
   public  class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool? Correct { get; set; }
        public int? Questionid { get; set; }

        public virtual Question Questions { get; set; }
        public object Answers { get; set; }
    }
}
