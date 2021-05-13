namespace todoApp{
    public class Todo
    {
        public int Id { get; set; }
        public string description { get; set; } 
        public bool done { get; set; }

        public Todo()
        {
            this.done = false;
        }
    }
}