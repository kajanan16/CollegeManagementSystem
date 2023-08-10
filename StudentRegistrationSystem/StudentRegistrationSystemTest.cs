using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    internal class StudentRegistrationSystemTest
    {       
        //lists for storing the student,courses ,faculties programs and enrolment information

        private List<Student> students = new List<Student>(CollegeData.studentData());
        private List<Course> courses = new List<Course>(CollegeData.courseData());
        private List<Faculty> faculties = new List<Faculty>(CollegeData.FacultiesData());
        private List<CollegeProgram> programs = new List<CollegeProgram>(CollegeData.CollegeProgramData());
        private List<Enrolment> enrolments = new List<Enrolment>(CollegeData.EntrollmentData());

        static void Main(string[] args)
        {
            StudentRegistrationSystemTest strs = new StudentRegistrationSystemTest();
            //an ifinite loop for repeatedly displaying menu to the user asking user for their choice

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Add Faculty");
                Console.WriteLine("4. Add Program");
                Console.WriteLine("5. Enroll Student in Course");
                Console.WriteLine("6. Display All Students");
                Console.WriteLine("7. Display All Courses");
                Console.WriteLine("8. Display All Faculties");
                Console.WriteLine("9. Display All Programs");
                Console.WriteLine("10. Display All Courses Taken by a Student");
                Console.WriteLine("11. Display All Students Taking a Course");
                Console.WriteLine("12. Display Courses Taught by a Faculty");
                Console.WriteLine("13. Display All Students in a Program");
                Console.WriteLine("0. Exit");
               //reading choice from the user
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
           //a switch case for processing the user choice
                switch (choice)
                {
                    case "1":
                        strs.AddStudent();
                        break;
                    case "2":
                        strs.AddCourse();
                        break;
                    case "3":
                        strs.AddFaculty();
                        break;
                    case "4":
                        strs.AddProgram();
                        break;
                    case "5":
                        strs.EnrollStudent();
                        break;
                    case "6":
                        strs.DisplayAllStudents();
                        break;
                    case "7":
                        strs.DisplayAllCourses();
                        break;
                    case "8":
                        strs.DisplayAllFaculties();
                        break;
                    case "9":
                        strs.DisplayAllPrograms();
                        break;
                    case "10":
                        strs.DisplayCoursesTakenByStudent();
                        break;
                    case "11":
                        strs.DisplayStudentsTakingCourse();
                        break;
                    case "12":
                        strs.DisplayCoursesTaughtByFaculty();
                        break;
                    case "13":
                        strs.DisplayStudentsInProgram();
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
//funtion to add the student details

        private void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            //validation using while loop
            while (studentId <= 0)
            {
                Console.WriteLine("The student id is invalid");
                studentId = Int32.Parse(Console.ReadLine());

            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("The FirstName should not be empty");
                firstName = Console.ReadLine();
            }

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            //validation using while loop
              while (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("The LastName should not be empty");
                lastName = Console.ReadLine();
            }

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("The Email should not be empty");
                email = Console.ReadLine();
            

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();
           //validation using while loop
            
            while (string.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine("The Program code should not be empty");
                phoneNumber = Console.ReadLine();
            }

            Console.Write("Enter Program Code: ");
            string programCode = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(programCode))
            {
                Console.WriteLine("The FirstName should not be empty");
                programCode = Console.ReadLine();
            }

            Student student = new Student(studentId, firstName, lastName, email, phoneNumber, programCode);
            students.Add(student);

            Console.WriteLine("Student added successfully.");
        }

        private void AddCourse()
        {
            Console.Write("Enter Course Code: ");
            string courseCode = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(courseCode))
            {
                Console.WriteLine("The course code should not be empty");
                courseCode = Console.ReadLine();
            }

            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(courseName))
            {
                Console.WriteLine("The course name should not be empty");
                courseName = Console.ReadLine();
            }

            Console.Write("Enter Faculty ID: ");
            string facultyId = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(facultyId))
            {
                Console.WriteLine("The faculty id should not be empty");
                facultyId = Console.ReadLine();
            }

            Console.Write("Enter Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            //validation using while loop
              while (creditHours<0)
            {
                Console.WriteLine("invalid credit hours");
                creditHours =  Int32.Parse(Console.ReadLine());
            }

            Course course = new Course(courseCode, courseName, facultyId, creditHours);
            courses.Add(course);

            Console.WriteLine("Course added successfully.");
        }

        private void AddFaculty()
        {
            Console.Write("Enter Faculty ID: ");
            string facultyId = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(facultyId))
            {
                Console.WriteLine("The faculty id should not be empty");
                facultyId = Console.ReadLine();
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("The FirstName should not be empty");
                firstName = Console.ReadLine();
            }

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            //validation using while loop
            while (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("The lastName should not be empty");
                lastName = Console.ReadLine();
            }

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            //validation using while loop
            while (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("The Email should not be empty");
                email = Console.ReadLine();
            }

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();
            //validation using while loop
              while (string.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine("The phone number should not be empty");
                phoneNumber = Console.ReadLine();
            }

            Faculty faculty = new Faculty(facultyId, firstName, lastName, email, phoneNumber);
            faculties.Add(faculty);

            Console.WriteLine("Faculty added successfully.");
        }

        private void AddProgram()
        {
            Console.Write("Enter Program Code: ");
            string programCode = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(programCode))
            {
                Console.WriteLine("The program code should not be empty");
                programCode = Console.ReadLine();
            }

            Console.Write("Enter Program Name: ");
            string programName = Console.ReadLine();
            //validation using while loop
            while (string.IsNullOrEmpty(programName))
            {
                Console.WriteLine("The program name should not be empty");
                programName = Console.ReadLine();
            }

            Console.Write("Enter Credentials: ");
            string credentials = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(credentials))
            {
                Console.WriteLine("The redentials should not be empty");
                credentials = Console.ReadLine();
            }

            Console.Write("Is this a degree program? (Y/N): ");
            string isDegreeProgram = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(isDegreeProgram))
            {
                Console.WriteLine("Invalid input");
                Console.Write("Is this a degree program? (Y/N): ");
                isDegreeProgram = Console.ReadLine();
            }

            CollegeProgram program = null;
            if (isDegreeProgram.ToUpper() == "Y")
            {
                Console.Write("Enter Degree Type: ");
                string degreeType = Console.ReadLine();

                program = new CollegeDegreeProgram(programCode, programName, degreeType, credentials);
            }


            programs.Add(program);

            Console.WriteLine("Program added successfully.");
        }

        private void EnrollStudent()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            //validation using while loop
             while (studentId <= 0)
            {
                Console.WriteLine("The student id is invalid");
                studentId = Int32.Parse(Console.ReadLine());

            }

            Console.Write("Enter Course Code: ");
            string courseCode = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(courseCode))
            {
                Console.WriteLine("The course code should not be empty");
                courseCode = Console.ReadLine();
            }

            Console.Write("Enter Section Number: ");
            string sectionNumber = Console.ReadLine();
            //validation using while loop
             while (string.IsNullOrEmpty(sectionNumber))
            {
                Console.WriteLine("The section number should not be empty");
                sectionNumber = Console.ReadLine();
            }

            Enrolment enrolment = new Enrolment(studentId, courseCode, sectionNumber);
            enrolments.Add(enrolment);

            Console.WriteLine("Student enrolled successfully.");
        }
