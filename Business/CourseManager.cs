﻿using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{

    Course[] courses=new Course[3];

    //Constructor bloğu new leyince çalışır.
    public CourseManager()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "C++";
        course2.Description = "Falan filan";
        course2.Price = 15;

        Course course3 = new Course();
        course3.Id = 1;
        course3.Name = "Python";
        course3.Description = "3.12";
        course3.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;

    }
    //Method deniyor bu komuta.
    public Course[] GetAll()
    {
        return courses;
    }
}
