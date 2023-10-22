namespace Foundation3.Classes
{
    // Define Class
    class CreateLectureCommand : Command
    {
        // Constructors
        public CreateLectureCommand()
            : base() { }

        // Methods

        public override void Execute()
        {
            Address address = new Address("151 W 4th S Apt 501", "Rexburg", "Idaho", "USA");
            Lecture lecture = new Lecture(
                "BYU-I Commencement",
                "Winter 2023 End-Of-Semester Graduation & Commencement",
                "April 6",
                "6:00 pm",
                address,
                "Brad Wilcox",
                15000
            );

            Console.WriteLine(lecture.StandardDetails() + "\n");
            Console.WriteLine(lecture.FullDetails() + "\n");
            Console.WriteLine(lecture.ShortDetails() + "\n");
        }
    }
}