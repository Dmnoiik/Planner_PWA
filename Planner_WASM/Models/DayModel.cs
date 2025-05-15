namespace Planner_WASM.Models
{
    public class DayModel
    {
        public DateOnly Date { get; set; }

        public string Notes { get; set; }

        public List<TimeSlotModel>? TimeSlots { get; set; }
    }
}
