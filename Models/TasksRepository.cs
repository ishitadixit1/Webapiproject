namespace Webapiproject.Models
{
    public static class TasksRepository
    {
        public static List<Tasks> Taskss { get; set; } = new List<Tasks>()
        { new Tasks
            {
                Id = 1,
                Taskname="Get up Early",
                Taskdetails="you have to getup early in thr morning"

            },
            new Tasks
            {
                Id = 2,
                Taskname="Take a bath",
               Taskdetails="Take bath daily"
            }


        };
    }
}
