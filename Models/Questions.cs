using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace KTB.Models{
    public class Questions : BaseEntity{
        
        [Key]
        public int id {get; set;}

        public string question {get; set;}

        public int gameId {get; set;}
        public Games Game {get; set;}

        public List<Answers> Answers{get; set;}

        public List<UsersAnswers> UsersAnswers {get; set;}

        public Questions(){
            Answers = new List<Answers>();
            UsersAnswers = new List<UsersAnswers>();
        }        
    }
}
