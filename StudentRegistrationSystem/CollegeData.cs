using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class CollegeData
    {


        public static List<Student> stList;
        public static List<Course> coList;
        public static List<Faculty> fList;
        public static List<CollegeProgram> cpList;
        public static List<CollegeAdvancedDiplomaProgram> cAList;
        public static List<Enrolment> eList;


        public static List<Student> studentData()
        {


            //Student Data
            Student student1 = new Student(101, "Kajanan", "Sivarajah", "kajanan16@gmail", "6475698620", "ITS");
            Student student2 = new Student(102, "Ganesh", "Nath", "test@gmail", "123456789", "ITM");
            Student student3 = new Student(103, "John", "Smith", "test1@gmail", "123456789", "ITS");
            Student student4 = new Student(104, "Peter", "Ricky", "test2@gmail", "123456789", "BCS");
            Student student5 = new Student(105, "Bill", "Roggers", "test3@gmail", "123456789", "GBB");

            stList = new List<Student> { student1, student2, student3, student4, student5 };
            return stList;
        }

        public static List<Course> courseData()
        {
            //Course Data
            Course c1 = new Course("ITC 5200", "ORACLE", "N00123", 40);
            Course c2 = new Course("ITC 5201", "JAVA", "N00125", 40);
            Course c3 = new Course("ITC 5300", "ASP.NET", "N00123", 40);
            Course c4 = new Course("ITO 5500", "Machine Learning", "N00126", 40);
            Course c5 = new Course("ITO 5501", "Deep Learning", "N00126", 40);
            Course c6 = new Course("GBB 2110", "Management", "N00127", 40);

            coList = new List<Course> { c1, c2, c3, c4, c5, c6 };
            return coList;
        }
        public static List<Faculty> FacultiesData()
        {
            //Faculty Data
            Faculty f1 = new Faculty("N00123", "Akshay", "Ram", "n00123.akshay@humber.ca", "12345645");
            Faculty f2 = new Faculty("N00124", "Kajanan", "Siva", "n00124.kajanan@humber.ca", "123458484");
            Faculty f3 = new Faculty("N00125", "Meenu", "Mathew", "n00125.meenu@humber.ca", "12345645");
            Faculty f4 = new Faculty("N00126", "Mayoo", "Right", "n00126.mayoo@humber.ca", "12345666");
            Faculty f5 = new Faculty("N00127", "Dumindu", "Harshana", "n00127.dumindu@humber.ca", "12345677");
            Faculty f6 = new Faculty("N00128", "Ravi", "Shanga", "n00128.ravi@humber.ca", "12345677");

            fList = new List<Faculty> { f1, f2, f3, f4, f5, f6 };
            return fList;
        }
        
        public static List<CollegeProgram> CollegeProgramData()
        {

            //College Degree Program Data
            CollegeDegreeProgram cd1 = new CollegeDegreeProgram("BCS", "BSc Computer Science", "Bachelors", "Degree");
            CollegeDegreeProgram cd2 = new CollegeDegreeProgram("BRN", "BSc Nursing", "Bachelors", "Degree");
            CollegeDegreeProgram cd3 = new CollegeDegreeProgram("BPharm", "BSc Pharmacy", "Bachelors", "Degree");
            CollegeDegreeProgram cd4 = new CollegeDegreeProgram("BCom", "BSc Commerce", "Bachelors", "Degree");
            CollegeDegreeProgram cd5 = new CollegeDegreeProgram("BMath", "BSc Math", "Bachelors", "Degree");

            //College Diploma Program Data
            CollegeAdvancedDiplomaProgram cdip1 = new CollegeAdvancedDiplomaProgram("ITS", "Information Technology Solutions", "Post Graduate Diploma");
            CollegeAdvancedDiplomaProgram cdip2 = new CollegeAdvancedDiplomaProgram("GBB", "Global Business Management", "Post Graduate Diploma");
            CollegeAdvancedDiplomaProgram cdip3 = new CollegeAdvancedDiplomaProgram("ITM", "Information Technology Management", "Post Graduate Diploma");
            CollegeAdvancedDiplomaProgram cdip4 = new CollegeAdvancedDiplomaProgram("CC", "Colud Computing", "Advanced Diploma");
            CollegeAdvancedDiplomaProgram cdip5 = new CollegeAdvancedDiplomaProgram("BIT", "Business Information Technology", "Diploma");



            cpList = new List<CollegeProgram> { cd1, cd2, cd3, cd4, cd5, cdip1, cdip2, cdip3, cdip4, cdip5 };
            return cpList;
        }


        public static List<Enrolment> EntrollmentData()
        {

            //Entrollment Data
            Enrolment e1 = new Enrolment(101, "ITC 5200", "ITC 5200 - 01");
            Enrolment e2 = new Enrolment(102, "ITC 5200", "ITC 5200 - 01");
            Enrolment e3 = new Enrolment(103, "ITC 5201", "ITC 5201 - 05");
            Enrolment e4 = new Enrolment(104, "ITO 5501", "ITO 5501 - 02");
            Enrolment e5 = new Enrolment(105, "GBB 2110", "GBB 2110 - 01");

            eList = new List<Enrolment> { e1, e2, e3, e4, e5 };
            return eList;
        }

    }
}
