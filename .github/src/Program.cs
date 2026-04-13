namespace bugs
{
    public class Bug
    {
        public enum State
        {
            NewBug,
            StudyingBug,
            FixingBug,
            Fixed,
            TooHard,
            NotABug
        };
        public enum Action
        {
            Start,
            ProblemSolved,
            ProblemNotSolved,
            ProblemIgnored,
            ProblemNeedsMoreResources,
            Reopen
        };
        private State state = State.NewBug;
        public State CurrentState { get { return state; } }
        public void TakeAction(Action action)
        {
            state = (state, action) switch
            {
                (State.NewBug, Action.Start) => State.StudyingBug,
                (State.StudyingBug, Action.ProblemSolved) => State.FixingBug,
                (State.StudyingBug, Action.ProblemIgnored) => State.NotABug,
                (State.StudyingBug, Action.ProblemNeedsMoreResources) => State.TooHard,
                (State.FixingBug, Action.ProblemSolved) => State.Fixed,
                (State.FixingBug, Action.ProblemNotSolved) => State.StudyingBug,
                (State.FixingBug, Action.ProblemIgnored) => State.NotABug,
                (State.FixingBug, Action.ProblemNeedsMoreResources) => State.TooHard,
                (State.TooHard, Action.ProblemSolved) => State.FixingBug,
                (State.TooHard, Action.ProblemNotSolved) => State.StudyingBug,
                (State.NotABug, Action.ProblemSolved) => State.Fixed,
                (State.NotABug, Action.ProblemNotSolved) => State.StudyingBug,
                (State.Fixed, Action.Reopen) => State.StudyingBug,
                _ => state
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bug bug = new();
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.Start);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemNeedsMoreResources);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemNotSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemIgnored);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.Reopen);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemIgnored);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemNotSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemNeedsMoreResources);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.Reopen);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
            bug.TakeAction(Bug.Action.ProblemSolved);
            Console.WriteLine($"State: {bug.CurrentState}");
        }
    }
}
