namespace IrynaZharnasek.Lecture7.task2
{
    public class Animals: IRun, IJump
    {
        private string name { get; set; }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int high { get; set; }
        public int speed { get; set; }

        public Animals()
        {

        }
        public Animals(string name)
        {
            this.Name = name;
        }

        public void CanJump()
        {
            Console.WriteLine($"{Name} can jumping") ;
        }

        public void CanRun()
        {
            Console.WriteLine($"{Name} can running");
        }
    }
}
