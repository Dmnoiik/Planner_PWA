namespace Planner_WASM.Models
{
    public class TimeSlotModel
    {
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }

        public ActivityType Activity { get; set; }

    }

}

public enum ActivityType
{
    Work,
    Study,
    Fitness,
    Chores,
    Fun,
    Social,
    Sleep
}
