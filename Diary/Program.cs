﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDiary
{
    class Program
    {        
        static void Main(string[] args)
        {   
            Diary student1 = new Diary();
            student1.AddName();
            Diary.AskForRatingsAndShowStatistic(student1);
                        
            Diary student2 = new Diary();
            student2.AddName();
            Diary.AskForRatingsAndShowStatistic(student2);
        }
    }
}