//function to display the student details
        private void DisplayAllStudents()
        {
            Console.WriteLine("===== All Students =====");
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("----------------------");
            }
        }
//function to display the course details

        private void DisplayAllCourses()
        {
            Console.WriteLine("===== All Courses =====");
            foreach (var course in courses)
            {
                Console.WriteLine(course);
                Console.WriteLine("----------------------");
            }
        }
//function to display the faculty details

        private void DisplayAllFaculties()
        {
            Console.WriteLine("===== All Faculties =====");
            foreach (var faculty in faculties)
            {
                Console.WriteLine(faculty);
                Console.WriteLine("----------------------");
            }
        }
//function to display the program details

        private void DisplayAllPrograms()
        {
            Console.WriteLine("===== All Programs =====");
            foreach (var program in programs)
            {
                Console.WriteLine(program);
                Console.WriteLine("----------------------");
            }
        }
//function to display the  details of courses taken up by students

        private void DisplayCoursesTakenByStudent()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine($"===== Courses taken by Student ID {studentId} =====");
            foreach (var enrolment in enrolments)
            {
                if (enrolment.StudentId == studentId)
                {
                    var course = courses.Find(c => c.CourseCode == enrolment.CourseCode);
                    Console.WriteLine(course);
                    Console.WriteLine("----------------------");
                }
            }
        }

        private void DisplayStudentsTakingCourse()
        {
            Console.Write("Enter Course Code: ");
            string courseCode = Console.ReadLine();

            Console.WriteLine($"===== Students taking Course Code {courseCode} =====");
            foreach (var enrolment in enrolments)
            {
                if (enrolment.CourseCode == courseCode)
                {
                    var student = students.Find(s => s.Id == enrolment.StudentId);
                    Console.WriteLine(student);
                    Console.WriteLine("----------------------");
                }
            }
        }
//function to display the courses taught by the faculty d

        private void DisplayCoursesTaughtByFaculty()
        {
            Console.Write("Enter Faculty ID: ");
            string facultyId = Console.ReadLine();

            Console.WriteLine($"===== Courses taught by Faculty ID {facultyId} =====");
            foreach (var course in courses)
            {
                if (course.FacultyId == facultyId)
                {
                    Console.WriteLine(course);
                    Console.WriteLine("----------------------");
                }
            }
        }
//function to display the details of students enrolled in programs
        private void DisplayStudentsInProgram()
        {
            Console.Write("Enter Program Code: ");
            string programCode = Console.ReadLine();

            Console.WriteLine($"===== Students in Program Code {programCode} =====");
            foreach (var student in students)
            {
                if (student.ProgramCode == programCode)
                {
                    Console.WriteLine(student);
                    Console.WriteLine("----------------------");
                }
            }
        }
    }
}

