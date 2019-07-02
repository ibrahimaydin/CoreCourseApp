﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public interface ICourseRepository
    {
        IQueryable<Course> Courses { get; }

        Course GetById(int courseid);
        IEnumerable<Course> GetCourse();
        IEnumerable<Course> GetCourseByActive(bool isActive);
        IEnumerable<Course> GetCourseByFilters(string name = null, decimal? price = null, string isActive = null);

        int CreateCourse(Course newCourse);
        void UpdateCourse(Course updatedCourse, Course originalCourse = null);
        void DeleteCourse(int courseid);
    }
}
